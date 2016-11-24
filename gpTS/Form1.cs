using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Reflection;

namespace gpTS {
    public partial class Form1 : Form {

        public string gpAuthkey = "";
        public string savePath = "";
        private Config config;
        
        enum STAGE { STGIDLE,STG1,STG2};
        STAGE stage;

        //受信したパケットを保存するバッファ
        List<byte[]> packetList = new List<byte[]>();

        public Form1() {
            InitializeComponent();
            stage = STAGE.STGIDLE;

            // イベントハンドラの追加
            WinPcap.OnRecv += new WinPcap.OnRecvHandler(OnRecv);

            config = new Config();
            loadConfig();
        }

        //キャプチャ開始
        private void MainMenuStart_Click(object sender, EventArgs e) {
            Form2 dlg = new Form2();//デバイス選択ダイアログ

            //デバイス一覧の取得
            var devList = WinPcap.GetDeviceList();
            if (devList.Count <= 0) {
                MessageBox.Show("デバイスが見つかりません。", "ERROR");
                return;
            }

            foreach (WinPcap.pcap_if dev in devList) {
                dlg.ListBox.Items.Add(dev.description);
            }
            dlg.ListBox.SelectedIndex = 0;

            if (DialogResult.OK == dlg.ShowDialog()) {
                int index = dlg.ListBox.SelectedIndex;
                if (WinPcap.Start(devList[index].name, dlg.Promiscuous)) {
                    MainMenuStart.Enabled = false;
                    MainMenuStop.Enabled = true;
                }
            }
        }

        //キャプチャ停止
        private void MainMenuStop_Click(object sender, EventArgs e) {
            if (WinPcap.Stop()) {
                MainMenuStart.Enabled = true;
                MainMenuStop.Enabled = false;
            }
        }
        //クリア
        private void MainMenuClear_Click(object sender, EventArgs e) {
            packetList.Clear();
        }
        //終了
        private void MainMenuExit_Click(object sender, EventArgs e) {
            Close();
        }

