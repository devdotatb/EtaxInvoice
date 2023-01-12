namespace EtaxInvoice
{
    partial class frmMain
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabInvoice = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tablebottom_1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel_bottom_3 = new System.Windows.Forms.Panel();
            this.table_bottom_3_1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_bottom_3_2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDown_sumNet = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel42 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.numericUpDown_VAT = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel41 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_sumDiscount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_sumVat = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Total = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_NetAfter = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel43 = new System.Windows.Forms.TableLayoutPanel();
            this.panel27 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel44 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel48 = new System.Windows.Forms.TableLayoutPanel();
            this.label44 = new System.Windows.Forms.Label();
            this.textBox_invoiceBranchCode = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel45 = new System.Windows.Forms.TableLayoutPanel();
            this.button_InvoiceSearch = new System.Windows.Forms.Button();
            this.label43 = new System.Windows.Forms.Label();
            this.textBox_invoiceDocNo = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel46 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_invoiceDate = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.tableLayoutPanel50 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_CNReason_Other = new System.Windows.Forms.TextBox();
            this.label_ReasonCN = new System.Windows.Forms.Label();
            this.comboBox_CNReason = new System.Windows.Forms.ComboBox();
            this.tabCustomerDetail = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel_Customer_1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_testCN = new System.Windows.Forms.Button();
            this.panel_c_1_1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_customerCode = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel_c_1_2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_customerAddress = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.panel_c_1_3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_customerName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel_c_1_4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_customerRoad = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.panel_c_1_5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_customerTaxId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel_c_1_6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_customerSubDistrict = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.panel_c_1_7 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_c_1_8 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.button_DistrictSearch = new System.Windows.Forms.Button();
            this.textBox_customerDistrictName = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox_customerDistrictCode = new System.Windows.Forms.TextBox();
            this.panel_c_1_9 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_customerEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel_c_1_10 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.button_provinceSearch = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox_customerProvinceCode = new System.Windows.Forms.TextBox();
            this.textBox_customerProvinceName = new System.Windows.Forms.TextBox();
            this.panel_c_1_11 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_customerTel = new System.Windows.Forms.TextBox();
            this.textBox_customerFax = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_c_1_12 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.button_countrySearch = new System.Windows.Forms.Button();
            this.textBox_customerPostCode = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_customerCountry = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_customerCode_1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_customerAddress_1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel18 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_customerName_1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel19 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_customerRoad_1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel20 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_customerTaxId_1 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel21 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_customerSubDistrict_1 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel22 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_customerWeb_1 = new System.Windows.Forms.TextBox();
            this.comboBox_cWeb_1 = new System.Windows.Forms.ComboBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel23 = new System.Windows.Forms.TableLayoutPanel();
            this.button_DistrictSearch_1 = new System.Windows.Forms.Button();
            this.textBox_customerDistrictName_1 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox_customerDistrictCode_1 = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel24 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_customerEmail_1 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel25 = new System.Windows.Forms.TableLayoutPanel();
            this.button_provinceSearch_1 = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.textBox_customerProvinceCode_1 = new System.Windows.Forms.TextBox();
            this.textBox_customerProvinceName_1 = new System.Windows.Forms.TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel26 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_customerTel_1 = new System.Windows.Forms.TextBox();
            this.textBox_customerFax_1 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel27 = new System.Windows.Forms.TableLayoutPanel();
            this.button_countrySearch_1 = new System.Windows.Forms.Button();
            this.textBox_customerPostCode_1 = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.textBox_customerCountry_1 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel28 = new System.Windows.Forms.TableLayoutPanel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel29 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_customerCode_2 = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel30 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_customerAddress_2 = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel31 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_customerName_2 = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel32 = new System.Windows.Forms.TableLayoutPanel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel33 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_customerTaxId_2 = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel34 = new System.Windows.Forms.TableLayoutPanel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel35 = new System.Windows.Forms.TableLayoutPanel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel36 = new System.Windows.Forms.TableLayoutPanel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel37 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_customerEmail_2 = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.panel24 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel38 = new System.Windows.Forms.TableLayoutPanel();
            this.label47 = new System.Windows.Forms.Label();
            this.textBox_customerProvinceName_2 = new System.Windows.Forms.TextBox();
            this.panel25 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel39 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_customerTel_2 = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.panel26 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel40 = new System.Windows.Forms.TableLayoutPanel();
            this.button_countrySearch_2 = new System.Windows.Forms.Button();
            this.textBox_customerPostCode_2 = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.textBox_customerCountry_2 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel47 = new System.Windows.Forms.TableLayoutPanel();
            this.button_add = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_customersearch = new System.Windows.Forms.Button();
            this.tableLayoutPanel49 = new System.Windows.Forms.TableLayoutPanel();
            this.button_print = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabInvoice.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tablebottom_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_bottom_3.SuspendLayout();
            this.table_bottom_3_1.SuspendLayout();
            this.panel_bottom_3_2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sumNet)).BeginInit();
            this.tableLayoutPanel42.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_VAT)).BeginInit();
            this.tableLayoutPanel41.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sumDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sumVat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Total)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NetAfter)).BeginInit();
            this.tableLayoutPanel43.SuspendLayout();
            this.tableLayoutPanel44.SuspendLayout();
            this.tableLayoutPanel48.SuspendLayout();
            this.tableLayoutPanel45.SuspendLayout();
            this.tableLayoutPanel46.SuspendLayout();
            this.tableLayoutPanel50.SuspendLayout();
            this.tabCustomerDetail.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tableLayoutPanel_Customer_1.SuspendLayout();
            this.panel_c_1_1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel_c_1_2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel_c_1_3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel_c_1_4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel_c_1_5.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.panel_c_1_6.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.panel_c_1_7.SuspendLayout();
            this.panel_c_1_8.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.panel_c_1_9.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.panel_c_1_10.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.panel_c_1_11.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.panel_c_1_12.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel18.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel19.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tableLayoutPanel20.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tableLayoutPanel21.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tableLayoutPanel22.SuspendLayout();
            this.panel10.SuspendLayout();
            this.tableLayoutPanel23.SuspendLayout();
            this.panel11.SuspendLayout();
            this.tableLayoutPanel24.SuspendLayout();
            this.panel12.SuspendLayout();
            this.tableLayoutPanel25.SuspendLayout();
            this.panel13.SuspendLayout();
            this.tableLayoutPanel26.SuspendLayout();
            this.panel14.SuspendLayout();
            this.tableLayoutPanel27.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tableLayoutPanel28.SuspendLayout();
            this.panel15.SuspendLayout();
            this.tableLayoutPanel29.SuspendLayout();
            this.panel16.SuspendLayout();
            this.tableLayoutPanel30.SuspendLayout();
            this.panel17.SuspendLayout();
            this.tableLayoutPanel31.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel19.SuspendLayout();
            this.tableLayoutPanel33.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel23.SuspendLayout();
            this.tableLayoutPanel37.SuspendLayout();
            this.panel24.SuspendLayout();
            this.tableLayoutPanel38.SuspendLayout();
            this.panel25.SuspendLayout();
            this.tableLayoutPanel39.SuspendLayout();
            this.panel26.SuspendLayout();
            this.tableLayoutPanel40.SuspendLayout();
            this.tableLayoutPanel47.SuspendLayout();
            this.tableLayoutPanel49.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tabCustomerDetail, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel47, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel49, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(959, 712);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabInvoice);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 287);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(953, 385);
            this.panel2.TabIndex = 1;
            // 
            // tabInvoice
            // 
            this.tabInvoice.Controls.Add(this.tabPage4);
            this.tabInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabInvoice.Location = new System.Drawing.Point(0, 0);
            this.tabInvoice.Name = "tabInvoice";
            this.tabInvoice.SelectedIndex = 0;
            this.tabInvoice.Size = new System.Drawing.Size(953, 385);
            this.tabInvoice.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage4.Controls.Add(this.tablebottom_1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(945, 359);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "page4 InitializeType error";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tablebottom_1
            // 
            this.tablebottom_1.ColumnCount = 1;
            this.tablebottom_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablebottom_1.Controls.Add(this.dataGridView1, 0, 1);
            this.tablebottom_1.Controls.Add(this.panel_bottom_3, 0, 2);
            this.tablebottom_1.Controls.Add(this.tableLayoutPanel44, 0, 0);
            this.tablebottom_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablebottom_1.Location = new System.Drawing.Point(3, 3);
            this.tablebottom_1.Margin = new System.Windows.Forms.Padding(0);
            this.tablebottom_1.Name = "tablebottom_1";
            this.tablebottom_1.RowCount = 3;
            this.tablebottom_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablebottom_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tablebottom_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tablebottom_1.Size = new System.Drawing.Size(937, 351);
            this.tablebottom_1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(931, 151);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel_bottom_3
            // 
            this.panel_bottom_3.Controls.Add(this.table_bottom_3_1);
            this.panel_bottom_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_bottom_3.Location = new System.Drawing.Point(0, 227);
            this.panel_bottom_3.Margin = new System.Windows.Forms.Padding(0);
            this.panel_bottom_3.Name = "panel_bottom_3";
            this.panel_bottom_3.Size = new System.Drawing.Size(937, 124);
            this.panel_bottom_3.TabIndex = 2;
            // 
            // table_bottom_3_1
            // 
            this.table_bottom_3_1.ColumnCount = 2;
            this.table_bottom_3_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_bottom_3_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_bottom_3_1.Controls.Add(this.panel_bottom_3_2, 1, 0);
            this.table_bottom_3_1.Controls.Add(this.tableLayoutPanel43, 0, 0);
            this.table_bottom_3_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_bottom_3_1.Location = new System.Drawing.Point(0, 0);
            this.table_bottom_3_1.Margin = new System.Windows.Forms.Padding(0);
            this.table_bottom_3_1.Name = "table_bottom_3_1";
            this.table_bottom_3_1.RowCount = 1;
            this.table_bottom_3_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_bottom_3_1.Size = new System.Drawing.Size(937, 124);
            this.table_bottom_3_1.TabIndex = 0;
            // 
            // panel_bottom_3_2
            // 
            this.panel_bottom_3_2.Controls.Add(this.tableLayoutPanel2);
            this.panel_bottom_3_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_bottom_3_2.Location = new System.Drawing.Point(468, 0);
            this.panel_bottom_3_2.Margin = new System.Windows.Forms.Padding(0);
            this.panel_bottom_3_2.Name = "panel_bottom_3_2";
            this.panel_bottom_3_2.Size = new System.Drawing.Size(469, 124);
            this.panel_bottom_3_2.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown_sumNet, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel42, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label20, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel41, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown_sumDiscount, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown_sumVat, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown_Total, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown_NetAfter, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(469, 124);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // numericUpDown_sumNet
            // 
            this.numericUpDown_sumNet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_sumNet.DecimalPlaces = 2;
            this.numericUpDown_sumNet.Enabled = false;
            this.numericUpDown_sumNet.Location = new System.Drawing.Point(237, 3);
            this.numericUpDown_sumNet.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_sumNet.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.numericUpDown_sumNet.Name = "numericUpDown_sumNet";
            this.numericUpDown_sumNet.ReadOnly = true;
            this.numericUpDown_sumNet.Size = new System.Drawing.Size(229, 20);
            this.numericUpDown_sumNet.TabIndex = 0;
            this.numericUpDown_sumNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel42
            // 
            this.tableLayoutPanel42.ColumnCount = 3;
            this.tableLayoutPanel42.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel42.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel42.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel42.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel42.Controls.Add(this.label29, 2, 0);
            this.tableLayoutPanel42.Controls.Add(this.numericUpDown_VAT, 1, 0);
            this.tableLayoutPanel42.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel42.Location = new System.Drawing.Point(0, 72);
            this.tableLayoutPanel42.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel42.Name = "tableLayoutPanel42";
            this.tableLayoutPanel42.RowCount = 1;
            this.tableLayoutPanel42.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel42.Size = new System.Drawing.Size(234, 24);
            this.tableLayoutPanel42.TabIndex = 108;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 103;
            this.label3.Text = "ภาษีมูลค่าเพิม";
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(179, 5);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(51, 13);
            this.label29.TabIndex = 104;
            this.label29.Text = "%";
            // 
            // numericUpDown_VAT
            // 
            this.numericUpDown_VAT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_VAT.DecimalPlaces = 2;
            this.numericUpDown_VAT.Enabled = false;
            this.numericUpDown_VAT.Location = new System.Drawing.Point(120, 3);
            this.numericUpDown_VAT.Name = "numericUpDown_VAT";
            this.numericUpDown_VAT.ReadOnly = true;
            this.numericUpDown_VAT.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown_VAT.TabIndex = 105;
            this.numericUpDown_VAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(4, 103);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(226, 13);
            this.label20.TabIndex = 106;
            this.label20.Text = "จำนวนเงินรวมทั้งสิ้น";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 5);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(226, 13);
            this.label8.TabIndex = 98;
            this.label8.Text = "รวมจำนวนเงิน";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 53);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 13);
            this.label7.TabIndex = 101;
            this.label7.Text = "จำนวนเงินหลัง ลด/มัดจำ";
            // 
            // tableLayoutPanel41
            // 
            this.tableLayoutPanel41.ColumnCount = 2;
            this.tableLayoutPanel41.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel41.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel41.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel41.Controls.Add(this.numericUpDown5, 1, 0);
            this.tableLayoutPanel41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel41.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel41.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel41.Name = "tableLayoutPanel41";
            this.tableLayoutPanel41.RowCount = 1;
            this.tableLayoutPanel41.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel41.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel41.Size = new System.Drawing.Size(234, 24);
            this.tableLayoutPanel41.TabIndex = 107;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 99;
            this.label1.Text = "ส่วนลด";
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown5.Enabled = false;
            this.numericUpDown5.Location = new System.Drawing.Point(120, 3);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.ReadOnly = true;
            this.numericUpDown5.Size = new System.Drawing.Size(111, 20);
            this.numericUpDown5.TabIndex = 100;
            // 
            // numericUpDown_sumDiscount
            // 
            this.numericUpDown_sumDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_sumDiscount.DecimalPlaces = 2;
            this.numericUpDown_sumDiscount.Enabled = false;
            this.numericUpDown_sumDiscount.Location = new System.Drawing.Point(237, 27);
            this.numericUpDown_sumDiscount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_sumDiscount.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.numericUpDown_sumDiscount.Name = "numericUpDown_sumDiscount";
            this.numericUpDown_sumDiscount.ReadOnly = true;
            this.numericUpDown_sumDiscount.Size = new System.Drawing.Size(229, 20);
            this.numericUpDown_sumDiscount.TabIndex = 109;
            this.numericUpDown_sumDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDown_sumVat
            // 
            this.numericUpDown_sumVat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_sumVat.DecimalPlaces = 2;
            this.numericUpDown_sumVat.Enabled = false;
            this.numericUpDown_sumVat.Location = new System.Drawing.Point(237, 75);
            this.numericUpDown_sumVat.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_sumVat.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.numericUpDown_sumVat.Name = "numericUpDown_sumVat";
            this.numericUpDown_sumVat.ReadOnly = true;
            this.numericUpDown_sumVat.Size = new System.Drawing.Size(229, 20);
            this.numericUpDown_sumVat.TabIndex = 111;
            this.numericUpDown_sumVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDown_Total
            // 
            this.numericUpDown_Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_Total.DecimalPlaces = 2;
            this.numericUpDown_Total.Enabled = false;
            this.numericUpDown_Total.Location = new System.Drawing.Point(237, 100);
            this.numericUpDown_Total.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_Total.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.numericUpDown_Total.Name = "numericUpDown_Total";
            this.numericUpDown_Total.ReadOnly = true;
            this.numericUpDown_Total.Size = new System.Drawing.Size(229, 20);
            this.numericUpDown_Total.TabIndex = 112;
            this.numericUpDown_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDown_NetAfter
            // 
            this.numericUpDown_NetAfter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_NetAfter.DecimalPlaces = 2;
            this.numericUpDown_NetAfter.Enabled = false;
            this.numericUpDown_NetAfter.Location = new System.Drawing.Point(237, 51);
            this.numericUpDown_NetAfter.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_NetAfter.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.numericUpDown_NetAfter.Name = "numericUpDown_NetAfter";
            this.numericUpDown_NetAfter.ReadOnly = true;
            this.numericUpDown_NetAfter.Size = new System.Drawing.Size(229, 20);
            this.numericUpDown_NetAfter.TabIndex = 110;
            this.numericUpDown_NetAfter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel43
            // 
            this.tableLayoutPanel43.ColumnCount = 1;
            this.tableLayoutPanel43.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel43.Controls.Add(this.panel27, 0, 0);
            this.tableLayoutPanel43.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel43.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel43.Name = "tableLayoutPanel43";
            this.tableLayoutPanel43.RowCount = 1;
            this.tableLayoutPanel43.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel43.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanel43.Size = new System.Drawing.Size(462, 118);
            this.tableLayoutPanel43.TabIndex = 1;
            // 
            // panel27
            // 
            this.panel27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel27.Location = new System.Drawing.Point(3, 3);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(456, 112);
            this.panel27.TabIndex = 1;
            // 
            // tableLayoutPanel44
            // 
            this.tableLayoutPanel44.ColumnCount = 3;
            this.tableLayoutPanel44.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel44.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel44.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel44.Controls.Add(this.tableLayoutPanel48, 0, 1);
            this.tableLayoutPanel44.Controls.Add(this.tableLayoutPanel45, 0, 0);
            this.tableLayoutPanel44.Controls.Add(this.tableLayoutPanel46, 1, 1);
            this.tableLayoutPanel44.Controls.Add(this.tableLayoutPanel50, 1, 0);
            this.tableLayoutPanel44.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel44.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel44.Name = "tableLayoutPanel44";
            this.tableLayoutPanel44.RowCount = 2;
            this.tableLayoutPanel44.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel44.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel44.Size = new System.Drawing.Size(931, 64);
            this.tableLayoutPanel44.TabIndex = 3;
            // 
            // tableLayoutPanel48
            // 
            this.tableLayoutPanel48.ColumnCount = 2;
            this.tableLayoutPanel48.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel48.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel48.Controls.Add(this.label44, 0, 0);
            this.tableLayoutPanel48.Controls.Add(this.textBox_invoiceBranchCode, 1, 0);
            this.tableLayoutPanel48.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel48.Location = new System.Drawing.Point(3, 35);
            this.tableLayoutPanel48.Name = "tableLayoutPanel48";
            this.tableLayoutPanel48.RowCount = 1;
            this.tableLayoutPanel48.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel48.Size = new System.Drawing.Size(412, 26);
            this.tableLayoutPanel48.TabIndex = 3;
            // 
            // label44
            // 
            this.label44.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(29, 6);
            this.label44.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(90, 13);
            this.label44.TabIndex = 110;
            this.label44.Text = "สาขาที่ออกเอกสาร";
            // 
            // textBox_invoiceBranchCode
            // 
            this.textBox_invoiceBranchCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_invoiceBranchCode.Location = new System.Drawing.Point(127, 4);
            this.textBox_invoiceBranchCode.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_invoiceBranchCode.MaxLength = 50;
            this.textBox_invoiceBranchCode.Name = "textBox_invoiceBranchCode";
            this.textBox_invoiceBranchCode.ReadOnly = true;
            this.textBox_invoiceBranchCode.Size = new System.Drawing.Size(281, 20);
            this.textBox_invoiceBranchCode.TabIndex = 109;
            // 
            // tableLayoutPanel45
            // 
            this.tableLayoutPanel45.ColumnCount = 3;
            this.tableLayoutPanel45.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel45.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel45.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel45.Controls.Add(this.button_InvoiceSearch, 2, 0);
            this.tableLayoutPanel45.Controls.Add(this.label43, 0, 0);
            this.tableLayoutPanel45.Controls.Add(this.textBox_invoiceDocNo, 1, 0);
            this.tableLayoutPanel45.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel45.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel45.Name = "tableLayoutPanel45";
            this.tableLayoutPanel45.RowCount = 1;
            this.tableLayoutPanel45.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel45.Size = new System.Drawing.Size(412, 26);
            this.tableLayoutPanel45.TabIndex = 0;
            // 
            // button_InvoiceSearch
            // 
            this.button_InvoiceSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_InvoiceSearch.Location = new System.Drawing.Point(373, 3);
            this.button_InvoiceSearch.Name = "button_InvoiceSearch";
            this.button_InvoiceSearch.Size = new System.Drawing.Size(25, 20);
            this.button_InvoiceSearch.TabIndex = 113;
            this.button_InvoiceSearch.Text = "...";
            this.button_InvoiceSearch.UseVisualStyleBackColor = true;
            this.button_InvoiceSearch.Click += new System.EventHandler(this.button_InvoiceSearch_Click);
            // 
            // label43
            // 
            this.label43.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(50, 6);
            this.label43.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(69, 13);
            this.label43.TabIndex = 108;
            this.label43.Text = "ค้นหาเอกสาร";
            // 
            // textBox_invoiceDocNo
            // 
            this.textBox_invoiceDocNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_invoiceDocNo.Location = new System.Drawing.Point(127, 4);
            this.textBox_invoiceDocNo.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_invoiceDocNo.MaxLength = 50;
            this.textBox_invoiceDocNo.Name = "textBox_invoiceDocNo";
            this.textBox_invoiceDocNo.ReadOnly = true;
            this.textBox_invoiceDocNo.Size = new System.Drawing.Size(239, 20);
            this.textBox_invoiceDocNo.TabIndex = 107;
            // 
            // tableLayoutPanel46
            // 
            this.tableLayoutPanel46.ColumnCount = 2;
            this.tableLayoutPanel46.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel46.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel46.Controls.Add(this.textBox_invoiceDate, 1, 0);
            this.tableLayoutPanel46.Controls.Add(this.label45, 0, 0);
            this.tableLayoutPanel46.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel46.Location = new System.Drawing.Point(421, 35);
            this.tableLayoutPanel46.Name = "tableLayoutPanel46";
            this.tableLayoutPanel46.RowCount = 1;
            this.tableLayoutPanel46.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel46.Size = new System.Drawing.Size(412, 26);
            this.tableLayoutPanel46.TabIndex = 4;
            // 
            // textBox_invoiceDate
            // 
            this.textBox_invoiceDate.Location = new System.Drawing.Point(127, 4);
            this.textBox_invoiceDate.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_invoiceDate.MaxLength = 50;
            this.textBox_invoiceDate.Name = "textBox_invoiceDate";
            this.textBox_invoiceDate.ReadOnly = true;
            this.textBox_invoiceDate.Size = new System.Drawing.Size(281, 20);
            this.textBox_invoiceDate.TabIndex = 111;
            // 
            // label45
            // 
            this.label45.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(37, 6);
            this.label45.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(82, 13);
            this.label45.TabIndex = 112;
            this.label45.Text = "วันที่ออกเอกสาร";
            // 
            // tableLayoutPanel50
            // 
            this.tableLayoutPanel50.ColumnCount = 3;
            this.tableLayoutPanel50.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel50.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel50.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel50.Controls.Add(this.textBox_CNReason_Other, 2, 0);
            this.tableLayoutPanel50.Controls.Add(this.label_ReasonCN, 0, 0);
            this.tableLayoutPanel50.Controls.Add(this.comboBox_CNReason, 1, 0);
            this.tableLayoutPanel50.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel50.Location = new System.Drawing.Point(421, 3);
            this.tableLayoutPanel50.Name = "tableLayoutPanel50";
            this.tableLayoutPanel50.RowCount = 1;
            this.tableLayoutPanel50.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel50.Size = new System.Drawing.Size(412, 26);
            this.tableLayoutPanel50.TabIndex = 5;
            // 
            // textBox_CNReason_Other
            // 
            this.textBox_CNReason_Other.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_CNReason_Other.Location = new System.Drawing.Point(312, 4);
            this.textBox_CNReason_Other.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_CNReason_Other.MaxLength = 50;
            this.textBox_CNReason_Other.Name = "textBox_CNReason_Other";
            this.textBox_CNReason_Other.ReadOnly = true;
            this.textBox_CNReason_Other.Size = new System.Drawing.Size(96, 20);
            this.textBox_CNReason_Other.TabIndex = 115;
            // 
            // label_ReasonCN
            // 
            this.label_ReasonCN.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_ReasonCN.AutoSize = true;
            this.label_ReasonCN.Location = new System.Drawing.Point(9, 6);
            this.label_ReasonCN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ReasonCN.Name = "label_ReasonCN";
            this.label_ReasonCN.Size = new System.Drawing.Size(131, 13);
            this.label_ReasonCN.TabIndex = 113;
            this.label_ReasonCN.Text = "เหตุผลในการออกใบลดหนี้";
            // 
            // comboBox_CNReason
            // 
            this.comboBox_CNReason.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_CNReason.DisplayMember = "FTRsnCNDescTh";
            this.comboBox_CNReason.FormattingEnabled = true;
            this.comboBox_CNReason.Location = new System.Drawing.Point(147, 3);
            this.comboBox_CNReason.Name = "comboBox_CNReason";
            this.comboBox_CNReason.Size = new System.Drawing.Size(158, 21);
            this.comboBox_CNReason.TabIndex = 114;
            this.comboBox_CNReason.SelectedValueChanged += new System.EventHandler(this.comboBox_CNReason_SelectedValueChanged);
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
            this.tabCustomerDetail.Size = new System.Drawing.Size(953, 243);
            this.tabCustomerDetail.TabIndex = 2;
            // 
            // tabPage5
            // 
            this.tabPage5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage5.Controls.Add(this.tableLayoutPanel_Customer_1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(945, 217);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "บุคคลธรรมดา";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_Customer_1
            // 
            this.tableLayoutPanel_Customer_1.ColumnCount = 3;
            this.tableLayoutPanel_Customer_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel_Customer_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel_Customer_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_Customer_1.Controls.Add(this.button_testCN, 2, 0);
            this.tableLayoutPanel_Customer_1.Controls.Add(this.panel_c_1_1, 0, 0);
            this.tableLayoutPanel_Customer_1.Controls.Add(this.panel_c_1_2, 1, 0);
            this.tableLayoutPanel_Customer_1.Controls.Add(this.panel_c_1_3, 0, 1);
            this.tableLayoutPanel_Customer_1.Controls.Add(this.panel_c_1_4, 1, 1);
            this.tableLayoutPanel_Customer_1.Controls.Add(this.panel_c_1_5, 0, 2);
            this.tableLayoutPanel_Customer_1.Controls.Add(this.panel_c_1_6, 1, 2);
            this.tableLayoutPanel_Customer_1.Controls.Add(this.panel_c_1_7, 0, 3);
            this.tableLayoutPanel_Customer_1.Controls.Add(this.panel_c_1_8, 1, 3);
            this.tableLayoutPanel_Customer_1.Controls.Add(this.panel_c_1_9, 0, 4);
            this.tableLayoutPanel_Customer_1.Controls.Add(this.panel_c_1_10, 1, 4);
            this.tableLayoutPanel_Customer_1.Controls.Add(this.panel_c_1_11, 0, 5);
            this.tableLayoutPanel_Customer_1.Controls.Add(this.panel_c_1_12, 1, 5);
            this.tableLayoutPanel_Customer_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Customer_1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_Customer_1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel_Customer_1.Name = "tableLayoutPanel_Customer_1";
            this.tableLayoutPanel_Customer_1.RowCount = 6;
            this.tableLayoutPanel_Customer_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_Customer_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_Customer_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_Customer_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_Customer_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_Customer_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_Customer_1.Size = new System.Drawing.Size(937, 209);
            this.tableLayoutPanel_Customer_1.TabIndex = 0;
            // 
            // button_testCN
            // 
            this.button_testCN.Location = new System.Drawing.Point(845, 3);
            this.button_testCN.Name = "button_testCN";
            this.button_testCN.Size = new System.Drawing.Size(75, 23);
            this.button_testCN.TabIndex = 12;
            this.button_testCN.Text = "Inv/CN";
            this.button_testCN.UseVisualStyleBackColor = true;
            this.button_testCN.Visible = false;
            this.button_testCN.Click += new System.EventHandler(this.button_testCN_Click);
            // 
            // panel_c_1_1
            // 
            this.panel_c_1_1.Controls.Add(this.tableLayoutPanel3);
            this.panel_c_1_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_c_1_1.Location = new System.Drawing.Point(3, 3);
            this.panel_c_1_1.Name = "panel_c_1_1";
            this.panel_c_1_1.Size = new System.Drawing.Size(415, 28);
            this.panel_c_1_1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.Controls.Add(this.textBox_customerCode, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label15, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(415, 28);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // textBox_customerCode
            // 
            this.textBox_customerCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerCode.Location = new System.Drawing.Point(128, 4);
            this.textBox_customerCode.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customerCode.MaxLength = 50;
            this.textBox_customerCode.Name = "textBox_customerCode";
            this.textBox_customerCode.ReadOnly = true;
            this.textBox_customerCode.Size = new System.Drawing.Size(283, 20);
            this.textBox_customerCode.TabIndex = 130;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(94, 7);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 13);
            this.label15.TabIndex = 129;
            this.label15.Text = "รหัส";
            // 
            // panel_c_1_2
            // 
            this.panel_c_1_2.Controls.Add(this.tableLayoutPanel4);
            this.panel_c_1_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_c_1_2.Location = new System.Drawing.Point(424, 3);
            this.panel_c_1_2.Name = "panel_c_1_2";
            this.panel_c_1_2.Size = new System.Drawing.Size(415, 28);
            this.panel_c_1_2.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.Controls.Add(this.textBox_customerAddress, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label28, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(415, 28);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // textBox_customerAddress
            // 
            this.textBox_customerAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerAddress.Location = new System.Drawing.Point(128, 4);
            this.textBox_customerAddress.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customerAddress.MaxLength = 50;
            this.textBox_customerAddress.Name = "textBox_customerAddress";
            this.textBox_customerAddress.ReadOnly = true;
            this.textBox_customerAddress.Size = new System.Drawing.Size(283, 20);
            this.textBox_customerAddress.TabIndex = 120;
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(93, 7);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(27, 13);
            this.label28.TabIndex = 119;
            this.label28.Text = "ที่อยู่";
            // 
            // panel_c_1_3
            // 
            this.panel_c_1_3.Controls.Add(this.tableLayoutPanel5);
            this.panel_c_1_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_c_1_3.Location = new System.Drawing.Point(3, 37);
            this.panel_c_1_3.Name = "panel_c_1_3";
            this.panel_c_1_3.Size = new System.Drawing.Size(415, 28);
            this.panel_c_1_3.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel5.Controls.Add(this.textBox_customerName, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(415, 28);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // textBox_customerName
            // 
            this.textBox_customerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerName.Location = new System.Drawing.Point(128, 4);
            this.textBox_customerName.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customerName.MaxLength = 50;
            this.textBox_customerName.Name = "textBox_customerName";
            this.textBox_customerName.ReadOnly = true;
            this.textBox_customerName.Size = new System.Drawing.Size(283, 20);
            this.textBox_customerName.TabIndex = 132;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(100, 7);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 13);
            this.label14.TabIndex = 131;
            this.label14.Text = "ชื่อ";
            // 
            // panel_c_1_4
            // 
            this.panel_c_1_4.Controls.Add(this.tableLayoutPanel6);
            this.panel_c_1_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_c_1_4.Location = new System.Drawing.Point(424, 37);
            this.panel_c_1_4.Name = "panel_c_1_4";
            this.panel_c_1_4.Size = new System.Drawing.Size(415, 28);
            this.panel_c_1_4.TabIndex = 3;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel6.Controls.Add(this.textBox_customerRoad, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label27, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(415, 28);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // textBox_customerRoad
            // 
            this.textBox_customerRoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerRoad.Location = new System.Drawing.Point(128, 4);
            this.textBox_customerRoad.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customerRoad.MaxLength = 50;
            this.textBox_customerRoad.Name = "textBox_customerRoad";
            this.textBox_customerRoad.ReadOnly = true;
            this.textBox_customerRoad.Size = new System.Drawing.Size(283, 20);
            this.textBox_customerRoad.TabIndex = 123;
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(90, 7);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(30, 13);
            this.label27.TabIndex = 122;
            this.label27.Text = "ถนน";
            // 
            // panel_c_1_5
            // 
            this.panel_c_1_5.Controls.Add(this.tableLayoutPanel7);
            this.panel_c_1_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_c_1_5.Location = new System.Drawing.Point(3, 71);
            this.panel_c_1_5.Name = "panel_c_1_5";
            this.panel_c_1_5.Size = new System.Drawing.Size(415, 28);
            this.panel_c_1_5.TabIndex = 4;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel7.Controls.Add(this.textBox_customerTaxId, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(415, 28);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // textBox_customerTaxId
            // 
            this.textBox_customerTaxId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerTaxId.Location = new System.Drawing.Point(128, 4);
            this.textBox_customerTaxId.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customerTaxId.MaxLength = 13;
            this.textBox_customerTaxId.Name = "textBox_customerTaxId";
            this.textBox_customerTaxId.ReadOnly = true;
            this.textBox_customerTaxId.Size = new System.Drawing.Size(283, 20);
            this.textBox_customerTaxId.TabIndex = 134;
            this.textBox_customerTaxId.ContextMenuStripChanged += new System.EventHandler(this.textBox_customerTaxId_ContextMenuStripChanged);
            this.textBox_customerTaxId.TextChanged += new System.EventHandler(this.textBox_customerTaxId_TextChanged);
            this.textBox_customerTaxId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_customerTaxId_KeyDown);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 7);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 13);
            this.label13.TabIndex = 133;
            this.label13.Text = "เลขประจำตัวผู้เสียภาษี";
            // 
            // panel_c_1_6
            // 
            this.panel_c_1_6.Controls.Add(this.tableLayoutPanel8);
            this.panel_c_1_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_c_1_6.Location = new System.Drawing.Point(424, 71);
            this.panel_c_1_6.Name = "panel_c_1_6";
            this.panel_c_1_6.Size = new System.Drawing.Size(415, 28);
            this.panel_c_1_6.TabIndex = 5;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel8.Controls.Add(this.textBox_customerSubDistrict, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.label26, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(415, 28);
            this.tableLayoutPanel8.TabIndex = 1;
            // 
            // textBox_customerSubDistrict
            // 
            this.textBox_customerSubDistrict.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerSubDistrict.Location = new System.Drawing.Point(128, 4);
            this.textBox_customerSubDistrict.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customerSubDistrict.MaxLength = 50;
            this.textBox_customerSubDistrict.Name = "textBox_customerSubDistrict";
            this.textBox_customerSubDistrict.ReadOnly = true;
            this.textBox_customerSubDistrict.Size = new System.Drawing.Size(283, 20);
            this.textBox_customerSubDistrict.TabIndex = 125;
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(58, 7);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(62, 13);
            this.label26.TabIndex = 124;
            this.label26.Text = "ตำบล/แขวง";
            // 
            // panel_c_1_7
            // 
            this.panel_c_1_7.Controls.Add(this.tableLayoutPanel9);
            this.panel_c_1_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_c_1_7.Location = new System.Drawing.Point(3, 105);
            this.panel_c_1_7.Name = "panel_c_1_7";
            this.panel_c_1_7.Size = new System.Drawing.Size(415, 28);
            this.panel_c_1_7.TabIndex = 6;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(415, 28);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // panel_c_1_8
            // 
            this.panel_c_1_8.Controls.Add(this.tableLayoutPanel13);
            this.panel_c_1_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_c_1_8.Location = new System.Drawing.Point(424, 105);
            this.panel_c_1_8.Name = "panel_c_1_8";
            this.panel_c_1_8.Size = new System.Drawing.Size(415, 28);
            this.panel_c_1_8.TabIndex = 7;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 4;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0044F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.33342F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33062F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33155F));
            this.tableLayoutPanel13.Controls.Add(this.button_DistrictSearch, 2, 0);
            this.tableLayoutPanel13.Controls.Add(this.textBox_customerDistrictName, 3, 0);
            this.tableLayoutPanel13.Controls.Add(this.label25, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.textBox_customerDistrictCode, 1, 0);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 1;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(415, 28);
            this.tableLayoutPanel13.TabIndex = 0;
            // 
            // button_DistrictSearch
            // 
            this.button_DistrictSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_DistrictSearch.Location = new System.Drawing.Point(223, 3);
            this.button_DistrictSearch.Name = "button_DistrictSearch";
            this.button_DistrictSearch.Size = new System.Drawing.Size(26, 21);
            this.button_DistrictSearch.TabIndex = 151;
            this.button_DistrictSearch.Text = "...";
            this.button_DistrictSearch.UseVisualStyleBackColor = true;
            this.button_DistrictSearch.Click += new System.EventHandler(this.button_DistrictSearch_Click);
            // 
            // textBox_customerDistrictName
            // 
            this.textBox_customerDistrictName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerDistrictName.Location = new System.Drawing.Point(279, 4);
            this.textBox_customerDistrictName.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customerDistrictName.MaxLength = 50;
            this.textBox_customerDistrictName.Name = "textBox_customerDistrictName";
            this.textBox_customerDistrictName.ReadOnly = true;
            this.textBox_customerDistrictName.Size = new System.Drawing.Size(132, 20);
            this.textBox_customerDistrictName.TabIndex = 148;
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(61, 7);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(59, 13);
            this.label25.TabIndex = 126;
            this.label25.Text = "เขต/อำเภอ";
            // 
            // textBox_customerDistrictCode
            // 
            this.textBox_customerDistrictCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerDistrictCode.Location = new System.Drawing.Point(128, 4);
            this.textBox_customerDistrictCode.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customerDistrictCode.MaxLength = 50;
            this.textBox_customerDistrictCode.Name = "textBox_customerDistrictCode";
            this.textBox_customerDistrictCode.ReadOnly = true;
            this.textBox_customerDistrictCode.Size = new System.Drawing.Size(88, 20);
            this.textBox_customerDistrictCode.TabIndex = 146;
            // 
            // panel_c_1_9
            // 
            this.panel_c_1_9.Controls.Add(this.tableLayoutPanel11);
            this.panel_c_1_9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_c_1_9.Location = new System.Drawing.Point(3, 139);
            this.panel_c_1_9.Name = "panel_c_1_9";
            this.panel_c_1_9.Size = new System.Drawing.Size(415, 28);
            this.panel_c_1_9.TabIndex = 8;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel11.Controls.Add(this.textBox_customerEmail, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(415, 28);
            this.tableLayoutPanel11.TabIndex = 1;
            // 
            // textBox_customerEmail
            // 
            this.textBox_customerEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerEmail.Location = new System.Drawing.Point(128, 4);
            this.textBox_customerEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customerEmail.MaxLength = 50;
            this.textBox_customerEmail.Name = "textBox_customerEmail";
            this.textBox_customerEmail.ReadOnly = true;
            this.textBox_customerEmail.Size = new System.Drawing.Size(283, 20);
            this.textBox_customerEmail.TabIndex = 136;
            this.textBox_customerEmail.TextChanged += new System.EventHandler(this.textBox_customerEmail_TextChanged);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(84, 7);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 135;
            this.label12.Text = "E-Mail";
            // 
            // panel_c_1_10
            // 
            this.panel_c_1_10.Controls.Add(this.tableLayoutPanel14);
            this.panel_c_1_10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_c_1_10.Location = new System.Drawing.Point(424, 139);
            this.panel_c_1_10.Name = "panel_c_1_10";
            this.panel_c_1_10.Size = new System.Drawing.Size(415, 28);
            this.panel_c_1_10.TabIndex = 9;
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 4;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0044F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.33342F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33062F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33155F));
            this.tableLayoutPanel14.Controls.Add(this.button_provinceSearch, 2, 0);
            this.tableLayoutPanel14.Controls.Add(this.label24, 0, 0);
            this.tableLayoutPanel14.Controls.Add(this.textBox_customerProvinceCode, 1, 0);
            this.tableLayoutPanel14.Controls.Add(this.textBox_customerProvinceName, 3, 0);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 1;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(415, 28);
            this.tableLayoutPanel14.TabIndex = 1;
            // 
            // button_provinceSearch
            // 
            this.button_provinceSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_provinceSearch.Location = new System.Drawing.Point(223, 3);
            this.button_provinceSearch.Name = "button_provinceSearch";
            this.button_provinceSearch.Size = new System.Drawing.Size(26, 21);
            this.button_provinceSearch.TabIndex = 150;
            this.button_provinceSearch.Text = "...";
            this.button_provinceSearch.UseVisualStyleBackColor = true;
            this.button_provinceSearch.Click += new System.EventHandler(this.button_provinceSearch_Click);
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(82, 7);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(38, 13);
            this.label24.TabIndex = 121;
            this.label24.Text = "จังหวัด";
            // 
            // textBox_customerProvinceCode
            // 
            this.textBox_customerProvinceCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerProvinceCode.Location = new System.Drawing.Point(128, 4);
            this.textBox_customerProvinceCode.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customerProvinceCode.MaxLength = 50;
            this.textBox_customerProvinceCode.Name = "textBox_customerProvinceCode";
            this.textBox_customerProvinceCode.ReadOnly = true;
            this.textBox_customerProvinceCode.Size = new System.Drawing.Size(88, 20);
            this.textBox_customerProvinceCode.TabIndex = 149;
            // 
            // textBox_customerProvinceName
            // 
            this.textBox_customerProvinceName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerProvinceName.Location = new System.Drawing.Point(279, 4);
            this.textBox_customerProvinceName.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customerProvinceName.MaxLength = 50;
            this.textBox_customerProvinceName.Name = "textBox_customerProvinceName";
            this.textBox_customerProvinceName.ReadOnly = true;
            this.textBox_customerProvinceName.Size = new System.Drawing.Size(132, 20);
            this.textBox_customerProvinceName.TabIndex = 150;
            // 
            // panel_c_1_11
            // 
            this.panel_c_1_11.Controls.Add(this.tableLayoutPanel10);
            this.panel_c_1_11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_c_1_11.Location = new System.Drawing.Point(3, 173);
            this.panel_c_1_11.Name = "panel_c_1_11";
            this.panel_c_1_11.Size = new System.Drawing.Size(415, 33);
            this.panel_c_1_11.TabIndex = 10;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 4;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.01F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.33F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.33F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.33F));
            this.tableLayoutPanel10.Controls.Add(this.textBox_customerTel, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.textBox_customerFax, 3, 0);
            this.tableLayoutPanel10.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(415, 33);
            this.tableLayoutPanel10.TabIndex = 0;
            // 
            // textBox_customerTel
            // 
            this.textBox_customerTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerTel.Location = new System.Drawing.Point(128, 6);
            this.textBox_customerTel.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customerTel.MaxLength = 50;
            this.textBox_customerTel.Name = "textBox_customerTel";
            this.textBox_customerTel.ReadOnly = true;
            this.textBox_customerTel.Size = new System.Drawing.Size(88, 20);
            this.textBox_customerTel.TabIndex = 138;
            this.textBox_customerTel.ContextMenuStripChanged += new System.EventHandler(this.textBox_customerTel_ContextMenuStripChanged);
            this.textBox_customerTel.TextChanged += new System.EventHandler(this.textBox_customerTel_TextChanged);
            this.textBox_customerTel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_customerTel_KeyDown);
            // 
            // textBox_customerFax
            // 
            this.textBox_customerFax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerFax.Location = new System.Drawing.Point(320, 6);
            this.textBox_customerFax.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customerFax.MaxLength = 50;
            this.textBox_customerFax.Name = "textBox_customerFax";
            this.textBox_customerFax.ReadOnly = true;
            this.textBox_customerFax.Size = new System.Drawing.Size(91, 20);
            this.textBox_customerFax.TabIndex = 140;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(72, 10);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 137;
            this.label11.Text = "โทรศัพท์";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 139;
            this.label6.Text = "โทรสาร";
            // 
            // panel_c_1_12
            // 
            this.panel_c_1_12.Controls.Add(this.tableLayoutPanel12);
            this.panel_c_1_12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_c_1_12.Location = new System.Drawing.Point(424, 173);
            this.panel_c_1_12.Name = "panel_c_1_12";
            this.panel_c_1_12.Size = new System.Drawing.Size(415, 33);
            this.panel_c_1_12.TabIndex = 11;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 5;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.01F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.33F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.33F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel12.Controls.Add(this.button_countrySearch, 4, 0);
            this.tableLayoutPanel12.Controls.Add(this.textBox_customerPostCode, 1, 0);
            this.tableLayoutPanel12.Controls.Add(this.label16, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel12.Controls.Add(this.textBox_customerCountry, 3, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(415, 33);
            this.tableLayoutPanel12.TabIndex = 1;
            // 
            // button_countrySearch
            // 
            this.button_countrySearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_countrySearch.Location = new System.Drawing.Point(374, 6);
            this.button_countrySearch.Name = "button_countrySearch";
            this.button_countrySearch.Size = new System.Drawing.Size(26, 21);
            this.button_countrySearch.TabIndex = 151;
            this.button_countrySearch.Text = "...";
            this.button_countrySearch.UseVisualStyleBackColor = true;
            this.button_countrySearch.Click += new System.EventHandler(this.button_countrySearch_Click);
            // 
            // textBox_customerPostCode
            // 
            this.textBox_customerPostCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerPostCode.Location = new System.Drawing.Point(128, 6);
            this.textBox_customerPostCode.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customerPostCode.MaxLength = 5;
            this.textBox_customerPostCode.Name = "textBox_customerPostCode";
            this.textBox_customerPostCode.ReadOnly = true;
            this.textBox_customerPostCode.Size = new System.Drawing.Size(88, 20);
            this.textBox_customerPostCode.TabIndex = 143;
            this.textBox_customerPostCode.ContextMenuStripChanged += new System.EventHandler(this.textBox_customerPostCode_ContextMenuStripChanged);
            this.textBox_customerPostCode.TextChanged += new System.EventHandler(this.textBox_customerPostCode_TextChanged);
            this.textBox_customerPostCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_customerPostCode_KeyDown);
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(51, 10);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 128;
            this.label16.Text = "รหัสไปรษณีย์";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 144;
            this.label5.Text = "ประเทศ";
            // 
            // textBox_customerCountry
            // 
            this.textBox_customerCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerCountry.Location = new System.Drawing.Point(278, 6);
            this.textBox_customerCountry.Name = "textBox_customerCountry";
            this.textBox_customerCountry.ReadOnly = true;
            this.textBox_customerCountry.Size = new System.Drawing.Size(90, 20);
            this.textBox_customerCountry.TabIndex = 145;
            // 
            // tabPage6
            // 
            this.tabPage6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage6.Controls.Add(this.tableLayoutPanel15);
            this.tabPage6.Controls.Add(this.label21);
            this.tabPage6.Controls.Add(this.textBox21);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(945, 217);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "นิติบุคคล";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.ColumnCount = 3;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel15.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel15.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel15.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel15.Controls.Add(this.panel6, 1, 1);
            this.tableLayoutPanel15.Controls.Add(this.panel7, 0, 2);
            this.tableLayoutPanel15.Controls.Add(this.panel8, 1, 2);
            this.tableLayoutPanel15.Controls.Add(this.panel9, 0, 3);
            this.tableLayoutPanel15.Controls.Add(this.panel10, 1, 3);
            this.tableLayoutPanel15.Controls.Add(this.panel11, 0, 4);
            this.tableLayoutPanel15.Controls.Add(this.panel12, 1, 4);
            this.tableLayoutPanel15.Controls.Add(this.panel13, 0, 5);
            this.tableLayoutPanel15.Controls.Add(this.panel14, 1, 5);
            this.tableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel15.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel15.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 6;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(937, 209);
            this.tableLayoutPanel15.TabIndex = 66;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel16);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(415, 28);
            this.panel3.TabIndex = 0;
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.ColumnCount = 2;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel16.Controls.Add(this.textBox_customerCode_1, 0, 0);
            this.tableLayoutPanel16.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel16.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 1;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(415, 28);
            this.tableLayoutPanel16.TabIndex = 0;
            // 
            // textBox_customerCode_1
            // 
            this.textBox_customerCode_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerCode_1.Location = new System.Drawing.Point(128, 4);
            this.textBox_customerCode_1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customerCode_1.MaxLength = 50;
            this.textBox_customerCode_1.Name = "textBox_customerCode_1";
            this.textBox_customerCode_1.ReadOnly = true;
            this.textBox_customerCode_1.Size = new System.Drawing.Size(283, 20);
            this.textBox_customerCode_1.TabIndex = 130;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 129;
            this.label2.Text = "รหัส";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel17);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(424, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(415, 28);
            this.panel4.TabIndex = 1;
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.ColumnCount = 2;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel17.Controls.Add(this.textBox_customerAddress_1, 0, 0);
            this.tableLayoutPanel17.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel17.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 1;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(415, 28);
            this.tableLayoutPanel17.TabIndex = 1;
            // 
            // textBox_customerAddress_1
            // 
            this.textBox_customerAddress_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerAddress_1.Location = new System.Drawing.Point(128, 4);
            this.textBox_customerAddress_1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customerAddress_1.MaxLength = 50;
            this.textBox_customerAddress_1.Name = "textBox_customerAddress_1";
            this.textBox_customerAddress_1.ReadOnly = true;
            this.textBox_customerAddress_1.Size = new System.Drawing.Size(283, 20);
            this.textBox_customerAddress_1.TabIndex = 120;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(93, 7);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 119;
            this.label9.Text = "ที่อยู่";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tableLayoutPanel18);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 37);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(415, 28);
            this.panel5.TabIndex = 2;
            // 
            // tableLayoutPanel18
            // 
            this.tableLayoutPanel18.ColumnCount = 2;
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel18.Controls.Add(this.textBox_customerName_1, 0, 0);
            this.tableLayoutPanel18.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel18.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel18.Name = "tableLayoutPanel18";
            this.tableLayoutPanel18.RowCount = 1;
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel18.Size = new System.Drawing.Size(415, 28);
            this.tableLayoutPanel18.TabIndex = 1;
            // 
            // textBox_customerName_1
            // 
            this.textBox_customerName_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerName_1.Location = new System.Drawing.Point(128, 4);
            this.textBox_customerName_1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customerName_1.MaxLength = 50;
            this.textBox_customerName_1.Name = "textBox_customerName_1";
            this.textBox_customerName_1.ReadOnly = true;
            this.textBox_customerName_1.Size = new System.Drawing.Size(283, 20);
            this.textBox_customerName_1.TabIndex = 132;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(100, 7);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 131;
            this.label10.Text = "ชื่อ";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tableLayoutPanel19);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(424, 37);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(415, 28);
            this.panel6.TabIndex = 3;
            // 
            // tableLayoutPanel19
            // 
            this.tableLayoutPanel19.ColumnCount = 2;
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel19.Controls.Add(this.textBox_customerRoad_1, 0, 0);
            this.tableLayoutPanel19.Controls.Add(this.label17, 0, 0);
            this.tableLayoutPanel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel19.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel19.Name = "tableLayoutPanel19";
            this.tableLayoutPanel19.RowCount = 1;
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel19.Size = new System.Drawing.Size(415, 28);
            this.tableLayoutPanel19.TabIndex = 1;
            // 
            // textBox_customerRoad_1
            // 
            this.textBox_customerRoad_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerRoad_1.Location = new System.Drawing.Point(128, 4);
            this.textBox_customerRoad_1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customerRoad_1.MaxLength = 50;
            this.textBox_customerRoad_1.Name = "textBox_customerRoad_1";
            this.textBox_customerRoad_1.ReadOnly = true;
            this.textBox_customerRoad_1.Size = new System.Drawing.Size(283, 20);
            this.textBox_customerRoad_1.TabIndex = 123;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(90, 7);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 13);
            this.label17.TabIndex = 122;
            this.label17.Text = "ถนน";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tableLayoutPanel20);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 71);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(415, 28);
            this.panel7.TabIndex = 4;
            // 
            // tableLayoutPanel20
            // 
            this.tableLayoutPanel20.ColumnCount = 2;
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel20.Controls.Add(this.textBox_customerTaxId_1, 0, 0);
            this.tableLayoutPanel20.Controls.Add(this.label18, 0, 0);
            this.tableLayoutPanel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel20.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel20.Name = "tableLayoutPanel20";
            this.tableLayoutPanel20.RowCount = 1;
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel20.Size = new System.Drawing.Size(415, 28);
            this.tableLayoutPanel20.TabIndex = 1;
            // 
            // textBox_customerTaxId_1
            // 
            this.textBox_customerTaxId_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerTaxId_1.Location = new System.Drawing.Point(128, 4);
            this.textBox_customerTaxId_1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customerTaxId_1.MaxLength = 13;
            this.textBox_customerTaxId_1.Name = "textBox_customerTaxId_1";
            this.textBox_customerTaxId_1.ReadOnly = true;
            this.textBox_customerTaxId_1.Size = new System.Drawing.Size(283, 20);
            this.textBox_customerTaxId_1.TabIndex = 134;
            this.textBox_customerTaxId_1.ContextMenuStripChanged += new System.EventHandler(this.textBox_customerTaxId_1_ContextMenuStripChanged);
            this.textBox_customerTaxId_1.TextChanged += new System.EventHandler(this.textBox_customerTaxId_1_TextChanged);
            this.textBox_customerTaxId_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_customerTaxId_1_KeyDown);
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 7);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 13);
            this.label18.TabIndex = 133;
            this.label18.Text = "เลขประจำตัวผู้เสียภาษี";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.tableLayoutPanel21);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(424, 71);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(415, 28);
            this.panel8.TabIndex = 5;
            // 
            // tableLayoutPanel21
            // 
            this.tableLayoutPanel21.ColumnCount = 2;
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel21.Controls.Add(this.textBox_customerSubDistrict_1, 0, 0);
            this.tableLayoutPanel21.Controls.Add(this.label19, 0, 0);
            this.tableLayoutPanel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel21.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel21.Name = "tableLayoutPanel21";
            this.tableLayoutPanel21.RowCount = 1;
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel21.Size = new System.Drawing.Size(415, 28);
            this.tableLayoutPanel21.TabIndex = 1;
            // 
            // textBox_customerSubDistrict_1
            // 
            this.textBox_customerSubDistrict_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerSubDistrict_1.Location = new System.Drawing.Point(128, 4);
            this.textBox_customerSubDistrict_1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customerSubDistrict_1.MaxLength = 50;
            this.textBox_customerSubDistrict_1.Name = "textBox_customerSubDistrict_1";
            this.textBox_customerSubDistrict_1.ReadOnly = true;
            this.textBox_customerSubDistrict_1.Size = new System.Drawing.Size(283, 20);
            this.textBox_customerSubDistrict_1.TabIndex = 125;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(58, 7);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 13);
            this.label19.TabIndex = 124;
            this.label19.Text = "ตำบล/แขวง";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.tableLayoutPanel22);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(3, 105);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(415, 28);
            this.panel9.TabIndex = 6;
            // 
            // tableLayoutPanel22
            // 
            this.tableLayoutPanel22.ColumnCount = 2;
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel22.Controls.Add(this.textBox_customerWeb_1, 1, 0);
            this.tableLayoutPanel22.Controls.Add(this.comboBox_cWeb_1, 0, 0);
            this.tableLayoutPanel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel22.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel22.Name = "tableLayoutPanel22";
            this.tableLayoutPanel22.RowCount = 1;
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel22.Size = new System.Drawing.Size(415, 28);
            this.tableLayoutPanel22.TabIndex = 1;
            // 
            // textBox_customerWeb_1
            // 
            this.textBox_customerWeb_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerWeb_1.Location = new System.Drawing.Point(128, 4);
            this.textBox_customerWeb_1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customerWeb_1.MaxLength = 50;
            this.textBox_customerWeb_1.Name = "textBox_customerWeb_1";
            this.textBox_customerWeb_1.ReadOnly = true;
            this.textBox_customerWeb_1.Size = new System.Drawing.Size(283, 20);
            this.textBox_customerWeb_1.TabIndex = 142;
            // 
            // comboBox_cWeb_1
            // 
            this.comboBox_cWeb_1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBox_cWeb_1.Enabled = false;
            this.comboBox_cWeb_1.FormattingEnabled = true;
            this.comboBox_cWeb_1.Items.AddRange(new object[] {
            "สาขาที่",
            "สำนักงานใหญ่"});
            this.comboBox_cWeb_1.Location = new System.Drawing.Point(3, 3);
            this.comboBox_cWeb_1.Name = "comboBox_cWeb_1";
            this.comboBox_cWeb_1.Size = new System.Drawing.Size(118, 21);
            this.comboBox_cWeb_1.TabIndex = 143;
            this.comboBox_cWeb_1.SelectedIndexChanged += new System.EventHandler(this.comboBox_cWeb_1_SelectedIndexChanged);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.tableLayoutPanel23);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(424, 105);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(415, 28);
            this.panel10.TabIndex = 7;
            // 
            // tableLayoutPanel23
            // 
            this.tableLayoutPanel23.ColumnCount = 4;
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0044F));
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.33342F));
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33062F));
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33155F));
            this.tableLayoutPanel23.Controls.Add(this.button_DistrictSearch_1, 2, 0);
            this.tableLayoutPanel23.Controls.Add(this.textBox_customerDistrictName_1, 3, 0);
            this.tableLayoutPanel23.Controls.Add(this.label22, 0, 0);
            this.tableLayoutPanel23.Controls.Add(this.textBox_customerDistrictCode_1, 1, 0);
            this.tableLayoutPanel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel23.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel23.Name = "tableLayoutPanel23";
            this.tableLayoutPanel23.RowCount = 1;
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel23.Size = new System.Drawing.Size(415, 28);
            this.tableLayoutPanel23.TabIndex = 0;
            // 
            // button_DistrictSearch_1
            // 
            this.button_DistrictSearch_1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_DistrictSearch_1.Location = new System.Drawing.Point(223, 3);
            this.button_DistrictSearch_1.Name = "button_DistrictSearch_1";
            this.button_DistrictSearch_1.Size = new System.Drawing.Size(26, 21);
            this.button_DistrictSearch_1.TabIndex = 151;
            this.button_DistrictSearch_1.Text = "...";
            this.button_DistrictSearch_1.UseVisualStyleBackColor = true;
            this.button_DistrictSearch_1.Click += new System.EventHandler(this.button_DistrictSearch_1_Click);
            // 
            // textBox_customerDistrictName_1
            // 
            this.textBox_customerDistrictName_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerDistrictName_1.Location = new System.Drawing.Point(279, 4);
            this.textBox_customerDistrictName_1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customerDistrictName_1.MaxLength = 50;
            this.textBox_customerDistrictName_1.Name = "textBox_customerDistrictName_1";
            this.textBox_customerDistrictName_1.ReadOnly = true;
            this.textBox_customerDistrictName_1.Size = new System.Drawing.Size(132, 20);
            this.textBox_customerDistrictName_1.TabIndex = 148;
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(61, 7);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 13);
            this.label22.TabIndex = 126;
            this.label22.Text = "เขต/อำเภอ";
            // 
            // textBox_customerDistrictCode_1
            // 
            this.textBox_customerDistrictCode_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerDistrictCode_1.Location = new System.Drawing.Point(128, 4);
            this.textBox_customerDistrictCode_1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customerDistrictCode_1.MaxLength = 50;
            this.textBox_customerDistrictCode_1.Name = "textBox_customerDistrictCode_1";
            this.textBox_customerDistrictCode_1.ReadOnly = true;
            this.textBox_customerDistrictCode_1.Size = new System.Drawing.Size(88, 20);
            this.textBox_customerDistrictCode_1.TabIndex = 146;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.tableLayoutPanel24);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(3, 139);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(415, 28);
            this.panel11.TabIndex = 8;
            // 
            // tableLayoutPanel24
            // 
            this.tableLayoutPanel24.ColumnCount = 2;
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel24.Controls.Add(this.textBox_customerEmail_1, 0, 0);
            this.tableLayoutPanel24.Controls.Add(this.label23, 0, 0);
            this.tableLayoutPanel24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel24.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel24.Name = "tableLayoutPanel24";
            this.tableLayoutPanel24.RowCount = 1;
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel24.Size = new System.Drawing.Size(415, 28);
            this.tableLayoutPanel24.TabIndex = 1;
            // 
            // textBox_customerEmail_1
            // 
            this.textBox_customerEmail_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerEmail_1.Location = new System.Drawing.Point(128, 4);
            this.textBox_customerEmail_1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customerEmail_1.MaxLength = 50;
            this.textBox_customerEmail_1.Name = "textBox_customerEmail_1";
            this.textBox_customerEmail_1.ReadOnly = true;
            this.textBox_customerEmail_1.Size = new System.Drawing.Size(283, 20);
            this.textBox_customerEmail_1.TabIndex = 136;
            this.textBox_customerEmail_1.TextChanged += new System.EventHandler(this.textBox_customerEmail_1_TextChanged);
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(84, 7);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(36, 13);
            this.label23.TabIndex = 135;
            this.label23.Text = "E-Mail";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.tableLayoutPanel25);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(424, 139);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(415, 28);
            this.panel12.TabIndex = 9;
            // 
            // tableLayoutPanel25
            // 
            this.tableLayoutPanel25.ColumnCount = 4;
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0044F));
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.33342F));
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33062F));
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33155F));
            this.tableLayoutPanel25.Controls.Add(this.button_provinceSearch_1, 2, 0);
            this.tableLayoutPanel25.Controls.Add(this.label30, 0, 0);
            this.tableLayoutPanel25.Controls.Add(this.textBox_customerProvinceCode_1, 1, 0);
            this.tableLayoutPanel25.Controls.Add(this.textBox_customerProvinceName_1, 3, 0);
            this.tableLayoutPanel25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel25.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel25.Name = "tableLayoutPanel25";
            this.tableLayoutPanel25.RowCount = 1;
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel25.Size = new System.Drawing.Size(415, 28);
            this.tableLayoutPanel25.TabIndex = 1;
            // 
            // button_provinceSearch_1
            // 
            this.button_provinceSearch_1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_provinceSearch_1.Location = new System.Drawing.Point(223, 3);
            this.button_provinceSearch_1.Name = "button_provinceSearch_1";
            this.button_provinceSearch_1.Size = new System.Drawing.Size(26, 21);
            this.button_provinceSearch_1.TabIndex = 150;
            this.button_provinceSearch_1.Text = "...";
            this.button_provinceSearch_1.UseVisualStyleBackColor = true;
            this.button_provinceSearch_1.Click += new System.EventHandler(this.button_provinceSearch_1_Click);
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(82, 7);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(38, 13);
            this.label30.TabIndex = 121;
            this.label30.Text = "จังหวัด";
            // 
            // textBox_customerProvinceCode_1
            // 
            this.textBox_customerProvinceCode_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerProvinceCode_1.Location = new System.Drawing.Point(128, 4);
            this.textBox_customerProvinceCode_1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customerProvinceCode_1.MaxLength = 50;
            this.textBox_customerProvinceCode_1.Name = "textBox_customerProvinceCode_1";
            this.textBox_customerProvinceCode_1.ReadOnly = true;
            this.textBox_customerProvinceCode_1.Size = new System.Drawing.Size(88, 20);
            this.textBox_customerProvinceCode_1.TabIndex = 149;
            // 
            // textBox_customerProvinceName_1
            // 
            this.textBox_customerProvinceName_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerProvinceName_1.Location = new System.Drawing.Point(279, 4);
            this.textBox_customerProvinceName_1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customerProvinceName_1.MaxLength = 50;
            this.textBox_customerProvinceName_1.Name = "textBox_customerProvinceName_1";
            this.textBox_customerProvinceName_1.ReadOnly = true;
            this.textBox_customerProvinceName_1.Size = new System.Drawing.Size(132, 20);
            this.textBox_customerProvinceName_1.TabIndex = 150;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.tableLayoutPanel26);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(3, 173);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(415, 33);
            this.panel13.TabIndex = 10;
            // 
            // tableLayoutPanel26
            // 
            this.tableLayoutPanel26.ColumnCount = 4;
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.01F));
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.33F));
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.33F));
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.33F));
            this.tableLayoutPanel26.Controls.Add(this.textBox_customerTel_1, 1, 0);
            this.tableLayoutPanel26.Controls.Add(this.textBox_customerFax_1, 3, 0);
            this.tableLayoutPanel26.Controls.Add(this.label31, 0, 0);
            this.tableLayoutPanel26.Controls.Add(this.label32, 2, 0);
            this.tableLayoutPanel26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel26.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel26.Name = "tableLayoutPanel26";
            this.tableLayoutPanel26.RowCount = 1;
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel26.Size = new System.Drawing.Size(415, 33);
            this.tableLayoutPanel26.TabIndex = 0;
            // 
            // textBox_customerTel_1
            // 
            this.textBox_customerTel_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerTel_1.Location = new System.Drawing.Point(128, 6);
            this.textBox_customerTel_1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customerTel_1.MaxLength = 50;
            this.textBox_customerTel_1.Name = "textBox_customerTel_1";
            this.textBox_customerTel_1.ReadOnly = true;
            this.textBox_customerTel_1.Size = new System.Drawing.Size(88, 20);
            this.textBox_customerTel_1.TabIndex = 138;
            this.textBox_customerTel_1.ContextMenuStripChanged += new System.EventHandler(this.textBox_customerTel_1_ContextMenuStripChanged);
            this.textBox_customerTel_1.TextChanged += new System.EventHandler(this.textBox_customerTel_1_TextChanged);
            this.textBox_customerTel_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_customerTel_1_KeyDown);
            // 
            // textBox_customerFax_1
            // 
            this.textBox_customerFax_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerFax_1.Location = new System.Drawing.Point(320, 6);
            this.textBox_customerFax_1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customerFax_1.MaxLength = 50;
            this.textBox_customerFax_1.Name = "textBox_customerFax_1";
            this.textBox_customerFax_1.ReadOnly = true;
            this.textBox_customerFax_1.Size = new System.Drawing.Size(91, 20);
            this.textBox_customerFax_1.TabIndex = 140;
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(72, 10);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(48, 13);
            this.label31.TabIndex = 137;
            this.label31.Text = "โทรศัพท์";
            // 
            // label32
            // 
            this.label32.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(270, 10);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(42, 13);
            this.label32.TabIndex = 139;
            this.label32.Text = "โทรสาร";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.tableLayoutPanel27);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(424, 173);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(415, 33);
            this.panel14.TabIndex = 11;
            // 
            // tableLayoutPanel27
            // 
            this.tableLayoutPanel27.ColumnCount = 5;
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.01F));
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.33F));
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33F));
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.33F));
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel27.Controls.Add(this.button_countrySearch_1, 4, 0);
            this.tableLayoutPanel27.Controls.Add(this.textBox_customerPostCode_1, 1, 0);
            this.tableLayoutPanel27.Controls.Add(this.label33, 0, 0);
            this.tableLayoutPanel27.Controls.Add(this.label34, 2, 0);
            this.tableLayoutPanel27.Controls.Add(this.textBox_customerCountry_1, 3, 0);
            this.tableLayoutPanel27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel27.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel27.Name = "tableLayoutPanel27";
            this.tableLayoutPanel27.RowCount = 1;
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel27.Size = new System.Drawing.Size(415, 33);
            this.tableLayoutPanel27.TabIndex = 1;
            // 
            // button_countrySearch_1
            // 
            this.button_countrySearch_1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_countrySearch_1.Location = new System.Drawing.Point(374, 6);
            this.button_countrySearch_1.Name = "button_countrySearch_1";
            this.button_countrySearch_1.Size = new System.Drawing.Size(26, 21);
            this.button_countrySearch_1.TabIndex = 152;
            this.button_countrySearch_1.Text = "...";
            this.button_countrySearch_1.UseVisualStyleBackColor = true;
            this.button_countrySearch_1.Click += new System.EventHandler(this.button_countrySearch_1_Click);
            // 
            // textBox_customerPostCode_1
            // 
            this.textBox_customerPostCode_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerPostCode_1.Location = new System.Drawing.Point(128, 6);
            this.textBox_customerPostCode_1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customerPostCode_1.MaxLength = 5;
            this.textBox_customerPostCode_1.Name = "textBox_customerPostCode_1";
            this.textBox_customerPostCode_1.ReadOnly = true;
            this.textBox_customerPostCode_1.Size = new System.Drawing.Size(88, 20);
            this.textBox_customerPostCode_1.TabIndex = 143;
            this.textBox_customerPostCode_1.ContextMenuStripChanged += new System.EventHandler(this.textBox_customerPostCode_1_ContextMenuStripChanged);
            this.textBox_customerPostCode_1.TextChanged += new System.EventHandler(this.textBox_customerPostCode_1_TextChanged);
            this.textBox_customerPostCode_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_customerPostCode_1_KeyDown);
            // 
            // label33
            // 
            this.label33.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(51, 10);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(69, 13);
            this.label33.TabIndex = 128;
            this.label33.Text = "รหัสไปรษณีย์";
            // 
            // label34
            // 
            this.label34.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(226, 10);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(45, 13);
            this.label34.TabIndex = 144;
            this.label34.Text = "ประเทศ";
            // 
            // textBox_customerCountry_1
            // 
            this.textBox_customerCountry_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerCountry_1.Location = new System.Drawing.Point(278, 6);
            this.textBox_customerCountry_1.Name = "textBox_customerCountry_1";
            this.textBox_customerCountry_1.ReadOnly = true;
            this.textBox_customerCountry_1.Size = new System.Drawing.Size(90, 20);
            this.textBox_customerCountry_1.TabIndex = 145;
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
            this.textBox21.MaxLength = 50;
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(232, 20);
            this.textBox21.TabIndex = 65;
            // 
            // tabPage7
            // 
            this.tabPage7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage7.Controls.Add(this.tableLayoutPanel28);
            this.tabPage7.Controls.Add(this.textBox27);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(945, 217);
            this.tabPage7.TabIndex = 3;
            this.tabPage7.Text = "ชาวต่างชาติ";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel28
            // 
            this.tableLayoutPanel28.ColumnCount = 3;
            this.tableLayoutPanel28.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel28.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel28.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel28.Controls.Add(this.panel15, 0, 0);
            this.tableLayoutPanel28.Controls.Add(this.panel16, 1, 0);
            this.tableLayoutPanel28.Controls.Add(this.panel17, 0, 1);
            this.tableLayoutPanel28.Controls.Add(this.panel18, 1, 1);
            this.tableLayoutPanel28.Controls.Add(this.panel19, 0, 2);
            this.tableLayoutPanel28.Controls.Add(this.panel20, 1, 2);
            this.tableLayoutPanel28.Controls.Add(this.panel21, 0, 3);
            this.tableLayoutPanel28.Controls.Add(this.panel22, 1, 3);
            this.tableLayoutPanel28.Controls.Add(this.panel23, 0, 4);
            this.tableLayoutPanel28.Controls.Add(this.panel24, 1, 4);
            this.tableLayoutPanel28.Controls.Add(this.panel25, 0, 5);
            this.tableLayoutPanel28.Controls.Add(this.panel26, 1, 5);
            this.tableLayoutPanel28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel28.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel28.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel28.Name = "tableLayoutPanel28";
            this.tableLayoutPanel28.RowCount = 6;
            this.tableLayoutPanel28.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel28.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel28.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel28.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel28.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel28.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel28.Size = new System.Drawing.Size(937, 209);
            this.tableLayoutPanel28.TabIndex = 94;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.tableLayoutPanel29);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(3, 3);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(415, 28);
            this.panel15.TabIndex = 0;
            // 
            // tableLayoutPanel29
            // 
            this.tableLayoutPanel29.ColumnCount = 2;
            this.tableLayoutPanel29.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel29.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel29.Controls.Add(this.textBox_customerCode_2, 0, 0);
            this.tableLayoutPanel29.Controls.Add(this.label35, 0, 0);
            this.tableLayoutPanel29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel29.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel29.Name = "tableLayoutPanel29";
            this.tableLayoutPanel29.RowCount = 1;
            this.tableLayoutPanel29.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel29.Size = new System.Drawing.Size(415, 28);
            this.tableLayoutPanel29.TabIndex = 0;
            // 
            // textBox_customerCode_2
            // 
            this.textBox_customerCode_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerCode_2.Location = new System.Drawing.Point(128, 4);
            this.textBox_customerCode_2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customerCode_2.MaxLength = 50;
            this.textBox_customerCode_2.Name = "textBox_customerCode_2";
            this.textBox_customerCode_2.ReadOnly = true;
            this.textBox_customerCode_2.Size = new System.Drawing.Size(283, 20);
            this.textBox_customerCode_2.TabIndex = 130;
            // 
            // label35
            // 
            this.label35.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(94, 7);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(26, 13);
            this.label35.TabIndex = 129;
            this.label35.Text = "รหัส";
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.tableLayoutPanel30);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(424, 3);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(415, 28);
            this.panel16.TabIndex = 1;
            // 
            // tableLayoutPanel30
            // 
            this.tableLayoutPanel30.ColumnCount = 2;
            this.tableLayoutPanel30.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel30.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel30.Controls.Add(this.textBox_customerAddress_2, 0, 0);
            this.tableLayoutPanel30.Controls.Add(this.label36, 0, 0);
            this.tableLayoutPanel30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel30.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel30.Name = "tableLayoutPanel30";
            this.tableLayoutPanel30.RowCount = 1;
            this.tableLayoutPanel30.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel30.Size = new System.Drawing.Size(415, 28);
            this.tableLayoutPanel30.TabIndex = 1;
            // 
            // textBox_customerAddress_2
            // 
            this.textBox_customerAddress_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerAddress_2.Location = new System.Drawing.Point(128, 4);
            this.textBox_customerAddress_2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customerAddress_2.MaxLength = 50;
            this.textBox_customerAddress_2.Name = "textBox_customerAddress_2";
            this.textBox_customerAddress_2.ReadOnly = true;
            this.textBox_customerAddress_2.Size = new System.Drawing.Size(283, 20);
            this.textBox_customerAddress_2.TabIndex = 120;
            // 
            // label36
            // 
            this.label36.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(93, 7);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(27, 13);
            this.label36.TabIndex = 119;
            this.label36.Text = "ที่อยู่";
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.tableLayoutPanel31);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel17.Location = new System.Drawing.Point(3, 37);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(415, 28);
            this.panel17.TabIndex = 2;
            // 
            // tableLayoutPanel31
            // 
            this.tableLayoutPanel31.ColumnCount = 2;
            this.tableLayoutPanel31.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel31.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel31.Controls.Add(this.textBox_customerName_2, 0, 0);
            this.tableLayoutPanel31.Controls.Add(this.label37, 0, 0);
            this.tableLayoutPanel31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel31.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel31.Name = "tableLayoutPanel31";
            this.tableLayoutPanel31.RowCount = 1;
            this.tableLayoutPanel31.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel31.Size = new System.Drawing.Size(415, 28);
            this.tableLayoutPanel31.TabIndex = 1;
            // 
            // textBox_customerName_2
            // 
            this.textBox_customerName_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerName_2.Location = new System.Drawing.Point(128, 4);
            this.textBox_customerName_2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customerName_2.MaxLength = 50;
            this.textBox_customerName_2.Name = "textBox_customerName_2";
            this.textBox_customerName_2.ReadOnly = true;
            this.textBox_customerName_2.Size = new System.Drawing.Size(283, 20);
            this.textBox_customerName_2.TabIndex = 132;
            // 
            // label37
            // 
            this.label37.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(100, 7);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(20, 13);
            this.label37.TabIndex = 131;
            this.label37.Text = "ชื่อ";
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.tableLayoutPanel32);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Location = new System.Drawing.Point(424, 37);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(415, 28);
            this.panel18.TabIndex = 3;
            // 
            // tableLayoutPanel32
            // 
            this.tableLayoutPanel32.ColumnCount = 2;
            this.tableLayoutPanel32.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel32.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel32.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel32.Name = "tableLayoutPanel32";
            this.tableLayoutPanel32.RowCount = 1;
            this.tableLayoutPanel32.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel32.Size = new System.Drawing.Size(415, 28);
            this.tableLayoutPanel32.TabIndex = 1;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.tableLayoutPanel33);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel19.Location = new System.Drawing.Point(3, 71);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(415, 28);
            this.panel19.TabIndex = 4;
            // 
            // tableLayoutPanel33
            // 
            this.tableLayoutPanel33.ColumnCount = 2;
            this.tableLayoutPanel33.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel33.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel33.Controls.Add(this.textBox_customerTaxId_2, 0, 0);
            this.tableLayoutPanel33.Controls.Add(this.label39, 0, 0);
            this.tableLayoutPanel33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel33.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel33.Name = "tableLayoutPanel33";
            this.tableLayoutPanel33.RowCount = 1;
            this.tableLayoutPanel33.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel33.Size = new System.Drawing.Size(415, 28);
            this.tableLayoutPanel33.TabIndex = 1;
            // 
            // textBox_customerTaxId_2
            // 
            this.textBox_customerTaxId_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerTaxId_2.Location = new System.Drawing.Point(128, 4);
            this.textBox_customerTaxId_2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customerTaxId_2.MaxLength = 9;
            this.textBox_customerTaxId_2.Name = "textBox_customerTaxId_2";
            this.textBox_customerTaxId_2.ReadOnly = true;
            this.textBox_customerTaxId_2.Size = new System.Drawing.Size(283, 20);
            this.textBox_customerTaxId_2.TabIndex = 134;
            // 
            // label39
            // 
            this.label39.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(20, 7);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(100, 13);
            this.label39.TabIndex = 133;
            this.label39.Text = "เลขที่หนังสือเดินทาง";
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.tableLayoutPanel34);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel20.Location = new System.Drawing.Point(424, 71);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(415, 28);
            this.panel20.TabIndex = 5;
            // 
            // tableLayoutPanel34
            // 
            this.tableLayoutPanel34.ColumnCount = 2;
            this.tableLayoutPanel34.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel34.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel34.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel34.Name = "tableLayoutPanel34";
            this.tableLayoutPanel34.RowCount = 1;
            this.tableLayoutPanel34.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel34.Size = new System.Drawing.Size(415, 28);
            this.tableLayoutPanel34.TabIndex = 1;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.tableLayoutPanel35);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel21.Location = new System.Drawing.Point(3, 105);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(415, 28);
            this.panel21.TabIndex = 6;
            // 
            // tableLayoutPanel35
            // 
            this.tableLayoutPanel35.ColumnCount = 2;
            this.tableLayoutPanel35.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel35.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel35.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel35.Name = "tableLayoutPanel35";
            this.tableLayoutPanel35.RowCount = 1;
            this.tableLayoutPanel35.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel35.Size = new System.Drawing.Size(415, 28);
            this.tableLayoutPanel35.TabIndex = 1;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.tableLayoutPanel36);
            this.panel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel22.Location = new System.Drawing.Point(424, 105);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(415, 28);
            this.panel22.TabIndex = 7;
            // 
            // tableLayoutPanel36
            // 
            this.tableLayoutPanel36.ColumnCount = 4;
            this.tableLayoutPanel36.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0044F));
            this.tableLayoutPanel36.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.33342F));
            this.tableLayoutPanel36.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33062F));
            this.tableLayoutPanel36.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33155F));
            this.tableLayoutPanel36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel36.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel36.Name = "tableLayoutPanel36";
            this.tableLayoutPanel36.RowCount = 1;
            this.tableLayoutPanel36.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel36.Size = new System.Drawing.Size(415, 28);
            this.tableLayoutPanel36.TabIndex = 0;
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.tableLayoutPanel37);
            this.panel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel23.Location = new System.Drawing.Point(3, 139);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(415, 28);
            this.panel23.TabIndex = 8;
            // 
            // tableLayoutPanel37
            // 
            this.tableLayoutPanel37.ColumnCount = 2;
            this.tableLayoutPanel37.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel37.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel37.Controls.Add(this.textBox_customerEmail_2, 0, 0);
            this.tableLayoutPanel37.Controls.Add(this.label46, 0, 0);
            this.tableLayoutPanel37.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel37.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel37.Name = "tableLayoutPanel37";
            this.tableLayoutPanel37.RowCount = 1;
            this.tableLayoutPanel37.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel37.Size = new System.Drawing.Size(415, 28);
            this.tableLayoutPanel37.TabIndex = 1;
            // 
            // textBox_customerEmail_2
            // 
            this.textBox_customerEmail_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerEmail_2.Location = new System.Drawing.Point(128, 4);
            this.textBox_customerEmail_2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customerEmail_2.MaxLength = 50;
            this.textBox_customerEmail_2.Name = "textBox_customerEmail_2";
            this.textBox_customerEmail_2.ReadOnly = true;
            this.textBox_customerEmail_2.Size = new System.Drawing.Size(283, 20);
            this.textBox_customerEmail_2.TabIndex = 136;
            this.textBox_customerEmail_2.TextChanged += new System.EventHandler(this.textBox_customerEmail_2_TextChanged);
            // 
            // label46
            // 
            this.label46.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(84, 7);
            this.label46.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(36, 13);
            this.label46.TabIndex = 135;
            this.label46.Text = "E-Mail";
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.tableLayoutPanel38);
            this.panel24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel24.Location = new System.Drawing.Point(424, 139);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(415, 28);
            this.panel24.TabIndex = 9;
            // 
            // tableLayoutPanel38
            // 
            this.tableLayoutPanel38.ColumnCount = 2;
            this.tableLayoutPanel38.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.00308F));
            this.tableLayoutPanel38.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.99692F));
            this.tableLayoutPanel38.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel38.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel38.Controls.Add(this.label47, 0, 0);
            this.tableLayoutPanel38.Controls.Add(this.textBox_customerProvinceName_2, 1, 0);
            this.tableLayoutPanel38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel38.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel38.Name = "tableLayoutPanel38";
            this.tableLayoutPanel38.RowCount = 1;
            this.tableLayoutPanel38.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel38.Size = new System.Drawing.Size(415, 28);
            this.tableLayoutPanel38.TabIndex = 1;
            // 
            // label47
            // 
            this.label47.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(82, 7);
            this.label47.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(38, 13);
            this.label47.TabIndex = 121;
            this.label47.Text = "จังหวัด";
            // 
            // textBox_customerProvinceName_2
            // 
            this.textBox_customerProvinceName_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerProvinceName_2.Location = new System.Drawing.Point(128, 4);
            this.textBox_customerProvinceName_2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customerProvinceName_2.MaxLength = 50;
            this.textBox_customerProvinceName_2.Name = "textBox_customerProvinceName_2";
            this.textBox_customerProvinceName_2.ReadOnly = true;
            this.textBox_customerProvinceName_2.Size = new System.Drawing.Size(283, 20);
            this.textBox_customerProvinceName_2.TabIndex = 150;
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.tableLayoutPanel39);
            this.panel25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel25.Location = new System.Drawing.Point(3, 173);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(415, 33);
            this.panel25.TabIndex = 10;
            // 
            // tableLayoutPanel39
            // 
            this.tableLayoutPanel39.ColumnCount = 4;
            this.tableLayoutPanel39.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.01F));
            this.tableLayoutPanel39.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.33F));
            this.tableLayoutPanel39.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.33F));
            this.tableLayoutPanel39.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.33F));
            this.tableLayoutPanel39.Controls.Add(this.textBox_customerTel_2, 1, 0);
            this.tableLayoutPanel39.Controls.Add(this.label48, 0, 0);
            this.tableLayoutPanel39.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel39.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel39.Name = "tableLayoutPanel39";
            this.tableLayoutPanel39.RowCount = 1;
            this.tableLayoutPanel39.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel39.Size = new System.Drawing.Size(415, 33);
            this.tableLayoutPanel39.TabIndex = 0;
            // 
            // textBox_customerTel_2
            // 
            this.textBox_customerTel_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerTel_2.Location = new System.Drawing.Point(128, 6);
            this.textBox_customerTel_2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customerTel_2.MaxLength = 50;
            this.textBox_customerTel_2.Name = "textBox_customerTel_2";
            this.textBox_customerTel_2.ReadOnly = true;
            this.textBox_customerTel_2.Size = new System.Drawing.Size(88, 20);
            this.textBox_customerTel_2.TabIndex = 138;
            this.textBox_customerTel_2.ContextMenuStripChanged += new System.EventHandler(this.textBox_customerTel_2_ContextMenuStripChanged);
            this.textBox_customerTel_2.TextChanged += new System.EventHandler(this.textBox_customerTel_2_TextChanged);
            this.textBox_customerTel_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_customerTel_2_KeyDown);
            // 
            // label48
            // 
            this.label48.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(72, 10);
            this.label48.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(48, 13);
            this.label48.TabIndex = 137;
            this.label48.Text = "โทรศัพท์";
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.tableLayoutPanel40);
            this.panel26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel26.Location = new System.Drawing.Point(424, 173);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(415, 33);
            this.panel26.TabIndex = 11;
            // 
            // tableLayoutPanel40
            // 
            this.tableLayoutPanel40.ColumnCount = 5;
            this.tableLayoutPanel40.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.01F));
            this.tableLayoutPanel40.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.33F));
            this.tableLayoutPanel40.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33F));
            this.tableLayoutPanel40.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.33F));
            this.tableLayoutPanel40.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel40.Controls.Add(this.button_countrySearch_2, 4, 0);
            this.tableLayoutPanel40.Controls.Add(this.textBox_customerPostCode_2, 1, 0);
            this.tableLayoutPanel40.Controls.Add(this.label50, 0, 0);
            this.tableLayoutPanel40.Controls.Add(this.label51, 2, 0);
            this.tableLayoutPanel40.Controls.Add(this.textBox_customerCountry_2, 3, 0);
            this.tableLayoutPanel40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel40.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel40.Name = "tableLayoutPanel40";
            this.tableLayoutPanel40.RowCount = 1;
            this.tableLayoutPanel40.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel40.Size = new System.Drawing.Size(415, 33);
            this.tableLayoutPanel40.TabIndex = 1;
            // 
            // button_countrySearch_2
            // 
            this.button_countrySearch_2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_countrySearch_2.Location = new System.Drawing.Point(374, 6);
            this.button_countrySearch_2.Name = "button_countrySearch_2";
            this.button_countrySearch_2.Size = new System.Drawing.Size(26, 21);
            this.button_countrySearch_2.TabIndex = 151;
            this.button_countrySearch_2.Text = "...";
            this.button_countrySearch_2.UseVisualStyleBackColor = true;
            this.button_countrySearch_2.Click += new System.EventHandler(this.button_countrySearch_2_Click);
            // 
            // textBox_customerPostCode_2
            // 
            this.textBox_customerPostCode_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerPostCode_2.Location = new System.Drawing.Point(128, 6);
            this.textBox_customerPostCode_2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_customerPostCode_2.MaxLength = 5;
            this.textBox_customerPostCode_2.Name = "textBox_customerPostCode_2";
            this.textBox_customerPostCode_2.ReadOnly = true;
            this.textBox_customerPostCode_2.Size = new System.Drawing.Size(88, 20);
            this.textBox_customerPostCode_2.TabIndex = 143;
            this.textBox_customerPostCode_2.ContextMenuStripChanged += new System.EventHandler(this.textBox_customerPostCode_2_ContextMenuStripChanged);
            this.textBox_customerPostCode_2.TextChanged += new System.EventHandler(this.textBox_customerPostCode_2_TextChanged);
            this.textBox_customerPostCode_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_customerPostCode_2_KeyDown);
            // 
            // label50
            // 
            this.label50.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(51, 10);
            this.label50.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(69, 13);
            this.label50.TabIndex = 128;
            this.label50.Text = "รหัสไปรษณีย์";
            // 
            // label51
            // 
            this.label51.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(226, 10);
            this.label51.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(45, 13);
            this.label51.TabIndex = 144;
            this.label51.Text = "ประเทศ";
            // 
            // textBox_customerCountry_2
            // 
            this.textBox_customerCountry_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerCountry_2.Location = new System.Drawing.Point(278, 6);
            this.textBox_customerCountry_2.Name = "textBox_customerCountry_2";
            this.textBox_customerCountry_2.ReadOnly = true;
            this.textBox_customerCountry_2.Size = new System.Drawing.Size(90, 20);
            this.textBox_customerCountry_2.TabIndex = 145;
            // 
            // textBox27
            // 
            this.textBox27.Location = new System.Drawing.Point(228, 253);
            this.textBox27.Margin = new System.Windows.Forms.Padding(4);
            this.textBox27.MaxLength = 50;
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(232, 20);
            this.textBox27.TabIndex = 93;
            // 
            // tableLayoutPanel47
            // 
            this.tableLayoutPanel47.ColumnCount = 4;
            this.tableLayoutPanel47.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.01F));
            this.tableLayoutPanel47.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66333F));
            this.tableLayoutPanel47.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66333F));
            this.tableLayoutPanel47.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66333F));
            this.tableLayoutPanel47.Controls.Add(this.button_add, 1, 0);
            this.tableLayoutPanel47.Controls.Add(this.button_save, 2, 0);
            this.tableLayoutPanel47.Controls.Add(this.button_customersearch, 3, 0);
            this.tableLayoutPanel47.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel47.Location = new System.Drawing.Point(3, 252);
            this.tableLayoutPanel47.Name = "tableLayoutPanel47";
            this.tableLayoutPanel47.RowCount = 1;
            this.tableLayoutPanel47.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel47.Size = new System.Drawing.Size(953, 29);
            this.tableLayoutPanel47.TabIndex = 3;
            // 
            // button_add
            // 
            this.button_add.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_add.Location = new System.Drawing.Point(479, 3);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(152, 23);
            this.button_add.TabIndex = 0;
            this.button_add.Text = "เพิ่ม";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.toolStripButton_Add_Click);
            // 
            // button_save
            // 
            this.button_save.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_save.Location = new System.Drawing.Point(637, 3);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(152, 23);
            this.button_save.TabIndex = 1;
            this.button_save.Text = "บันทึก";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.toolStripButton_Save_Click);
            // 
            // button_customersearch
            // 
            this.button_customersearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_customersearch.Location = new System.Drawing.Point(795, 3);
            this.button_customersearch.Name = "button_customersearch";
            this.button_customersearch.Size = new System.Drawing.Size(155, 23);
            this.button_customersearch.TabIndex = 2;
            this.button_customersearch.Text = "ค้นหา";
            this.button_customersearch.UseVisualStyleBackColor = true;
            this.button_customersearch.Click += new System.EventHandler(this.button_SearchCustomer_Click);
            // 
            // tableLayoutPanel49
            // 
            this.tableLayoutPanel49.ColumnCount = 3;
            this.tableLayoutPanel49.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.67333F));
            this.tableLayoutPanel49.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66333F));
            this.tableLayoutPanel49.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66333F));
            this.tableLayoutPanel49.Controls.Add(this.button_print, 1, 0);
            this.tableLayoutPanel49.Controls.Add(this.button_close, 2, 0);
            this.tableLayoutPanel49.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel49.Location = new System.Drawing.Point(3, 678);
            this.tableLayoutPanel49.Name = "tableLayoutPanel49";
            this.tableLayoutPanel49.RowCount = 1;
            this.tableLayoutPanel49.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel49.Size = new System.Drawing.Size(953, 31);
            this.tableLayoutPanel49.TabIndex = 4;
            // 
            // button_print
            // 
            this.button_print.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_print.Location = new System.Drawing.Point(638, 3);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(152, 25);
            this.button_print.TabIndex = 0;
            this.button_print.Text = "ออกใบกำกับภาษี";
            this.button_print.UseVisualStyleBackColor = true;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // button_close
            // 
            this.button_close.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_close.Location = new System.Drawing.Point(796, 3);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(154, 25);
            this.button_close.TabIndex = 1;
            this.button_close.Text = "ปิด";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(959, 712);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmMain";
            this.Text = "Main program Name";
            this.Load += new System.EventHandler(this.frmInvoiceMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabInvoice.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tablebottom_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_bottom_3.ResumeLayout(false);
            this.table_bottom_3_1.ResumeLayout(false);
            this.panel_bottom_3_2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sumNet)).EndInit();
            this.tableLayoutPanel42.ResumeLayout(false);
            this.tableLayoutPanel42.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_VAT)).EndInit();
            this.tableLayoutPanel41.ResumeLayout(false);
            this.tableLayoutPanel41.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sumDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sumVat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Total)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NetAfter)).EndInit();
            this.tableLayoutPanel43.ResumeLayout(false);
            this.tableLayoutPanel44.ResumeLayout(false);
            this.tableLayoutPanel48.ResumeLayout(false);
            this.tableLayoutPanel48.PerformLayout();
            this.tableLayoutPanel45.ResumeLayout(false);
            this.tableLayoutPanel45.PerformLayout();
            this.tableLayoutPanel46.ResumeLayout(false);
            this.tableLayoutPanel46.PerformLayout();
            this.tableLayoutPanel50.ResumeLayout(false);
            this.tableLayoutPanel50.PerformLayout();
            this.tabCustomerDetail.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tableLayoutPanel_Customer_1.ResumeLayout(false);
            this.panel_c_1_1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel_c_1_2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel_c_1_3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.panel_c_1_4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.panel_c_1_5.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.panel_c_1_6.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.panel_c_1_7.ResumeLayout(false);
            this.panel_c_1_8.ResumeLayout(false);
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.panel_c_1_9.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.panel_c_1_10.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            this.panel_c_1_11.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.panel_c_1_12.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tableLayoutPanel15.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel16.ResumeLayout(false);
            this.tableLayoutPanel16.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel17.ResumeLayout(false);
            this.tableLayoutPanel17.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel18.ResumeLayout(false);
            this.tableLayoutPanel18.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.tableLayoutPanel19.ResumeLayout(false);
            this.tableLayoutPanel19.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.tableLayoutPanel20.ResumeLayout(false);
            this.tableLayoutPanel20.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.tableLayoutPanel21.ResumeLayout(false);
            this.tableLayoutPanel21.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.tableLayoutPanel22.ResumeLayout(false);
            this.tableLayoutPanel22.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.tableLayoutPanel23.ResumeLayout(false);
            this.tableLayoutPanel23.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.tableLayoutPanel24.ResumeLayout(false);
            this.tableLayoutPanel24.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.tableLayoutPanel25.ResumeLayout(false);
            this.tableLayoutPanel25.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.tableLayoutPanel26.ResumeLayout(false);
            this.tableLayoutPanel26.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.tableLayoutPanel27.ResumeLayout(false);
            this.tableLayoutPanel27.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tableLayoutPanel28.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.tableLayoutPanel29.ResumeLayout(false);
            this.tableLayoutPanel29.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.tableLayoutPanel30.ResumeLayout(false);
            this.tableLayoutPanel30.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.tableLayoutPanel31.ResumeLayout(false);
            this.tableLayoutPanel31.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.tableLayoutPanel33.ResumeLayout(false);
            this.tableLayoutPanel33.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            this.tableLayoutPanel37.ResumeLayout(false);
            this.tableLayoutPanel37.PerformLayout();
            this.panel24.ResumeLayout(false);
            this.tableLayoutPanel38.ResumeLayout(false);
            this.tableLayoutPanel38.PerformLayout();
            this.panel25.ResumeLayout(false);
            this.tableLayoutPanel39.ResumeLayout(false);
            this.tableLayoutPanel39.PerformLayout();
            this.panel26.ResumeLayout(false);
            this.tableLayoutPanel40.ResumeLayout(false);
            this.tableLayoutPanel40.PerformLayout();
            this.tableLayoutPanel47.ResumeLayout(false);
            this.tableLayoutPanel49.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabCustomerDetail;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Customer_1;
        private System.Windows.Forms.Panel panel_c_1_1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel_c_1_2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel_c_1_3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel panel_c_1_4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Panel panel_c_1_5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Panel panel_c_1_6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Panel panel_c_1_7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Panel panel_c_1_8;
        private System.Windows.Forms.Panel panel_c_1_9;
        private System.Windows.Forms.Panel panel_c_1_10;
        private System.Windows.Forms.Panel panel_c_1_11;
        private System.Windows.Forms.Panel panel_c_1_12;
        private System.Windows.Forms.TextBox textBox_customerCode;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_customerAddress;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBox_customerName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.TextBox textBox_customerEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_customerRoad;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox_customerTaxId;
        private System.Windows.Forms.TextBox textBox_customerSubDistrict;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_customerTel;
        private System.Windows.Forms.TextBox textBox_customerFax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.TextBox textBox_customerPostCode;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.TextBox textBox_customerDistrictName;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox_customerDistrictCode;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox_customerProvinceCode;
        private System.Windows.Forms.Button button_provinceSearch;
        private System.Windows.Forms.TextBox textBox_customerProvinceName;
        private System.Windows.Forms.Button button_DistrictSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
        private System.Windows.Forms.TextBox textBox_customerCode_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel17;
        private System.Windows.Forms.TextBox textBox_customerAddress_1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel18;
        private System.Windows.Forms.TextBox textBox_customerName_1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel19;
        private System.Windows.Forms.TextBox textBox_customerRoad_1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel20;
        private System.Windows.Forms.TextBox textBox_customerTaxId_1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel21;
        private System.Windows.Forms.TextBox textBox_customerSubDistrict_1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel22;
        private System.Windows.Forms.TextBox textBox_customerWeb_1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel23;
        private System.Windows.Forms.Button button_DistrictSearch_1;
        private System.Windows.Forms.TextBox textBox_customerDistrictName_1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox_customerDistrictCode_1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel24;
        private System.Windows.Forms.TextBox textBox_customerEmail_1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel25;
        private System.Windows.Forms.Button button_provinceSearch_1;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBox_customerProvinceCode_1;
        private System.Windows.Forms.TextBox textBox_customerProvinceName_1;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel26;
        private System.Windows.Forms.TextBox textBox_customerTel_1;
        private System.Windows.Forms.TextBox textBox_customerFax_1;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel27;
        private System.Windows.Forms.TextBox textBox_customerPostCode_1;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel28;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel29;
        private System.Windows.Forms.TextBox textBox_customerCode_2;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel30;
        private System.Windows.Forms.TextBox textBox_customerAddress_2;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel31;
        private System.Windows.Forms.TextBox textBox_customerName_2;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel32;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel33;
        private System.Windows.Forms.TextBox textBox_customerTaxId_2;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel34;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel35;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel36;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel37;
        private System.Windows.Forms.TextBox textBox_customerEmail_2;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel38;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox textBox_customerProvinceName_2;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel39;
        private System.Windows.Forms.TextBox textBox_customerTel_2;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel40;
        private System.Windows.Forms.TextBox textBox_customerPostCode_2;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TabControl tabInvoice;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TableLayoutPanel tablebottom_1;
        private System.Windows.Forms.Button button_InvoiceSearch;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox textBox_invoiceDocNo;
        private System.Windows.Forms.TextBox textBox_invoiceDate;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox textBox_invoiceBranchCode;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel_bottom_3;
        private System.Windows.Forms.TableLayoutPanel table_bottom_3_1;
        private System.Windows.Forms.Panel panel_bottom_3_2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_cWeb_1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel42;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel41;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.NumericUpDown numericUpDown_sumNet;
        private System.Windows.Forms.NumericUpDown numericUpDown_VAT;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown_sumDiscount;
        private System.Windows.Forms.NumericUpDown numericUpDown_NetAfter;
        private System.Windows.Forms.NumericUpDown numericUpDown_sumVat;
        private System.Windows.Forms.NumericUpDown numericUpDown_Total;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel43;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel44;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel48;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel45;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel46;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel47;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_customersearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel49;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.TextBox textBox_customerCountry;
        private System.Windows.Forms.Button button_countrySearch;
        private System.Windows.Forms.TextBox textBox_customerCountry_1;
        private System.Windows.Forms.Button button_countrySearch_1;
        private System.Windows.Forms.Button button_countrySearch_2;
        private System.Windows.Forms.TextBox textBox_customerCountry_2;
        private System.Windows.Forms.Button button_testCN;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel50;
        private System.Windows.Forms.TextBox textBox_CNReason_Other;
        private System.Windows.Forms.Label label_ReasonCN;
        private System.Windows.Forms.ComboBox comboBox_CNReason;
    }
}

