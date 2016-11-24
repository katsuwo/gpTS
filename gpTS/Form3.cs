using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

delegate void configSet();

namespace gpTS {
    public partial class Form3 : Form {
        public Form3() {
            InitializeComponent();
        }

        public void setControl(Config cfg) {
            gpIPTextbox.Text = cfg.garaponIP;
            outputPathTextbox.Text = cfg.outputPath;
            rtmpDumpPathTextbox.Text = cfg.rtmpdumpPath;
            ffmpegPathTextbox.Text = cfg.ffmpegPath;
            ffmpegOptTextbox.Text = cfg.ffmpegOpt;
        }

        public void setConfig(Config cfg) {
            cfg.garaponIP = this.gpIPTextbox.Text;
            cfg.outputPath = this.outputPathTextbox.Text;
            cfg.rtmpdumpPath = this.rtmpDumpPathTextbox.Text;
            cfg.ffmpegPath = this.ffmpegPathTextbox.Text;
            cfg.ffmpegOpt = this.ffmpegOptTextbox.Text;
        }

        private void OKButton_Click(object sender, EventArgs e) {

        }

        private void outputBrowseButton_Click(object sender, EventArgs e) {
            var dlg = new FolderBrowserDialog();
            dlg.Description = "保存パス選択";
            if (dlg.ShowDialog() == DialogResult.OK) {
                outputPathTextbox.Text = dlg.SelectedPath;
            }
        }

        private void rtmpBrowseButton_Click(object sender, EventArgs e) {
            var dlg = new FolderBrowserDialog();
            dlg.Description = "rtmpDumpパス選択";
            if (dlg.ShowDialog() == DialogResult.OK) {
                rtmpDumpPathTextbox.Text = dlg.SelectedPath;
            }
        }

        private void ffmpegBrowseButton_Click(object sender, EventArgs e) {
            var dlg = new FolderBrowserDialog();
            dlg.Description = "ffmpegパス選択";
            if (dlg.ShowDialog() == DialogResult.OK) {
                ffmpegPathTextbox.Text = dlg.SelectedPath;
            }
        }
    }
}
