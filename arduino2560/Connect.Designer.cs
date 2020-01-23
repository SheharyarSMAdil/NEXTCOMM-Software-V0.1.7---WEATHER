namespace arduino2560
{
    partial class Connect
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_connect2 = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton();
            this.btn_connect = new System.Windows.Forms.Button();
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_BaudRate = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_readTimeout = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopTextBox();
            this.zeroitLollipopLabel1 = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopLabel();
            this.lbl_connecting = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.timer_port = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 25000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(461, 79);
            this.label2.TabIndex = 14;
            this.label2.Text = "Connect Your Device";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btn_connect2);
            this.groupBox1.Controls.Add(this.btn_connect);
            this.groupBox1.Controls.Add(this.cboPorts);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(93, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 170);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Available Ports";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_connect2
            // 
            this.btn_connect2.AllowTransparency = true;
            this.btn_connect2.AnimationInterval = 1;
            this.btn_connect2.BackColor = System.Drawing.Color.Transparent;
            this.btn_connect2.BGColor = "#508ef5";
            this.btn_connect2.Corners = 1F;
            this.btn_connect2.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.btn_connect2.DoubleRipple = false;
            this.btn_connect2.EnabledBGColor = System.Drawing.Color.SeaGreen;
            this.btn_connect2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connect2.FontColor = "#ffffff";
            this.btn_connect2.ForeColor = System.Drawing.Color.White;
            this.btn_connect2.Location = new System.Drawing.Point(326, 72);
            this.btn_connect2.Name = "btn_connect2";
            this.btn_connect2.RippleEffectColor = System.Drawing.Color.Black;
            this.btn_connect2.RippleOpacity = 25;
            this.btn_connect2.Size = new System.Drawing.Size(120, 34);
            this.btn_connect2.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btn_connect2.TabIndex = 3;
            this.btn_connect2.Text = "Connect";
            this.btn_connect2.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btn_connect2.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_connect.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_connect.FlatAppearance.BorderSize = 0;
            this.btn_connect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_connect.Location = new System.Drawing.Point(329, 120);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(120, 32);
            this.btn_connect.TabIndex = 2;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = false;
            this.btn_connect.Visible = false;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // cboPorts
            // 
            this.cboPorts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPorts.BackColor = System.Drawing.SystemColors.Control;
            this.cboPorts.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.ItemHeight = 24;
            this.cboPorts.Location = new System.Drawing.Point(75, 73);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(254, 32);
            this.cboPorts.TabIndex = 1;
            this.cboPorts.SelectedIndexChanged += new System.EventHandler(this.cboPorts_SelectedIndexChanged);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCards1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DodgerBlue;
            this.bunifuCards1.Controls.Add(this.panel1);
            this.bunifuCards1.Controls.Add(this.lbl_connecting);
            this.bunifuCards1.Controls.Add(this.groupBox1);
            this.bunifuCards1.Controls.Add(this.label2);
            this.bunifuCards1.Controls.Add(this.pictureBox4);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(240, 54);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(616, 434);
            this.bunifuCards1.TabIndex = 13;
            this.bunifuCards1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuCards1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_BaudRate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_readTimeout);
            this.panel1.Controls.Add(this.zeroitLollipopLabel1);
            this.panel1.Location = new System.Drawing.Point(3, 374);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 57);
            this.panel1.TabIndex = 19;
            this.panel1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Baud Rate";
            // 
            // tb_BaudRate
            // 
            this.tb_BaudRate.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.tb_BaudRate.DisabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.tb_BaudRate.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tb_BaudRate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.tb_BaudRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tb_BaudRate.IsEnabled = true;
            this.tb_BaudRate.Location = new System.Drawing.Point(208, 24);
            this.tb_BaudRate.MaxLength = 32767;
            this.tb_BaudRate.Multiline = false;
            this.tb_BaudRate.Name = "tb_BaudRate";
            this.tb_BaudRate.PasswordChar = '\0';
            this.tb_BaudRate.ReadOnly = false;
            this.tb_BaudRate.Size = new System.Drawing.Size(106, 24);
            this.tb_BaudRate.TabIndex = 16;
            this.tb_BaudRate.Text = "9600";
            this.tb_BaudRate.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_BaudRate.TextBackgroundColor = System.Drawing.SystemColors.Control;
            this.tb_BaudRate.UseSystemPasswordChar = false;
            this.tb_BaudRate.WordWrap = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Update Read Time Out";
            // 
            // tb_readTimeout
            // 
            this.tb_readTimeout.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.tb_readTimeout.DisabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.tb_readTimeout.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tb_readTimeout.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.tb_readTimeout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tb_readTimeout.IsEnabled = true;
            this.tb_readTimeout.Location = new System.Drawing.Point(28, 24);
            this.tb_readTimeout.MaxLength = 32767;
            this.tb_readTimeout.Multiline = false;
            this.tb_readTimeout.Name = "tb_readTimeout";
            this.tb_readTimeout.PasswordChar = '\0';
            this.tb_readTimeout.ReadOnly = false;
            this.tb_readTimeout.Size = new System.Drawing.Size(106, 24);
            this.tb_readTimeout.TabIndex = 16;
            this.tb_readTimeout.Text = "4500";
            this.tb_readTimeout.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_readTimeout.TextBackgroundColor = System.Drawing.SystemColors.Control;
            this.tb_readTimeout.UseSystemPasswordChar = false;
            this.tb_readTimeout.WordWrap = true;
            // 
            // zeroitLollipopLabel1
            // 
            this.zeroitLollipopLabel1.AllowTransparency = true;
            this.zeroitLollipopLabel1.AutoSize = true;
            this.zeroitLollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.zeroitLollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.zeroitLollipopLabel1.Location = new System.Drawing.Point(140, 30);
            this.zeroitLollipopLabel1.Name = "zeroitLollipopLabel1";
            this.zeroitLollipopLabel1.Size = new System.Drawing.Size(26, 17);
            this.zeroitLollipopLabel1.TabIndex = 17;
            this.zeroitLollipopLabel1.Text = "ms";
            // 
            // lbl_connecting
            // 
            this.lbl_connecting.AutoSize = true;
            this.lbl_connecting.BackColor = System.Drawing.Color.Transparent;
            this.lbl_connecting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_connecting.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_connecting.Location = new System.Drawing.Point(505, 311);
            this.lbl_connecting.Name = "lbl_connecting";
            this.lbl_connecting.Size = new System.Drawing.Size(95, 18);
            this.lbl_connecting.TabIndex = 3;
            this.lbl_connecting.Text = "Connecting...";
            this.lbl_connecting.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = global::arduino2560.Properties.Resources.sidepanel1;
            this.pictureBox4.Location = new System.Drawing.Point(429, 168);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(187, 266);
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // timer_port
            // 
            this.timer_port.Interval = 5000;
            this.timer_port.Tick += new System.EventHandler(this.timer_port_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(200, 100);
            this.MaximizeBox = false;
            this.Name = "Connect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Connect";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Connect_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Connect_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Connect_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox cboPorts;
        private System.Windows.Forms.Button btn_connect;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Label lbl_connecting;
        private System.Windows.Forms.Timer timer_port;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopLabel zeroitLollipopLabel1;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopTextBox tb_readTimeout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopButton btn_connect2;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopTextBox tb_BaudRate;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}