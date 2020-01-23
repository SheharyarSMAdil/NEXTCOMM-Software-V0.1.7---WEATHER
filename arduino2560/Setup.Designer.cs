namespace arduino2560
{
    partial class Setup
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
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.gb_calibration = new System.Windows.Forms.GroupBox();
            this.txt_cal_b = new System.Windows.Forms.TextBox();
            this.txt_cal_a = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_calCoef = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_wireLength = new System.Windows.Forms.GroupBox();
            this.lbl_meter = new System.Windows.Forms.Label();
            this.NUD_wireLength = new System.Windows.Forms.NumericUpDown();
            this.bt_wireLength = new System.Windows.Forms.Button();
            this.gb_logInterval = new System.Windows.Forms.GroupBox();
            this.NUD_LogInterval = new System.Windows.Forms.ComboBox();
            this.lbl_min = new System.Windows.Forms.Label();
            this.bt_logInterval = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.NUD_Min = new arduino2560.Hour_Min();
            this.NUD_Hour = new arduino2560.Hour_Min();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.bt_dateTime = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_apn = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bt_apn_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            this.gb_calibration.SuspendLayout();
            this.gb_wireLength.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_wireLength)).BeginInit();
            this.gb_logInterval.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(0, 0);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 0;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCards1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(225)))));
            this.bunifuCards1.Controls.Add(this.groupBox1);
            this.bunifuCards1.Controls.Add(this.gb_calibration);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.Controls.Add(this.gb_wireLength);
            this.bunifuCards1.Controls.Add(this.gb_logInterval);
            this.bunifuCards1.Controls.Add(this.groupBox2);
            this.bunifuCards1.Controls.Add(this.pictureBox4);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(288, 111);
            this.bunifuCards1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(849, 510);
            this.bunifuCards1.TabIndex = 0;
            // 
            // gb_calibration
            // 
            this.gb_calibration.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gb_calibration.Controls.Add(this.txt_cal_b);
            this.gb_calibration.Controls.Add(this.txt_cal_a);
            this.gb_calibration.Controls.Add(this.label3);
            this.gb_calibration.Controls.Add(this.label2);
            this.gb_calibration.Controls.Add(this.bt_calCoef);
            this.gb_calibration.Enabled = false;
            this.gb_calibration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_calibration.Location = new System.Drawing.Point(49, 468);
            this.gb_calibration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_calibration.Name = "gb_calibration";
            this.gb_calibration.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_calibration.Size = new System.Drawing.Size(752, 105);
            this.gb_calibration.TabIndex = 17;
            this.gb_calibration.TabStop = false;
            this.gb_calibration.Text = "Calibration Coefficients:";
            this.gb_calibration.Visible = false;
            // 
            // txt_cal_b
            // 
            this.txt_cal_b.Location = new System.Drawing.Point(335, 43);
            this.txt_cal_b.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cal_b.Name = "txt_cal_b";
            this.txt_cal_b.Size = new System.Drawing.Size(232, 29);
            this.txt_cal_b.TabIndex = 11;
            // 
            // txt_cal_a
            // 
            this.txt_cal_a.Location = new System.Drawing.Point(55, 44);
            this.txt_cal_a.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cal_a.Name = "txt_cal_a";
            this.txt_cal_a.Size = new System.Drawing.Size(232, 29);
            this.txt_cal_a.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(296, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "b:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "a:";
            // 
            // bt_calCoef
            // 
            this.bt_calCoef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.bt_calCoef.FlatAppearance.BorderSize = 0;
            this.bt_calCoef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_calCoef.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_calCoef.ForeColor = System.Drawing.Color.White;
            this.bt_calCoef.Location = new System.Drawing.Point(667, 37);
            this.bt_calCoef.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_calCoef.Name = "bt_calCoef";
            this.bt_calCoef.Size = new System.Drawing.Size(85, 37);
            this.bt_calCoef.TabIndex = 12;
            this.bt_calCoef.Text = "Update";
            this.bt_calCoef.UseVisualStyleBackColor = false;
            this.bt_calCoef.Click += new System.EventHandler(this.bt_calCoef_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 46);
            this.label1.TabIndex = 16;
            this.label1.Text = "Setup Your Device";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gb_wireLength
            // 
            this.gb_wireLength.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gb_wireLength.Controls.Add(this.lbl_meter);
            this.gb_wireLength.Controls.Add(this.NUD_wireLength);
            this.gb_wireLength.Controls.Add(this.bt_wireLength);
            this.gb_wireLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_wireLength.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gb_wireLength.Location = new System.Drawing.Point(437, 267);
            this.gb_wireLength.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_wireLength.Name = "gb_wireLength";
            this.gb_wireLength.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_wireLength.Size = new System.Drawing.Size(364, 87);
            this.gb_wireLength.TabIndex = 11;
            this.gb_wireLength.TabStop = false;
            this.gb_wireLength.Text = "Update Wire Length";
            this.gb_wireLength.Visible = false;
            // 
            // lbl_meter
            // 
            this.lbl_meter.AutoSize = true;
            this.lbl_meter.Location = new System.Drawing.Point(161, 38);
            this.lbl_meter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_meter.Name = "lbl_meter";
            this.lbl_meter.Size = new System.Drawing.Size(63, 24);
            this.lbl_meter.TabIndex = 10;
            this.lbl_meter.Text = "meter";
            // 
            // NUD_wireLength
            // 
            this.NUD_wireLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_wireLength.Location = new System.Drawing.Point(29, 34);
            this.NUD_wireLength.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NUD_wireLength.Maximum = new decimal(new int[] {
            101,
            0,
            0,
            0});
            this.NUD_wireLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.NUD_wireLength.Name = "NUD_wireLength";
            this.NUD_wireLength.Size = new System.Drawing.Size(124, 29);
            this.NUD_wireLength.TabIndex = 8;
            this.NUD_wireLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_wireLength.ValueChanged += new System.EventHandler(this.NUD_wireLength_ValueChanged);
            // 
            // bt_wireLength
            // 
            this.bt_wireLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.bt_wireLength.FlatAppearance.BorderSize = 0;
            this.bt_wireLength.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_wireLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_wireLength.ForeColor = System.Drawing.Color.White;
            this.bt_wireLength.Location = new System.Drawing.Point(279, 27);
            this.bt_wireLength.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_wireLength.Name = "bt_wireLength";
            this.bt_wireLength.Size = new System.Drawing.Size(85, 37);
            this.bt_wireLength.TabIndex = 9;
            this.bt_wireLength.Text = "Update";
            this.bt_wireLength.UseVisualStyleBackColor = false;
            this.bt_wireLength.Click += new System.EventHandler(this.bt_wireLength_Click);
            // 
            // gb_logInterval
            // 
            this.gb_logInterval.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gb_logInterval.Controls.Add(this.NUD_LogInterval);
            this.gb_logInterval.Controls.Add(this.lbl_min);
            this.gb_logInterval.Controls.Add(this.bt_logInterval);
            this.gb_logInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_logInterval.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gb_logInterval.Location = new System.Drawing.Point(49, 267);
            this.gb_logInterval.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_logInterval.Name = "gb_logInterval";
            this.gb_logInterval.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_logInterval.Size = new System.Drawing.Size(380, 87);
            this.gb_logInterval.TabIndex = 10;
            this.gb_logInterval.TabStop = false;
            this.gb_logInterval.Text = "Update Log Interval";
            // 
            // NUD_LogInterval
            // 
            this.NUD_LogInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_LogInterval.FormattingEnabled = true;
            this.NUD_LogInterval.Items.AddRange(new object[] {
            "15",
            "30",
            "60"});
            this.NUD_LogInterval.Location = new System.Drawing.Point(25, 36);
            this.NUD_LogInterval.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NUD_LogInterval.Name = "NUD_LogInterval";
            this.NUD_LogInterval.Size = new System.Drawing.Size(183, 32);
            this.NUD_LogInterval.TabIndex = 14;
            this.NUD_LogInterval.Text = "Select Log Interval";
            this.NUD_LogInterval.SelectedIndexChanged += new System.EventHandler(this.NUD_LogInterval_SelectedIndexChanged);
            // 
            // lbl_min
            // 
            this.lbl_min.AutoSize = true;
            this.lbl_min.Location = new System.Drawing.Point(208, 39);
            this.lbl_min.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_min.Name = "lbl_min";
            this.lbl_min.Size = new System.Drawing.Size(54, 24);
            this.lbl_min.TabIndex = 8;
            this.lbl_min.Text = "mins";
            // 
            // bt_logInterval
            // 
            this.bt_logInterval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.bt_logInterval.Enabled = false;
            this.bt_logInterval.FlatAppearance.BorderSize = 0;
            this.bt_logInterval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_logInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_logInterval.ForeColor = System.Drawing.Color.White;
            this.bt_logInterval.Location = new System.Drawing.Point(293, 32);
            this.bt_logInterval.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_logInterval.Name = "bt_logInterval";
            this.bt_logInterval.Size = new System.Drawing.Size(87, 37);
            this.bt_logInterval.TabIndex = 7;
            this.bt_logInterval.Text = "Update";
            this.bt_logInterval.UseVisualStyleBackColor = false;
            this.bt_logInterval.Click += new System.EventHandler(this.bt_logInterval_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.bunifuCheckbox1);
            this.groupBox2.Controls.Add(this.NUD_Min);
            this.groupBox2.Controls.Add(this.NUD_Hour);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.bt_dateTime);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(49, 118);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(752, 130);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Date and Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(432, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Time";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(81, 41);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(313, 26);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox1.Checked = false;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(225)))));
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(24, 87);
            this.bunifuCheckbox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 12;
            this.bunifuCheckbox1.OnChange += new System.EventHandler(this.bunifuCheckbox1_OnChange);
            // 
            // NUD_Min
            // 
            this.NUD_Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_Min.Location = new System.Drawing.Point(561, 42);
            this.NUD_Min.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NUD_Min.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.NUD_Min.Name = "NUD_Min";
            this.NUD_Min.Size = new System.Drawing.Size(49, 26);
            this.NUD_Min.TabIndex = 3;
            this.NUD_Min.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUD_Min.ValueChanged += new System.EventHandler(this.NUD_Min_ValueChanged);
            // 
            // NUD_Hour
            // 
            this.NUD_Hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_Hour.Location = new System.Drawing.Point(492, 42);
            this.NUD_Hour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NUD_Hour.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.NUD_Hour.Name = "NUD_Hour";
            this.NUD_Hour.Size = new System.Drawing.Size(49, 26);
            this.NUD_Hour.TabIndex = 2;
            this.NUD_Hour.Value = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.NUD_Hour.ValueChanged += new System.EventHandler(this.NUD_Hour_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(544, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = ":";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(29, 87);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(166, 24);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Pick System Time";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // bt_dateTime
            // 
            this.bt_dateTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.bt_dateTime.FlatAppearance.BorderSize = 0;
            this.bt_dateTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_dateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dateTime.ForeColor = System.Drawing.Color.White;
            this.bt_dateTime.Location = new System.Drawing.Point(667, 49);
            this.bt_dateTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_dateTime.Name = "bt_dateTime";
            this.bt_dateTime.Size = new System.Drawing.Size(85, 37);
            this.bt_dateTime.TabIndex = 5;
            this.bt_dateTime.Text = "Update";
            this.bt_dateTime.UseVisualStyleBackColor = false;
            this.bt_dateTime.Click += new System.EventHandler(this.bt_dateTime_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = global::arduino2560.Properties.Resources.sidepanel1;
            this.pictureBox4.Location = new System.Drawing.Point(596, 180);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(249, 327);
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.tb_apn);
            this.groupBox1.Controls.Add(this.bt_apn_update);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(49, 357);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(752, 103);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert APN";
            // 
            // tb_apn
            // 
            this.tb_apn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_apn.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_apn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_apn.HintForeColor = System.Drawing.Color.Empty;
            this.tb_apn.HintText = "";
            this.tb_apn.isPassword = false;
            this.tb_apn.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.tb_apn.LineIdleColor = System.Drawing.Color.Gray;
            this.tb_apn.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.tb_apn.LineThickness = 3;
            this.tb_apn.Location = new System.Drawing.Point(51, 33);
            this.tb_apn.Margin = new System.Windows.Forms.Padding(5);
            this.tb_apn.Name = "tb_apn";
            this.tb_apn.Size = new System.Drawing.Size(505, 41);
            this.tb_apn.TabIndex = 1;
            this.tb_apn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bt_apn_update
            // 
            this.bt_apn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_apn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.bt_apn_update.FlatAppearance.BorderSize = 0;
            this.bt_apn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_apn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_apn_update.ForeColor = System.Drawing.Color.White;
            this.bt_apn_update.Location = new System.Drawing.Point(592, 36);
            this.bt_apn_update.Margin = new System.Windows.Forms.Padding(4);
            this.bt_apn_update.Name = "bt_apn_update";
            this.bt_apn_update.Size = new System.Drawing.Size(160, 41);
            this.bt_apn_update.TabIndex = 2;
            this.bt_apn_update.Text = "Update";
            this.bt_apn_update.UseVisualStyleBackColor = false;
            this.bt_apn_update.Click += new System.EventHandler(this.bt_apn_update_Click);
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(200, 100);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Setup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Setup";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Setup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.gb_calibration.ResumeLayout(false);
            this.gb_calibration.PerformLayout();
            this.gb_wireLength.ResumeLayout(false);
            this.gb_wireLength.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_wireLength)).EndInit();
            this.gb_logInterval.ResumeLayout(false);
            this.gb_logInterval.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Button bt_logInterval;
        private System.Windows.Forms.GroupBox groupBox2;
        private Hour_Min NUD_Min;
        private Hour_Min NUD_Hour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button bt_dateTime;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown NUD_wireLength;
        private System.Windows.Forms.Button bt_wireLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_calCoef;
        private System.Windows.Forms.TextBox txt_cal_b;
        private System.Windows.Forms.TextBox txt_cal_a;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_meter;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.GroupBox gb_logInterval;
        public System.Windows.Forms.GroupBox gb_calibration;
        public System.Windows.Forms.GroupBox gb_wireLength;
        public System.Windows.Forms.Label lbl_min;
        private System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.ComboBox NUD_LogInterval;
        private System.Windows.Forms.GroupBox groupBox1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox tb_apn;
        private System.Windows.Forms.Button bt_apn_update;
    }
}