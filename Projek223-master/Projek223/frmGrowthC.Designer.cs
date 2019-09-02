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
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDesc1 = new System.Windows.Forms.Label();
            this.lblDesc2 = new System.Windows.Forms.Label();
            this.MaintainGC = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblAddDesc1 = new System.Windows.Forms.Label();
            this.lblAddDesc2 = new System.Windows.Forms.Label();
            this.lblAddDesc3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBTNAddGC = new System.Windows.Forms.Label();
            this.lblAddGC = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblChangeGC = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDeleteGC = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.MaintainVariant = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblAddVar1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.lblAddVar2 = new System.Windows.Forms.Label();
            this.lblAddVar3 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCDVar1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCDVar2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblChangeVar = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblDeleteVar = new System.Windows.Forms.Label();
            this.lblCDVar4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblCDVar3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.addPage.SuspendLayout();
            this.Info.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.MaintainGC.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.MaintainVariant.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.monthCalendar1.BackColor = System.Drawing.Color.White;
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(24, 31);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
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
            this.panel1.Location = new System.Drawing.Point(691, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 261);
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
            this.addPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addPage.Name = "addPage";
            this.addPage.SelectedIndex = 0;
            this.addPage.Size = new System.Drawing.Size(1853, 1102);
            this.addPage.TabIndex = 2;
            // 
            // Info
            // 
            this.Info.AutoScroll = true;
            this.Info.Controls.Add(this.tableLayoutPanel6);
            this.Info.Location = new System.Drawing.Point(4, 37);
            this.Info.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Info.Name = "Info";
            this.Info.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Info.Size = new System.Drawing.Size(1845, 1061);
            this.Info.TabIndex = 0;
            this.Info.Text = "Info";
            this.Info.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.lblInfo, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(11, 37);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1375, 803);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(4, 0);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(644, 84);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Growth cycle information";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel1.Controls.Add(this.lblDesc1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDesc2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 442);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(679, 357);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lblDesc1
            // 
            this.lblDesc1.AutoSize = true;
            this.lblDesc1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc1.Location = new System.Drawing.Point(4, 0);
            this.lblDesc1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc1.Name = "lblDesc1";
            this.lblDesc1.Size = new System.Drawing.Size(79, 37);
            this.lblDesc1.TabIndex = 1;
            this.lblDesc1.Text = "Date:";
            // 
            // lblDesc2
            // 
            this.lblDesc2.AutoSize = true;
            this.lblDesc2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc2.Location = new System.Drawing.Point(4, 102);
            this.lblDesc2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc2.Name = "lblDesc2";
            this.lblDesc2.Size = new System.Drawing.Size(112, 37);
            this.lblDesc2.TabIndex = 0;
            this.lblDesc2.Text = "Harvest:";
            // 
            // MaintainGC
            // 
            this.MaintainGC.AutoScroll = true;
            this.MaintainGC.Controls.Add(this.tableLayoutPanel7);
            this.MaintainGC.Location = new System.Drawing.Point(4, 37);
            this.MaintainGC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaintainGC.Name = "MaintainGC";
            this.MaintainGC.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaintainGC.Size = new System.Drawing.Size(1845, 1061);
            this.MaintainGC.TabIndex = 1;
            this.MaintainGC.Text = "Growth cycles";
            this.MaintainGC.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.lblAddGC, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel4, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.lblChange, 1, 1);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.26077F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.478468F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.26077F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1795, 1011);
            this.tableLayoutPanel7.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(889, 454);
            this.dataGridView1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.63447F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.5079F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.85763F));
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker1, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblAddDesc1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblAddDesc2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblAddDesc3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.comboBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBox2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 536);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.45347F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.45348F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.45348F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.63958F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(747, 325);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Location = new System.Drawing.Point(298, 155);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(288, 34);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lblAddDesc1
            // 
            this.lblAddDesc1.AutoSize = true;
            this.lblAddDesc1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDesc1.Location = new System.Drawing.Point(4, 0);
            this.lblAddDesc1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddDesc1.Name = "lblAddDesc1";
            this.lblAddDesc1.Size = new System.Drawing.Size(106, 37);
            this.lblAddDesc1.TabIndex = 1;
            this.lblAddDesc1.Text = "Variant:";
            // 
            // lblAddDesc2
            // 
            this.lblAddDesc2.AutoSize = true;
            this.lblAddDesc2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDesc2.Location = new System.Drawing.Point(4, 69);
            this.lblAddDesc2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddDesc2.Name = "lblAddDesc2";
            this.lblAddDesc2.Size = new System.Drawing.Size(125, 37);
            this.lblAddDesc2.TabIndex = 2;
            this.lblAddDesc2.Text = "Quantity:";
            // 
            // lblAddDesc3
            // 
            this.lblAddDesc3.AutoSize = true;
            this.lblAddDesc3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDesc3.Location = new System.Drawing.Point(4, 138);
            this.lblAddDesc3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddDesc3.Name = "lblAddDesc3";
            this.lblAddDesc3.Size = new System.Drawing.Size(79, 37);
            this.lblAddDesc3.TabIndex = 3;
            this.lblAddDesc3.Text = "Date:";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(298, 16);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(289, 36);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(298, 85);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(289, 36);
            this.comboBox2.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(107)))));
            this.panel2.Controls.Add(this.lblBTNAddGC);
            this.panel2.Location = new System.Drawing.Point(311, 250);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 71);
            this.panel2.TabIndex = 2;
            // 
            // lblBTNAddGC
            // 
            this.lblBTNAddGC.AutoSize = true;
            this.lblBTNAddGC.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBTNAddGC.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBTNAddGC.Location = new System.Drawing.Point(79, 11);
            this.lblBTNAddGC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBTNAddGC.Name = "lblBTNAddGC";
            this.lblBTNAddGC.Size = new System.Drawing.Size(94, 50);
            this.lblBTNAddGC.TabIndex = 0;
            this.lblBTNAddGC.Text = "Add";
            // 
            // lblAddGC
            // 
            this.lblAddGC.AutoSize = true;
            this.lblAddGC.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddGC.Location = new System.Drawing.Point(4, 477);
            this.lblAddGC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddGC.Name = "lblAddGC";
            this.lblAddGC.Size = new System.Drawing.Size(369, 46);
            this.lblAddGC.TabIndex = 0;
            this.lblAddGC.Text = "Add new growth cycle:";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel4.Controls.Add(this.panel5, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.panel4, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.dateTimePicker2, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.comboBox4, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.comboBox5, 1, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(901, 536);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.45347F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.45348F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.45348F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.63958F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(708, 325);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(156)))), ((int)(((byte)(40)))));
            this.panel5.Controls.Add(this.lblChangeGC);
            this.panel5.Location = new System.Drawing.Point(29, 250);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(263, 71);
            this.panel5.TabIndex = 6;
            // 
            // lblChangeGC
            // 
            this.lblChangeGC.AutoSize = true;
            this.lblChangeGC.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeGC.ForeColor = System.Drawing.SystemColors.Control;
            this.lblChangeGC.Location = new System.Drawing.Point(47, 11);
            this.lblChangeGC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChangeGC.Name = "lblChangeGC";
            this.lblChangeGC.Size = new System.Drawing.Size(152, 50);
            this.lblChangeGC.TabIndex = 0;
            this.lblChangeGC.Text = "Change";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.panel4.Controls.Add(this.lblDeleteGC);
            this.panel4.Location = new System.Drawing.Point(350, 250);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(263, 71);
            this.panel4.TabIndex = 2;
            // 
            // lblDeleteGC
            // 
            this.lblDeleteGC.AutoSize = true;
            this.lblDeleteGC.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteGC.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDeleteGC.Location = new System.Drawing.Point(63, 11);
            this.lblDeleteGC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeleteGC.Name = "lblDeleteGC";
            this.lblDeleteGC.Size = new System.Drawing.Size(134, 50);
            this.lblDeleteGC.TabIndex = 0;
            this.lblDeleteGC.Text = "Delete";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker2.Location = new System.Drawing.Point(337, 155);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(288, 34);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "Variant:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 37);
            this.label5.TabIndex = 3;
            this.label5.Text = "Date:";
            // 
            // comboBox4
            // 
            this.comboBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(337, 16);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(289, 36);
            this.comboBox4.TabIndex = 4;
            // 
            // comboBox5
            // 
            this.comboBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(337, 85);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(289, 36);
            this.comboBox5.TabIndex = 5;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(901, 477);
            this.lblChange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(496, 46);
            this.lblChange.TabIndex = 2;
            this.lblChange.Text = "Change or delete growth cycle:";
            // 
            // MaintainVariant
            // 
            this.MaintainVariant.AutoScroll = true;
            this.MaintainVariant.Controls.Add(this.tableLayoutPanel8);
            this.MaintainVariant.Location = new System.Drawing.Point(4, 37);
            this.MaintainVariant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaintainVariant.Name = "MaintainVariant";
            this.MaintainVariant.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaintainVariant.Size = new System.Drawing.Size(1845, 1265);
            this.MaintainVariant.TabIndex = 2;
            this.MaintainVariant.Text = "Variants";
            this.MaintainVariant.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.dataGridView2, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.lblAddVar1, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.lblCDVar1, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(8, 7);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.61905F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.61905F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(2128, 1070);
            this.tableLayoutPanel8.TabIndex = 9;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(4, 4);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1003, 489);
            this.dataGridView2.TabIndex = 5;
            // 
            // lblAddVar1
            // 
            this.lblAddVar1.AutoSize = true;
            this.lblAddVar1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddVar1.Location = new System.Drawing.Point(4, 509);
            this.lblAddVar1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddVar1.Name = "lblAddVar1";
            this.lblAddVar1.Size = new System.Drawing.Size(369, 46);
            this.lblAddVar1.TabIndex = 8;
            this.lblAddVar1.Text = "Add new growth cycle:";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.29192F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.29192F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.41617F));
            this.tableLayoutPanel5.Controls.Add(this.panel7, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.lblAddVar2, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblAddVar3, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.comboBox7, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBox1, 1, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 563);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.31307F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.31308F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.37385F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(796, 289);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(107)))));
            this.panel7.Controls.Add(this.label12);
            this.panel7.Location = new System.Drawing.Point(384, 214);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(263, 71);
            this.panel7.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(79, 11);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 50);
            this.label12.TabIndex = 0;
            this.label12.Text = "Add";
            // 
            // lblAddVar2
            // 
            this.lblAddVar2.AutoSize = true;
            this.lblAddVar2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddVar2.Location = new System.Drawing.Point(4, 0);
            this.lblAddVar2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddVar2.Name = "lblAddVar2";
            this.lblAddVar2.Size = new System.Drawing.Size(204, 37);
            this.lblAddVar2.TabIndex = 1;
            this.lblAddVar2.Text = "Days to harvest:";
            // 
            // lblAddVar3
            // 
            this.lblAddVar3.AutoSize = true;
            this.lblAddVar3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddVar3.Location = new System.Drawing.Point(4, 78);
            this.lblAddVar3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddVar3.Name = "lblAddVar3";
            this.lblAddVar3.Size = new System.Drawing.Size(79, 37);
            this.lblAddVar3.TabIndex = 2;
            this.lblAddVar3.Text = "Type:";
            // 
            // comboBox7
            // 
            this.comboBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(371, 21);
            this.comboBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(289, 36);
            this.comboBox7.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(372, 100);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 34);
            this.textBox1.TabIndex = 5;
            // 
            // lblCDVar1
            // 
            this.lblCDVar1.AutoSize = true;
            this.lblCDVar1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCDVar1.Location = new System.Drawing.Point(1068, 509);
            this.lblCDVar1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCDVar1.Name = "lblCDVar1";
            this.lblCDVar1.Size = new System.Drawing.Size(496, 46);
            this.lblCDVar1.TabIndex = 6;
            this.lblCDVar1.Text = "Change or delete growth cycle:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.Controls.Add(this.lblCDVar2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.panel6, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblCDVar4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.textBox3, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblCDVar3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBox4, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1068, 563);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(685, 325);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // lblCDVar2
            // 
            this.lblCDVar2.AutoSize = true;
            this.lblCDVar2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCDVar2.Location = new System.Drawing.Point(4, 0);
            this.lblCDVar2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCDVar2.Name = "lblCDVar2";
            this.lblCDVar2.Size = new System.Drawing.Size(49, 37);
            this.lblCDVar2.TabIndex = 11;
            this.lblCDVar2.Text = "ID:";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(156)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.lblChangeVar);
            this.panel3.Location = new System.Drawing.Point(24, 250);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 71);
            this.panel3.TabIndex = 6;
            // 
            // lblChangeVar
            // 
            this.lblChangeVar.AutoSize = true;
            this.lblChangeVar.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeVar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblChangeVar.Location = new System.Drawing.Point(45, 11);
            this.lblChangeVar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChangeVar.Name = "lblChangeVar";
            this.lblChangeVar.Size = new System.Drawing.Size(152, 50);
            this.lblChangeVar.TabIndex = 0;
            this.lblChangeVar.Text = "Change";
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.panel6.Controls.Add(this.lblDeleteVar);
            this.panel6.Location = new System.Drawing.Point(335, 250);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(263, 71);
            this.panel6.TabIndex = 2;
            // 
            // lblDeleteVar
            // 
            this.lblDeleteVar.AutoSize = true;
            this.lblDeleteVar.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteVar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDeleteVar.Location = new System.Drawing.Point(63, 11);
            this.lblDeleteVar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeleteVar.Name = "lblDeleteVar";
            this.lblDeleteVar.Size = new System.Drawing.Size(134, 50);
            this.lblDeleteVar.TabIndex = 0;
            this.lblDeleteVar.Text = "Delete";
            // 
            // lblCDVar4
            // 
            this.lblCDVar4.AutoSize = true;
            this.lblCDVar4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCDVar4.Location = new System.Drawing.Point(4, 154);
            this.lblCDVar4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCDVar4.Name = "lblCDVar4";
            this.lblCDVar4.Size = new System.Drawing.Size(79, 37);
            this.lblCDVar4.TabIndex = 2;
            this.lblCDVar4.Text = "Type:";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Location = new System.Drawing.Point(322, 175);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(288, 34);
            this.textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(322, 98);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(288, 34);
            this.textBox2.TabIndex = 9;
            // 
            // lblCDVar3
            // 
            this.lblCDVar3.AutoSize = true;
            this.lblCDVar3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCDVar3.Location = new System.Drawing.Point(4, 77);
            this.lblCDVar3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCDVar3.Name = "lblCDVar3";
            this.lblCDVar3.Size = new System.Drawing.Size(204, 37);
            this.lblCDVar3.TabIndex = 1;
            this.lblCDVar3.Text = "Days to harvest:";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.Location = new System.Drawing.Point(322, 21);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(288, 34);
            this.textBox4.TabIndex = 10;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmGrowthC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1853, 1102);
            this.Controls.Add(this.addPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmGrowthC";
            this.Text = "frmGrowthC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.addPage.ResumeLayout(false);
            this.Info.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.MaintainGC.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl addPage;
        private System.Windows.Forms.TabPage Info;
        private System.Windows.Forms.TabPage MaintainGC;
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblBTNAddGC;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblChangeGC;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblDeleteGC;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblAddVar1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblChangeVar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblDeleteVar;
        private System.Windows.Forms.Label lblCDVar3;
        private System.Windows.Forms.Label lblCDVar4;
        private System.Windows.Forms.Label lblCDVar1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblAddVar2;
        private System.Windows.Forms.Label lblAddVar3;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCDVar2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
    }
}