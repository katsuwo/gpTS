using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace gpTS {
    public partial class Form2 : Form {
        public ListBox ListBox
        {
            get { return listBox1; }
        }
        public bool Promiscuous
        {
            get { return checkBox1.Checked; }
        }
        public Form2() {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e) {

        }
    }
}
