namespace gpTS {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.gpauthkeyTextbox = new System.Windows.Forms.TextBox();
            this.outputTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fileNameTextbox = new System.Windows.Forms.TextBox();
            this.programIDTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MainMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.MainMenuSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.suffix = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.encodeCheckbox = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suffix)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Garapon AuthKey";
            // 
            // gpauthkeyTextbox
            // 
            this.gpauthkeyTextbox.Location = new System.Drawing.Point(16, 86);
            this.gpauthkeyTextbox.Name = "gpauthkeyTextbox";
            this.gpauthkeyTextbox.ReadOnly = true;
            this.gpauthkeyTextbox.Size = new System.Drawing.Size(352, 31);
            this.gpauthkeyTextbox.TabIndex = 9;
            // 
            // outputTextbox
            // 
            this.outputTextbox.Location = new System.Drawing.Point(16, 402);
            this.outputTextbox.Multiline = true;
            this.outputTextbox.Name = "outputTextbox";
            this.outputTextbox.Size = new System.Drawing.Size(677, 233);
            this.outputTextbox.TabIndex = 20;
            this.outputTextbox.TextChanged += new System.EventHandler(this.outputTextbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = ".ts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "OutputFileName";
            // 
            // fileNameTextbox
            // 
            this.fileNameTextbox.Location = new System.Drawing.Point(16, 265);
            this.fileNameTextbox.Name = "fileNameTextbox";
            this.fileNameTextbox.Size = new System.Drawing.Size(352, 31);
            this.fileNameTextbox.TabIndex = 17;
            // 
            // programIDTextbox
            // 
            this.programIDTextbox.Location = new System.Drawing.Point(16, 172);
            this.programIDTextbox.Name = "programIDTextbox";
            this.programIDTextbox.Size = new System.Drawing.Size(352, 31);
            this.programIDTextbox.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "ProgramID";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Location = new System.Drawing.Point(0, 669);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 30, 0);
            this.statusStrip1.Size = new System.Drawing.Size(710, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuFile,
            this.aboutMeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(710, 46);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainMenuFile
            // 
            this.MainMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuStart,
            this.MainMenuStop,
            this.toolStripMenuItem2,
            this.MainMenuSetting,
            this.MainMenuExit});
            this.MainMenuFile.Name = "MainMenuFile";
            this.MainMenuFile.Size = new System.Drawing.Size(120, 38);
            this.MainMenuFile.Text = "ファイル(&F)";
            // 
            // MainMenuStart
            // 
            this.MainMenuStart.Name = "MainMenuStart";
            this.MainMenuStart.Size = new System.Drawing.Size(269, 38);
            this.MainMenuStart.Text = "覗き見開始(&S)";
            this.MainMenuStart.Click += new System.EventHandler(this.MainMenuStart_Click);
            // 
            // MainMenuStop
            // 
            this.MainMenuStop.Enabled = false;
            this.MainMenuStop.Name = "MainMenuStop";
            this.MainMenuStop.Size = new System.Drawing.Size(269, 38);
            this.MainMenuStop.Text = "覗き見停止(&E)";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(266, 6);
            // 
            // MainMenuSetting
            // 
            this.MainMenuSetting.Name = "MainMenuSetting";
            this.MainMenuSetting.Size = new System.Drawing.Size(269, 38);
            this.MainMenuSetting.Text = "設定";
            this.MainMenuSetting.Click += new System.EventHandler(this.MainMenuSetting_Click);
            // 
            // MainMenuExit
            // 
            this.MainMenuExit.Name = "MainMenuExit";
            this.MainMenuExit.Size = new System.Drawing.Size(269, 38);
            this.MainMenuExit.Text = "終了(&X)";
            // 
            // aboutMeToolStripMenuItem
            // 
            this.aboutMeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m9ToolStripMenuItem});
            this.aboutMeToolStripMenuItem.Name = "aboutMeToolStripMenuItem";
            this.aboutMeToolStripMenuItem.Size = new System.Drawing.Size(111, 38);
            this.aboutMeToolStripMenuItem.Text = "壁|ω・)ノ";
            // 
            // m9ToolStripMenuItem
            // 
            this.m9ToolStripMenuItem.Name = "m9ToolStripMenuItem";
            this.m9ToolStripMenuItem.Size = new System.Drawing.Size(212, 38);
            this.m9ToolStripMenuItem.Text = "m9(^Д^)";
            this.m9ToolStripMenuItem.Click += new System.EventHandler(this.m9ToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 233);
            this.button1.TabIndex = 23;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // suffix
            // 
            this.suffix.Location = new System.Drawing.Point(16, 350);
            this.suffix.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.suffix.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.suffix.Name = "suffix";
            this.suffix.Size = new System.Drawing.Size(120, 31);
            this.suffix.TabIndex = 25;
            this.suffix.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "suffix";
            // 
            // encodeCheckbox
            // 
            this.encodeCheckbox.AutoSize = true;
            this.encodeCheckbox.Checked = true;
            this.encodeCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.encodeCheckbox.Location = new System.Drawing.Point(234, 352);
            this.encodeCheckbox.Name = "encodeCheckbox";
            this.encodeCheckbox.Size = new System.Drawing.Size(116, 28);
            this.encodeCheckbox.TabIndex = 27;
            this.encodeCheckbox.Text = "Encode";
            this.encodeCheckbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 691);
            this.Controls.Add(this.encodeCheckbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.suffix);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.outputTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fileNameTextbox);
            this.Controls.Add(this.programIDTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gpauthkeyTextbox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "gpTS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suffix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gpauthkeyTextbox;
        private System.Windows.Forms.TextBox outputTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fileNameTextbox;
        private System.Windows.Forms.TextBox programIDTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MainMenuFile;
        private System.Windows.Forms.ToolStripMenuItem MainMenuStart;
        private System.Windows.Forms.ToolStripMenuItem MainMenuStop;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem MainMenuExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem MainMenuSetting;
        private System.Windows.Forms.NumericUpDown suffix;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox encodeCheckbox;
        private System.Windows.Forms.ToolStripMenuItem aboutMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m9ToolStripMenuItem;
    }
}

