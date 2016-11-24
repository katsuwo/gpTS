using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Deployment.Application;

namespace gpTS {
    public partial class Form4 : Form {
        public Form4() {
            InitializeComponent();
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            //バージョンの取得
            System.Version ver = asm.GetName().Version; verLabel.Text = string.Format("gpTS - Version:{0}", ver);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("http://amzn.asia/50DIKId");
        }
    }
}
