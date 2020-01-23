namespace arduino2560
{
    partial class BackUpData
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
            this.components = new System.ComponentModel.Container();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuProgressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.lbl_MissingError = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_SelectAll = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_BackUp = new System.Windows.Forms.Button();
            this.pnl_FileList = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_filename = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_copied_count = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_remainging = new System.Windows.Forms.Label();
            this.lbl_wait = new System.Windows.Forms.Label();
            this.lbl_CopyingFiles = new System.Windows.Forms.Label();
            this.btn_refresh = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.bunifuCards1.SuspendLayout();
            this.pnl_FileList.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCards1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.SystemColors.Control;
            this.bunifuCards1.Controls.Add(this.btn_refresh);
            this.bunifuCards1.Controls.Add(this.bunifuProgressBar1);
            this.bunifuCards1.Controls.Add(this.lbl_MissingError);
            this.bunifuCards1.Controls.Add(this.button1);
            this.bunifuCards1.Controls.Add(this.bt_SelectAll);
            this.bunifuCards1.Controls.Add(this.pictureBox1);
            this.bunifuCards1.Controls.Add(this.bt_delete);
            this.bunifuCards1.Controls.Add(this.bt_BackUp);
            this.bunifuCards1.Controls.Add(this.pnl_FileList);
            this.bunifuCards1.Controls.Add(this.lbl_Title);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(240, 140);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(616, 376);
            this.bunifuCards1.TabIndex = 14;
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuProgressBar1.BorderRadius = 4;
            this.bunifuProgressBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuProgressBar1.Location = new System.Drawing.Point(0, 0);
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.bunifuProgressBar1.Size = new System.Drawing.Size(616, 6);
            this.bunifuProgressBar1.TabIndex = 29;
            this.bunifuProgressBar1.Value = 100;
            // 
            // lbl_MissingError
            // 
            this.lbl_MissingError.AutoSize = true;
            this.lbl_MissingError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MissingError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_MissingError.Location = new System.Drawing.Point(308, 15);
            this.lbl_MissingError.Name = "lbl_MissingError";
            this.lbl_MissingError.Size = new System.Drawing.Size(294, 48);
            this.lbl_MissingError.TabIndex = 34;
            this.lbl_MissingError.Text = "Recommended: Check if the SD card is properly\r\ninserted or not, && Re-Plug your d" +
    "evice for proper\r\nCommunication.";
            this.lbl_MissingError.Visible = false;
            this.lbl_MissingError.Click += new System.EventHandler(this.lbl_MissingError_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(87, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(515, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "File Names";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.bt_SelectAll_Click_1);
            // 
            // bt_SelectAll
            // 
            this.bt_SelectAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.bt_SelectAll.FlatAppearance.BorderSize = 0;
            this.bt_SelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_SelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SelectAll.ForeColor = System.Drawing.Color.White;
            this.bt_SelectAll.Location = new System.Drawing.Point(61, 75);
            this.bt_SelectAll.Name = "bt_SelectAll";
            this.bt_SelectAll.Size = new System.Drawing.Size(24, 23);
            this.bt_SelectAll.TabIndex = 1;
            this.bt_SelectAll.Text = "🔳";
            this.bt_SelectAll.UseVisualStyleBackColor = false;
            this.bt_SelectAll.Click += new System.EventHandler(this.bt_SelectAll_Click_1);
            // 
            // bt_delete
            // 
            this.bt_delete.BackColor = System.Drawing.Color.Crimson;
            this.bt_delete.Enabled = false;
            this.bt_delete.FlatAppearance.BorderSize = 0;
            this.bt_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_delete.Location = new System.Drawing.Point(330, 311);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(139, 41);
            this.bt_delete.TabIndex = 1;
            this.bt_delete.Text = "Delete ";
            this.bt_delete.UseVisualStyleBackColor = false;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_BackUp
            // 
            this.bt_BackUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.bt_BackUp.Enabled = false;
            this.bt_BackUp.FlatAppearance.BorderSize = 0;
            this.bt_BackUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_BackUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_BackUp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_BackUp.Location = new System.Drawing.Point(475, 311);
            this.bt_BackUp.Name = "bt_BackUp";
            this.bt_BackUp.Size = new System.Drawing.Size(139, 41);
            this.bt_BackUp.TabIndex = 1;
            this.bt_BackUp.Text = "Back Up Data";
            this.bt_BackUp.UseVisualStyleBackColor = false;
            this.bt_BackUp.Click += new System.EventHandler(this.bt_BackUp_Click);
            // 
            // pnl_FileList
            // 
            this.pnl_FileList.AutoScroll = true;
            this.pnl_FileList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_FileList.Controls.Add(this.pictureBox4);
            this.pnl_FileList.Controls.Add(this.richTextBox1);
            this.pnl_FileList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_FileList.Location = new System.Drawing.Point(61, 99);
            this.pnl_FileList.Name = "pnl_FileList";
            this.pnl_FileList.Size = new System.Drawing.Size(541, 194);
            this.pnl_FileList.TabIndex = 15;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(281, 179);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(255, 10);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // lbl_Title
            // 
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.lbl_Title.Location = new System.Drawing.Point(13, -7);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(366, 79);
            this.lbl_Title.TabIndex = 14;
            this.lbl_Title.Text = "Back Up Your Data";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Title.Click += new System.EventHandler(this.lbl_Title_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 498);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 30);
            this.panel1.TabIndex = 15;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DarkGray;
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.lbl_filename);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.lbl_copied_count);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.lbl_remainging);
            this.flowLayoutPanel1.Controls.Add(this.lbl_wait);
            this.flowLayoutPanel1.Controls.Add(this.lbl_CopyingFiles);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(218, 2);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(684, 33);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Files:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "__";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_filename
            // 
            this.lbl_filename.AutoSize = true;
            this.lbl_filename.BackColor = System.Drawing.Color.Transparent;
            this.lbl_filename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filename.ForeColor = System.Drawing.Color.White;
            this.lbl_filename.Location = new System.Drawing.Point(77, 0);
            this.lbl_filename.Name = "lbl_filename";
            this.lbl_filename.Size = new System.Drawing.Size(76, 16);
            this.lbl_filename.TabIndex = 32;
            this.lbl_filename.Text = "| Filename: ";
            this.lbl_filename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_filename.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(159, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "| Copied: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // lbl_copied_count
            // 
            this.lbl_copied_count.AutoSize = true;
            this.lbl_copied_count.BackColor = System.Drawing.Color.Transparent;
            this.lbl_copied_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_copied_count.ForeColor = System.Drawing.Color.White;
            this.lbl_copied_count.Location = new System.Drawing.Point(229, 0);
            this.lbl_copied_count.Name = "lbl_copied_count";
            this.lbl_copied_count.Size = new System.Drawing.Size(15, 16);
            this.lbl_copied_count.TabIndex = 41;
            this.lbl_copied_count.Text = "_";
            this.lbl_copied_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_copied_count.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(250, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "| Remaining: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // lbl_remainging
            // 
            this.lbl_remainging.AutoSize = true;
            this.lbl_remainging.BackColor = System.Drawing.Color.Transparent;
            this.lbl_remainging.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_remainging.ForeColor = System.Drawing.Color.White;
            this.lbl_remainging.Location = new System.Drawing.Point(341, 0);
            this.lbl_remainging.Name = "lbl_remainging";
            this.lbl_remainging.Size = new System.Drawing.Size(15, 16);
            this.lbl_remainging.TabIndex = 37;
            this.lbl_remainging.Text = "_";
            this.lbl_remainging.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_remainging.Visible = false;
            // 
            // lbl_wait
            // 
            this.lbl_wait.AutoSize = true;
            this.lbl_wait.BackColor = System.Drawing.Color.Transparent;
            this.lbl_wait.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wait.ForeColor = System.Drawing.Color.White;
            this.lbl_wait.Location = new System.Drawing.Point(362, 0);
            this.lbl_wait.Name = "lbl_wait";
            this.lbl_wait.Size = new System.Drawing.Size(225, 16);
            this.lbl_wait.TabIndex = 39;
            this.lbl_wait.Text = "| Please wait your files are copying....";
            this.lbl_wait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_wait.Visible = false;
            // 
            // lbl_CopyingFiles
            // 
            this.lbl_CopyingFiles.AutoSize = true;
            this.lbl_CopyingFiles.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CopyingFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CopyingFiles.ForeColor = System.Drawing.Color.White;
            this.lbl_CopyingFiles.Location = new System.Drawing.Point(593, 0);
            this.lbl_CopyingFiles.Name = "lbl_CopyingFiles";
            this.lbl_CopyingFiles.Size = new System.Drawing.Size(12, 18);
            this.lbl_CopyingFiles.TabIndex = 36;
            this.lbl_CopyingFiles.Text = " ";
            this.lbl_CopyingFiles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_CopyingFiles.Visible = false;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_refresh.AutoSize = true;
            this.btn_refresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_refresh.BackColor = System.Drawing.Color.Silver;
            this.btn_refresh.Depth = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.btn_refresh.Image = global::arduino2560.Properties.Resources.Circuit_Graphic;
            this.btn_refresh.Location = new System.Drawing.Point(61, 311);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_refresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Primary = false;
            this.btn_refresh.Size = new System.Drawing.Size(90, 36);
            this.btn_refresh.TabIndex = 15;
            this.btn_refresh.Text = " ↺  Refresh";
            this.btn_refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::arduino2560.Properties.Resources.loading_1;
            this.pictureBox1.Location = new System.Drawing.Point(279, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = global::arduino2560.Properties.Resources.sidepanel1;
            this.pictureBox4.Location = new System.Drawing.Point(351, -25);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(189, 218);
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // BackUpData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 528);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuCards1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(200, 100);
            this.MaximizeBox = false;
            this.Name = "BackUpData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BackUpData";
            this.Load += new System.EventHandler(this.BackUpData_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.pnl_FileList.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.IO.Ports.SerialPort serialPort;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel pnl_FileList;
        private System.Windows.Forms.Button bt_SelectAll;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_MissingError;
        public System.Windows.Forms.Timer timer1;
        public Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
        public System.Windows.Forms.Button bt_BackUp;
        public System.Windows.Forms.Button bt_delete;
        private MaterialSkin.Controls.MaterialFlatButton btn_refresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbl_filename;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lbl_copied_count;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbl_remainging;
        public System.Windows.Forms.Label lbl_wait;
        public System.Windows.Forms.Label lbl_CopyingFiles;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox4;

    }
}