        //パケット受信時のイベントハンドラ
        delegate void OnRecvDelegate(IntPtr pkt_hdr, IntPtr pkt_data);
        void OnRecv(IntPtr pkt_hdr, IntPtr pkt_data) {
            if (InvokeRequired) {// 別スレッドから呼び出された場合
                //デリゲートインスタンスの作成
                OnRecvDelegate func = new OnRecvDelegate(OnRecv);
                //メインスレッドのAddNodeを呼び出す
                this.Invoke(func, new object[] { pkt_hdr, pkt_data });
            }
            else {
                WinPcap.pcap_pkthdr hdr = (WinPcap.pcap_pkthdr)Marshal.PtrToStructure(pkt_hdr, typeof(WinPcap.pcap_pkthdr));

                byte[] data = new byte[hdr.caplen];
                Marshal.Copy(pkt_data, data, 0, (int)hdr.caplen);

                //------------------------------------------------------------
                // パケットの保存
                //------------------------------------------------------------
                //                packetList.Add(data);


                int len = data.Length;
                unsafe
                {
                    int offSet = 0;
                    fixed (byte* p = data) {
                        // Etherヘッダ処理
                        EtherHeader etherHeader = new EtherHeader();
                        int etherHeaderSize = Marshal.SizeOf(etherHeader);

                        if (offSet + etherHeaderSize > len) //  受信バイト数超過
                            return;
                        etherHeader = (EtherHeader)Marshal.PtrToStructure((IntPtr)(p + offSet), typeof(EtherHeader));
                        offSet += etherHeaderSize;

                        // Ether type
                        ushort type = htons(etherHeader.type);

                        if (type == 0x0800) {//IP
                            // IPヘッダ処理
                            IpHeader ipHeader = new IpHeader();
                            int ipHeaderSize = Marshal.SizeOf(ipHeader);

                            if (offSet + ipHeaderSize > len) //  受信バイト数超過
                                return;
                            ipHeader = (IpHeader)Marshal.PtrToStructure((IntPtr)(p + offSet), typeof(IpHeader));

                            offSet += (ipHeader.verLen & 0x0F) * 4;

                            // 送信先　IPアドレス
                            string dip = string.Format("{0}.{1}.{2}.{3}", ipHeader.dstIp[0], ipHeader.dstIp[1], ipHeader.dstIp[2], ipHeader.dstIp[3]
                                );
                            if (ipHeader.protocol == 6) { // TCP

                                // TCPヘッダ処理
                                TcpHeader tcpHeader = new TcpHeader();
                                int tcpHeaderSize = Marshal.SizeOf(tcpHeader);

                                if (offSet + tcpHeaderSize > len) //  受信バイト数超過
                                    return;
                                tcpHeader = (TcpHeader)Marshal.PtrToStructure((IntPtr)(p + offSet), typeof(TcpHeader));

                                // garapon検出
                                if (0 == dip.CompareTo(config.garaponIP) && stage == STAGE.STGIDLE) {
                                    int payloadsize = len - (offSet + tcpHeaderSize);
                                    byte[] payload = new byte[payloadsize];
                                    Marshal.Copy((IntPtr)(p + offSet + tcpHeaderSize), payload, 0, payloadsize);

                                    if (payloadsize != 0) {
                                        string st = System.Text.Encoding.ASCII.GetString(payload);
                                        char[] dmlt = { '\r', '\n', ';' };
                                        string[] lines = st.Split(dmlt);
                                        foreach (string line in lines) {
                                            if (line.Contains("GaraponAuthKey") == true) {
                                                gpAuthkey = line.Split('=')[1];
                                                System.Console.WriteLine("GaraponAuthKey Found:{0}", gpAuthkey);
                                                gpauthkeyTextbox.Text = gpAuthkey;
                                            }
                                            if (line.Contains("gtvid") == true && line.Contains("GET") == false) {
                                                System.Console.WriteLine("GTAG found");
                                                programIDTextbox.Text = line.Split('=')[1];
                                            }
                                        }
                                    }
                                }
                            }
                            else if (ipHeader.protocol == 17) { //UDP
                                // UDPヘッダ処理
                                UdpHeader udpHeader = new UdpHeader();
                                int udpHeaderSize = Marshal.SizeOf(udpHeader);

                                if (offSet + udpHeaderSize > len) //  受信バイト数超過
                                    return;
                                udpHeader = (UdpHeader)Marshal.PtrToStructure((IntPtr)(p + offSet), typeof(UdpHeader));
                            }
                            int totalLen = htons(ipHeader.totalLen);

                        }
                        else if (type == 0x0806) { //ARP
                        }
                        else {
                            return; // 未対応
                        }
                    }
                }
            }
        }


        public ushort htons(ushort i) {
            return (ushort)((i << 8) + (i >> 8));
        }
        public uint htons(uint i) {
            return (uint)((i >> 24) + ((i & 0x00FF0000) >> 8) + ((i & 0x0000FF00) << 8) + (i << 24));
        }

        private void button1_Click(object sender, EventArgs e) {
            stage = STAGE.STG1;
            string cmd = System.IO.Path.Combine( config.rtmpdumpPath,  @"rtmpdump.exe");
            string fileName = string.Format(programIDTextbox.Text + '-' + gpAuthkey + "-0-{0}",this.suffix.Value) ;
            string outputName = System.IO.Path.Combine(config.outputPath, fileNameTextbox.Text);
            string argval = String.Format("-n {0} -l 0 -y \"{1}\" -o {2}.ts", config.garaponIP, fileName, outputName);
            System.Console.WriteLine(argval);

            ProcessStartInfo psinfo = new ProcessStartInfo();
            psinfo.FileName = cmd;
            psinfo.CreateNoWindow = true;
            psinfo.UseShellExecute = false;
            psinfo.RedirectStandardOutput = true;
            psinfo.RedirectStandardError = true;
            psinfo.Arguments = argval;
            Process p = Process.Start(psinfo);
            p.EnableRaisingEvents = true;
            p.SynchronizingObject = this;
            p.OutputDataReceived += OutputHandler;
            p.ErrorDataReceived += OutputHandler;
            p.Exited += procTerminated;
            p.BeginOutputReadLine();
            p.BeginErrorReadLine();
 //    //       p.WaitForInputIdle();
            this.button1.Enabled = false;
        }

