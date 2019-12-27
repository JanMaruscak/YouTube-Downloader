namespace YTB_Downloader
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userLink_txt = new System.Windows.Forms.TextBox();
            this.download_btn = new System.Windows.Forms.Button();
            this.install_btn = new System.Windows.Forms.Button();
            this.thumbnail_pBox = new System.Windows.Forms.PictureBox();
            this.title_label = new System.Windows.Forms.Label();
            this.getInfo_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.author_label = new System.Windows.Forms.Label();
            this.downloadPath_btn = new System.Windows.Forms.Button();
            this.downloadPath_label = new System.Windows.Forms.Label();
            this.quality_cmbBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.log_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.format_cmbBox = new System.Windows.Forms.ComboBox();
            this.navbar_panel = new System.Windows.Forms.Panel();
            this.programTitle_label = new System.Windows.Forms.Label();
            this.exit_pBox = new System.Windows.Forms.PictureBox();
            this.download_progBar = new System.Windows.Forms.ProgressBar();
            this.addToPath_checkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail_pBox)).BeginInit();
            this.navbar_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit_pBox)).BeginInit();
            this.SuspendLayout();
            // 
            // userLink_txt
            // 
            this.userLink_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.userLink_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userLink_txt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userLink_txt.ForeColor = System.Drawing.Color.White;
            this.userLink_txt.Location = new System.Drawing.Point(17, 95);
            this.userLink_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userLink_txt.Name = "userLink_txt";
            this.userLink_txt.Size = new System.Drawing.Size(511, 20);
            this.userLink_txt.TabIndex = 0;
            this.userLink_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userLink_txt_KeyDown);
            // 
            // download_btn
            // 
            this.download_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.download_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.download_btn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.download_btn.Location = new System.Drawing.Point(554, 591);
            this.download_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.download_btn.Name = "download_btn";
            this.download_btn.Size = new System.Drawing.Size(178, 74);
            this.download_btn.TabIndex = 1;
            this.download_btn.Text = "Download";
            this.download_btn.UseVisualStyleBackColor = false;
            this.download_btn.Click += new System.EventHandler(this.download_btn_Click);
            // 
            // install_btn
            // 
            this.install_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.install_btn.Location = new System.Drawing.Point(807, 61);
            this.install_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.install_btn.Name = "install_btn";
            this.install_btn.Size = new System.Drawing.Size(87, 30);
            this.install_btn.TabIndex = 2;
            this.install_btn.Text = "Install";
            this.install_btn.UseVisualStyleBackColor = true;
            this.install_btn.Click += new System.EventHandler(this.install_btn_Click);
            // 
            // thumbnail_pBox
            // 
            this.thumbnail_pBox.Location = new System.Drawing.Point(17, 275);
            this.thumbnail_pBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.thumbnail_pBox.Name = "thumbnail_pBox";
            this.thumbnail_pBox.Size = new System.Drawing.Size(511, 392);
            this.thumbnail_pBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thumbnail_pBox.TabIndex = 3;
            this.thumbnail_pBox.TabStop = false;
            this.thumbnail_pBox.Click += new System.EventHandler(this.thumbnail_pBox_Click);
            // 
            // title_label
            // 
            this.title_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.title_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title_label.ForeColor = System.Drawing.Color.White;
            this.title_label.Location = new System.Drawing.Point(17, 150);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(511, 52);
            this.title_label.TabIndex = 6;
            this.title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // getInfo_btn
            // 
            this.getInfo_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.getInfo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getInfo_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.getInfo_btn.ForeColor = System.Drawing.Color.Black;
            this.getInfo_btn.Location = new System.Drawing.Point(554, 72);
            this.getInfo_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.getInfo_btn.Name = "getInfo_btn";
            this.getInfo_btn.Size = new System.Drawing.Size(139, 58);
            this.getInfo_btn.TabIndex = 7;
            this.getInfo_btn.Text = "Get Info";
            this.getInfo_btn.UseVisualStyleBackColor = false;
            this.getInfo_btn.Click += new System.EventHandler(this.getInfo_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "URL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Author:";
            // 
            // author_label
            // 
            this.author_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.author_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.author_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.author_label.ForeColor = System.Drawing.Color.White;
            this.author_label.Location = new System.Drawing.Point(17, 236);
            this.author_label.Name = "author_label";
            this.author_label.Size = new System.Drawing.Size(511, 35);
            this.author_label.TabIndex = 11;
            this.author_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // downloadPath_btn
            // 
            this.downloadPath_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.downloadPath_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadPath_btn.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.downloadPath_btn.ForeColor = System.Drawing.Color.Black;
            this.downloadPath_btn.Location = new System.Drawing.Point(554, 508);
            this.downloadPath_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.downloadPath_btn.Name = "downloadPath_btn";
            this.downloadPath_btn.Size = new System.Drawing.Size(178, 36);
            this.downloadPath_btn.TabIndex = 12;
            this.downloadPath_btn.Text = "Set download path:";
            this.downloadPath_btn.UseVisualStyleBackColor = false;
            this.downloadPath_btn.Click += new System.EventHandler(this.downloadPath_btn_Click);
            // 
            // downloadPath_label
            // 
            this.downloadPath_label.AutoSize = true;
            this.downloadPath_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.downloadPath_label.ForeColor = System.Drawing.Color.White;
            this.downloadPath_label.Location = new System.Drawing.Point(554, 548);
            this.downloadPath_label.Name = "downloadPath_label";
            this.downloadPath_label.Size = new System.Drawing.Size(149, 21);
            this.downloadPath_label.TabIndex = 13;
            this.downloadPath_label.Text = "c://YTB-Downloader";
            this.downloadPath_label.Click += new System.EventHandler(this.downloadPath_label_Click);
            // 
            // quality_cmbBox
            // 
            this.quality_cmbBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.quality_cmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quality_cmbBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quality_cmbBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.quality_cmbBox.ForeColor = System.Drawing.Color.White;
            this.quality_cmbBox.FormattingEnabled = true;
            this.quality_cmbBox.Items.AddRange(new object[] {
            "1080p",
            "720p",
            "480p",
            "360p",
            "144p",
            "Audio only",
            "Best Possible",
            "4k",
            "2k"});
            this.quality_cmbBox.Location = new System.Drawing.Point(554, 444);
            this.quality_cmbBox.Name = "quality_cmbBox";
            this.quality_cmbBox.Size = new System.Drawing.Size(178, 28);
            this.quality_cmbBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(550, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Max quality:";
            // 
            // log_txt
            // 
            this.log_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.log_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.log_txt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.log_txt.ForeColor = System.Drawing.Color.White;
            this.log_txt.Location = new System.Drawing.Point(554, 148);
            this.log_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.log_txt.Multiline = true;
            this.log_txt.Name = "log_txt";
            this.log_txt.ReadOnly = true;
            this.log_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.log_txt.Size = new System.Drawing.Size(367, 255);
            this.log_txt.TabIndex = 17;
            this.log_txt.TextChanged += new System.EventHandler(this.log_txt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(739, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "Convert to:";
            // 
            // format_cmbBox
            // 
            this.format_cmbBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.format_cmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.format_cmbBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.format_cmbBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.format_cmbBox.ForeColor = System.Drawing.Color.White;
            this.format_cmbBox.FormattingEnabled = true;
            this.format_cmbBox.Items.AddRange(new object[] {
            "Default",
            "mp4",
            "mp3",
            "avi",
            "flv",
            "mkv",
            "webm",
            "ogg"});
            this.format_cmbBox.Location = new System.Drawing.Point(743, 444);
            this.format_cmbBox.Name = "format_cmbBox";
            this.format_cmbBox.Size = new System.Drawing.Size(178, 28);
            this.format_cmbBox.TabIndex = 18;
            // 
            // navbar_panel
            // 
            this.navbar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.navbar_panel.Controls.Add(this.programTitle_label);
            this.navbar_panel.Controls.Add(this.exit_pBox);
            this.navbar_panel.Location = new System.Drawing.Point(0, -1);
            this.navbar_panel.Name = "navbar_panel";
            this.navbar_panel.Size = new System.Drawing.Size(934, 55);
            this.navbar_panel.TabIndex = 20;
            this.navbar_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.navbar_panel_MouseDown);
            // 
            // programTitle_label
            // 
            this.programTitle_label.AutoSize = true;
            this.programTitle_label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.programTitle_label.ForeColor = System.Drawing.Color.White;
            this.programTitle_label.Location = new System.Drawing.Point(15, 10);
            this.programTitle_label.Name = "programTitle_label";
            this.programTitle_label.Size = new System.Drawing.Size(379, 37);
            this.programTitle_label.TabIndex = 21;
            this.programTitle_label.Text = "YouTube Downloader for gods";
            // 
            // exit_pBox
            // 
            this.exit_pBox.Location = new System.Drawing.Point(891, 13);
            this.exit_pBox.Name = "exit_pBox";
            this.exit_pBox.Size = new System.Drawing.Size(30, 30);
            this.exit_pBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit_pBox.TabIndex = 0;
            this.exit_pBox.TabStop = false;
            this.exit_pBox.Click += new System.EventHandler(this.exit_pBox_Click);
            // 
            // download_progBar
            // 
            this.download_progBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.download_progBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.download_progBar.Location = new System.Drawing.Point(743, 612);
            this.download_progBar.Name = "download_progBar";
            this.download_progBar.Size = new System.Drawing.Size(178, 36);
            this.download_progBar.TabIndex = 21;
            // 
            // addToPath_checkBox
            // 
            this.addToPath_checkBox.AutoSize = true;
            this.addToPath_checkBox.ForeColor = System.Drawing.Color.White;
            this.addToPath_checkBox.Location = new System.Drawing.Point(777, 94);
            this.addToPath_checkBox.Name = "addToPath_checkBox";
            this.addToPath_checkBox.Size = new System.Drawing.Size(157, 21);
            this.addToPath_checkBox.TabIndex = 22;
            this.addToPath_checkBox.Text = "Add to windows path?";
            this.addToPath_checkBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(933, 698);
            this.Controls.Add(this.addToPath_checkBox);
            this.Controls.Add(this.download_progBar);
            this.Controls.Add(this.navbar_panel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.format_cmbBox);
            this.Controls.Add(this.log_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.quality_cmbBox);
            this.Controls.Add(this.downloadPath_label);
            this.Controls.Add(this.downloadPath_btn);
            this.Controls.Add(this.author_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getInfo_btn);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.thumbnail_pBox);
            this.Controls.Add(this.install_btn);
            this.Controls.Add(this.download_btn);
            this.Controls.Add(this.userLink_txt);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Youtube Downloader";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail_pBox)).EndInit();
            this.navbar_panel.ResumeLayout(false);
            this.navbar_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit_pBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userLink_txt;
        private System.Windows.Forms.Button download_btn;
        private System.Windows.Forms.Button install_btn;
        private System.Windows.Forms.PictureBox thumbnail_pBox;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Button getInfo_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label author_label;
        private System.Windows.Forms.Button downloadPath_btn;
        private System.Windows.Forms.Label downloadPath_label;
        private System.Windows.Forms.ComboBox quality_cmbBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox log_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox format_cmbBox;
        private System.Windows.Forms.Panel navbar_panel;
        private System.Windows.Forms.PictureBox exit_pBox;
        private System.Windows.Forms.Label programTitle_label;
        private System.Windows.Forms.ProgressBar download_progBar;
        private System.Windows.Forms.CheckBox addToPath_checkBox;
    }
}

