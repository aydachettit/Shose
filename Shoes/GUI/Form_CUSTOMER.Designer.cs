namespace Shoes.GUI
{
    partial class Form_CUSTOMER
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
            this.grBInfo = new System.Windows.Forms.GroupBox();
            this.CBGender = new System.Windows.Forms.ComboBox();
            this.tbCustomerId = new System.Windows.Forms.TextBox();
            this.tbCustomerPhone = new System.Windows.Forms.TextBox();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblphnumber = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.lblKhachhang = new System.Windows.Forms.Label();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerGenderDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.customerPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.grBNumberCustumer = new System.Windows.Forms.GroupBox();
            this.lblNumFemale = new System.Windows.Forms.Label();
            this.lblNumMale = new System.Windows.Forms.Label();
            this.lblNumCustomer = new System.Windows.Forms.Label();
            this.rdBNu = new System.Windows.Forms.RadioButton();
            this.lblFemaleCus = new System.Windows.Forms.Label();
            this.lblMaleCus = new System.Windows.Forms.Label();
            this.rdBNam = new System.Windows.Forms.RadioButton();
            this.lblCus = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.grBInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDTOBindingSource)).BeginInit();
            this.grBNumberCustumer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grBInfo
            // 
            this.grBInfo.Controls.Add(this.CBGender);
            this.grBInfo.Controls.Add(this.tbCustomerId);
            this.grBInfo.Controls.Add(this.tbCustomerPhone);
            this.grBInfo.Controls.Add(this.tbCustomerName);
            this.grBInfo.Controls.Add(this.lblGender);
            this.grBInfo.Controls.Add(this.lblphnumber);
            this.grBInfo.Controls.Add(this.lblMaKH);
            this.grBInfo.Controls.Add(this.lblKhachhang);
            this.grBInfo.Location = new System.Drawing.Point(85, 28);
            this.grBInfo.Name = "grBInfo";
            this.grBInfo.Size = new System.Drawing.Size(816, 143);
            this.grBInfo.TabIndex = 1;
            this.grBInfo.TabStop = false;
            this.grBInfo.Text = "Thông tin khách hàng";
            // 
            // CBGender
            // 
            this.CBGender.FormattingEnabled = true;
            this.CBGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.CBGender.Location = new System.Drawing.Point(538, 100);
            this.CBGender.Name = "CBGender";
            this.CBGender.Size = new System.Drawing.Size(251, 27);
            this.CBGender.TabIndex = 8;
            this.CBGender.Text = "-------------Chọn giới tính---------------";
            // 
            // tbCustomerId
            // 
            this.tbCustomerId.Location = new System.Drawing.Point(538, 41);
            this.tbCustomerId.Name = "tbCustomerId";
            this.tbCustomerId.Size = new System.Drawing.Size(251, 26);
            this.tbCustomerId.TabIndex = 7;
            // 
            // tbCustomerPhone
            // 
            this.tbCustomerPhone.Location = new System.Drawing.Point(153, 100);
            this.tbCustomerPhone.Name = "tbCustomerPhone";
            this.tbCustomerPhone.Size = new System.Drawing.Size(257, 26);
            this.tbCustomerPhone.TabIndex = 6;
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(153, 41);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(257, 26);
            this.tbCustomerName.TabIndex = 5;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(471, 103);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(61, 19);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Giới tính";
            // 
            // lblphnumber
            // 
            this.lblphnumber.AutoSize = true;
            this.lblphnumber.Location = new System.Drawing.Point(58, 103);
            this.lblphnumber.Name = "lblphnumber";
            this.lblphnumber.Size = new System.Drawing.Size(89, 19);
            this.lblphnumber.TabIndex = 2;
            this.lblphnumber.Text = "Số điện thoại";
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(428, 44);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(104, 19);
            this.lblMaKH.TabIndex = 1;
            this.lblMaKH.Text = "Mã khách hàng";
            // 
            // lblKhachhang
            // 
            this.lblKhachhang.AutoSize = true;
            this.lblKhachhang.Location = new System.Drawing.Point(42, 44);
            this.lblKhachhang.Name = "lblKhachhang";
            this.lblKhachhang.Size = new System.Drawing.Size(105, 19);
            this.lblKhachhang.TabIndex = 0;
            this.lblKhachhang.Text = "Tên khách hàng";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AutoGenerateColumns = false;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIdDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.customerGenderDataGridViewCheckBoxColumn,
            this.customerPhoneDataGridViewTextBoxColumn});
            this.dgvCustomer.DataSource = this.customerDTOBindingSource;
            this.dgvCustomer.Location = new System.Drawing.Point(85, 230);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowTemplate.Height = 28;
            this.dgvCustomer.Size = new System.Drawing.Size(1085, 381);
            this.dgvCustomer.TabIndex = 2;
            this.dgvCustomer.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCustomer_RowHeaderMouseClick);
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "Mã khách hàng";
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.Width = 200;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "Tên khách hàng";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.Width = 378;
            // 
            // customerGenderDataGridViewCheckBoxColumn
            // 
            this.customerGenderDataGridViewCheckBoxColumn.DataPropertyName = "CustomerGender";
            this.customerGenderDataGridViewCheckBoxColumn.HeaderText = "Giới tính";
            this.customerGenderDataGridViewCheckBoxColumn.Name = "customerGenderDataGridViewCheckBoxColumn";
            this.customerGenderDataGridViewCheckBoxColumn.Width = 200;
            // 
            // customerPhoneDataGridViewTextBoxColumn
            // 
            this.customerPhoneDataGridViewTextBoxColumn.DataPropertyName = "CustomerPhone";
            this.customerPhoneDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.customerPhoneDataGridViewTextBoxColumn.Name = "customerPhoneDataGridViewTextBoxColumn";
            this.customerPhoneDataGridViewTextBoxColumn.Width = 262;
            // 
            // customerDTOBindingSource
            // 
            this.customerDTOBindingSource.DataSource = typeof(Shoes.DTO.customerDTO);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(623, 188);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(95, 26);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(759, 188);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 26);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(886, 188);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 26);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(85, 188);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 26);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search Id";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(197, 188);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(260, 26);
            this.tbSearch.TabIndex = 7;
            // 
            // grBNumberCustumer
            // 
            this.grBNumberCustumer.Controls.Add(this.lblNumFemale);
            this.grBNumberCustumer.Controls.Add(this.lblNumMale);
            this.grBNumberCustumer.Controls.Add(this.lblNumCustomer);
            this.grBNumberCustumer.Controls.Add(this.rdBNu);
            this.grBNumberCustumer.Controls.Add(this.lblFemaleCus);
            this.grBNumberCustumer.Controls.Add(this.lblMaleCus);
            this.grBNumberCustumer.Controls.Add(this.rdBNam);
            this.grBNumberCustumer.Controls.Add(this.lblCus);
            this.grBNumberCustumer.Location = new System.Drawing.Point(934, 28);
            this.grBNumberCustumer.Name = "grBNumberCustumer";
            this.grBNumberCustumer.Size = new System.Drawing.Size(236, 143);
            this.grBNumberCustumer.TabIndex = 8;
            this.grBNumberCustumer.TabStop = false;
            this.grBNumberCustumer.Text = "Số lượng khách hàng";
            // 
            // lblNumFemale
            // 
            this.lblNumFemale.AutoSize = true;
            this.lblNumFemale.Location = new System.Drawing.Point(108, 108);
            this.lblNumFemale.Name = "lblNumFemale";
            this.lblNumFemale.Size = new System.Drawing.Size(17, 19);
            this.lblNumFemale.TabIndex = 9;
            this.lblNumFemale.Text = "0";
            // 
            // lblNumMale
            // 
            this.lblNumMale.AutoSize = true;
            this.lblNumMale.Location = new System.Drawing.Point(108, 68);
            this.lblNumMale.Name = "lblNumMale";
            this.lblNumMale.Size = new System.Drawing.Size(17, 19);
            this.lblNumMale.TabIndex = 8;
            this.lblNumMale.Text = "0";
            // 
            // lblNumCustomer
            // 
            this.lblNumCustomer.AutoSize = true;
            this.lblNumCustomer.Location = new System.Drawing.Point(108, 28);
            this.lblNumCustomer.Name = "lblNumCustomer";
            this.lblNumCustomer.Size = new System.Drawing.Size(17, 19);
            this.lblNumCustomer.TabIndex = 7;
            this.lblNumCustomer.Text = "0";
            // 
            // rdBNu
            // 
            this.rdBNu.AutoSize = true;
            this.rdBNu.Location = new System.Drawing.Point(48, 106);
            this.rdBNu.Name = "rdBNu";
            this.rdBNu.Size = new System.Drawing.Size(45, 23);
            this.rdBNu.TabIndex = 6;
            this.rdBNu.TabStop = true;
            this.rdBNu.Text = "Nữ";
            this.rdBNu.UseVisualStyleBackColor = true;
            this.rdBNu.CheckedChanged += new System.EventHandler(this.rdBNu_CheckedChanged);
            // 
            // lblFemaleCus
            // 
            this.lblFemaleCus.AutoSize = true;
            this.lblFemaleCus.Location = new System.Drawing.Point(140, 108);
            this.lblFemaleCus.Name = "lblFemaleCus";
            this.lblFemaleCus.Size = new System.Drawing.Size(81, 19);
            this.lblFemaleCus.TabIndex = 5;
            this.lblFemaleCus.Text = "Khách hàng";
            // 
            // lblMaleCus
            // 
            this.lblMaleCus.AutoSize = true;
            this.lblMaleCus.Location = new System.Drawing.Point(140, 68);
            this.lblMaleCus.Name = "lblMaleCus";
            this.lblMaleCus.Size = new System.Drawing.Size(81, 19);
            this.lblMaleCus.TabIndex = 4;
            this.lblMaleCus.Text = "Khách hàng";
            // 
            // rdBNam
            // 
            this.rdBNam.AutoSize = true;
            this.rdBNam.Location = new System.Drawing.Point(48, 66);
            this.rdBNam.Name = "rdBNam";
            this.rdBNam.Size = new System.Drawing.Size(56, 23);
            this.rdBNam.TabIndex = 2;
            this.rdBNam.TabStop = true;
            this.rdBNam.Text = "Nam";
            this.rdBNam.UseVisualStyleBackColor = true;
            this.rdBNam.CheckedChanged += new System.EventHandler(this.rdBNam_CheckedChanged);
            // 
            // lblCus
            // 
            this.lblCus.AutoSize = true;
            this.lblCus.Location = new System.Drawing.Point(140, 28);
            this.lblCus.Name = "lblCus";
            this.lblCus.Size = new System.Drawing.Size(81, 19);
            this.lblCus.TabIndex = 1;
            this.lblCus.Text = "Khách hàng";
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(1014, 188);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(95, 26);
            this.btnReload.TabIndex = 9;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // Form_CUSTOMER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 642);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.grBNumberCustumer);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.grBInfo);
            this.Name = "Form_CUSTOMER";
            this.Text = "Customer Manage";
            this.Load += new System.EventHandler(this.Form_CUSTOMER_Load);
            this.grBInfo.ResumeLayout(false);
            this.grBInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDTOBindingSource)).EndInit();
            this.grBNumberCustumer.ResumeLayout(false);
            this.grBNumberCustumer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox grBInfo;
        private TextBox tbCustomerId;
        private TextBox tbCustomerPhone;
        private TextBox tbCustomerName;
        private Label lblGender;
        private Label lblphnumber;
        private Label lblMaKH;
        private Label lblKhachhang;
        private DataGridView dgvCustomer;
        private ComboBox CBGender;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private BindingSource customerDTOBindingSource;
        private Button btnSearch;
        private TextBox tbSearch;
        private GroupBox grBNumberCustumer;
        private DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn customerGenderDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn customerPhoneDataGridViewTextBoxColumn;
        private Label lblCus;
        private RadioButton rdBNam;
        private Label lblMaleCus;
        private Label lblFemaleCus;
        private RadioButton rdBNu;
        private Button btnReload;
        private Label lblNumCustomer;
        private Label lblNumMale;
        private Label lblNumFemale;
    }
}