        private void encode() {
            stage = STAGE.STG2;
            string cmd = System.IO.Path.Combine(config.ffmpegPath, @"ffmpeg.exe");
            string videoFileName = System.IO.Path.Combine(config.outputPath, fileNameTextbox.Text);
            string argval = String.Format("-i {0}.ts {1} {2}.mp4", videoFileName,config.ffmpegOpt,videoFileName);
            System.Console.WriteLine(argval);

            ProcessStartInfo psinfo = new ProcessStartInfo();
            psinfo.FileName = cmd;
            psinfo.CreateNoWindow = true;
            psinfo.UseShellExecute = false;
            psinfo.RedirectStandardOutput = true;
            psinfo.RedirectStandardError = true;
            psinfo.Arguments = argval;
            Process p = Process.Start(psinfo);
            p.EnableRaisingEvents = true;
            p.SynchronizingObject = this;
            p.OutputDataReceived += OutputHandler;
            p.ErrorDataReceived += OutputHandler;
            p.Exited += procTerminated;
            p.BeginOutputReadLine();
            p.BeginErrorReadLine();
            //           p.WaitForInputIdle();
            this.button1.Enabled = false;
        }

        delegate void outputStringDelegate(string str);
        void OutputHandler(object o, DataReceivedEventArgs args) {
            System.Console.WriteLine(args.Data);
            Invoke(new outputStringDelegate(outputString), args.Data);
        }

        internal void outputString(string str) {
            outputTextbox.Text = str;
        }

        delegate void procTerminateDelegate();
        void procTerminated(object o, EventArgs e) {
            if (stage == STAGE.STG1) {
                if (this.encodeCheckbox.Checked == true) {
                    this.encode();
                }
                else {
                    Invoke(new procTerminateDelegate(enableButton));
                    stage = STAGE.STGIDLE;
                }
            }
            else {
                Invoke(new procTerminateDelegate(enableButton));
                stage = STAGE.STGIDLE;
            }
        }

        internal void enableButton() {
            this.button1.Enabled = true;
        }


        private void MainMenuSetting_Click(object sender, EventArgs e) {
            Form3 dlg = new Form3();
            dlg.setControl(config);
            if (DialogResult.OK == dlg.ShowDialog()) {
                dlg.setConfig(config);
                saveConfig();
            }
        }
        private void saveConfig() {
            string configFileName = this.getConfigFileName();

            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Config));
            System.IO.StreamWriter sw = new System.IO.StreamWriter(configFileName, false, new System.Text.UTF8Encoding(false));
            serializer.Serialize(sw, config);
            sw.Close();
        }

        private bool loadConfig() {
            string configFileName = this.getConfigFileName();
            if(System.IO.File.Exists(configFileName) == false) {
                return false;
            }

            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Config));
            System.IO.StreamReader sr = new System.IO.StreamReader(configFileName, new System.Text.UTF8Encoding(false));
            config = (Config)serializer.Deserialize(sr);
            sr.Close();
            return true;
        }

        private string getConfigFileName() {
            Assembly myAssembly = Assembly.GetEntryAssembly();
            string path = System.Windows.Forms.Application.StartupPath;
            return System.IO.Path.Combine(path, "config.xml");
        }

        private void outputTextbox_TextChanged(object sender, EventArgs e) {

        }

        private void m9ToolStripMenuItem_Click(object sender, EventArgs e) {
            Form4 dlg = new Form4();
            dlg.ShowDialog();
        }
    }
}
