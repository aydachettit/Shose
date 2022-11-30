namespace Shoes.GUI
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
            this.productIDLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productAmountLabel = new System.Windows.Forms.Label();
            this.productPriceLabel = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.totalMoneyLabel = new System.Windows.Forms.Label();
            this.receiptIDLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.receiptdetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shoestoreDataSet = new Shoes.GUI.shoestoreDataSet();
            this.cboMaKhachHang = new System.Windows.Forms.ComboBox();
            this.receiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.cboxGioiTinh = new System.Windows.Forms.CheckBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboMaNhanVien = new System.Windows.Forms.ComboBox();
            this.dateReceipt = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSuaHoaDon = new System.Windows.Forms.Button();
            this.btnSuaSanPham = new System.Windows.Forms.Button();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.shoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelBangChu = new System.Windows.Forms.Label();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.cboMaSanPham = new System.Windows.Forms.ComboBox();
            this.btnThemSanPham = new System.Windows.Forms.Button();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnXoaHoaDon = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnThemHoaDon = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTongCong = new System.Windows.Forms.TextBox();
            this.receiptdetailDataGridView = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableAdapterManager = new Shoes.GUI.shoestoreDataSetTableAdapters.TableAdapterManager();
            this.employeeTableAdapter = new Shoes.GUI.shoestoreDataSetTableAdapters.employeeTableAdapter();
            this.receiptdetailTableAdapter = new Shoes.GUI.shoestoreDataSetTableAdapters.receiptdetailTableAdapter();
            this.receiptTableAdapter = new Shoes.GUI.shoestoreDataSetTableAdapters.receiptTableAdapter();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.importnotedetailTableAdapter = new Shoes.GUI.shoestoreDataSetTableAdapters.importnotedetailTableAdapter();
            this.customerTableAdapter = new Shoes.GUI.shoestoreDataSetTableAdapters.customerTableAdapter();
            this.shoesTableAdapter = new Shoes.GUI.shoestoreDataSetTableAdapters.shoesTableAdapter();
            this.shoesibfkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productidfkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customeribfkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboMaHoaDon = new System.Windows.Forms.ComboBox();
            this.labelSoluongHD = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiptdetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoestoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptdetailDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoesibfkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productidfkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customeribfkBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productIDLabel
            // 
            this.productIDLabel.AutoSize = true;
            this.productIDLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.productIDLabel.Location = new System.Drawing.Point(18, 26);
            this.productIDLabel.Name = "productIDLabel";
            this.productIDLabel.Size = new System.Drawing.Size(71, 13);
            this.productIDLabel.TabIndex = 2;
            this.productIDLabel.Text = "Mã sản phẩm";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.productNameLabel.Location = new System.Drawing.Point(18, 53);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(75, 13);
            this.productNameLabel.TabIndex = 4;
            this.productNameLabel.Text = "Tên sản phẩm";
            // 
            // productAmountLabel
            // 
            this.productAmountLabel.AutoSize = true;
            this.productAmountLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.productAmountLabel.Location = new System.Drawing.Point(288, 26);
            this.productAmountLabel.Name = "productAmountLabel";
            this.productAmountLabel.Size = new System.Drawing.Size(49, 13);
            this.productAmountLabel.TabIndex = 6;
            this.productAmountLabel.Text = "Số lượng";
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.productPriceLabel.Location = new System.Drawing.Point(288, 52);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(44, 13);
            this.productPriceLabel.TabIndex = 8;
            this.productPriceLabel.Text = "Đơn giá";
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.moneyLabel.Location = new System.Drawing.Point(513, 26);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(58, 13);
            this.moneyLabel.TabIndex = 10;
            this.moneyLabel.Text = "Thành tiền";
            // 
            // totalMoneyLabel
            // 
            this.totalMoneyLabel.AutoSize = true;
            this.totalMoneyLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.totalMoneyLabel.Location = new System.Drawing.Point(328, 232);
            this.totalMoneyLabel.Name = "totalMoneyLabel";
            this.totalMoneyLabel.Size = new System.Drawing.Size(62, 13);
            this.totalMoneyLabel.TabIndex = 11;
            this.totalMoneyLabel.Text = "Tổng cộng:";
            // 
            // receiptIDLabel
            // 
            this.receiptIDLabel.AutoSize = true;
            this.receiptIDLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.receiptIDLabel.Location = new System.Drawing.Point(48, 528);
            this.receiptIDLabel.Name = "receiptIDLabel";
            this.receiptIDLabel.Size = new System.Drawing.Size(65, 13);
            this.receiptIDLabel.TabIndex = 3;
            this.receiptIDLabel.Text = "Mã hóa đơn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaHoaDon);
            this.groupBox1.Controls.Add(this.cboMaKhachHang);
            this.groupBox1.Controls.Add(this.txtTenKhachHang);
            this.groupBox1.Controls.Add(this.cboxGioiTinh);
            this.groupBox1.Controls.Add(this.txtDienThoai);
            this.groupBox1.Controls.Add(this.txtTenNhanVien);
            this.groupBox1.Controls.Add(this.cboMaNhanVien);
            this.groupBox1.Controls.Add(this.dateReceipt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(24, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptdetailBindingSource, "ReceiptID", true));
            this.txtMaHoaDon.Enabled = false;
            this.txtMaHoaDon.Location = new System.Drawing.Point(110, 25);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(242, 20);
            this.txtMaHoaDon.TabIndex = 28;
            // 
            // receiptdetailBindingSource
            // 
            this.receiptdetailBindingSource.DataMember = "receiptdetail";
            this.receiptdetailBindingSource.DataSource = this.shoestoreDataSet;
            // 
            // shoestoreDataSet
            // 
            this.shoestoreDataSet.DataSetName = "shoestoreDataSet";
            this.shoestoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboMaKhachHang
            // 
            this.cboMaKhachHang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptBindingSource, "CustomerID", true));
            this.cboMaKhachHang.DataSource = this.customerBindingSource;
            this.cboMaKhachHang.DisplayMember = "CustomerID";
            this.cboMaKhachHang.FormattingEnabled = true;
            this.cboMaKhachHang.Location = new System.Drawing.Point(469, 25);
            this.cboMaKhachHang.Name = "cboMaKhachHang";
            this.cboMaKhachHang.Size = new System.Drawing.Size(236, 21);
            this.cboMaKhachHang.TabIndex = 27;
            // 
            // receiptBindingSource
            // 
            this.receiptBindingSource.DataMember = "receipt";
            this.receiptBindingSource.DataSource = this.shoestoreDataSet;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.shoestoreDataSet;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Name", true));
            this.txtTenKhachHang.Enabled = false;
            this.txtTenKhachHang.Location = new System.Drawing.Point(469, 54);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(236, 20);
            this.txtTenKhachHang.TabIndex = 22;
            // 
            // cboxGioiTinh
            // 
            this.cboxGioiTinh.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.customerBindingSource, "Gender", true));
            this.cboxGioiTinh.Enabled = false;
            this.cboxGioiTinh.Location = new System.Drawing.Point(469, 107);
            this.cboxGioiTinh.Name = "cboxGioiTinh";
            this.cboxGioiTinh.Size = new System.Drawing.Size(216, 24);
            this.cboxGioiTinh.TabIndex = 24;
            this.cboxGioiTinh.Text = "Nam";
            this.cboxGioiTinh.UseVisualStyleBackColor = true;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Phone", true));
            this.txtDienThoai.Enabled = false;
            this.txtDienThoai.Location = new System.Drawing.Point(469, 84);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(236, 20);
            this.txtDienThoai.TabIndex = 26;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmployeeName", true));
            this.txtTenNhanVien.Enabled = false;
            this.txtTenNhanVien.Location = new System.Drawing.Point(110, 112);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(242, 20);
            this.txtTenNhanVien.TabIndex = 19;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.shoestoreDataSet;
            // 
            // cboMaNhanVien
            // 
            this.cboMaNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptBindingSource, "EmployeeID", true));
            this.cboMaNhanVien.DataSource = this.employeeBindingSource;
            this.cboMaNhanVien.DisplayMember = "EmployeeID";
            this.cboMaNhanVien.FormattingEnabled = true;
            this.cboMaNhanVien.Location = new System.Drawing.Point(110, 81);
            this.cboMaNhanVien.Name = "cboMaNhanVien";
            this.cboMaNhanVien.Size = new System.Drawing.Size(242, 21);
            this.cboMaNhanVien.TabIndex = 18;
            // 
            // dateReceipt
            // 
            this.dateReceipt.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.receiptBindingSource, "ReceiptDate", true));
            this.dateReceipt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateReceipt.Location = new System.Drawing.Point(110, 54);
            this.dateReceipt.Name = "dateReceipt";
            this.dateReceipt.Size = new System.Drawing.Size(242, 20);
            this.dateReceipt.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(377, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Giới tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(377, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tên khách hàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(377, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Số điện thoại";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(377, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Mã khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(19, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(19, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày bán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(19, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(19, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSuaHoaDon);
            this.groupBox2.Controls.Add(this.btnSuaSanPham);
            this.groupBox2.Controls.Add(this.txtDonGia);
            this.groupBox2.Controls.Add(this.labelBangChu);
            this.groupBox2.Controls.Add(this.txtTenSanPham);
            this.groupBox2.Controls.Add(this.cboMaSanPham);
            this.groupBox2.Controls.Add(this.btnThemSanPham);
            this.groupBox2.Controls.Add(this.btnInHoaDon);
            this.groupBox2.Controls.Add(this.btnXoaHoaDon);
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.btnThemHoaDon);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.totalMoneyLabel);
            this.groupBox2.Controls.Add(this.txtTongCong);
            this.groupBox2.Controls.Add(this.receiptdetailDataGridView);
            this.groupBox2.Controls.Add(this.productIDLabel);
            this.groupBox2.Controls.Add(this.productNameLabel);
            this.groupBox2.Controls.Add(this.productAmountLabel);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.productPriceLabel);
            this.groupBox2.Controls.Add(this.moneyLabel);
            this.groupBox2.Controls.Add(this.txtThanhTien);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(24, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(753, 331);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin các mặt hàng";
            // 
            // btnSuaHoaDon
            // 
            this.btnSuaHoaDon.BackColor = System.Drawing.Color.DarkRed;
            this.btnSuaHoaDon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSuaHoaDon.Location = new System.Drawing.Point(324, 286);
            this.btnSuaHoaDon.Name = "btnSuaHoaDon";
            this.btnSuaHoaDon.Size = new System.Drawing.Size(89, 30);
            this.btnSuaHoaDon.TabIndex = 31;
            this.btnSuaHoaDon.Text = "Sửa hóa đơn";
            this.btnSuaHoaDon.UseVisualStyleBackColor = false;
            this.btnSuaHoaDon.Click += new System.EventHandler(this.btnSuaHoaDon_Click);
            // 
            // btnSuaSanPham
            // 
            this.btnSuaSanPham.BackColor = System.Drawing.Color.DarkRed;
            this.btnSuaSanPham.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSuaSanPham.Location = new System.Drawing.Point(430, 286);
            this.btnSuaSanPham.Name = "btnSuaSanPham";
            this.btnSuaSanPham.Size = new System.Drawing.Size(89, 30);
            this.btnSuaSanPham.TabIndex = 30;
            this.btnSuaSanPham.Text = "Sửa sản phẩm";
            this.btnSuaSanPham.UseVisualStyleBackColor = false;
            this.btnSuaSanPham.Click += new System.EventHandler(this.btnSuaSanPham_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shoesBindingSource, "ProductPrice", true));
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Location = new System.Drawing.Point(349, 50);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(154, 20);
            this.txtDonGia.TabIndex = 29;
            this.txtDonGia.TextChanged += new System.EventHandler(this.txtDonGia_TextChanged);
            // 
            // shoesBindingSource
            // 
            this.shoesBindingSource.DataMember = "shoes";
            this.shoesBindingSource.DataSource = this.shoestoreDataSet;
            // 
            // labelBangChu
            // 
            this.labelBangChu.AutoSize = true;
            this.labelBangChu.ForeColor = System.Drawing.Color.DarkRed;
            this.labelBangChu.Location = new System.Drawing.Point(328, 257);
            this.labelBangChu.Name = "labelBangChu";
            this.labelBangChu.Size = new System.Drawing.Size(59, 13);
            this.labelBangChu.TabIndex = 28;
            this.labelBangChu.Text = "Bằng chữ: ";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shoesBindingSource, "ProductName", true));
            this.txtTenSanPham.Enabled = false;
            this.txtTenSanPham.Location = new System.Drawing.Point(95, 50);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(172, 20);
            this.txtTenSanPham.TabIndex = 20;
            // 
            // cboMaSanPham
            // 
            this.cboMaSanPham.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptdetailBindingSource, "ProductID", true));
            this.cboMaSanPham.DataSource = this.shoesBindingSource;
            this.cboMaSanPham.DisplayMember = "ProductID";
            this.cboMaSanPham.FormattingEnabled = true;
            this.cboMaSanPham.Location = new System.Drawing.Point(95, 22);
            this.cboMaSanPham.Name = "cboMaSanPham";
            this.cboMaSanPham.Size = new System.Drawing.Size(172, 21);
            this.cboMaSanPham.TabIndex = 27;
            // 
            // btnThemSanPham
            // 
            this.btnThemSanPham.BackColor = System.Drawing.Color.DarkRed;
            this.btnThemSanPham.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThemSanPham.Location = new System.Drawing.Point(649, 286);
            this.btnThemSanPham.Name = "btnThemSanPham";
            this.btnThemSanPham.Size = new System.Drawing.Size(98, 30);
            this.btnThemSanPham.TabIndex = 18;
            this.btnThemSanPham.Text = "Thêm sản phẩm";
            this.btnThemSanPham.UseVisualStyleBackColor = false;
            this.btnThemSanPham.Click += new System.EventHandler(this.btnThemSanPham_Click);
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.BackColor = System.Drawing.Color.DarkRed;
            this.btnInHoaDon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInHoaDon.Location = new System.Drawing.Point(541, 286);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(89, 30);
            this.btnInHoaDon.TabIndex = 17;
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = false;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // btnXoaHoaDon
            // 
            this.btnXoaHoaDon.BackColor = System.Drawing.Color.DarkRed;
            this.btnXoaHoaDon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoaHoaDon.Location = new System.Drawing.Point(221, 286);
            this.btnXoaHoaDon.Name = "btnXoaHoaDon";
            this.btnXoaHoaDon.Size = new System.Drawing.Size(89, 30);
            this.btnXoaHoaDon.TabIndex = 16;
            this.btnXoaHoaDon.Text = "Xóa hóa đơn";
            this.btnXoaHoaDon.UseVisualStyleBackColor = false;
            this.btnXoaHoaDon.Click += new System.EventHandler(this.btnXoaHoaDon_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DarkRed;
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(110, 286);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 30);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnThemHoaDon
            // 
            this.btnThemHoaDon.BackColor = System.Drawing.Color.DarkRed;
            this.btnThemHoaDon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThemHoaDon.Location = new System.Drawing.Point(6, 286);
            this.btnThemHoaDon.Name = "btnThemHoaDon";
            this.btnThemHoaDon.Size = new System.Drawing.Size(89, 30);
            this.btnThemHoaDon.TabIndex = 14;
            this.btnThemHoaDon.Text = "Thêm hóa đơn";
            this.btnThemHoaDon.UseVisualStyleBackColor = false;
            this.btnThemHoaDon.Click += new System.EventHandler(this.btnThemHoaDon_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(22, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Nháy đúp một dòng để xóa";
            // 
            // txtTongCong
            // 
            this.txtTongCong.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptBindingSource, "TotalMoney", true));
            this.txtTongCong.Enabled = false;
            this.txtTongCong.Location = new System.Drawing.Point(396, 228);
            this.txtTongCong.Name = "txtTongCong";
            this.txtTongCong.Size = new System.Drawing.Size(202, 20);
            this.txtTongCong.TabIndex = 12;
            this.txtTongCong.TextChanged += new System.EventHandler(this.txtTongCong_TextChanged);
            // 
            // receiptdetailDataGridView
            // 
            this.receiptdetailDataGridView.AutoGenerateColumns = false;
            this.receiptdetailDataGridView.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.receiptdetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receiptdetailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productAmountDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn,
            this.moneyDataGridViewTextBoxColumn});
            this.receiptdetailDataGridView.DataSource = this.receiptdetailBindingSource;
            this.receiptdetailDataGridView.GridColor = System.Drawing.Color.Silver;
            this.receiptdetailDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.receiptdetailDataGridView.Location = new System.Drawing.Point(21, 85);
            this.receiptdetailDataGridView.Name = "receiptdetailDataGridView";
            this.receiptdetailDataGridView.Size = new System.Drawing.Size(703, 132);
            this.receiptdetailDataGridView.TabIndex = 11;
            this.receiptdetailDataGridView.DoubleClick += new System.EventHandler(this.receiptdetailDataGridView_DoubleClick);
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Mã sản ";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Tên sản phẩm";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // productAmountDataGridViewTextBoxColumn
            // 
            this.productAmountDataGridViewTextBoxColumn.DataPropertyName = "ProductAmount";
            this.productAmountDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.productAmountDataGridViewTextBoxColumn.Name = "productAmountDataGridViewTextBoxColumn";
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            this.productPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductPrice";
            this.productPriceDataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            // 
            // moneyDataGridViewTextBoxColumn
            // 
            this.moneyDataGridViewTextBoxColumn.DataPropertyName = "Money";
            this.moneyDataGridViewTextBoxColumn.HeaderText = "Thành tiền";
            this.moneyDataGridViewTextBoxColumn.Name = "moneyDataGridViewTextBoxColumn";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptdetailBindingSource, "ProductAmount", true));
            this.txtSoLuong.Location = new System.Drawing.Point(349, 24);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(154, 20);
            this.txtSoLuong.TabIndex = 7;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptdetailBindingSource, "Money", true));
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Location = new System.Drawing.Point(577, 23);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(147, 20);
            this.txtThanhTien.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(286, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.accountTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customerTableAdapter = null;
            this.tableAdapterManager.employeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.importnotedetailTableAdapter = null;
            this.tableAdapterManager.importnoteTableAdapter = null;
            this.tableAdapterManager.receiptdetailTableAdapter = this.receiptdetailTableAdapter;
            this.tableAdapterManager.receiptTableAdapter = this.receiptTableAdapter;
            this.tableAdapterManager.shoesTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Shoes.GUI.shoestoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // receiptdetailTableAdapter
            // 
            this.receiptdetailTableAdapter.ClearBeforeFill = true;
            // 
            // receiptTableAdapter
            // 
            this.receiptTableAdapter.ClearBeforeFill = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.DarkRed;
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimKiem.Location = new System.Drawing.Point(281, 517);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 30);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // importnotedetailTableAdapter
            // 
            this.importnotedetailTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // shoesTableAdapter
            // 
            this.shoesTableAdapter.ClearBeforeFill = true;
            // 
            // shoesibfkBindingSource
            // 
            this.shoesibfkBindingSource.DataMember = "Shoes_ibfk";
            this.shoesibfkBindingSource.DataSource = this.shoesBindingSource;
            // 
            // productidfkBindingSource
            // 
            this.productidfkBindingSource.DataMember = "product_idfk";
            this.productidfkBindingSource.DataSource = this.shoesBindingSource;
            // 
            // customeribfkBindingSource
            // 
            this.customeribfkBindingSource.DataMember = "Customer_ibfk";
            this.customeribfkBindingSource.DataSource = this.customerBindingSource;
            // 
            // cboMaHoaDon
            // 
            this.cboMaHoaDon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptBindingSource, "ReceiptID", true));
            this.cboMaHoaDon.FormattingEnabled = true;
            this.cboMaHoaDon.Location = new System.Drawing.Point(121, 523);
            this.cboMaHoaDon.Name = "cboMaHoaDon";
            this.cboMaHoaDon.Size = new System.Drawing.Size(154, 21);
            this.cboMaHoaDon.TabIndex = 6;
            this.cboMaHoaDon.DataSourceChanged += new System.EventHandler(this.cboMaHoaDon_DataSourceChanged);
            // 
            // labelSoluongHD
            // 
            this.labelSoluongHD.AutoSize = true;
            this.labelSoluongHD.ForeColor = System.Drawing.Color.DarkRed;
            this.labelSoluongHD.Location = new System.Drawing.Point(373, 526);
            this.labelSoluongHD.Name = "labelSoluongHD";
            this.labelSoluongHD.Size = new System.Drawing.Size(98, 13);
            this.labelSoluongHD.TabIndex = 8;
            this.labelSoluongHD.Text = "Số lượng hóa đơn: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.labelSoluongHD);
            this.Controls.Add(this.cboMaHoaDon);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.receiptIDLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Hóa đơn bán hàng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiptdetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoestoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptdetailDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoesibfkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productidfkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customeribfkBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private shoestoreDataSet shoestoreDataSet;
        private shoestoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private shoestoreDataSetTableAdapters.receiptTableAdapter receiptTableAdapter;
        private System.Windows.Forms.BindingSource receiptBindingSource;
        private System.Windows.Forms.ComboBox cboMaNhanVien;
        private System.Windows.Forms.DateTimePicker dateReceipt;
        private shoestoreDataSetTableAdapters.employeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private shoestoreDataSetTableAdapters.receiptdetailTableAdapter receiptdetailTableAdapter;
        private System.Windows.Forms.BindingSource receiptdetailBindingSource;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnXoaHoaDon;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnThemHoaDon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTongCong;
        private System.Windows.Forms.DataGridView receiptdetailDataGridView;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThemSanPham;
        private shoestoreDataSetTableAdapters.importnotedetailTableAdapter importnotedetailTableAdapter;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private shoestoreDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.CheckBox cboxGioiTinh;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.BindingSource shoesBindingSource;
        private shoestoreDataSetTableAdapters.shoesTableAdapter shoesTableAdapter;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.BindingSource customeribfkBindingSource;
        private System.Windows.Forms.BindingSource productidfkBindingSource;
        private System.Windows.Forms.BindingSource shoesibfkBindingSource;
        private System.Windows.Forms.ComboBox cboMaKhachHang;
        private System.Windows.Forms.ComboBox cboMaSanPham;
        private System.Windows.Forms.Label labelBangChu;
        private System.Windows.Forms.ComboBox cboMaHoaDon;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSuaSanPham;
        private System.Windows.Forms.Button btnSuaHoaDon;
        private System.Windows.Forms.Label labelSoluongHD;
        private System.Windows.Forms.Label productIDLabel;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label productAmountLabel;
        private System.Windows.Forms.Label productPriceLabel;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label totalMoneyLabel;
        private System.Windows.Forms.Label receiptIDLabel;
    }
}

