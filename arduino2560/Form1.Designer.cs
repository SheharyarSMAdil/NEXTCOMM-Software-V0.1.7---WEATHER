namespace arduino2560
{
    partial class Form1
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
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation5 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation6 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tClk = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.pnl_TitleBar = new System.Windows.Forms.Panel();
            this.btn_Min = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.serialPort_Form = new System.IO.Ports.SerialPort(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tim_ScanRefresh = new System.Windows.Forms.Timer(this.components);
            this.bt_pnCon = new System.Windows.Forms.Button();
            this.bt_pnSetup = new System.Windows.Forms.Button();
            this.bt_pnScan = new System.Windows.Forms.Button();
            this.bt_pnSys = new System.Windows.Forms.Button();
            this.bt_pnBackUp = new System.Windows.Forms.Button();
            this.bt_pnTele = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_pnCon_bu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bt_pnTele_bu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bt_pnSys_bu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bt_pnSetup_bu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bt_pnBackUp_bu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bt_pnScan_bu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bt_pnAnal_bu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_version = new System.Windows.Forms.Label();
            this.bt_pnRefresh_bu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.bunifuColorTransition1 = new Bunifu.Framework.UI.BunifuColorTransition(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuTransition2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuTransition3 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuTransition4 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuTransition5 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuTransition6 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnl_TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.bunifuTransition6.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition5.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(53, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "| NextSense Technologies Pvt Ltd |";
            // 
            // pnl_TitleBar
            // 
            this.pnl_TitleBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_TitleBar.Controls.Add(this.btn_Min);
            this.pnl_TitleBar.Controls.Add(this.btn_close);
            this.pnl_TitleBar.Controls.Add(this.pictureBox1);
            this.pnl_TitleBar.Controls.Add(this.label5);
            this.bunifuTransition6.SetDecoration(this.pnl_TitleBar, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.pnl_TitleBar, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.pnl_TitleBar, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.pnl_TitleBar, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition5.SetDecoration(this.pnl_TitleBar, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pnl_TitleBar, BunifuAnimatorNS.DecorationType.None);
            this.pnl_TitleBar.Location = new System.Drawing.Point(272, 0);
            this.pnl_TitleBar.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_TitleBar.Name = "pnl_TitleBar";
            this.pnl_TitleBar.Size = new System.Drawing.Size(1821, 39);
            this.pnl_TitleBar.TabIndex = 7;
            this.pnl_TitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_TitleBar_Paint);
            this.pnl_TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_TitleBar_MouseDown);
            this.pnl_TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_TitleBar_MouseMove);
            this.pnl_TitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_TitleBar_MouseUp);
            // 
            // btn_Min
            // 
            this.btn_Min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(225)))));
            this.bunifuTransition6.SetDecoration(this.btn_Min, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.btn_Min, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btn_Min, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.btn_Min, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.btn_Min, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition5.SetDecoration(this.btn_Min, BunifuAnimatorNS.DecorationType.None);
            this.btn_Min.FlatAppearance.BorderSize = 0;
            this.btn_Min.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Min.ForeColor = System.Drawing.Color.White;
            this.btn_Min.Location = new System.Drawing.Point(955, -1);
            this.btn_Min.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Min.Name = "btn_Min";
            this.btn_Min.Size = new System.Drawing.Size(52, 39);
            this.btn_Min.TabIndex = 18;
            this.btn_Min.Text = "_";
            this.btn_Min.UseVisualStyleBackColor = false;
            this.btn_Min.Click += new System.EventHandler(this.btn_Min_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.bunifuTransition6.SetDecoration(this.btn_close, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.btn_close, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btn_close, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.btn_close, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.btn_close, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition5.SetDecoration(this.btn_close, BunifuAnimatorNS.DecorationType.None);
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(1007, -1);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(79, 39);
            this.btn_close.TabIndex = 19;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(14)))), ((int)(((byte)(238)))));
            this.pictureBox1.BackgroundImage = global::arduino2560.Properties.Resources.Circuit_Graphic;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuTransition5.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition6.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1087, 128);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_TitleBar_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_TitleBar_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_TitleBar_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // tim_ScanRefresh
            // 
            this.tim_ScanRefresh.Tick += new System.EventHandler(this.tim_ScanRefresh_Tick);
            // 
            // bt_pnCon
            // 
            this.bt_pnCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.bunifuTransition6.SetDecoration(this.bt_pnCon, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bt_pnCon, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bt_pnCon, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bt_pnCon, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bt_pnCon, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition5.SetDecoration(this.bt_pnCon, BunifuAnimatorNS.DecorationType.None);
            this.bt_pnCon.FlatAppearance.BorderSize = 0;
            this.bt_pnCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_pnCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pnCon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_pnCon.Location = new System.Drawing.Point(-8, 196);
            this.bt_pnCon.Margin = new System.Windows.Forms.Padding(4);
            this.bt_pnCon.Name = "bt_pnCon";
            this.bt_pnCon.Size = new System.Drawing.Size(276, 53);
            this.bt_pnCon.TabIndex = 5;
            this.bt_pnCon.Text = "          Connect";
            this.bt_pnCon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_pnCon.UseVisualStyleBackColor = false;
            this.bt_pnCon.Click += new System.EventHandler(this.bt_pnCon_Click);
            this.bt_pnCon.MouseLeave += new System.EventHandler(this.bt_pnCon_MouseLeave);
            this.bt_pnCon.MouseHover += new System.EventHandler(this.bt_pnCon_MouseHover);
            // 
            // bt_pnSetup
            // 
            this.bt_pnSetup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.bunifuTransition6.SetDecoration(this.bt_pnSetup, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bt_pnSetup, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bt_pnSetup, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bt_pnSetup, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bt_pnSetup, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition5.SetDecoration(this.bt_pnSetup, BunifuAnimatorNS.DecorationType.None);
            this.bt_pnSetup.FlatAppearance.BorderSize = 0;
            this.bt_pnSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_pnSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pnSetup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_pnSetup.Location = new System.Drawing.Point(-4, 249);
            this.bt_pnSetup.Margin = new System.Windows.Forms.Padding(4);
            this.bt_pnSetup.Name = "bt_pnSetup";
            this.bt_pnSetup.Size = new System.Drawing.Size(276, 53);
            this.bt_pnSetup.TabIndex = 5;
            this.bt_pnSetup.Text = "          Setup";
            this.bt_pnSetup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_pnSetup.UseVisualStyleBackColor = false;
            this.bt_pnSetup.Click += new System.EventHandler(this.bt_pnSetup_Click);
            // 
            // bt_pnScan
            // 
            this.bt_pnScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.bunifuTransition6.SetDecoration(this.bt_pnScan, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bt_pnScan, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bt_pnScan, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bt_pnScan, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bt_pnScan, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition5.SetDecoration(this.bt_pnScan, BunifuAnimatorNS.DecorationType.None);
            this.bt_pnScan.FlatAppearance.BorderSize = 0;
            this.bt_pnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_pnScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pnScan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_pnScan.Location = new System.Drawing.Point(-8, 304);
            this.bt_pnScan.Margin = new System.Windows.Forms.Padding(4);
            this.bt_pnScan.Name = "bt_pnScan";
            this.bt_pnScan.Size = new System.Drawing.Size(276, 53);
            this.bt_pnScan.TabIndex = 5;
            this.bt_pnScan.Text = "          Scan";
            this.bt_pnScan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_pnScan.UseVisualStyleBackColor = false;
            this.bt_pnScan.Click += new System.EventHandler(this.bt_pnScan_Click);
            // 
            // bt_pnSys
            // 
            this.bt_pnSys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.bunifuTransition6.SetDecoration(this.bt_pnSys, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bt_pnSys, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bt_pnSys, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bt_pnSys, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bt_pnSys, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition5.SetDecoration(this.bt_pnSys, BunifuAnimatorNS.DecorationType.None);
            this.bt_pnSys.FlatAppearance.BorderSize = 0;
            this.bt_pnSys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_pnSys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pnSys.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_pnSys.Location = new System.Drawing.Point(-8, 359);
            this.bt_pnSys.Margin = new System.Windows.Forms.Padding(4);
            this.bt_pnSys.Name = "bt_pnSys";
            this.bt_pnSys.Size = new System.Drawing.Size(273, 53);
            this.bt_pnSys.TabIndex = 5;
            this.bt_pnSys.Text = "          System Info";
            this.bt_pnSys.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_pnSys.UseVisualStyleBackColor = false;
            this.bt_pnSys.Click += new System.EventHandler(this.bt_pnSys_Click);
            // 
            // bt_pnBackUp
            // 
            this.bt_pnBackUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.bunifuTransition6.SetDecoration(this.bt_pnBackUp, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bt_pnBackUp, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bt_pnBackUp, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bt_pnBackUp, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bt_pnBackUp, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition5.SetDecoration(this.bt_pnBackUp, BunifuAnimatorNS.DecorationType.None);
            this.bt_pnBackUp.FlatAppearance.BorderSize = 0;
            this.bt_pnBackUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_pnBackUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pnBackUp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_pnBackUp.Location = new System.Drawing.Point(-8, 414);
            this.bt_pnBackUp.Margin = new System.Windows.Forms.Padding(4);
            this.bt_pnBackUp.Name = "bt_pnBackUp";
            this.bt_pnBackUp.Size = new System.Drawing.Size(276, 53);
            this.bt_pnBackUp.TabIndex = 5;
            this.bt_pnBackUp.Text = "          Backup Data ";
            this.bt_pnBackUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_pnBackUp.UseVisualStyleBackColor = false;
            this.bt_pnBackUp.Click += new System.EventHandler(this.bt_pnBackUp_Click);
            // 
            // bt_pnTele
            // 
            this.bt_pnTele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.bunifuTransition6.SetDecoration(this.bt_pnTele, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bt_pnTele, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bt_pnTele, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bt_pnTele, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bt_pnTele, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition5.SetDecoration(this.bt_pnTele, BunifuAnimatorNS.DecorationType.None);
            this.bt_pnTele.FlatAppearance.BorderSize = 0;
            this.bt_pnTele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_pnTele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pnTele.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_pnTele.Location = new System.Drawing.Point(0, 455);
            this.bt_pnTele.Margin = new System.Windows.Forms.Padding(4);
            this.bt_pnTele.Name = "bt_pnTele";
            this.bt_pnTele.Size = new System.Drawing.Size(276, 53);
            this.bt_pnTele.TabIndex = 5;
            this.bt_pnTele.Text = "          Telemetry";
            this.bt_pnTele.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_pnTele.UseVisualStyleBackColor = false;
            this.bt_pnTele.Click += new System.EventHandler(this.bt_pnTele_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.panel1.Controls.Add(this.bunifuGradientPanel1);
            this.panel1.Controls.Add(this.bt_pnTele);
            this.panel1.Controls.Add(this.bt_pnBackUp);
            this.panel1.Controls.Add(this.bt_pnSys);
            this.panel1.Controls.Add(this.bt_pnScan);
            this.panel1.Controls.Add(this.bt_pnSetup);
            this.panel1.Controls.Add(this.bt_pnCon);
            this.bunifuTransition6.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition5.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 945);
            this.panel1.TabIndex = 6;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox3);
            this.bunifuGradientPanel1.Controls.Add(this.flowLayoutPanel1);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_version);
            this.bunifuGradientPanel1.Controls.Add(this.bt_pnRefresh_bu);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox2);
            this.bunifuTransition5.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.BottomMirror);
            this.bunifuTransition1.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.BottomMirror);
            this.bunifuTransition4.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition6.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-3, 0);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(281, 809);
            this.bunifuGradientPanel1.TabIndex = 17;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint_1);
            // 
            // pictureBox3
            // 
            this.bunifuTransition5.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition6.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = global::arduino2560.Properties.Resources.nextsense_small_32px_white;
            this.pictureBox3.Location = new System.Drawing.Point(13, 757);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flowLayoutPanel1.Controls.Add(this.bt_pnCon_bu);
            this.flowLayoutPanel1.Controls.Add(this.bt_pnTele_bu);
            this.flowLayoutPanel1.Controls.Add(this.bt_pnSys_bu);
            this.flowLayoutPanel1.Controls.Add(this.bt_pnSetup_bu);
            this.flowLayoutPanel1.Controls.Add(this.bt_pnBackUp_bu);
            this.flowLayoutPanel1.Controls.Add(this.bt_pnScan_bu);
            this.flowLayoutPanel1.Controls.Add(this.bt_pnAnal_bu);
            this.bunifuTransition5.SetDecoration(this.flowLayoutPanel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.flowLayoutPanel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.flowLayoutPanel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.flowLayoutPanel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.flowLayoutPanel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition6.SetDecoration(this.flowLayoutPanel1, BunifuAnimatorNS.DecorationType.None);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-29, 208);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(304, 543);
            this.flowLayoutPanel1.TabIndex = 28;
            // 
            // bt_pnCon_bu
            // 
            this.bt_pnCon_bu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(152)))), ((int)(((byte)(206)))));
            this.bt_pnCon_bu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_pnCon_bu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.bt_pnCon_bu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_pnCon_bu.BorderRadius = 0;
            this.bt_pnCon_bu.ButtonText = "               Connect";
            this.bt_pnCon_bu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition6.SetDecoration(this.bt_pnCon_bu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition5.SetDecoration(this.bt_pnCon_bu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bt_pnCon_bu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bt_pnCon_bu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bt_pnCon_bu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bt_pnCon_bu, BunifuAnimatorNS.DecorationType.None);
            this.bt_pnCon_bu.DisabledColor = System.Drawing.Color.Gray;
            this.bt_pnCon_bu.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pnCon_bu.Iconcolor = System.Drawing.Color.Transparent;
            this.bt_pnCon_bu.Iconimage = global::arduino2560.Properties.Resources.connect_white;
            this.bt_pnCon_bu.Iconimage_right = null;
            this.bt_pnCon_bu.Iconimage_right_Selected = null;
            this.bt_pnCon_bu.Iconimage_Selected = null;
            this.bt_pnCon_bu.IconMarginLeft = 22;
            this.bt_pnCon_bu.IconMarginRight = 0;
            this.bt_pnCon_bu.IconRightVisible = true;
            this.bt_pnCon_bu.IconRightZoom = 0D;
            this.bt_pnCon_bu.IconVisible = true;
            this.bt_pnCon_bu.IconZoom = 65D;
            this.bt_pnCon_bu.IsTab = false;
            this.bt_pnCon_bu.Location = new System.Drawing.Point(24, 4);
            this.bt_pnCon_bu.Margin = new System.Windows.Forms.Padding(17, 4, 4, 4);
            this.bt_pnCon_bu.Name = "bt_pnCon_bu";
            this.bt_pnCon_bu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.bt_pnCon_bu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(224)))));
            this.bt_pnCon_bu.OnHoverTextColor = System.Drawing.Color.White;
            this.bt_pnCon_bu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_pnCon_bu.selected = true;
            this.bt_pnCon_bu.Size = new System.Drawing.Size(276, 62);
            this.bt_pnCon_bu.TabIndex = 17;
            this.bt_pnCon_bu.Text = "               Connect";
            this.bt_pnCon_bu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_pnCon_bu.Textcolor = System.Drawing.Color.White;
            this.bt_pnCon_bu.TextFont = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pnCon_bu.Click += new System.EventHandler(this.bt_pnCon_Click);
            // 
            // bt_pnTele_bu
            // 
            this.bt_pnTele_bu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(152)))), ((int)(((byte)(206)))));
            this.bt_pnTele_bu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.bt_pnTele_bu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_pnTele_bu.BorderRadius = 0;
            this.bt_pnTele_bu.ButtonText = "               Telemetry";
            this.bt_pnTele_bu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition6.SetDecoration(this.bt_pnTele_bu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition5.SetDecoration(this.bt_pnTele_bu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bt_pnTele_bu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bt_pnTele_bu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bt_pnTele_bu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bt_pnTele_bu, BunifuAnimatorNS.DecorationType.None);
            this.bt_pnTele_bu.DisabledColor = System.Drawing.Color.SteelBlue;
            this.bt_pnTele_bu.Iconcolor = System.Drawing.Color.Transparent;
            this.bt_pnTele_bu.Iconimage = global::arduino2560.Properties.Resources.tower;
            this.bt_pnTele_bu.Iconimage_right = null;
            this.bt_pnTele_bu.Iconimage_right_Selected = null;
            this.bt_pnTele_bu.Iconimage_Selected = null;
            this.bt_pnTele_bu.IconMarginLeft = 25;
            this.bt_pnTele_bu.IconMarginRight = 0;
            this.bt_pnTele_bu.IconRightVisible = true;
            this.bt_pnTele_bu.IconRightZoom = 0D;
            this.bt_pnTele_bu.IconVisible = true;
            this.bt_pnTele_bu.IconZoom = 65D;
            this.bt_pnTele_bu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_pnTele_bu.IsTab = false;
            this.bt_pnTele_bu.Location = new System.Drawing.Point(24, 74);
            this.bt_pnTele_bu.Margin = new System.Windows.Forms.Padding(17, 4, 4, 4);
            this.bt_pnTele_bu.Name = "bt_pnTele_bu";
            this.bt_pnTele_bu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.bt_pnTele_bu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(224)))));
            this.bt_pnTele_bu.OnHoverTextColor = System.Drawing.Color.White;
            this.bt_pnTele_bu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_pnTele_bu.selected = true;
            this.bt_pnTele_bu.Size = new System.Drawing.Size(276, 62);
            this.bt_pnTele_bu.TabIndex = 18;
            this.bt_pnTele_bu.Text = "               Telemetry";
            this.bt_pnTele_bu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_pnTele_bu.Textcolor = System.Drawing.Color.White;
            this.bt_pnTele_bu.TextFont = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.bt_pnTele_bu, "In this Tab you can enter APN and FTP settings");
            this.bt_pnTele_bu.Visible = false;
            this.bt_pnTele_bu.Click += new System.EventHandler(this.bt_pnTele_Click);
            // 
            // bt_pnSys_bu
            // 
            this.bt_pnSys_bu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(152)))), ((int)(((byte)(206)))));
            this.bt_pnSys_bu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.bt_pnSys_bu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_pnSys_bu.BorderRadius = 0;
            this.bt_pnSys_bu.ButtonText = "               System Info";
            this.bt_pnSys_bu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition6.SetDecoration(this.bt_pnSys_bu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition5.SetDecoration(this.bt_pnSys_bu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bt_pnSys_bu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bt_pnSys_bu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bt_pnSys_bu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bt_pnSys_bu, BunifuAnimatorNS.DecorationType.None);
            this.bt_pnSys_bu.DisabledColor = System.Drawing.Color.SteelBlue;
            this.bt_pnSys_bu.Iconcolor = System.Drawing.Color.Transparent;
            this.bt_pnSys_bu.Iconimage = global::arduino2560.Properties.Resources.info;
            this.bt_pnSys_bu.Iconimage_right = null;
            this.bt_pnSys_bu.Iconimage_right_Selected = null;
            this.bt_pnSys_bu.Iconimage_Selected = null;
            this.bt_pnSys_bu.IconMarginLeft = 22;
            this.bt_pnSys_bu.IconMarginRight = 0;
            this.bt_pnSys_bu.IconRightVisible = true;
            this.bt_pnSys_bu.IconRightZoom = 0D;
            this.bt_pnSys_bu.IconVisible = true;
            this.bt_pnSys_bu.IconZoom = 65D;
            this.bt_pnSys_bu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_pnSys_bu.IsTab = false;
            this.bt_pnSys_bu.Location = new System.Drawing.Point(31, 144);
            this.bt_pnSys_bu.Margin = new System.Windows.Forms.Padding(17, 4, 4, 4);
            this.bt_pnSys_bu.Name = "bt_pnSys_bu";
            this.bt_pnSys_bu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.bt_pnSys_bu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(224)))));
            this.bt_pnSys_bu.OnHoverTextColor = System.Drawing.Color.White;
            this.bt_pnSys_bu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_pnSys_bu.selected = true;
            this.bt_pnSys_bu.Size = new System.Drawing.Size(269, 62);
            this.bt_pnSys_bu.TabIndex = 20;
            this.bt_pnSys_bu.Text = "               System Info";
            this.bt_pnSys_bu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_pnSys_bu.Textcolor = System.Drawing.Color.White;
            this.bt_pnSys_bu.TextFont = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pnSys_bu.Click += new System.EventHandler(this.bt_pnSys_Click);
            // 
            // bt_pnSetup_bu
            // 
            this.bt_pnSetup_bu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(152)))), ((int)(((byte)(206)))));
            this.bt_pnSetup_bu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.bt_pnSetup_bu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_pnSetup_bu.BorderRadius = 0;
            this.bt_pnSetup_bu.ButtonText = "               Setup";
            this.bt_pnSetup_bu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition6.SetDecoration(this.bt_pnSetup_bu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition5.SetDecoration(this.bt_pnSetup_bu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bt_pnSetup_bu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bt_pnSetup_bu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bt_pnSetup_bu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bt_pnSetup_bu, BunifuAnimatorNS.DecorationType.None);
            this.bt_pnSetup_bu.DisabledColor = System.Drawing.Color.SteelBlue;
            this.bt_pnSetup_bu.Iconcolor = System.Drawing.Color.Transparent;
            this.bt_pnSetup_bu.Iconimage = global::arduino2560.Properties.Resources.settings3;
            this.bt_pnSetup_bu.Iconimage_right = null;
            this.bt_pnSetup_bu.Iconimage_right_Selected = null;
            this.bt_pnSetup_bu.Iconimage_Selected = null;
            this.bt_pnSetup_bu.IconMarginLeft = 22;
            this.bt_pnSetup_bu.IconMarginRight = 0;
            this.bt_pnSetup_bu.IconRightVisible = true;
            this.bt_pnSetup_bu.IconRightZoom = 0D;
            this.bt_pnSetup_bu.IconVisible = true;
            this.bt_pnSetup_bu.IconZoom = 65D;
            this.bt_pnSetup_bu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_pnSetup_bu.IsTab = false;
            this.bt_pnSetup_bu.Location = new System.Drawing.Point(31, 214);
            this.bt_pnSetup_bu.Margin = new System.Windows.Forms.Padding(17, 4, 4, 4);
            this.bt_pnSetup_bu.Name = "bt_pnSetup_bu";
            this.bt_pnSetup_bu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.bt_pnSetup_bu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(224)))));
            this.bt_pnSetup_bu.OnHoverTextColor = System.Drawing.Color.White;
            this.bt_pnSetup_bu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_pnSetup_bu.selected = true;
            this.bt_pnSetup_bu.Size = new System.Drawing.Size(269, 62);
            this.bt_pnSetup_bu.TabIndex = 22;
            this.bt_pnSetup_bu.Text = "               Setup";
            this.bt_pnSetup_bu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_pnSetup_bu.Textcolor = System.Drawing.Color.White;
            this.bt_pnSetup_bu.TextFont = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pnSetup_bu.Click += new System.EventHandler(this.bt_pnSetup_Click);
            // 
            // bt_pnBackUp_bu
            // 
            this.bt_pnBackUp_bu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(152)))), ((int)(((byte)(206)))));
            this.bt_pnBackUp_bu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.bt_pnBackUp_bu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_pnBackUp_bu.BorderRadius = 0;
            this.bt_pnBackUp_bu.ButtonText = "               BackUp";
            this.bt_pnBackUp_bu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition6.SetDecoration(this.bt_pnBackUp_bu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition5.SetDecoration(this.bt_pnBackUp_bu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bt_pnBackUp_bu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bt_pnBackUp_bu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bt_pnBackUp_bu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bt_pnBackUp_bu, BunifuAnimatorNS.DecorationType.None);
            this.bt_pnBackUp_bu.DisabledColor = System.Drawing.Color.SteelBlue;
            this.bt_pnBackUp_bu.Iconcolor = System.Drawing.Color.Transparent;
            this.bt_pnBackUp_bu.Iconimage = global::arduino2560.Properties.Resources.download2;
            this.bt_pnBackUp_bu.Iconimage_right = null;
            this.bt_pnBackUp_bu.Iconimage_right_Selected = null;
            this.bt_pnBackUp_bu.Iconimage_Selected = null;
            this.bt_pnBackUp_bu.IconMarginLeft = 25;
            this.bt_pnBackUp_bu.IconMarginRight = 0;
            this.bt_pnBackUp_bu.IconRightVisible = true;
            this.bt_pnBackUp_bu.IconRightZoom = 0D;
            this.bt_pnBackUp_bu.IconVisible = true;
            this.bt_pnBackUp_bu.IconZoom = 65D;
            this.bt_pnBackUp_bu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_pnBackUp_bu.IsTab = false;
            this.bt_pnBackUp_bu.Location = new System.Drawing.Point(31, 284);
            this.bt_pnBackUp_bu.Margin = new System.Windows.Forms.Padding(17, 4, 4, 4);
            this.bt_pnBackUp_bu.Name = "bt_pnBackUp_bu";
            this.bt_pnBackUp_bu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.bt_pnBackUp_bu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(224)))));
            this.bt_pnBackUp_bu.OnHoverTextColor = System.Drawing.Color.White;
            this.bt_pnBackUp_bu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_pnBackUp_bu.selected = true;
            this.bt_pnBackUp_bu.Size = new System.Drawing.Size(269, 62);
            this.bt_pnBackUp_bu.TabIndex = 19;
            this.bt_pnBackUp_bu.Text = "               BackUp";
            this.bt_pnBackUp_bu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_pnBackUp_bu.Textcolor = System.Drawing.Color.White;
            this.bt_pnBackUp_bu.TextFont = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pnBackUp_bu.Click += new System.EventHandler(this.bt_pnBackUp_Click);
            // 
            // bt_pnScan_bu
            // 
            this.bt_pnScan_bu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(152)))), ((int)(((byte)(206)))));
            this.bt_pnScan_bu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.bt_pnScan_bu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_pnScan_bu.BorderRadius = 0;
            this.bt_pnScan_bu.ButtonText = "               Scan";
            this.bt_pnScan_bu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition6.SetDecoration(this.bt_pnScan_bu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition5.SetDecoration(this.bt_pnScan_bu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bt_pnScan_bu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bt_pnScan_bu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bt_pnScan_bu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bt_pnScan_bu, BunifuAnimatorNS.DecorationType.None);
            this.bt_pnScan_bu.DisabledColor = System.Drawing.Color.Gray;
            this.bt_pnScan_bu.Iconcolor = System.Drawing.Color.Transparent;
            this.bt_pnScan_bu.Iconimage = global::arduino2560.Properties.Resources.Scan;
            this.bt_pnScan_bu.Iconimage_right = null;
            this.bt_pnScan_bu.Iconimage_right_Selected = null;
            this.bt_pnScan_bu.Iconimage_Selected = null;
            this.bt_pnScan_bu.IconMarginLeft = 22;
            this.bt_pnScan_bu.IconMarginRight = 0;
            this.bt_pnScan_bu.IconRightVisible = true;
            this.bt_pnScan_bu.IconRightZoom = 0D;
            this.bt_pnScan_bu.IconVisible = true;
            this.bt_pnScan_bu.IconZoom = 65D;
            this.bt_pnScan_bu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_pnScan_bu.IsTab = false;
            this.bt_pnScan_bu.Location = new System.Drawing.Point(31, 354);
            this.bt_pnScan_bu.Margin = new System.Windows.Forms.Padding(17, 4, 4, 4);
            this.bt_pnScan_bu.Name = "bt_pnScan_bu";
            this.bt_pnScan_bu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.bt_pnScan_bu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(224)))));
            this.bt_pnScan_bu.OnHoverTextColor = System.Drawing.Color.White;
            this.bt_pnScan_bu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_pnScan_bu.selected = true;
            this.bt_pnScan_bu.Size = new System.Drawing.Size(269, 62);
            this.bt_pnScan_bu.TabIndex = 21;
            this.bt_pnScan_bu.Text = "               Scan";
            this.bt_pnScan_bu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_pnScan_bu.Textcolor = System.Drawing.Color.White;
            this.bt_pnScan_bu.TextFont = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pnScan_bu.Click += new System.EventHandler(this.bt_pnScan_Click);
            this.bt_pnScan_bu.MouseHover += new System.EventHandler(this.bt_pnScan_bu_MouseHover);
            // 
            // bt_pnAnal_bu
            // 
            this.bt_pnAnal_bu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(152)))), ((int)(((byte)(206)))));
            this.bt_pnAnal_bu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.bt_pnAnal_bu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_pnAnal_bu.BorderRadius = 0;
            this.bt_pnAnal_bu.ButtonText = "    Analysis";
            this.bt_pnAnal_bu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition6.SetDecoration(this.bt_pnAnal_bu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition5.SetDecoration(this.bt_pnAnal_bu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bt_pnAnal_bu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bt_pnAnal_bu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bt_pnAnal_bu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bt_pnAnal_bu, BunifuAnimatorNS.DecorationType.None);
            this.bt_pnAnal_bu.DisabledColor = System.Drawing.Color.SteelBlue;
            this.bt_pnAnal_bu.Iconcolor = System.Drawing.Color.Transparent;
            this.bt_pnAnal_bu.Iconimage = null;
            this.bt_pnAnal_bu.Iconimage_right = null;
            this.bt_pnAnal_bu.Iconimage_right_Selected = null;
            this.bt_pnAnal_bu.Iconimage_Selected = null;
            this.bt_pnAnal_bu.IconMarginLeft = 22;
            this.bt_pnAnal_bu.IconMarginRight = 0;
            this.bt_pnAnal_bu.IconRightVisible = true;
            this.bt_pnAnal_bu.IconRightZoom = 0D;
            this.bt_pnAnal_bu.IconVisible = true;
            this.bt_pnAnal_bu.IconZoom = 65D;
            this.bt_pnAnal_bu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_pnAnal_bu.IsTab = false;
            this.bt_pnAnal_bu.Location = new System.Drawing.Point(31, 424);
            this.bt_pnAnal_bu.Margin = new System.Windows.Forms.Padding(17, 4, 4, 4);
            this.bt_pnAnal_bu.Name = "bt_pnAnal_bu";
            this.bt_pnAnal_bu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.bt_pnAnal_bu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(224)))));
            this.bt_pnAnal_bu.OnHoverTextColor = System.Drawing.Color.White;
            this.bt_pnAnal_bu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bt_pnAnal_bu.selected = true;
            this.bt_pnAnal_bu.Size = new System.Drawing.Size(269, 62);
            this.bt_pnAnal_bu.TabIndex = 20;
            this.bt_pnAnal_bu.Text = "    Analysis";
            this.bt_pnAnal_bu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_pnAnal_bu.Textcolor = System.Drawing.Color.White;
            this.bt_pnAnal_bu.TextFont = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pnAnal_bu.Visible = false;
            this.bt_pnAnal_bu.Click += new System.EventHandler(this.bt_pnAnal_bu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition6.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition5.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(52, 772);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "NEXTSENSE TECHNOLOGIES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.bunifuTransition6.SetDecoration(this.lbl_version, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.lbl_version, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.lbl_version, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.lbl_version, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.lbl_version, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition5.SetDecoration(this.lbl_version, BunifuAnimatorNS.DecorationType.None);
            this.lbl_version.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_version.Location = new System.Drawing.Point(52, 102);
            this.lbl_version.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(56, 17);
            this.lbl_version.TabIndex = 26;
            this.lbl_version.Text = "Version";
            this.lbl_version.Click += new System.EventHandler(this.lbl_version_Click_1);
            // 
            // bt_pnRefresh_bu
            // 
            this.bt_pnRefresh_bu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(152)))), ((int)(((byte)(206)))));
            this.bt_pnRefresh_bu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(224)))));
            this.bt_pnRefresh_bu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_pnRefresh_bu.BorderRadius = 0;
            this.bt_pnRefresh_bu.ButtonText = "";
            this.bt_pnRefresh_bu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition6.SetDecoration(this.bt_pnRefresh_bu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition5.SetDecoration(this.bt_pnRefresh_bu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.bt_pnRefresh_bu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bt_pnRefresh_bu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.bt_pnRefresh_bu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.bt_pnRefresh_bu, BunifuAnimatorNS.DecorationType.None);
            this.bt_pnRefresh_bu.DisabledColor = System.Drawing.Color.Gray;
            this.bt_pnRefresh_bu.Iconcolor = System.Drawing.Color.Transparent;
            this.bt_pnRefresh_bu.Iconimage = global::arduino2560.Properties.Resources.refresh_white;
            this.bt_pnRefresh_bu.Iconimage_right = null;
            this.bt_pnRefresh_bu.Iconimage_right_Selected = null;
            this.bt_pnRefresh_bu.Iconimage_Selected = null;
            this.bt_pnRefresh_bu.IconMarginLeft = 12;
            this.bt_pnRefresh_bu.IconMarginRight = 0;
            this.bt_pnRefresh_bu.IconRightVisible = true;
            this.bt_pnRefresh_bu.IconRightZoom = 0D;
            this.bt_pnRefresh_bu.IconVisible = true;
            this.bt_pnRefresh_bu.IconZoom = 65D;
            this.bt_pnRefresh_bu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_pnRefresh_bu.IsTab = false;
            this.bt_pnRefresh_bu.Location = new System.Drawing.Point(17, 486);
            this.bt_pnRefresh_bu.Margin = new System.Windows.Forms.Padding(17, 4, 4, 4);
            this.bt_pnRefresh_bu.Name = "bt_pnRefresh_bu";
            this.bt_pnRefresh_bu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(224)))));
            this.bt_pnRefresh_bu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(224)))));
            this.bt_pnRefresh_bu.OnHoverTextColor = System.Drawing.Color.White;
            this.bt_pnRefresh_bu.selected = true;
            this.bt_pnRefresh_bu.Size = new System.Drawing.Size(75, 62);
            this.bt_pnRefresh_bu.TabIndex = 21;
            this.bt_pnRefresh_bu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_pnRefresh_bu.Textcolor = System.Drawing.Color.White;
            this.bt_pnRefresh_bu.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pnRefresh_bu.Visible = false;
            this.bt_pnRefresh_bu.Click += new System.EventHandler(this.bt_pnRefresh_bu_Click);
            this.bt_pnRefresh_bu.MouseHover += new System.EventHandler(this.bt_pnScan_bu_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.bunifuTransition5.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition6.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = global::arduino2560.Properties.Resources.next_comm;
            this.pictureBox2.Location = new System.Drawing.Point(0, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(40, 25, 40, 25);
            this.pictureBox2.Size = new System.Drawing.Size(275, 129);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 1;
            // 
            // bunifuColorTransition1
            // 
            this.bunifuColorTransition1.Color1 = System.Drawing.Color.White;
            this.bunifuColorTransition1.Color2 = System.Drawing.Color.White;
            this.bunifuColorTransition1.ProgessValue = 0;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide;
            this.bunifuTransition1.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation3;
            // 
            // bunifuTransition2
            // 
            this.bunifuTransition2.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide;
            this.bunifuTransition2.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition2.DefaultAnimation = animation2;
            // 
            // bunifuTransition3
            // 
            this.bunifuTransition3.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide;
            this.bunifuTransition3.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.bunifuTransition3.DefaultAnimation = animation5;
            // 
            // bunifuTransition4
            // 
            this.bunifuTransition4.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide;
            this.bunifuTransition4.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.bunifuTransition4.DefaultAnimation = animation4;
            // 
            // bunifuTransition5
            // 
            this.bunifuTransition5.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide;
            this.bunifuTransition5.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 0;
            animation6.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 0F;
            this.bunifuTransition5.DefaultAnimation = animation6;
            // 
            // bunifuTransition6
            // 
            this.bunifuTransition6.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition6.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition6.DefaultAnimation = animation1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1352, 800);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_TitleBar);
            this.bunifuTransition2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition4.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition6.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition5.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Next-Comm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.pnl_TitleBar.ResumeLayout(false);
            this.pnl_TitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tClk;
        private System.Windows.Forms.Panel pnl_TitleBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label5;
        private System.IO.Ports.SerialPort serialPort_Form;
        private System.Windows.Forms.Button btn_Min;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Timer tim_ScanRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_pnTele;
        private System.Windows.Forms.Button bt_pnBackUp;
        private System.Windows.Forms.Button bt_pnSys;
        private System.Windows.Forms.Button bt_pnScan;
        private System.Windows.Forms.Button bt_pnSetup;
        private System.Windows.Forms.Button bt_pnCon;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
        private Bunifu.Framework.UI.BunifuFlatButton bt_pnRefresh_bu;
        private Bunifu.Framework.UI.BunifuColorTransition bunifuColorTransition1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.ToolTip toolTip1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition6;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition2;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition4;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition3;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition5;
        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton bt_pnCon_bu;
        public Bunifu.Framework.UI.BunifuFlatButton bt_pnScan_bu;
        public Bunifu.Framework.UI.BunifuFlatButton bt_pnTele_bu;
        public Bunifu.Framework.UI.BunifuFlatButton bt_pnSys_bu;
        public Bunifu.Framework.UI.BunifuFlatButton bt_pnAnal_bu;
        private Bunifu.Framework.UI.BunifuFlatButton bt_pnBackUp_bu;
        private Bunifu.Framework.UI.BunifuFlatButton bt_pnSetup_bu;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

