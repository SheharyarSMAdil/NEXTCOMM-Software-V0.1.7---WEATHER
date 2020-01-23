namespace arduino2560
{
    partial class Analysis
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
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.btn_openFolder = new MaterialSkin.Controls.MaterialFlatButton();
            this.tb_folderPath = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pnl_tool = new System.Windows.Forms.Panel();
            this.cb_dataValues = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_table = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tab_chart = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_analysis = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dd_fileList_bu = new Bunifu.Framework.UI.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.bunifuCards1.SuspendLayout();
            this.pnl_tool.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tab_chart.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCards1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(225)))));
            this.bunifuCards1.Controls.Add(this.btn_openFolder);
            this.bunifuCards1.Controls.Add(this.tb_folderPath);
            this.bunifuCards1.Controls.Add(this.pnl_tool);
            this.bunifuCards1.Controls.Add(this.tabControl1);
            this.bunifuCards1.Controls.Add(this.btn_analysis);
            this.bunifuCards1.Controls.Add(this.dd_fileList_bu);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(218, 59);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(727, 563);
            this.bunifuCards1.TabIndex = 1;
            // 
            // btn_openFolder
            // 
            this.btn_openFolder.AutoSize = true;
            this.btn_openFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_openFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.btn_openFolder.Depth = 0;
            this.btn_openFolder.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_openFolder.Location = new System.Drawing.Point(274, 63);
            this.btn_openFolder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_openFolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_openFolder.Name = "btn_openFolder";
            this.btn_openFolder.Primary = false;
            this.btn_openFolder.Size = new System.Drawing.Size(67, 36);
            this.btn_openFolder.TabIndex = 22;
            this.btn_openFolder.Text = "Browse";
            this.btn_openFolder.UseVisualStyleBackColor = false;
            // 
            // tb_folderPath
            // 
            this.tb_folderPath.Depth = 0;
            this.tb_folderPath.Hint = "";
            this.tb_folderPath.Location = new System.Drawing.Point(16, 77);
            this.tb_folderPath.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_folderPath.Name = "tb_folderPath";
            this.tb_folderPath.PasswordChar = '\0';
            this.tb_folderPath.SelectedText = "";
            this.tb_folderPath.SelectionLength = 0;
            this.tb_folderPath.SelectionStart = 0;
            this.tb_folderPath.Size = new System.Drawing.Size(252, 23);
            this.tb_folderPath.TabIndex = 21;
            this.tb_folderPath.UseSystemPasswordChar = false;
            // 
            // pnl_tool
            // 
            this.pnl_tool.BackColor = System.Drawing.Color.White;
            this.pnl_tool.Controls.Add(this.cb_dataValues);
            this.pnl_tool.Controls.Add(this.label3);
            this.pnl_tool.Location = new System.Drawing.Point(12, 510);
            this.pnl_tool.Name = "pnl_tool";
            this.pnl_tool.Size = new System.Drawing.Size(698, 25);
            this.pnl_tool.TabIndex = 20;
            this.pnl_tool.Visible = false;
            // 
            // cb_dataValues
            // 
            this.cb_dataValues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_dataValues.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_dataValues.Checked = false;
            this.cb_dataValues.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(67)))));
            this.cb_dataValues.ForeColor = System.Drawing.Color.White;
            this.cb_dataValues.Location = new System.Drawing.Point(518, 3);
            this.cb_dataValues.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.cb_dataValues.Name = "cb_dataValues";
            this.cb_dataValues.Size = new System.Drawing.Size(20, 20);
            this.cb_dataValues.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(67)))));
            this.label3.Location = new System.Drawing.Point(540, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Show/Hide Data Values";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_table);
            this.tabControl1.Controls.Add(this.tab_chart);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.ItemSize = new System.Drawing.Size(150, 25);
            this.tabControl1.Location = new System.Drawing.Point(11, 144);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(20, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(704, 366);
            this.tabControl1.TabIndex = 19;
            // 
            // tab_table
            // 
            this.tab_table.BackColor = System.Drawing.Color.Transparent;
            this.tab_table.Controls.Add(this.dataGridView1);
            this.tab_table.Location = new System.Drawing.Point(4, 29);
            this.tab_table.Name = "tab_table";
            this.tab_table.Padding = new System.Windows.Forms.Padding(3);
            this.tab_table.Size = new System.Drawing.Size(696, 333);
            this.tab_table.TabIndex = 0;
            this.tab_table.Text = "TABLE";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(687, 327);
            this.dataGridView1.TabIndex = 0;
            // 
            // tab_chart
            // 
            this.tab_chart.BackColor = System.Drawing.SystemColors.Control;
            this.tab_chart.Controls.Add(this.tabControl2);
            this.tab_chart.Location = new System.Drawing.Point(4, 29);
            this.tab_chart.Name = "tab_chart";
            this.tab_chart.Padding = new System.Windows.Forms.Padding(3);
            this.tab_chart.Size = new System.Drawing.Size(696, 333);
            this.tab_chart.TabIndex = 1;
            this.tab_chart.Text = "CHART";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(690, 327);
            this.tabControl2.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(682, 297);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_analysis
            // 
            this.btn_analysis.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_analysis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_analysis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_analysis.BorderRadius = 3;
            this.btn_analysis.ButtonText = "Analysis";
            this.btn_analysis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_analysis.DisabledColor = System.Drawing.Color.Gray;
            this.btn_analysis.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_analysis.Iconimage = null;
            this.btn_analysis.Iconimage_right = global::arduino2560.Properties.Resources.ic_show_chart_white_48dp;
            this.btn_analysis.Iconimage_right_Selected = null;
            this.btn_analysis.Iconimage_Selected = null;
            this.btn_analysis.IconMarginLeft = 0;
            this.btn_analysis.IconMarginRight = 0;
            this.btn_analysis.IconRightVisible = true;
            this.btn_analysis.IconRightZoom = 0D;
            this.btn_analysis.IconVisible = true;
            this.btn_analysis.IconZoom = 90D;
            this.btn_analysis.IsTab = false;
            this.btn_analysis.Location = new System.Drawing.Point(596, 67);
            this.btn_analysis.Name = "btn_analysis";
            this.btn_analysis.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_analysis.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.btn_analysis.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_analysis.selected = false;
            this.btn_analysis.Size = new System.Drawing.Size(113, 35);
            this.btn_analysis.TabIndex = 18;
            this.btn_analysis.Text = "Analysis";
            this.btn_analysis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_analysis.Textcolor = System.Drawing.Color.White;
            this.btn_analysis.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_analysis.Click += new System.EventHandler(this.btn_analysis_Click);
            // 
            // dd_fileList_bu
            // 
            this.dd_fileList_bu.BackColor = System.Drawing.Color.Transparent;
            this.dd_fileList_bu.BorderRadius = 3;
            this.dd_fileList_bu.DisabledColor = System.Drawing.Color.Gray;
            this.dd_fileList_bu.ForeColor = System.Drawing.Color.White;
            this.dd_fileList_bu.Items = new string[] {
        "Select File Name"};
            this.dd_fileList_bu.Location = new System.Drawing.Point(363, 67);
            this.dd_fileList_bu.Name = "dd_fileList_bu";
            this.dd_fileList_bu.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.dd_fileList_bu.onHoverColor = System.Drawing.Color.DodgerBlue;
            this.dd_fileList_bu.selectedIndex = 0;
            this.dd_fileList_bu.Size = new System.Drawing.Size(227, 35);
            this.dd_fileList_bu.TabIndex = 17;
            this.dd_fileList_bu.onItemSelected += new System.EventHandler(this.dd_fileList_bu_onItemSelected);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Analysis";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Analysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 634);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(200, 100);
            this.MaximizeBox = false;
            this.Name = "Analysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Analysis_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.pnl_tool.ResumeLayout(false);
            this.pnl_tool.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tab_chart.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuDropdown dd_fileList_bu;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_analysis;
        private System.Windows.Forms.Panel pnl_tool;
        private Bunifu.Framework.UI.BunifuCheckbox cb_dataValues;
        private System.Windows.Forms.Label label3;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopSelectFolder SelectFolder_dialog;
        private MaterialSkin.Controls.MaterialFlatButton btn_openFolder;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_folderPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_table;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tab_chart;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
    }
}