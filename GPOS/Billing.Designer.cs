namespace GPOS
{
    partial class Billing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            label12 = new Label();
            label10 = new Label();
            BillDGV = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            label14 = new Label();
            label8 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            label3 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            CusNameCB = new TextBox();
            CusIDCB = new ComboBox();
            BDateCB = new DateTimePicker();
            panel4 = new Panel();
            button2 = new Button();
            AddBtn = new Button();
            Search = new TextBox();
            groupBox1 = new GroupBox();
            pictureBox9 = new PictureBox();
            button3 = new Button();
            ProductsDVG = new DataGridView();
            SubTotal = new TextBox();
            panel5 = new Panel();
            label18 = new Label();
            label16 = new Label();
            TotalDiscount = new TextBox();
            label17 = new Label();
            TotTaxTb = new TextBox();
            PaymentCB = new ComboBox();
            GrdTotal = new TextBox();
            discountTb = new TextBox();
            label15 = new Label();
            VATtb = new TextBox();
            label13 = new Label();
            label19 = new Label();
            Quantity = new TextBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            BtnEdit = new Button();
            panel2 = new Panel();
            button1 = new Button();
            button4 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)BillDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductsDVG).BeginInit();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(7, 9);
            label12.Name = "label12";
            label12.Size = new Size(66, 14);
            label12.TabIndex = 100;
            label12.Text = "Sub Total";
            label12.Click += label12_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(255, 128, 0);
            label10.Location = new Point(934, 490);
            label10.Name = "label10";
            label10.Size = new Size(44, 18);
            label10.TabIndex = 99;
            label10.Text = "Back";
            label10.Click += label10_Click;
            // 
            // BillDGV
            // 
            BillDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BillDGV.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            BillDGV.Location = new Point(32, 302);
            BillDGV.Name = "BillDGV";
            BillDGV.Size = new Size(382, 189);
            BillDGV.TabIndex = 89;
            BillDGV.CellContentClick += SupplierDGV_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Num";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Product";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Quantity";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Price";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "SubTotal";
            Column5.Name = "Column5";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(33, 159);
            label14.Name = "label14";
            label14.Size = new Size(130, 18);
            label14.TabIndex = 92;
            label14.Text = "Customer  Name";
            label14.Click += label14_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Teal;
            label8.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(10, 7);
            label8.Name = "label8";
            label8.Size = new Size(90, 18);
            label8.TabIndex = 18;
            label8.Text = "View Sales";
            label8.Click += label8_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(74, 13);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 88;
            label1.Text = "GPOS";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(32, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 86;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Teal;
            panel3.Controls.Add(label3);
            panel3.Location = new Point(293, 14);
            panel3.Name = "panel3";
            panel3.Size = new Size(154, 18);
            panel3.TabIndex = 87;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Teal;
            label3.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(2, 2);
            label3.Name = "label3";
            label3.Size = new Size(149, 13);
            label3.TabIndex = 5;
            label3.Text = "Point of Sale Version 17.0";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(392, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(665, 44);
            panel1.TabIndex = 84;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(253, 9);
            label2.Name = "label2";
            label2.Size = new Size(219, 19);
            label2.TabIndex = 4;
            label2.Text = "Point of Sale Version 17.0";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(615, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // CusNameCB
            // 
            CusNameCB.Location = new Point(32, 180);
            CusNameCB.Name = "CusNameCB";
            CusNameCB.Size = new Size(186, 23);
            CusNameCB.TabIndex = 96;
            CusNameCB.TextChanged += SupName_TextChanged;
            // 
            // CusIDCB
            // 
            CusIDCB.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CusIDCB.FormattingEnabled = true;
            CusIDCB.Location = new Point(32, 128);
            CusIDCB.Name = "CusIDCB";
            CusIDCB.Size = new Size(186, 25);
            CusIDCB.TabIndex = 101;
            CusIDCB.Text = "Customer ID";
            CusIDCB.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            CusIDCB.SelectionChangeCommitted += CusIDCB_SelectionChangeCommitted;
            CusIDCB.SelectedValueChanged += CusIDCB_SelectedValueChanged;
            // 
            // BDateCB
            // 
            BDateCB.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BDateCB.Format = DateTimePickerFormat.Short;
            BDateCB.Location = new Point(32, 225);
            BDateCB.Name = "BDateCB";
            BDateCB.Size = new Size(186, 23);
            BDateCB.TabIndex = 102;
            // 
            // panel4
            // 
            panel4.Controls.Add(button2);
            panel4.Controls.Add(AddBtn);
            panel4.Location = new Point(429, 197);
            panel4.Name = "panel4";
            panel4.Size = new Size(96, 189);
            panel4.TabIndex = 103;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(7, 105);
            button2.Name = "button2";
            button2.Padding = new Padding(5);
            button2.Size = new Size(86, 34);
            button2.TabIndex = 105;
            button2.Text = "Remove";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.Teal;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = Color.White;
            AddBtn.Image = (Image)resources.GetObject("AddBtn.Image");
            AddBtn.ImageAlign = ContentAlignment.MiddleRight;
            AddBtn.Location = new Point(7, 65);
            AddBtn.Name = "AddBtn";
            AddBtn.Padding = new Padding(5);
            AddBtn.Size = new Size(86, 34);
            AddBtn.TabIndex = 104;
            AddBtn.Text = "Add";
            AddBtn.TextAlign = ContentAlignment.MiddleLeft;
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // Search
            // 
            Search.Location = new Point(6, 33);
            Search.Multiline = true;
            Search.Name = "Search";
            Search.Size = new Size(307, 42);
            Search.TabIndex = 94;
            Search.TextChanged += Search_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox9);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(Search);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(531, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(506, 98);
            groupBox1.TabIndex = 104;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search By Product Name";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(404, 32);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(43, 43);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 5;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox9_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Teal;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(315, 32);
            button3.Name = "button3";
            button3.Padding = new Padding(5);
            button3.Size = new Size(87, 43);
            button3.TabIndex = 105;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // ProductsDVG
            // 
            ProductsDVG.BackgroundColor = Color.White;
            ProductsDVG.BorderStyle = BorderStyle.Fixed3D;
            ProductsDVG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsDVG.GridColor = Color.DimGray;
            ProductsDVG.Location = new Point(531, 197);
            ProductsDVG.Name = "ProductsDVG";
            ProductsDVG.ReadOnly = true;
            ProductsDVG.Size = new Size(511, 189);
            ProductsDVG.TabIndex = 89;
            ProductsDVG.CellContentClick += dataGridView1_CellContentClick;
            // 
            // SubTotal
            // 
            SubTotal.Location = new Point(81, 6);
            SubTotal.Name = "SubTotal";
            SubTotal.Size = new Size(122, 23);
            SubTotal.TabIndex = 106;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label18);
            panel5.Controls.Add(label16);
            panel5.Controls.Add(TotalDiscount);
            panel5.Controls.Add(label17);
            panel5.Controls.Add(TotTaxTb);
            panel5.Controls.Add(PaymentCB);
            panel5.Controls.Add(GrdTotal);
            panel5.Controls.Add(discountTb);
            panel5.Controls.Add(label15);
            panel5.Controls.Add(VATtb);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(SubTotal);
            panel5.Controls.Add(label12);
            panel5.Location = new Point(531, 392);
            panel5.Name = "panel5";
            panel5.Size = new Size(393, 117);
            panel5.TabIndex = 107;
            panel5.Paint += panel5_Paint;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(9, 95);
            label18.Name = "label18";
            label18.Size = new Size(63, 14);
            label18.TabIndex = 110;
            label18.Text = "Grd Total";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(9, 67);
            label16.Name = "label16";
            label16.Size = new Size(61, 14);
            label16.TabIndex = 110;
            label16.Text = "Discount";
            // 
            // TotalDiscount
            // 
            TotalDiscount.Location = new Point(193, 61);
            TotalDiscount.Name = "TotalDiscount";
            TotalDiscount.Size = new Size(75, 23);
            TotalDiscount.TabIndex = 109;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(163, 68);
            label17.Name = "label17";
            label17.Size = new Size(21, 14);
            label17.TabIndex = 108;
            label17.Text = "%";
            // 
            // TotTaxTb
            // 
            TotTaxTb.Enabled = false;
            TotTaxTb.Location = new Point(192, 34);
            TotTaxTb.Name = "TotTaxTb";
            TotTaxTb.Size = new Size(75, 23);
            TotTaxTb.TabIndex = 109;
            // 
            // PaymentCB
            // 
            PaymentCB.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PaymentCB.FormattingEnabled = true;
            PaymentCB.Items.AddRange(new object[] { "Momo", "Cash", "Credit", "Installment" });
            PaymentCB.Location = new Point(169, 87);
            PaymentCB.Name = "PaymentCB";
            PaymentCB.Size = new Size(130, 25);
            PaymentCB.TabIndex = 101;
            PaymentCB.Text = "Payment Method";
            PaymentCB.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // GrdTotal
            // 
            GrdTotal.Location = new Point(82, 89);
            GrdTotal.Name = "GrdTotal";
            GrdTotal.Size = new Size(75, 23);
            GrdTotal.TabIndex = 106;
            GrdTotal.TextChanged += GrdTotal_TextChanged;
            // 
            // discountTb
            // 
            discountTb.Location = new Point(82, 62);
            discountTb.Name = "discountTb";
            discountTb.Size = new Size(75, 23);
            discountTb.TabIndex = 106;
            discountTb.TextChanged += discountTb_TextChanged;
            discountTb.KeyPress += discountTb_KeyPress;
            discountTb.KeyUp += textBox5_KeyUp;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(165, 40);
            label15.Name = "label15";
            label15.Size = new Size(21, 14);
            label15.TabIndex = 108;
            label15.Text = "%";
            // 
            // VATtb
            // 
            VATtb.Location = new Point(82, 35);
            VATtb.Name = "VATtb";
            VATtb.Size = new Size(75, 23);
            VATtb.TabIndex = 106;
            VATtb.TextChanged += VATtb_TextChanged;
            VATtb.KeyDown += VATtb_KeyDown;
            VATtb.KeyPress += VATtb_KeyPress;
            VATtb.KeyUp += VATtb_KeyUp;
            VATtb.MouseLeave += VATtb_MouseLeave;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(9, 40);
            label13.Name = "label13";
            label13.Size = new Size(31, 14);
            label13.TabIndex = 107;
            label13.Text = "VAT";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(33, 267);
            label19.Name = "label19";
            label19.Size = new Size(73, 18);
            label19.TabIndex = 92;
            label19.Text = "Quantity";
            label19.Click += label14_Click;
            // 
            // Quantity
            // 
            Quantity.Location = new Point(107, 265);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(111, 23);
            Quantity.TabIndex = 96;
            Quantity.TextChanged += SupName_TextChanged;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            printPreviewDialog1.Load += printPreviewDialog1_Load;
            // 
            // BtnEdit
            // 
            BtnEdit.BackColor = Color.Teal;
            BtnEdit.FlatStyle = FlatStyle.Flat;
            BtnEdit.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEdit.ForeColor = Color.White;
            BtnEdit.Image = (Image)resources.GetObject("BtnEdit.Image");
            BtnEdit.ImageAlign = ContentAlignment.MiddleRight;
            BtnEdit.Location = new Point(934, 401);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Padding = new Padding(20, 0, 0, 0);
            BtnEdit.Size = new Size(108, 34);
            BtnEdit.TabIndex = 98;
            BtnEdit.Text = "Sale";
            BtnEdit.TextAlign = ContentAlignment.MiddleLeft;
            BtnEdit.UseVisualStyleBackColor = false;
            BtnEdit.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(label8);
            panel2.Location = new Point(932, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(108, 35);
            panel2.TabIndex = 108;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(934, 441);
            button1.Name = "button1";
            button1.Padding = new Padding(20, 0, 0, 0);
            button1.Size = new Size(108, 36);
            button1.TabIndex = 110;
            button1.Text = "Reset";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button4
            // 
            button4.BackColor = Color.Teal;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(805, 48);
            button4.Name = "button4";
            button4.Size = new Size(126, 35);
            button4.TabIndex = 111;
            button4.Text = "View Expiring";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(192, 0, 0);
            label4.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(211, 59);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 113;
            label4.Text = "Today's Sales:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Teal;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(218, 76);
            label5.Name = "label5";
            label5.Size = new Size(0, 21);
            label5.TabIndex = 114;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(192, 0, 0);
            label6.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(33, 59);
            label6.Name = "label6";
            label6.Size = new Size(154, 15);
            label6.TabIndex = 113;
            label6.Text = "Monthly Accom. Sales:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Teal;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(58, 74);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 44);
            textBox1.TabIndex = 116;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Teal;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(213, 74);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 45);
            textBox2.TabIndex = 116;
            // 
            // button5
            // 
            button5.BackColor = Color.Yellow;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(682, 48);
            button5.Name = "button5";
            button5.Size = new Size(120, 35);
            button5.TabIndex = 117;
            button5.Text = "Bill Details";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Billing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1044, 521);
            Controls.Add(button5);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(panel5);
            Controls.Add(groupBox1);
            Controls.Add(panel4);
            Controls.Add(BDateCB);
            Controls.Add(CusIDCB);
            Controls.Add(label10);
            Controls.Add(ProductsDVG);
            Controls.Add(BillDGV);
            Controls.Add(label19);
            Controls.Add(label14);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(BtnEdit);
            Controls.Add(Quantity);
            Controls.Add(CusNameCB);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Billing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing";
            Load += Billing_Load;
            ((System.ComponentModel.ISupportInitialize)BillDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductsDVG).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label12;
        private Label label10;
        private DataGridView BillDGV;
        private Label label14;
        private Label label8;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label label3;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox2;
        private TextBox CusNameCB;
        private ComboBox CusIDCB;
        private DateTimePicker BDateCB;
        private Panel panel4;
        private Button AddBtn;
        private TextBox Search;
        private GroupBox groupBox1;
        private Button button3;
        private DataGridView ProductsDVG;
        private TextBox SubTotal;
        private Panel panel5;
        private TextBox VATtb;
        private Label label13;
        private Label label18;
        private Label label16;
        private TextBox TotalDiscount;
        private Label label17;
        private TextBox TotTaxTb;
        private ComboBox PaymentCB;
        private TextBox GrdTotal;
        private TextBox discountTb;
        private Label label15;
        private Button button2;
        private PictureBox pictureBox9;
#pragma warning disable CS0169 // The field 'Billing.QtyTb' is never used
        private TextBox QtyTb;
#pragma warning restore CS0169 // The field 'Billing.QtyTb' is never used
        private Label label19;
        private TextBox Quantity;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Button BtnEdit;
        private Panel panel2;
        private Button button1;
        private Button button4;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button5;
        //  private TextBox QtyTb;
    }
}