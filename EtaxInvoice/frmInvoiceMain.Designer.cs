namespace EtaxInvoice
{
    partial class frmInvoiceMain
    {
        public int CustomerDetailSelectedIndex { get; set; }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoiceMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabInvoice = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tablebottom_1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_InvoiceSearch = new System.Windows.Forms.Button();
            this.label45 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox42 = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.panel_bottom_3 = new System.Windows.Forms.Panel();
            this.table_bottom_3_1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_bottom_3_2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabCustomerDetail = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_customerfax = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_customertel = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_customeremail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_customerTaxId = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_customerName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_userid = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabInvoice.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tablebottom_1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_bottom_3.SuspendLayout();
            this.table_bottom_3_1.SuspendLayout();
            this.panel_bottom_3_2.SuspendLayout();
            this.tabCustomerDetail.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tabCustomerDetail, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(938, 710);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabInvoice);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 287);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(932, 420);
            this.panel2.TabIndex = 1;
            // 
            // tabInvoice
            // 
            this.tabInvoice.Controls.Add(this.tabPage4);
            this.tabInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabInvoice.Location = new System.Drawing.Point(0, 0);
            this.tabInvoice.Name = "tabInvoice";
            this.tabInvoice.SelectedIndex = 0;
            this.tabInvoice.Size = new System.Drawing.Size(932, 420);
            this.tabInvoice.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tablebottom_1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(924, 394);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "ใบกำกับภาษีอย่างย่อ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tablebottom_1
            // 
            this.tablebottom_1.ColumnCount = 1;
            this.tablebottom_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablebottom_1.Controls.Add(this.panel1, 0, 0);
            this.tablebottom_1.Controls.Add(this.dataGridView1, 0, 1);
            this.tablebottom_1.Controls.Add(this.panel_bottom_3, 0, 2);
            this.tablebottom_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablebottom_1.Location = new System.Drawing.Point(3, 3);
            this.tablebottom_1.Margin = new System.Windows.Forms.Padding(0);
            this.tablebottom_1.Name = "tablebottom_1";
            this.tablebottom_1.RowCount = 3;
            this.tablebottom_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablebottom_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tablebottom_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablebottom_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablebottom_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablebottom_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablebottom_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablebottom_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablebottom_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablebottom_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablebottom_1.Size = new System.Drawing.Size(918, 388);
            this.tablebottom_1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_InvoiceSearch);
            this.panel1.Controls.Add(this.label45);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox42);
            this.panel1.Controls.Add(this.label43);
            this.panel1.Controls.Add(this.label44);
            this.panel1.Controls.Add(this.textBox41);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 71);
            this.panel1.TabIndex = 0;
            // 
            // button_InvoiceSearch
            // 
            this.button_InvoiceSearch.Location = new System.Drawing.Point(364, 9);
            this.button_InvoiceSearch.Name = "button_InvoiceSearch";
            this.button_InvoiceSearch.Size = new System.Drawing.Size(26, 21);
            this.button_InvoiceSearch.TabIndex = 113;
            this.button_InvoiceSearch.UseVisualStyleBackColor = true;
            this.button_InvoiceSearch.Click += new System.EventHandler(this.button_InvoiceSearch_Click);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(474, 40);
            this.label45.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(82, 13);
            this.label45.TabIndex = 112;
            this.label45.Text = "วันที่ออกเอกสาร";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(158, 9);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.MaxLength = 13;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(199, 20);
            this.textBox4.TabIndex = 107;
            // 
            // textBox42
            // 
            this.textBox42.Location = new System.Drawing.Point(564, 37);
            this.textBox42.Margin = new System.Windows.Forms.Padding(4);
            this.textBox42.MaxLength = 13;
            this.textBox42.Name = "textBox42";
            this.textBox42.Size = new System.Drawing.Size(232, 20);
            this.textBox42.TabIndex = 111;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(66, 12);
            this.label43.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(69, 13);
            this.label43.TabIndex = 108;
            this.label43.Text = "ค้นหาเอกสาร";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(45, 40);
            this.label44.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(90, 13);
            this.label44.TabIndex = 110;
            this.label44.Text = "สาขาที่ออกเอกสาร";
            // 
            // textBox41
            // 
            this.textBox41.Location = new System.Drawing.Point(158, 37);
            this.textBox41.Margin = new System.Windows.Forms.Padding(4);
            this.textBox41.MaxLength = 13;
            this.textBox41.Name = "textBox41";
            this.textBox41.Size = new System.Drawing.Size(232, 20);
            this.textBox41.TabIndex = 109;
            // 
            // panel_bottom_3
            // 
            this.panel_bottom_3.Controls.Add(this.table_bottom_3_1);
            this.panel_bottom_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_bottom_3.Location = new System.Drawing.Point(0, 290);
            this.panel_bottom_3.Margin = new System.Windows.Forms.Padding(0);
            this.panel_bottom_3.Name = "panel_bottom_3";
            this.panel_bottom_3.Size = new System.Drawing.Size(918, 98);
            this.panel_bottom_3.TabIndex = 2;
            // 
            // table_bottom_3_1
            // 
            this.table_bottom_3_1.ColumnCount = 2;
            this.table_bottom_3_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_bottom_3_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_bottom_3_1.Controls.Add(this.panel_bottom_3_2, 1, 0);
            this.table_bottom_3_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_bottom_3_1.Location = new System.Drawing.Point(0, 0);
            this.table_bottom_3_1.Margin = new System.Windows.Forms.Padding(0);
            this.table_bottom_3_1.Name = "table_bottom_3_1";
            this.table_bottom_3_1.RowCount = 1;
            this.table_bottom_3_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_bottom_3_1.Size = new System.Drawing.Size(918, 98);
            this.table_bottom_3_1.TabIndex = 0;
            // 
            // panel_bottom_3_2
            // 
            this.panel_bottom_3_2.Controls.Add(this.label3);
            this.panel_bottom_3_2.Controls.Add(this.textBox7);
            this.panel_bottom_3_2.Controls.Add(this.label7);
            this.panel_bottom_3_2.Controls.Add(this.textBox2);
            this.panel_bottom_3_2.Controls.Add(this.textBox8);
            this.panel_bottom_3_2.Controls.Add(this.textBox3);
            this.panel_bottom_3_2.Controls.Add(this.label1);
            this.panel_bottom_3_2.Controls.Add(this.label2);
            this.panel_bottom_3_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_bottom_3_2.Location = new System.Drawing.Point(459, 0);
            this.panel_bottom_3_2.Margin = new System.Windows.Forms.Padding(0);
            this.panel_bottom_3_2.Name = "panel_bottom_3_2";
            this.panel_bottom_3_2.Size = new System.Drawing.Size(459, 98);
            this.panel_bottom_3_2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 95;
            this.label3.Text = "ภาษีมูลค่าเพิม";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(271, 70);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.MaxLength = 13;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(174, 20);
            this.textBox7.TabIndex = 96;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 53);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 93;
            this.label7.Text = "จำนวนเงินหลัง ลด/มัดจำ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(271, 29);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.MaxLength = 13;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 20);
            this.textBox2.TabIndex = 92;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(271, 50);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4);
            this.textBox8.MaxLength = 13;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(174, 20);
            this.textBox8.TabIndex = 94;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(271, 9);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.MaxLength = 13;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(174, 20);
            this.textBox3.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 91;
            this.label1.Text = "ส่วนลด";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 89;
            this.label2.Text = "รวมจำนวนเงิน";
            // 
            // tabCustomerDetail
            // 
            this.tabCustomerDetail.Controls.Add(this.tabPage5);
            this.tabCustomerDetail.Controls.Add(this.tabPage6);
            this.tabCustomerDetail.Controls.Add(this.tabPage7);
            this.tabCustomerDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCustomerDetail.Location = new System.Drawing.Point(3, 3);
            this.tabCustomerDetail.Name = "tabCustomerDetail";
            this.tabCustomerDetail.SelectedIndex = 0;
            this.tabCustomerDetail.Size = new System.Drawing.Size(932, 278);
            this.tabCustomerDetail.TabIndex = 2;
            this.tabCustomerDetail.SelectedIndexChanged += new System.EventHandler(this.tabCustomerDetail_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.textBox15);
            this.tabPage5.Controls.Add(this.textBox40);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.textBox1);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.textBox_customerfax);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.textBox_customertel);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.textBox_customeremail);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.textBox_customerTaxId);
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.textBox_customerName);
            this.tabPage5.Controls.Add(this.label15);
            this.tabPage5.Controls.Add(this.textBox_userid);
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.Controls.Add(this.label24);
            this.tabPage5.Controls.Add(this.textBox16);
            this.tabPage5.Controls.Add(this.label25);
            this.tabPage5.Controls.Add(this.textBox23);
            this.tabPage5.Controls.Add(this.label26);
            this.tabPage5.Controls.Add(this.textBox24);
            this.tabPage5.Controls.Add(this.label27);
            this.tabPage5.Controls.Add(this.textBox25);
            this.tabPage5.Controls.Add(this.label28);
            this.tabPage5.Controls.Add(this.textBox26);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(924, 252);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "บุคคลธรรมดา";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(666, 193);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 100;
            this.label5.Text = "ประเทศ";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(711, 189);
            this.textBox15.Margin = new System.Windows.Forms.Padding(4);
            this.textBox15.MaxLength = 13;
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(91, 20);
            this.textBox15.TabIndex = 101;
            // 
            // textBox40
            // 
            this.textBox40.Location = new System.Drawing.Point(570, 189);
            this.textBox40.Margin = new System.Windows.Forms.Padding(4);
            this.textBox40.MaxLength = 13;
            this.textBox40.Name = "textBox40";
            this.textBox40.Size = new System.Drawing.Size(88, 20);
            this.textBox40.TabIndex = 99;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 97;
            this.label4.Text = "เลขประจำตัวผู้เสียภาษี";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 117);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.MaxLength = 13;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 20);
            this.textBox1.TabIndex = 98;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 189);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 95;
            this.label6.Text = "โทรสาร";
            // 
            // textBox_customerfax
            // 
            this.textBox_customerfax.Location = new System.Drawing.Point(305, 185);
            this.textBox_customerfax.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customerfax.MaxLength = 13;
            this.textBox_customerfax.Name = "textBox_customerfax";
            this.textBox_customerfax.Size = new System.Drawing.Size(91, 20);
            this.textBox_customerfax.TabIndex = 96;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(105, 189);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 87;
            this.label11.Text = "โทรศัพท์";
            // 
            // textBox_customertel
            // 
            this.textBox_customertel.Location = new System.Drawing.Point(164, 185);
            this.textBox_customertel.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customertel.MaxLength = 13;
            this.textBox_customertel.Name = "textBox_customertel";
            this.textBox_customertel.Size = new System.Drawing.Size(88, 20);
            this.textBox_customertel.TabIndex = 88;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(105, 153);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 85;
            this.label12.Text = "E-Mail";
            // 
            // textBox_customeremail
            // 
            this.textBox_customeremail.Location = new System.Drawing.Point(164, 149);
            this.textBox_customeremail.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customeremail.MaxLength = 13;
            this.textBox_customeremail.Name = "textBox_customeremail";
            this.textBox_customeremail.Size = new System.Drawing.Size(232, 20);
            this.textBox_customeremail.TabIndex = 86;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 87);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 13);
            this.label13.TabIndex = 83;
            this.label13.Text = "เลขประจำตัวผู้เสียภาษี";
            // 
            // textBox_customerTaxId
            // 
            this.textBox_customerTaxId.Location = new System.Drawing.Point(164, 84);
            this.textBox_customerTaxId.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customerTaxId.MaxLength = 13;
            this.textBox_customerTaxId.Name = "textBox_customerTaxId";
            this.textBox_customerTaxId.Size = new System.Drawing.Size(232, 20);
            this.textBox_customerTaxId.TabIndex = 84;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(111, 55);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 13);
            this.label14.TabIndex = 81;
            this.label14.Text = "ชื่อ";
            // 
            // textBox_customerName
            // 
            this.textBox_customerName.Location = new System.Drawing.Point(164, 52);
            this.textBox_customerName.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customerName.MaxLength = 13;
            this.textBox_customerName.Name = "textBox_customerName";
            this.textBox_customerName.Size = new System.Drawing.Size(232, 20);
            this.textBox_customerName.TabIndex = 82;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(111, 26);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 13);
            this.label15.TabIndex = 79;
            this.label15.Text = "รหัส";
            // 
            // textBox_userid
            // 
            this.textBox_userid.Location = new System.Drawing.Point(164, 23);
            this.textBox_userid.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_userid.MaxLength = 13;
            this.textBox_userid.Name = "textBox_userid";
            this.textBox_userid.Size = new System.Drawing.Size(232, 20);
            this.textBox_userid.TabIndex = 80;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(488, 192);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 77;
            this.label16.Text = "รหัสไปรษณีย์";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(488, 157);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(38, 13);
            this.label24.TabIndex = 69;
            this.label24.Text = "จังหวัด";
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(570, 154);
            this.textBox16.Margin = new System.Windows.Forms.Padding(4);
            this.textBox16.MaxLength = 13;
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(232, 20);
            this.textBox16.TabIndex = 71;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(488, 125);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(59, 13);
            this.label25.TabIndex = 75;
            this.label25.Text = "เขต/อำเภอ";
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(570, 122);
            this.textBox23.Margin = new System.Windows.Forms.Padding(4);
            this.textBox23.MaxLength = 13;
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(232, 20);
            this.textBox23.TabIndex = 76;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(488, 92);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(62, 13);
            this.label26.TabIndex = 73;
            this.label26.Text = "ตำบล/แขวง";
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(570, 89);
            this.textBox24.Margin = new System.Windows.Forms.Padding(4);
            this.textBox24.MaxLength = 13;
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(232, 20);
            this.textBox24.TabIndex = 74;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(488, 55);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(30, 13);
            this.label27.TabIndex = 70;
            this.label27.Text = "ถนน";
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(570, 52);
            this.textBox25.Margin = new System.Windows.Forms.Padding(4);
            this.textBox25.MaxLength = 13;
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(232, 20);
            this.textBox25.TabIndex = 72;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(488, 22);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(27, 13);
            this.label28.TabIndex = 67;
            this.label28.Text = "ที่อยู่";
            // 
            // textBox26
            // 
            this.textBox26.Location = new System.Drawing.Point(570, 19);
            this.textBox26.Margin = new System.Windows.Forms.Padding(4);
            this.textBox26.MaxLength = 13;
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(232, 20);
            this.textBox26.TabIndex = 68;
            // 
            // tabPage6
            // 
            this.tabPage6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage6.Controls.Add(this.label21);
            this.tabPage6.Controls.Add(this.textBox21);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(924, 252);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(108, 252);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(25, 13);
            this.label21.TabIndex = 64;
            this.label21.Text = "อายุ";
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(190, 249);
            this.textBox21.Margin = new System.Windows.Forms.Padding(4);
            this.textBox21.MaxLength = 13;
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(232, 20);
            this.textBox21.TabIndex = 65;
            // 
            // tabPage7
            // 
            this.tabPage7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage7.Controls.Add(this.label29);
            this.tabPage7.Controls.Add(this.textBox27);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(924, 252);
            this.tabPage7.TabIndex = 3;
            this.tabPage7.Text = "tabPage7";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(146, 256);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(25, 13);
            this.label29.TabIndex = 92;
            this.label29.Text = "อายุ";
            // 
            // textBox27
            // 
            this.textBox27.Location = new System.Drawing.Point(228, 253);
            this.textBox27.Margin = new System.Windows.Forms.Padding(4);
            this.textBox27.MaxLength = 13;
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(232, 20);
            this.textBox27.TabIndex = 93;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 710);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(938, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(53, 22);
            this.toolStripButton1.Text = "ค้นหา";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(912, 207);
            this.dataGridView1.TabIndex = 1;
            // 
            // frmInvoiceMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(938, 735);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmInvoiceMain";
            this.Text = "E-TAX Invoice";
            this.Load += new System.EventHandler(this.frmInvoiceMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabInvoice.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tablebottom_1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_bottom_3.ResumeLayout(false);
            this.table_bottom_3_1.ResumeLayout(false);
            this.panel_bottom_3_2.ResumeLayout(false);
            this.panel_bottom_3_2.PerformLayout();
            this.tabCustomerDetail.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabCustomerDetail;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabControl tabInvoice;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_customertel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_customeremail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_customerTaxId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_customerName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_userid;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_customerfax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox40;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TableLayoutPanel tablebottom_1;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox textBox42;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox textBox41;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_bottom_3;
        private System.Windows.Forms.TableLayoutPanel table_bottom_3_1;
        private System.Windows.Forms.Panel panel_bottom_3_2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_InvoiceSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

