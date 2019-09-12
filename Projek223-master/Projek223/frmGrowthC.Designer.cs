namespace Projek223
{
    partial class frmGrowthC
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addPage = new System.Windows.Forms.TabControl();
            this.Info = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDesc1 = new System.Windows.Forms.Label();
            this.lblDesc2 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.streep = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.MaintainGC = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.dgGROWT = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBTNAddGC = new System.Windows.Forms.Label();
            this.dateTimePickerADD = new System.Windows.Forms.DateTimePicker();
            this.lblAddDesc1 = new System.Windows.Forms.Label();
            this.lblAddDesc2 = new System.Windows.Forms.Label();
            this.lblAddDesc3 = new System.Windows.Forms.Label();
            this.cmbVarADD = new System.Windows.Forms.ComboBox();
            this.txtADD = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCD = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblChangeGC = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDeleteGC = new System.Windows.Forms.Label();
            this.dateTimePickerCD = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbVarCD = new System.Windows.Forms.ComboBox();
            this.lblAddGC = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.MaintainVariant = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchVar = new System.Windows.Forms.TextBox();
            this.lblAddVar1 = new System.Windows.Forms.Label();
            this.dgVariants = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCDVar2 = new System.Windows.Forms.Label();
            this.lblCDVar4 = new System.Windows.Forms.Label();
            this.txtTypeCD = new System.Windows.Forms.TextBox();
            this.txtDaysCD = new System.Windows.Forms.TextBox();
            this.lblCDVar3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblChangeVar = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDaysADD = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.lblAddVar2 = new System.Windows.Forms.Label();
            this.lblAddVar3 = new System.Windows.Forms.Label();
            this.txtTypeADD = new System.Windows.Forms.TextBox();
            this.lblCDVar1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.addPage.SuspendLayout();
            this.Info.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.MaintainGC.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGROWT)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.MaintainVariant.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVariants)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.monthCalendar1.BackColor = System.Drawing.Color.White;
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(18, 25);
            this.monthCalendar1.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.TitleBackColor = System.Drawing.Color.Aqua;
            this.monthCalendar1.TrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Location = new System.Drawing.Point(154, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 213);
            this.panel1.TabIndex = 1;
            // 
            // addPage
            // 
            this.addPage.Controls.Add(this.Info);
            this.addPage.Controls.Add(this.MaintainGC);
            this.addPage.Controls.Add(this.MaintainVariant);
            this.addPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addPage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPage.Location = new System.Drawing.Point(0, 0);
            this.addPage.Name = "addPage";
            this.addPage.SelectedIndex = 0;
            this.addPage.Size = new System.Drawing.Size(1294, 735);
            this.addPage.TabIndex = 2;
            // 
            // Info
            // 
            this.Info.AutoScroll = true;
            this.Info.Controls.Add(this.tableLayoutPanel1);
            this.Info.Controls.Add(this.streep);
            this.Info.Controls.Add(this.lblInfo);
            this.Info.Controls.Add(this.panel1);
            this.Info.Location = new System.Drawing.Point(4, 30);
            this.Info.Name = "Info";
            this.Info.Padding = new System.Windows.Forms.Padding(3);
            this.Info.Size = new System.Drawing.Size(1286, 701);
            this.Info.TabIndex = 0;
            this.Info.Text = "Info";
            this.Info.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel1.Controls.Add(this.lblDesc1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDesc2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBox1, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(154, 401);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(670, 346);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lblDesc1
            // 
            this.lblDesc1.AutoSize = true;
            this.lblDesc1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc1.Location = new System.Drawing.Point(3, 0);
            this.lblDesc1.Name = "lblDesc1";
            this.lblDesc1.Size = new System.Drawing.Size(62, 30);
            this.lblDesc1.TabIndex = 1;
            this.lblDesc1.Text = "Date:";
            // 
            // lblDesc2
            // 
            this.lblDesc2.AutoSize = true;
            this.lblDesc2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc2.Location = new System.Drawing.Point(3, 98);
            this.lblDesc2.Name = "lblDesc2";
            this.lblDesc2.Size = new System.Drawing.Size(88, 30);
            this.lblDesc2.TabIndex = 0;
            this.lblDesc2.Text = "Harvest:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(194, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(68, 30);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "label1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(194, 101);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(473, 235);
            this.listBox1.TabIndex = 3;
            // 
            // streep
            // 
            this.streep.AutoSize = true;
            this.streep.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streep.Location = new System.Drawing.Point(43, 92);
            this.streep.Name = "streep";
            this.streep.Size = new System.Drawing.Size(677, 39);
            this.streep.TabIndex = 3;
            this.streep.Text = "_________________________________";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(125, 27);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(511, 65);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Growth cycle information";
            // 
            // MaintainGC
            // 
            this.MaintainGC.AutoScroll = true;
            this.MaintainGC.Controls.Add(this.tableLayoutPanel6);
            this.MaintainGC.Location = new System.Drawing.Point(4, 30);
            this.MaintainGC.Name = "MaintainGC";
            this.MaintainGC.Padding = new System.Windows.Forms.Padding(3);
            this.MaintainGC.Size = new System.Drawing.Size(1286, 701);
            this.MaintainGC.TabIndex = 1;
            this.MaintainGC.Text = "Growth cycles";
            this.MaintainGC.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.dgGROWT, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel4, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.lblAddGC, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.lblChange, 1, 1);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(8, 6);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.61905F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.61905F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1384, 831);
            this.tableLayoutPanel6.TabIndex = 4;
            // 
            // dgGROWT
            // 
            this.dgGROWT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGROWT.Location = new System.Drawing.Point(3, 3);
            this.dgGROWT.Name = "dgGROWT";
            this.dgGROWT.Size = new System.Drawing.Size(686, 389);
            this.dgGROWT.TabIndex = 1;
            this.dgGROWT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgGROWT_CellClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.12765F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.19962F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.67273F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePickerADD, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblAddDesc1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblAddDesc2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblAddDesc3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cmbVarADD, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtADD, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 437);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.45347F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.45348F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.45348F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.63958F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(686, 264);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(107)))));
            this.panel2.Controls.Add(this.lblBTNAddGC);
            this.panel2.Location = new System.Drawing.Point(214, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 58);
            this.panel2.TabIndex = 2;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // lblBTNAddGC
            // 
            this.lblBTNAddGC.AutoSize = true;
            this.lblBTNAddGC.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBTNAddGC.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBTNAddGC.Location = new System.Drawing.Point(59, 9);
            this.lblBTNAddGC.Name = "lblBTNAddGC";
            this.lblBTNAddGC.Size = new System.Drawing.Size(73, 40);
            this.lblBTNAddGC.TabIndex = 0;
            this.lblBTNAddGC.Text = "Add";
            this.lblBTNAddGC.Click += new System.EventHandler(this.lblBTNAddGC_Click);
            // 
            // dateTimePickerADD
            // 
            this.dateTimePickerADD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerADD.Location = new System.Drawing.Point(204, 125);
            this.dateTimePickerADD.Name = "dateTimePickerADD";
            this.dateTimePickerADD.Size = new System.Drawing.Size(217, 29);
            this.dateTimePickerADD.TabIndex = 2;
            // 
            // lblAddDesc1
            // 
            this.lblAddDesc1.AutoSize = true;
            this.lblAddDesc1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDesc1.Location = new System.Drawing.Point(3, 0);
            this.lblAddDesc1.Name = "lblAddDesc1";
            this.lblAddDesc1.Size = new System.Drawing.Size(82, 30);
            this.lblAddDesc1.TabIndex = 1;
            this.lblAddDesc1.Text = "Variant:";
            // 
            // lblAddDesc2
            // 
            this.lblAddDesc2.AutoSize = true;
            this.lblAddDesc2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDesc2.Location = new System.Drawing.Point(3, 56);
            this.lblAddDesc2.Name = "lblAddDesc2";
            this.lblAddDesc2.Size = new System.Drawing.Size(128, 30);
            this.lblAddDesc2.TabIndex = 2;
            this.lblAddDesc2.Text = "Quantity (g):";
            // 
            // lblAddDesc3
            // 
            this.lblAddDesc3.AutoSize = true;
            this.lblAddDesc3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDesc3.Location = new System.Drawing.Point(3, 112);
            this.lblAddDesc3.Name = "lblAddDesc3";
            this.lblAddDesc3.Size = new System.Drawing.Size(138, 30);
            this.lblAddDesc3.TabIndex = 3;
            this.lblAddDesc3.Text = "Date planted:";
            // 
            // cmbVarADD
            // 
            this.cmbVarADD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbVarADD.FormattingEnabled = true;
            this.cmbVarADD.Location = new System.Drawing.Point(204, 13);
            this.cmbVarADD.Name = "cmbVarADD";
            this.cmbVarADD.Size = new System.Drawing.Size(218, 29);
            this.cmbVarADD.TabIndex = 4;
            this.cmbVarADD.SelectedIndexChanged += new System.EventHandler(this.cmbVarADD_SelectedIndexChanged);
            // 
            // txtADD
            // 
            this.txtADD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtADD.Location = new System.Drawing.Point(203, 69);
            this.txtADD.Name = "txtADD";
            this.txtADD.Size = new System.Drawing.Size(219, 29);
            this.txtADD.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.txtCD, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.panel5, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.panel4, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.dateTimePickerCD, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.cmbVarCD, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(695, 437);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.45347F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.45348F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.45348F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.63958F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(514, 264);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // txtCD
            // 
            this.txtCD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCD.Location = new System.Drawing.Point(276, 69);
            this.txtCD.Name = "txtCD";
            this.txtCD.Size = new System.Drawing.Size(219, 29);
            this.txtCD.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(156)))), ((int)(((byte)(40)))));
            this.panel5.Controls.Add(this.lblChangeGC);
            this.panel5.Location = new System.Drawing.Point(30, 203);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(197, 58);
            this.panel5.TabIndex = 6;
            this.panel5.Click += new System.EventHandler(this.panel5_Click);
            // 
            // lblChangeGC
            // 
            this.lblChangeGC.AutoSize = true;
            this.lblChangeGC.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeGC.ForeColor = System.Drawing.SystemColors.Control;
            this.lblChangeGC.Location = new System.Drawing.Point(35, 9);
            this.lblChangeGC.Name = "lblChangeGC";
            this.lblChangeGC.Size = new System.Drawing.Size(120, 40);
            this.lblChangeGC.TabIndex = 0;
            this.lblChangeGC.Text = "Change";
            this.lblChangeGC.Click += new System.EventHandler(this.lblChangeGC_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.panel4.Controls.Add(this.lblDeleteGC);
            this.panel4.Location = new System.Drawing.Point(287, 203);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 58);
            this.panel4.TabIndex = 2;
            this.panel4.Click += new System.EventHandler(this.panel4_Click);
            // 
            // lblDeleteGC
            // 
            this.lblDeleteGC.AutoSize = true;
            this.lblDeleteGC.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteGC.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDeleteGC.Location = new System.Drawing.Point(47, 9);
            this.lblDeleteGC.Name = "lblDeleteGC";
            this.lblDeleteGC.Size = new System.Drawing.Size(105, 40);
            this.lblDeleteGC.TabIndex = 0;
            this.lblDeleteGC.Text = "Delete";
            this.lblDeleteGC.Click += new System.EventHandler(this.lblDeleteGC_Click);
            // 
            // dateTimePickerCD
            // 
            this.dateTimePickerCD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerCD.Location = new System.Drawing.Point(277, 125);
            this.dateTimePickerCD.Name = "dateTimePickerCD";
            this.dateTimePickerCD.Size = new System.Drawing.Size(217, 29);
            this.dateTimePickerCD.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Variant:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quantity (g):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 30);
            this.label5.TabIndex = 3;
            this.label5.Text = "Harvest date:";
            // 
            // cmbVarCD
            // 
            this.cmbVarCD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbVarCD.FormattingEnabled = true;
            this.cmbVarCD.Location = new System.Drawing.Point(276, 17);
            this.cmbVarCD.Name = "cmbVarCD";
            this.cmbVarCD.Size = new System.Drawing.Size(218, 29);
            this.cmbVarCD.TabIndex = 4;
            this.cmbVarCD.SelectedIndexChanged += new System.EventHandler(this.cmbVarCD_SelectedIndexChanged);
            // 
            // lblAddGC
            // 
            this.lblAddGC.AutoSize = true;
            this.lblAddGC.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddGC.Location = new System.Drawing.Point(3, 395);
            this.lblAddGC.Name = "lblAddGC";
            this.lblAddGC.Size = new System.Drawing.Size(294, 37);
            this.lblAddGC.TabIndex = 0;
            this.lblAddGC.Text = "Add new growth cycle:";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(695, 395);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(395, 37);
            this.lblChange.TabIndex = 2;
            this.lblChange.Text = "Change or delete growth cycle:";
            // 
            // MaintainVariant
            // 
            this.MaintainVariant.AutoScroll = true;
            this.MaintainVariant.Controls.Add(this.tableLayoutPanel7);
            this.MaintainVariant.Location = new System.Drawing.Point(4, 30);
            this.MaintainVariant.Name = "MaintainVariant";
            this.MaintainVariant.Padding = new System.Windows.Forms.Padding(3);
            this.MaintainVariant.Size = new System.Drawing.Size(1286, 701);
            this.MaintainVariant.TabIndex = 2;
            this.MaintainVariant.Text = "Variants";
            this.MaintainVariant.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel14, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.lblAddVar1, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.dgVariants, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.lblCDVar1, 1, 1);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.57662F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.846763F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.57662F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1206, 693);
            this.tableLayoutPanel7.TabIndex = 9;
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 2;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel14.Controls.Add(this.txtSearchVar, 1, 0);
            this.tableLayoutPanel14.Location = new System.Drawing.Point(606, 3);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 2;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(535, 156);
            this.tableLayoutPanel14.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 30);
            this.label7.TabIndex = 14;
            this.label7.Text = "Search a variant:";
            // 
            // txtSearchVar
            // 
            this.txtSearchVar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchVar.Location = new System.Drawing.Point(286, 24);
            this.txtSearchVar.Name = "txtSearchVar";
            this.txtSearchVar.Size = new System.Drawing.Size(229, 29);
            this.txtSearchVar.TabIndex = 0;
            // 
            // lblAddVar1
            // 
            this.lblAddVar1.AutoSize = true;
            this.lblAddVar1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddVar1.Location = new System.Drawing.Point(3, 322);
            this.lblAddVar1.Name = "lblAddVar1";
            this.lblAddVar1.Size = new System.Drawing.Size(223, 37);
            this.lblAddVar1.TabIndex = 8;
            this.lblAddVar1.Text = "Add new variant:";
            // 
            // dgVariants
            // 
            this.dgVariants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVariants.Location = new System.Drawing.Point(3, 3);
            this.dgVariants.Name = "dgVariants";
            this.dgVariants.Size = new System.Drawing.Size(597, 316);
            this.dgVariants.TabIndex = 5;
            this.dgVariants.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVariants_CellClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lblCDVar2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblCDVar4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtTypeCD, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtDaysCD, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblCDVar3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtID, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel3, 1, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(606, 372);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(514, 264);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // lblCDVar2
            // 
            this.lblCDVar2.AutoSize = true;
            this.lblCDVar2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCDVar2.Location = new System.Drawing.Point(3, 0);
            this.lblCDVar2.Name = "lblCDVar2";
            this.lblCDVar2.Size = new System.Drawing.Size(39, 30);
            this.lblCDVar2.TabIndex = 11;
            this.lblCDVar2.Text = "ID:";
            // 
            // lblCDVar4
            // 
            this.lblCDVar4.AutoSize = true;
            this.lblCDVar4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCDVar4.Location = new System.Drawing.Point(3, 124);
            this.lblCDVar4.Name = "lblCDVar4";
            this.lblCDVar4.Size = new System.Drawing.Size(123, 30);
            this.lblCDVar4.TabIndex = 2;
            this.lblCDVar4.Text = "Description:";
            // 
            // txtTypeCD
            // 
            this.txtTypeCD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTypeCD.Location = new System.Drawing.Point(277, 140);
            this.txtTypeCD.Name = "txtTypeCD";
            this.txtTypeCD.Size = new System.Drawing.Size(217, 29);
            this.txtTypeCD.TabIndex = 9;
            // 
            // txtDaysCD
            // 
            this.txtDaysCD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDaysCD.Location = new System.Drawing.Point(277, 78);
            this.txtDaysCD.Name = "txtDaysCD";
            this.txtDaysCD.Size = new System.Drawing.Size(217, 29);
            this.txtDaysCD.TabIndex = 9;
            // 
            // lblCDVar3
            // 
            this.lblCDVar3.AutoSize = true;
            this.lblCDVar3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCDVar3.Location = new System.Drawing.Point(3, 62);
            this.lblCDVar3.Name = "lblCDVar3";
            this.lblCDVar3.Size = new System.Drawing.Size(161, 30);
            this.lblCDVar3.TabIndex = 1;
            this.lblCDVar3.Text = "Days to harvest:";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.Location = new System.Drawing.Point(277, 16);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(217, 29);
            this.txtID.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(156)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.lblChangeVar);
            this.panel3.Location = new System.Drawing.Point(287, 203);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 58);
            this.panel3.TabIndex = 6;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            // 
            // lblChangeVar
            // 
            this.lblChangeVar.AutoSize = true;
            this.lblChangeVar.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeVar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblChangeVar.Location = new System.Drawing.Point(34, 9);
            this.lblChangeVar.Name = "lblChangeVar";
            this.lblChangeVar.Size = new System.Drawing.Size(120, 40);
            this.lblChangeVar.TabIndex = 0;
            this.lblChangeVar.Text = "Change";
            this.lblChangeVar.Click += new System.EventHandler(this.lblChangeVar_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.txtDaysADD, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.panel7, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.lblAddVar2, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblAddVar3, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.txtTypeADD, 1, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 372);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.31307F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.31308F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.37385F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(597, 288);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // txtDaysADD
            // 
            this.txtDaysADD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDaysADD.Location = new System.Drawing.Point(202, 24);
            this.txtDaysADD.Name = "txtDaysADD";
            this.txtDaysADD.Size = new System.Drawing.Size(193, 29);
            this.txtDaysADD.TabIndex = 9;
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(107)))));
            this.panel7.Controls.Add(this.label12);
            this.panel7.Location = new System.Drawing.Point(202, 227);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(193, 58);
            this.panel7.TabIndex = 2;
            this.panel7.Click += new System.EventHandler(this.panel7_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(59, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 40);
            this.label12.TabIndex = 0;
            this.label12.Text = "Add";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // lblAddVar2
            // 
            this.lblAddVar2.AutoSize = true;
            this.lblAddVar2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddVar2.Location = new System.Drawing.Point(3, 0);
            this.lblAddVar2.Name = "lblAddVar2";
            this.lblAddVar2.Size = new System.Drawing.Size(161, 30);
            this.lblAddVar2.TabIndex = 1;
            this.lblAddVar2.Text = "Days to harvest:";
            // 
            // lblAddVar3
            // 
            this.lblAddVar3.AutoSize = true;
            this.lblAddVar3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddVar3.Location = new System.Drawing.Point(3, 78);
            this.lblAddVar3.Name = "lblAddVar3";
            this.lblAddVar3.Size = new System.Drawing.Size(123, 30);
            this.lblAddVar3.TabIndex = 2;
            this.lblAddVar3.Text = "Description:";
            // 
            // txtTypeADD
            // 
            this.txtTypeADD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTypeADD.Location = new System.Drawing.Point(202, 102);
            this.txtTypeADD.Name = "txtTypeADD";
            this.txtTypeADD.Size = new System.Drawing.Size(193, 29);
            this.txtTypeADD.TabIndex = 5;
            // 
            // lblCDVar1
            // 
            this.lblCDVar1.AutoSize = true;
            this.lblCDVar1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCDVar1.Location = new System.Drawing.Point(606, 322);
            this.lblCDVar1.Name = "lblCDVar1";
            this.lblCDVar1.Size = new System.Drawing.Size(209, 37);
            this.lblCDVar1.TabIndex = 6;
            this.lblCDVar1.Text = "Change variant:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmGrowthC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 735);
            this.Controls.Add(this.addPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGrowthC";
            this.Text = "frmGrowthC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGrowthC_Load);
            this.panel1.ResumeLayout(false);
            this.addPage.ResumeLayout(false);
            this.Info.ResumeLayout(false);
            this.Info.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.MaintainGC.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGROWT)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.MaintainVariant.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVariants)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl addPage;
        private System.Windows.Forms.TabPage Info;
        private System.Windows.Forms.TabPage MaintainGC;
        private System.Windows.Forms.Label streep;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDesc1;
        private System.Windows.Forms.Label lblDesc2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TabPage MaintainVariant;
        private System.Windows.Forms.Label lblAddGC;
        private System.Windows.Forms.Label lblAddDesc1;
        private System.Windows.Forms.Label lblAddDesc2;
        private System.Windows.Forms.Label lblAddDesc3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePickerADD;
        private System.Windows.Forms.ComboBox cmbVarADD;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblBTNAddGC;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblChangeGC;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblDeleteGC;
        private System.Windows.Forms.DateTimePicker dateTimePickerCD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbVarCD;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.DataGridView dgGROWT;
        private System.Windows.Forms.Label lblAddVar1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblChangeVar;
        private System.Windows.Forms.Label lblCDVar3;
        private System.Windows.Forms.Label lblCDVar4;
        private System.Windows.Forms.Label lblCDVar1;
        private System.Windows.Forms.DataGridView dgVariants;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblAddVar2;
        private System.Windows.Forms.Label lblAddVar3;
        private System.Windows.Forms.TextBox txtTypeCD;
        private System.Windows.Forms.TextBox txtDaysCD;
        private System.Windows.Forms.TextBox txtTypeADD;
        private System.Windows.Forms.Label lblCDVar2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TextBox txtADD;
        private System.Windows.Forms.TextBox txtCD;
        private System.Windows.Forms.TextBox txtDaysADD;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearchVar;
    }
}