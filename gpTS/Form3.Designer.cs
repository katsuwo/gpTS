namespace gpTS {
    partial class Form3 {
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
            this.outputPathTextbox = new System.Windows.Forms.TextBox();
            this.outputBrowseButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtmpDumpPathTextbox = new System.Windows.Forms.TextBox();
            this.rtmpBrowseButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ffmpegPathTextbox = new System.Windows.Forms.TextBox();
            this.ffmpegBrowseButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ffmpegOptTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gpIPTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // outputPathTextbox
            // 
            this.outputPathTextbox.Location = new System.Drawing.Point(16, 121);
            this.outputPathTextbox.Name = "outputPathTextbox";
            this.outputPathTextbox.Size = new System.Drawing.Size(352, 31);
            this.outputPathTextbox.TabIndex = 28;
            // 
            // outputBrowseButton
            // 
            this.outputBrowseButton.Location = new System.Drawing.Point(374, 116);
            this.outputBrowseButton.Name = "outputBrowseButton";
            this.outputBrowseButton.Size = new System.Drawing.Size(115, 36);
            this.outputBrowseButton.TabIndex = 27;
            this.outputBrowseButton.Text = "Browse";
            this.outputBrowseButton.UseVisualStyleBackColor = true;
            this.outputBrowseButton.Click += new System.EventHandler(this.outputBrowseButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "Output Path";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "rtmpdump Path";
            // 
            // rtmpDumpPathTextbox
            // 
            this.rtmpDumpPathTextbox.Location = new System.Drawing.Point(16, 197);
            this.rtmpDumpPathTextbox.Name = "rtmpDumpPathTextbox";
            this.rtmpDumpPathTextbox.Size = new System.Drawing.Size(352, 31);
            this.rtmpDumpPathTextbox.TabIndex = 31;
            // 
            // rtmpBrowseButton
            // 
            this.rtmpBrowseButton.Location = new System.Drawing.Point(374, 193);
            this.rtmpBrowseButton.Name = "rtmpBrowseButton";
            this.rtmpBrowseButton.Size = new System.Drawing.Size(115, 36);
            this.rtmpBrowseButton.TabIndex = 30;
            this.rtmpBrowseButton.Text = "Browse";
            this.rtmpBrowseButton.UseVisualStyleBackColor = true;
            this.rtmpBrowseButton.Click += new System.EventHandler(this.rtmpBrowseButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "ffmpeg Path";
            // 
            // ffmpegPathTextbox
            // 
            this.ffmpegPathTextbox.Location = new System.Drawing.Point(16, 278);
            this.ffmpegPathTextbox.Name = "ffmpegPathTextbox";
            this.ffmpegPathTextbox.Size = new System.Drawing.Size(352, 31);
            this.ffmpegPathTextbox.TabIndex = 34;
            // 
            // ffmpegBrowseButton
            // 
            this.ffmpegBrowseButton.Location = new System.Drawing.Point(374, 274);
            this.ffmpegBrowseButton.Name = "ffmpegBrowseButton";
            this.ffmpegBrowseButton.Size = new System.Drawing.Size(115, 36);
            this.ffmpegBrowseButton.TabIndex = 33;
            this.ffmpegBrowseButton.Text = "Browse";
            this.ffmpegBrowseButton.UseVisualStyleBackColor = true;
            this.ffmpegBrowseButton.Click += new System.EventHandler(this.ffmpegBrowseButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(16, 492);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(159, 58);
            this.OKButton.TabIndex = 36;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(237, 492);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(159, 58);
            this.cancelButton.TabIndex = 37;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "ffmpeg argument";
            // 
            // ffmpegOptTextbox
            // 
            this.ffmpegOptTextbox.Location = new System.Drawing.Point(16, 362);
            this.ffmpegOptTextbox.Multiline = true;
            this.ffmpegOptTextbox.Name = "ffmpegOptTextbox";
            this.ffmpegOptTextbox.Size = new System.Drawing.Size(352, 95);
            this.ffmpegOptTextbox.TabIndex = 38;
            this.ffmpegOptTextbox.Text = "-vcodec libx265";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 24);
            this.label6.TabIndex = 41;
            this.label6.Text = "Garapon IP Address";
            // 
            // gpIPTextbox
            // 
            this.gpIPTextbox.Location = new System.Drawing.Point(16, 38);
            this.gpIPTextbox.Name = "gpIPTextbox";
            this.gpIPTextbox.Size = new System.Drawing.Size(352, 31);
            this.gpIPTextbox.TabIndex = 40;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 572);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gpIPTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ffmpegOptTextbox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ffmpegPathTextbox);
            this.Controls.Add(this.ffmpegBrowseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtmpDumpPathTextbox);
            this.Controls.Add(this.rtmpBrowseButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.outputPathTextbox);
            this.Controls.Add(this.outputBrowseButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = "Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outputPathTextbox;
        private System.Windows.Forms.Button outputBrowseButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rtmpDumpPathTextbox;
        private System.Windows.Forms.Button rtmpBrowseButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ffmpegPathTextbox;
        private System.Windows.Forms.Button ffmpegBrowseButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ffmpegOptTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox gpIPTextbox;
    }
}