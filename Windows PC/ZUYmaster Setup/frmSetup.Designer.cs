namespace ZUYmaster
{
    partial class frmSetup
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbRExcSpeed = new System.Windows.Forms.ComboBox();
            this.cbLExcSpeed = new System.Windows.Forms.ComboBox();
            this.cbRExcHex = new System.Windows.Forms.ComboBox();
            this.cbLExcHex = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbRKenwood = new System.Windows.Forms.RadioButton();
            this.rbRICOM = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbLKenwood = new System.Windows.Forms.RadioButton();
            this.rbLICOM = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbRAmpSpeed = new System.Windows.Forms.ComboBox();
            this.cbLAmpSpeed = new System.Windows.Forms.ComboBox();
            this.cbRAmpHex = new System.Windows.Forms.ComboBox();
            this.cbLAmpHex = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMsgs = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbCOMPort = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.cbZUYHex = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblConStatus = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.lblSaveStatus = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel1.Controls.Add(this.cbRExcSpeed, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbLExcSpeed, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbRExcHex, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbLExcHex, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(310, 165);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cbRExcSpeed
            // 
            this.cbRExcSpeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbRExcSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRExcSpeed.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRExcSpeed.FormattingEnabled = true;
            this.cbRExcSpeed.Items.AddRange(new object[] {
            "300",
            "1200",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cbRExcSpeed.Location = new System.Drawing.Point(217, 134);
            this.cbRExcSpeed.Name = "cbRExcSpeed";
            this.cbRExcSpeed.Size = new System.Drawing.Size(80, 25);
            this.cbRExcSpeed.TabIndex = 20;
            // 
            // cbLExcSpeed
            // 
            this.cbLExcSpeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbLExcSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLExcSpeed.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLExcSpeed.FormattingEnabled = true;
            this.cbLExcSpeed.Items.AddRange(new object[] {
            "300",
            "1200",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cbLExcSpeed.Location = new System.Drawing.Point(114, 134);
            this.cbLExcSpeed.Name = "cbLExcSpeed";
            this.cbLExcSpeed.Size = new System.Drawing.Size(80, 25);
            this.cbLExcSpeed.TabIndex = 19;
            // 
            // cbRExcHex
            // 
            this.cbRExcHex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbRExcHex.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRExcHex.FormattingEnabled = true;
            this.cbRExcHex.Items.AddRange(new object[] {
            "6E",
            "7A",
            "7C"});
            this.cbRExcHex.Location = new System.Drawing.Point(233, 100);
            this.cbRExcHex.Name = "cbRExcHex";
            this.cbRExcHex.Size = new System.Drawing.Size(47, 25);
            this.cbRExcHex.TabIndex = 15;
            // 
            // cbLExcHex
            // 
            this.cbLExcHex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbLExcHex.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLExcHex.FormattingEnabled = true;
            this.cbLExcHex.Items.AddRange(new object[] {
            "6E",
            "7A",
            "7C"});
            this.cbLExcHex.Location = new System.Drawing.Point(130, 100);
            this.cbLExcHex.Name = "cbLExcHex";
            this.cbLExcHex.Size = new System.Drawing.Size(47, 25);
            this.cbLExcHex.TabIndex = 14;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.rbRKenwood);
            this.flowLayoutPanel2.Controls.Add(this.rbRICOM);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(209, 37);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(93, 54);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // rbRKenwood
            // 
            this.rbRKenwood.AutoSize = true;
            this.rbRKenwood.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRKenwood.Location = new System.Drawing.Point(3, 3);
            this.rbRKenwood.Name = "rbRKenwood";
            this.rbRKenwood.Size = new System.Drawing.Size(87, 21);
            this.rbRKenwood.TabIndex = 0;
            this.rbRKenwood.Text = "Kenwood";
            this.rbRKenwood.UseVisualStyleBackColor = true;
            // 
            // rbRICOM
            // 
            this.rbRICOM.AutoSize = true;
            this.rbRICOM.Checked = true;
            this.rbRICOM.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRICOM.Location = new System.Drawing.Point(3, 30);
            this.rbRICOM.Name = "rbRICOM";
            this.rbRICOM.Size = new System.Drawing.Size(63, 21);
            this.rbRICOM.TabIndex = 1;
            this.rbRICOM.TabStop = true;
            this.rbRICOM.Text = "ICOM";
            this.rbRICOM.UseVisualStyleBackColor = true;
            this.rbRICOM.CheckedChanged += new System.EventHandler(this.rbRICOM_CheckedChanged);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 18);
            this.label11.TabIndex = 7;
            this.label11.Text = "Radio";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "LEFT\r";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "RIGHT\r";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Maker";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "CI-V Hex";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "COM Speed";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.rbLKenwood);
            this.flowLayoutPanel1.Controls.Add(this.rbLICOM);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(107, 37);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(93, 54);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // rbLKenwood
            // 
            this.rbLKenwood.AutoSize = true;
            this.rbLKenwood.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLKenwood.Location = new System.Drawing.Point(3, 3);
            this.rbLKenwood.Name = "rbLKenwood";
            this.rbLKenwood.Size = new System.Drawing.Size(87, 21);
            this.rbLKenwood.TabIndex = 0;
            this.rbLKenwood.Text = "Kenwood";
            this.rbLKenwood.UseVisualStyleBackColor = true;
            // 
            // rbLICOM
            // 
            this.rbLICOM.AutoSize = true;
            this.rbLICOM.Checked = true;
            this.rbLICOM.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLICOM.Location = new System.Drawing.Point(3, 30);
            this.rbLICOM.Name = "rbLICOM";
            this.rbLICOM.Size = new System.Drawing.Size(63, 21);
            this.rbLICOM.TabIndex = 1;
            this.rbLICOM.TabStop = true;
            this.rbLICOM.Text = "ICOM";
            this.rbLICOM.UseVisualStyleBackColor = true;
            this.rbLICOM.CheckedChanged += new System.EventHandler(this.rbLICOM_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel2.Controls.Add(this.cbRAmpSpeed, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbLAmpSpeed, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbRAmpHex, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbLAmpHex, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(23, 215);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(310, 102);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // cbRAmpSpeed
            // 
            this.cbRAmpSpeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbRAmpSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRAmpSpeed.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRAmpSpeed.FormattingEnabled = true;
            this.cbRAmpSpeed.Items.AddRange(new object[] {
            "300",
            "1200",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cbRAmpSpeed.Location = new System.Drawing.Point(217, 71);
            this.cbRAmpSpeed.Name = "cbRAmpSpeed";
            this.cbRAmpSpeed.Size = new System.Drawing.Size(80, 25);
            this.cbRAmpSpeed.TabIndex = 22;
            // 
            // cbLAmpSpeed
            // 
            this.cbLAmpSpeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbLAmpSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLAmpSpeed.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLAmpSpeed.FormattingEnabled = true;
            this.cbLAmpSpeed.Items.AddRange(new object[] {
            "300",
            "1200",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cbLAmpSpeed.Location = new System.Drawing.Point(114, 71);
            this.cbLAmpSpeed.Name = "cbLAmpSpeed";
            this.cbLAmpSpeed.Size = new System.Drawing.Size(80, 25);
            this.cbLAmpSpeed.TabIndex = 21;
            // 
            // cbRAmpHex
            // 
            this.cbRAmpHex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbRAmpHex.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRAmpHex.FormattingEnabled = true;
            this.cbRAmpHex.Items.AddRange(new object[] {
            "54"});
            this.cbRAmpHex.Location = new System.Drawing.Point(233, 37);
            this.cbRAmpHex.Name = "cbRAmpHex";
            this.cbRAmpHex.Size = new System.Drawing.Size(47, 25);
            this.cbRAmpHex.TabIndex = 17;
            // 
            // cbLAmpHex
            // 
            this.cbLAmpHex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbLAmpHex.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLAmpHex.FormattingEnabled = true;
            this.cbLAmpHex.Items.AddRange(new object[] {
            "54"});
            this.cbLAmpHex.Location = new System.Drawing.Point(130, 37);
            this.cbLAmpHex.Name = "cbLAmpHex";
            this.cbLAmpHex.Size = new System.Drawing.Size(47, 25);
            this.cbLAmpHex.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "COM Speed";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(132, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "LEFT\r\n";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(231, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "RIGHT\r\n";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "CI-V Hex";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 18);
            this.label10.TabIndex = 6;
            this.label10.Text = "IC-PW1";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(361, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 17);
            this.label12.TabIndex = 7;
            this.label12.Text = "ZUYmaster";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(361, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 17);
            this.label13.TabIndex = 8;
            this.label13.Text = "CI-V Hex";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMsgs
            // 
            this.txtMsgs.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsgs.Location = new System.Drawing.Point(23, 344);
            this.txtMsgs.Multiline = true;
            this.txtMsgs.Name = "txtMsgs";
            this.txtMsgs.Size = new System.Drawing.Size(309, 102);
            this.txtMsgs.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(428, 361);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(428, 412);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 28);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbCOMPort
            // 
            this.cbCOMPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCOMPort.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCOMPort.FormattingEnabled = true;
            this.cbCOMPort.Location = new System.Drawing.Point(356, 240);
            this.cbCOMPort.Name = "cbCOMPort";
            this.cbCOMPort.Size = new System.Drawing.Size(80, 25);
            this.cbCOMPort.TabIndex = 12;
            this.cbCOMPort.SelectedIndexChanged += new System.EventHandler(this.cbCOMPort_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(353, 218);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(147, 17);
            this.label14.TabIndex = 13;
            this.label14.Text = "Port for Arduino Mega\r\n";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 1200;
            // 
            // cbZUYHex
            // 
            this.cbZUYHex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbZUYHex.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbZUYHex.FormattingEnabled = true;
            this.cbZUYHex.Items.AddRange(new object[] {
            "7A"});
            this.cbZUYHex.Location = new System.Drawing.Point(445, 157);
            this.cbZUYHex.Name = "cbZUYHex";
            this.cbZUYHex.Size = new System.Drawing.Size(47, 25);
            this.cbZUYHex.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Meiryo", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label15.Location = new System.Drawing.Point(350, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(155, 36);
            this.label15.TabIndex = 19;
            this.label15.Text = "ZUYmaster\r";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Meiryo", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label16.Location = new System.Drawing.Point(391, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 36);
            this.label16.TabIndex = 20;
            this.label16.Text = "Setup";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblConStatus
            // 
            this.lblConStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConStatus.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConStatus.ForeColor = System.Drawing.Color.LightGray;
            this.lblConStatus.Location = new System.Drawing.Point(360, 281);
            this.lblConStatus.Name = "lblConStatus";
            this.lblConStatus.Size = new System.Drawing.Size(164, 22);
            this.lblConStatus.TabIndex = 21;
            this.lblConStatus.Text = "DISCONNECTED";
            this.lblConStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConnect
            // 
            this.btnConnect.AutoSize = true;
            this.btnConnect.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(445, 238);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(78, 28);
            this.btnConnect.TabIndex = 22;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(465, 102);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 17);
            this.label17.TabIndex = 23;
            this.label17.Text = "ver. 0.1";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSaveStatus
            // 
            this.lblSaveStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSaveStatus.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveStatus.ForeColor = System.Drawing.Color.Red;
            this.lblSaveStatus.Location = new System.Drawing.Point(360, 313);
            this.lblSaveStatus.Name = "lblSaveStatus";
            this.lblSaveStatus.Size = new System.Drawing.Size(164, 22);
            this.lblSaveStatus.TabIndex = 24;
            this.lblSaveStatus.Text = "SAVED";
            this.lblSaveStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSaveStatus.Visible = false;
            // 
            // frmSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 471);
            this.Controls.Add(this.lblSaveStatus);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblConStatus);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbZUYHex);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbCOMPort);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMsgs);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSetup";
            this.Text = "ZUYmaster Setup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSetup_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton rbLKenwood;
        private System.Windows.Forms.RadioButton rbLICOM;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton rbRKenwood;
        private System.Windows.Forms.RadioButton rbRICOM;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMsgs;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbCOMPort;
        private System.Windows.Forms.Label label14;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox cbRExcSpeed;
        private System.Windows.Forms.ComboBox cbLExcSpeed;
        private System.Windows.Forms.ComboBox cbRExcHex;
        private System.Windows.Forms.ComboBox cbLExcHex;
        private System.Windows.Forms.ComboBox cbRAmpSpeed;
        private System.Windows.Forms.ComboBox cbLAmpSpeed;
        private System.Windows.Forms.ComboBox cbRAmpHex;
        private System.Windows.Forms.ComboBox cbLAmpHex;
        private System.Windows.Forms.ComboBox cbZUYHex;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblConStatus;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblSaveStatus;
    }
}

