namespace Shoes.GUI
{
    partial class Form_ADD
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
            this.grBImportnotedetail = new System.Windows.Forms.GroupBox();
            this.lblproductnamevalue = new System.Windows.Forms.Label();
            this.lblsoluong = new System.Windows.Forms.Label();
            this.cbproductid = new System.Windows.Forms.ComboBox();
            this.grbInfoHDdetail = new System.Windows.Forms.GroupBox();
            this.lblnum0 = new System.Windows.Forms.Label();
            this.lblnumtype = new System.Windows.Forms.Label();
            this.lblnum = new System.Windows.Forms.Label();
            this.lbldetailnum = new System.Windows.Forms.Label();
            this.btnExportPDF = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnResetdetail = new System.Windows.Forms.Button();
            this.btnDeleteDetail = new System.Windows.Forms.Button();
            this.btnAdddetail = new System.Windows.Forms.Button();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblProductAmount = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.adddetailDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbltotalmoney = new System.Windows.Forms.Label();
            this.lblSumHD = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grNote = new System.Windows.Forms.GroupBox();
            this.grbInfoDH = new System.Windows.Forms.GroupBox();
            this.lblSupplierId = new System.Windows.Forms.Label();
            this.lblNoteId = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHDid = new System.Windows.Forms.TextBox();
            this.tbSupplierID = new System.Windows.Forms.TextBox();
            this.tbNhapId = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grBTool = new System.Windows.Forms.GroupBox();
            this.btnResetGridView = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.addDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.btnEmpty = new System.Windows.Forms.Button();
            this.sqlCommand2 = new Microsoft.Data.SqlClient.SqlCommand();
            this.lblnumnote = new System.Windows.Forms.Label();
            this.lblDH = new System.Windows.Forms.Label();
            this.lblNCC = new System.Windows.Forms.Label();
            this.lblnumsupplier = new System.Windows.Forms.Label();
            this.noteIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notedetailIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grBImportnotedetail.SuspendLayout();
            this.grbInfoHDdetail.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adddetailDTOBindingSource)).BeginInit();
            this.grNote.SuspendLayout();
            this.grbInfoDH.SuspendLayout();
            this.grBTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grBImportnotedetail
            // 
            this.grBImportnotedetail.Controls.Add(this.lblproductnamevalue);
            this.grBImportnotedetail.Controls.Add(this.lblsoluong);
            this.grBImportnotedetail.Controls.Add(this.cbproductid);
            this.grBImportnotedetail.Controls.Add(this.grbInfoHDdetail);
            this.grBImportnotedetail.Controls.Add(this.btnExportPDF);
            this.grBImportnotedetail.Controls.Add(this.groupBox1);
            this.grBImportnotedetail.Controls.Add(this.tbQuantity);
            this.grBImportnotedetail.Controls.Add(this.tbPrice);
            this.grBImportnotedetail.Controls.Add(this.lblPrice);
            this.grBImportnotedetail.Controls.Add(this.lblQuantity);
            this.grBImportnotedetail.Controls.Add(this.lblProductAmount);
            this.grBImportnotedetail.Controls.Add(this.lblProductName);
            this.grBImportnotedetail.Controls.Add(this.lblProductId);
            this.grBImportnotedetail.Controls.Add(this.dataGridView2);
            this.grBImportnotedetail.Location = new System.Drawing.Point(525, 51);
            this.grBImportnotedetail.Name = "grBImportnotedetail";
            this.grBImportnotedetail.Size = new System.Drawing.Size(731, 570);
            this.grBImportnotedetail.TabIndex = 0;
            this.grBImportnotedetail.TabStop = false;
            this.grBImportnotedetail.Text = "Chi tiết Phiếu nhập";
            // 
            // lblproductnamevalue
            // 
            this.lblproductnamevalue.AutoSize = true;
            this.lblproductnamevalue.Location = new System.Drawing.Point(127, 69);
            this.lblproductnamevalue.Name = "lblproductnamevalue";
            this.lblproductnamevalue.Size = new System.Drawing.Size(45, 19);
            this.lblproductnamevalue.TabIndex = 15;
            this.lblproductnamevalue.Text = "Name";
            // 
            // lblsoluong
            // 
            this.lblsoluong.AutoSize = true;
            this.lblsoluong.Location = new System.Drawing.Point(127, 106);
            this.lblsoluong.Name = "lblsoluong";
            this.lblsoluong.Size = new System.Drawing.Size(17, 19);
            this.lblsoluong.TabIndex = 14;
            this.lblsoluong.Text = "0";
            // 
            // cbproductid
            // 
            this.cbproductid.FormattingEnabled = true;
            this.cbproductid.Location = new System.Drawing.Point(127, 30);
            this.cbproductid.Name = "cbproductid";
            this.cbproductid.Size = new System.Drawing.Size(244, 27);
            this.cbproductid.TabIndex = 13;
            this.cbproductid.SelectedIndexChanged += new System.EventHandler(this.cbproductid_SelectedIndexChanged);
            // 
            // grbInfoHDdetail
            // 
            this.grbInfoHDdetail.Controls.Add(this.lblnum0);
            this.grbInfoHDdetail.Controls.Add(this.lblnumtype);
            this.grbInfoHDdetail.Controls.Add(this.lblnum);
            this.grbInfoHDdetail.Controls.Add(this.lbldetailnum);
            this.grbInfoHDdetail.Location = new System.Drawing.Point(489, 19);
            this.grbInfoHDdetail.Name = "grbInfoHDdetail";
            this.grbInfoHDdetail.Size = new System.Drawing.Size(222, 106);
            this.grbInfoHDdetail.TabIndex = 12;
            this.grbInfoHDdetail.TabStop = false;
            this.grbInfoHDdetail.Text = "Thông tin chi tiết";
            // 
            // lblnum0
            // 
            this.lblnum0.AutoSize = true;
            this.lblnum0.Location = new System.Drawing.Point(183, 70);
            this.lblnum0.Name = "lblnum0";
            this.lblnum0.Size = new System.Drawing.Size(17, 19);
            this.lblnum0.TabIndex = 3;
            this.lblnum0.Text = "0";
            // 
            // lblnumtype
            // 
            this.lblnumtype.AutoSize = true;
            this.lblnumtype.Location = new System.Drawing.Point(21, 70);
            this.lblnumtype.Name = "lblnumtype";
            this.lblnumtype.Size = new System.Drawing.Size(159, 19);
            this.lblnumtype.TabIndex = 2;
            this.lblnumtype.Text = "Số lượng loại sản phẩm: ";
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Location = new System.Drawing.Point(183, 36);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(17, 19);
            this.lblnum.TabIndex = 1;
            this.lblnum.Text = "0";
            // 
            // lbldetailnum
            // 
            this.lbldetailnum.AutoSize = true;
            this.lbldetailnum.Location = new System.Drawing.Point(21, 36);
            this.lbldetailnum.Name = "lbldetailnum";
            this.lbldetailnum.Size = new System.Drawing.Size(166, 19);
            this.lbldetailnum.TabIndex = 0;
            this.lbldetailnum.Text = "Số lượng hóa đơn chi tiết:";
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.Location = new System.Drawing.Point(539, 144);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Size = new System.Drawing.Size(130, 32);
            this.btnExportPDF.TabIndex = 7;
            this.btnExportPDF.Text = "Xuất file PDF";
            this.btnExportPDF.UseVisualStyleBackColor = true;
            this.btnExportPDF.Click += new System.EventHandler(this.btnExportPDF_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnResetdetail);
            this.groupBox1.Controls.Add(this.btnDeleteDetail);
            this.groupBox1.Controls.Add(this.btnAdddetail);
            this.groupBox1.Location = new System.Drawing.Point(377, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 174);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnResetdetail
            // 
            this.btnResetdetail.Location = new System.Drawing.Point(6, 131);
            this.btnResetdetail.Name = "btnResetdetail";
            this.btnResetdetail.Size = new System.Drawing.Size(88, 26);
            this.btnResetdetail.TabIndex = 11;
            this.btnResetdetail.Text = "Reset";
            this.btnResetdetail.UseVisualStyleBackColor = true;
            this.btnResetdetail.Click += new System.EventHandler(this.btnResetdetail_Click);
            // 
            // btnDeleteDetail
            // 
            this.btnDeleteDetail.Location = new System.Drawing.Point(6, 78);
            this.btnDeleteDetail.Name = "btnDeleteDetail";
            this.btnDeleteDetail.Size = new System.Drawing.Size(88, 26);
            this.btnDeleteDetail.TabIndex = 9;
            this.btnDeleteDetail.Text = "Xóa";
            this.btnDeleteDetail.UseVisualStyleBackColor = true;
            this.btnDeleteDetail.Click += new System.EventHandler(this.btnDeleteDetail_Click);
            // 
            // btnAdddetail
            // 
            this.btnAdddetail.Location = new System.Drawing.Point(6, 25);
            this.btnAdddetail.Name = "btnAdddetail";
            this.btnAdddetail.Size = new System.Drawing.Size(88, 26);
            this.btnAdddetail.TabIndex = 7;
            this.btnAdddetail.Text = "Thêm";
            this.btnAdddetail.UseVisualStyleBackColor = true;
            this.btnAdddetail.Click += new System.EventHandler(this.btnAdddetail_Click);
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(127, 167);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(244, 26);
            this.tbQuantity.TabIndex = 10;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(127, 134);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(244, 26);
            this.tbPrice.TabIndex = 9;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(57, 137);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(64, 19);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Giá nhập";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(21, 170);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(100, 19);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Số lượng Nhập";
            // 
            // lblProductAmount
            // 
            this.lblProductAmount.AutoSize = true;
            this.lblProductAmount.Location = new System.Drawing.Point(55, 106);
            this.lblProductAmount.Name = "lblProductAmount";
            this.lblProductAmount.Size = new System.Drawing.Size(63, 19);
            this.lblProductAmount.TabIndex = 3;
            this.lblProductAmount.Text = "Số lượng";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(26, 69);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(95, 19);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Tên Sản phẩm";
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(27, 34);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(94, 19);
            this.lblProductId.TabIndex = 1;
            this.lblProductId.Text = "Mã Sản phẩm";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.notedetailIdDataGridViewTextBoxColumn,
            this.productIdDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productAmountDataGridViewTextBoxColumn,
            this.importPriceDataGridViewTextBoxColumn,
            this.importQuantityDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.adddetailDTOBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(17, 222);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(694, 326);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_RowHeaderMouseClick);
            // 
            // adddetailDTOBindingSource
            // 
            this.adddetailDTOBindingSource.DataSource = typeof(Shoes.DTO.adddetailDTO);
            // 
            // lbltotalmoney
            // 
            this.lbltotalmoney.AutoSize = true;
            this.lbltotalmoney.Location = new System.Drawing.Point(172, 604);
            this.lbltotalmoney.Name = "lbltotalmoney";
            this.lbltotalmoney.Size = new System.Drawing.Size(50, 19);
            this.lbltotalmoney.TabIndex = 12;
            this.lbltotalmoney.Text = "0 VND";
            // 
            // lblSumHD
            // 
            this.lblSumHD.AutoSize = true;
            this.lblSumHD.Location = new System.Drawing.Point(35, 604);
            this.lblSumHD.Name = "lblSumHD";
            this.lblSumHD.Size = new System.Drawing.Size(125, 19);
            this.lblSumHD.TabIndex = 3;
            this.lblSumHD.Text = "Tổng tiền hóa đơn:";
            // 
            // grNote
            // 
            this.grNote.Controls.Add(this.grbInfoDH);
            this.grNote.Controls.Add(this.tbNhapId);
            this.grNote.Controls.Add(this.btnSearch);
            this.grNote.Controls.Add(this.grBTool);
            this.grNote.Controls.Add(this.dgvHD);
            this.grNote.Location = new System.Drawing.Point(12, 12);
            this.grNote.Name = "grNote";
            this.grNote.Size = new System.Drawing.Size(507, 535);
            this.grNote.TabIndex = 1;
            this.grNote.TabStop = false;
            this.grNote.Text = "Đơn hàng";
            // 
            // grbInfoDH
            // 
            this.grbInfoDH.Controls.Add(this.lblSupplierId);
            this.grbInfoDH.Controls.Add(this.lblNoteId);
            this.grbInfoDH.Controls.Add(this.dateTimePicker1);
            this.grbInfoDH.Controls.Add(this.label1);
            this.grbInfoDH.Controls.Add(this.tbHDid);
            this.grbInfoDH.Controls.Add(this.tbSupplierID);
            this.grbInfoDH.Location = new System.Drawing.Point(6, 25);
            this.grbInfoDH.Name = "grbInfoDH";
            this.grbInfoDH.Size = new System.Drawing.Size(373, 179);
            this.grbInfoDH.TabIndex = 9;
            this.grbInfoDH.TabStop = false;
            this.grbInfoDH.Text = "Thông tin Phiếu nhập";
            // 
            // lblSupplierId
            // 
            this.lblSupplierId.AutoSize = true;
            this.lblSupplierId.Location = new System.Drawing.Point(-5, 86);
            this.lblSupplierId.Name = "lblSupplierId";
            this.lblSupplierId.Size = new System.Drawing.Size(115, 19);
            this.lblSupplierId.TabIndex = 5;
            this.lblSupplierId.Text = "Mã nhà cung cấp";
            // 
            // lblNoteId
            // 
            this.lblNoteId.AutoSize = true;
            this.lblNoteId.Location = new System.Drawing.Point(6, 36);
            this.lblNoteId.Name = "lblNoteId";
            this.lblNoteId.Size = new System.Drawing.Size(102, 19);
            this.lblNoteId.TabIndex = 1;
            this.lblNoteId.Text = "Mã Phiếu nhập";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(116, 129);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(117, 26);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ngày cung cấp";
            // 
            // tbHDid
            // 
            this.tbHDid.Location = new System.Drawing.Point(116, 33);
            this.tbHDid.Name = "tbHDid";
            this.tbHDid.Size = new System.Drawing.Size(232, 26);
            this.tbHDid.TabIndex = 3;
            // 
            // tbSupplierID
            // 
            this.tbSupplierID.Location = new System.Drawing.Point(116, 83);
            this.tbSupplierID.Name = "tbSupplierID";
            this.tbSupplierID.Size = new System.Drawing.Size(232, 26);
            this.tbSupplierID.TabIndex = 4;
            // 
            // tbNhapId
            // 
            this.tbNhapId.Location = new System.Drawing.Point(123, 221);
            this.tbNhapId.Name = "tbNhapId";
            this.tbNhapId.Size = new System.Drawing.Size(232, 26);
            this.tbNhapId.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(23, 221);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 26);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search Id";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grBTool
            // 
            this.grBTool.Controls.Add(this.btnResetGridView);
            this.grBTool.Controls.Add(this.btnDelete);
            this.grBTool.Controls.Add(this.btnEdit);
            this.grBTool.Controls.Add(this.btnAdd);
            this.grBTool.Location = new System.Drawing.Point(385, 58);
            this.grBTool.Name = "grBTool";
            this.grBTool.Size = new System.Drawing.Size(106, 189);
            this.grBTool.TabIndex = 1;
            this.grBTool.TabStop = false;
            this.grBTool.Text = "Chức năng";
            // 
            // btnResetGridView
            // 
            this.btnResetGridView.Location = new System.Drawing.Point(6, 152);
            this.btnResetGridView.Name = "btnResetGridView";
            this.btnResetGridView.Size = new System.Drawing.Size(88, 26);
            this.btnResetGridView.TabIndex = 10;
            this.btnResetGridView.Text = "Reset";
            this.btnResetGridView.UseVisualStyleBackColor = true;
            this.btnResetGridView.Click += new System.EventHandler(this.btnResetGridView_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 112);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 26);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(6, 66);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(88, 27);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 26);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvHD
            // 
            this.dgvHD.AutoGenerateColumns = false;
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noteIdDataGridViewTextBoxColumn,
            this.supplierIdDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dgvHD.DataSource = this.addDTOBindingSource;
            this.dgvHD.Location = new System.Drawing.Point(32, 261);
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.RowTemplate.Height = 28;
            this.dgvHD.Size = new System.Drawing.Size(458, 257);
            this.dgvHD.TabIndex = 0;
            this.dgvHD.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvHD_RowHeaderMouseClick);
            // 
            // addDTOBindingSource
            // 
            this.addDTOBindingSource.DataSource = typeof(Shoes.DTO.addDTO);
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // btnEmpty
            // 
            this.btnEmpty.Location = new System.Drawing.Point(525, 12);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Size = new System.Drawing.Size(97, 33);
            this.btnEmpty.TabIndex = 6;
            this.btnEmpty.Text = "Empty";
            this.btnEmpty.UseVisualStyleBackColor = true;
            this.btnEmpty.Click += new System.EventHandler(this.btnEmpty_Click);
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandTimeout = 30;
            this.sqlCommand2.EnableOptimizedParameterBinding = false;
            // 
            // lblnumnote
            // 
            this.lblnumnote.AutoSize = true;
            this.lblnumnote.Location = new System.Drawing.Point(172, 560);
            this.lblnumnote.Name = "lblnumnote";
            this.lblnumnote.Size = new System.Drawing.Size(17, 19);
            this.lblnumnote.TabIndex = 8;
            this.lblnumnote.Text = "0";
            // 
            // lblDH
            // 
            this.lblDH.AutoSize = true;
            this.lblDH.Location = new System.Drawing.Point(35, 560);
            this.lblDH.Name = "lblDH";
            this.lblDH.Size = new System.Drawing.Size(131, 19);
            this.lblDH.TabIndex = 9;
            this.lblDH.Text = "Số lượng Đơn hàng:";
            // 
            // lblNCC
            // 
            this.lblNCC.AutoSize = true;
            this.lblNCC.Location = new System.Drawing.Point(229, 560);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Size = new System.Drawing.Size(152, 19);
            this.lblNCC.TabIndex = 10;
            this.lblNCC.Text = "Số lượng nhà cung cấp:";
            // 
            // lblnumsupplier
            // 
            this.lblnumsupplier.AutoSize = true;
            this.lblnumsupplier.Location = new System.Drawing.Point(387, 560);
            this.lblnumsupplier.Name = "lblnumsupplier";
            this.lblnumsupplier.Size = new System.Drawing.Size(17, 19);
            this.lblnumsupplier.TabIndex = 11;
            this.lblnumsupplier.Text = "0";
            // 
            // noteIdDataGridViewTextBoxColumn
            // 
            this.noteIdDataGridViewTextBoxColumn.DataPropertyName = "NoteId";
            this.noteIdDataGridViewTextBoxColumn.HeaderText = "Mã Phiếu nhập";
            this.noteIdDataGridViewTextBoxColumn.Name = "noteIdDataGridViewTextBoxColumn";
            this.noteIdDataGridViewTextBoxColumn.Width = 130;
            // 
            // supplierIdDataGridViewTextBoxColumn
            // 
            this.supplierIdDataGridViewTextBoxColumn.DataPropertyName = "SupplierId";
            this.supplierIdDataGridViewTextBoxColumn.HeaderText = "Mã nhà cung cấp";
            this.supplierIdDataGridViewTextBoxColumn.Name = "supplierIdDataGridViewTextBoxColumn";
            this.supplierIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Ngày nhập";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 145;
            // 
            // notedetailIdDataGridViewTextBoxColumn
            // 
            this.notedetailIdDataGridViewTextBoxColumn.DataPropertyName = "NotedetailId";
            this.notedetailIdDataGridViewTextBoxColumn.HeaderText = "Mã Phiếu nhập";
            this.notedetailIdDataGridViewTextBoxColumn.Name = "notedetailIdDataGridViewTextBoxColumn";
            this.notedetailIdDataGridViewTextBoxColumn.Width = 140;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "Mã sản phẩm";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.Width = 118;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Tên sản phẩm";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 180;
            // 
            // productAmountDataGridViewTextBoxColumn
            // 
            this.productAmountDataGridViewTextBoxColumn.DataPropertyName = "ProductAmount";
            this.productAmountDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.productAmountDataGridViewTextBoxColumn.Name = "productAmountDataGridViewTextBoxColumn";
            this.productAmountDataGridViewTextBoxColumn.Width = 90;
            // 
            // importPriceDataGridViewTextBoxColumn
            // 
            this.importPriceDataGridViewTextBoxColumn.DataPropertyName = "ImportPrice";
            this.importPriceDataGridViewTextBoxColumn.HeaderText = "Giá nhập";
            this.importPriceDataGridViewTextBoxColumn.Name = "importPriceDataGridViewTextBoxColumn";
            this.importPriceDataGridViewTextBoxColumn.Width = 90;
            // 
            // importQuantityDataGridViewTextBoxColumn
            // 
            this.importQuantityDataGridViewTextBoxColumn.DataPropertyName = "ImportQuantity";
            this.importQuantityDataGridViewTextBoxColumn.HeaderText = "Số lượng nhập";
            this.importQuantityDataGridViewTextBoxColumn.Name = "importQuantityDataGridViewTextBoxColumn";
            this.importQuantityDataGridViewTextBoxColumn.Width = 123;
            // 
            // Form_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 642);
            this.Controls.Add(this.lbltotalmoney);
            this.Controls.Add(this.lblnumsupplier);
            this.Controls.Add(this.lblNCC);
            this.Controls.Add(this.lblDH);
            this.Controls.Add(this.lblnumnote);
            this.Controls.Add(this.lblSumHD);
            this.Controls.Add(this.btnEmpty);
            this.Controls.Add(this.grNote);
            this.Controls.Add(this.grBImportnotedetail);
            this.Name = "Form_ADD";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Form_ADD_Load);
            this.grBImportnotedetail.ResumeLayout(false);
            this.grBImportnotedetail.PerformLayout();
            this.grbInfoHDdetail.ResumeLayout(false);
            this.grbInfoHDdetail.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adddetailDTOBindingSource)).EndInit();
            this.grNote.ResumeLayout(false);
            this.grNote.PerformLayout();
            this.grbInfoDH.ResumeLayout(false);
            this.grbInfoDH.PerformLayout();
            this.grBTool.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grBImportnotedetail;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox grNote;
        private Label lblSumHD;
        private Label lblNoteId;
        private DataGridView dgvHD;
        private DataGridView dataGridView2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TextBox tbHDid;
        private DateTimePicker dateTimePicker1;
        private TextBox tbSupplierID;
        private Label lblSupplierId;
        private Label label1;
        private Button btnAdd;
        private Button btnEmpty;
        private Button btnExportPDF;
        private Button btnEdit;
        private GroupBox grBTool;
        private Button btnDelete;
        private Button btnSearch;
        private TextBox tbNhapId;
        private Button btnResetGridView;
        private Label lblProductId;
        private Label lblProductName;
        private Label lblProductAmount;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand2;
        private Label lblQuantity;
        private Label lblPrice;
        private TextBox tbPrice;
        private TextBox tbQuantity;
        private GroupBox groupBox1;
        private Button btnDeleteDetail;
        private Button btnAdddetail;
        private BindingSource adddetailDTOBindingSource;
        private BindingSource addDTOBindingSource;
        private Button btnResetdetail;
        private Label lblnumnote;
        private Label lblDH;
        private Label lblNCC;
        private Label lblnumsupplier;
        private GroupBox grbInfoDH;
        private GroupBox grbInfoHDdetail;
        private Label lblnum;
        private Label lbldetailnum;
        private Label lblnum0;
        private Label lblnumtype;
        private Label lbltotalmoney;
        private ComboBox cbproductid;
        private Label lblsoluong;
        private Label lblproductnamevalue;
        private DataGridViewTextBoxColumn notedetailIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productAmountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn importPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn importQuantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn noteIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn supplierIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}