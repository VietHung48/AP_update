namespace Group4Ap
{
	partial class FormServiceOrders
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
            this.servicesTableAdapter = new Group4Ap.HotelManagementDataSetTableAdapters.ServicesTableAdapter();
            this.hotelManagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelManagementDataSet = new Group4Ap.HotelManagementDataSet();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SOIField = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMSV = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.guestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guestsTableAdapter = new Group4Ap.HotelManagementDataSetTableAdapters.GuestsTableAdapter();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ServiceOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTao = new System.Windows.Forms.Button();
            this.doDongHaiAPMidtermsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUNHAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceOrdersTableAdapter = new Group4Ap.HotelManagementDataSetTableAdapters.ServiceOrdersTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.ODField = new System.Windows.Forms.DateTimePicker();
            this.GIDField = new System.Windows.Forms.ComboBox();
            this.SIDField = new System.Windows.Forms.ComboBox();
            this.EIDField = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doDongHaiAPMidtermsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // hotelManagementDataSetBindingSource
            // 
            this.hotelManagementDataSetBindingSource.DataSource = this.hotelManagementDataSet;
            this.hotelManagementDataSetBindingSource.Position = 0;
            // 
            // hotelManagementDataSet
            // 
            this.hotelManagementDataSet.DataSetName = "HotelManagementDataSet";
            this.hotelManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "Services";
            this.servicesBindingSource.DataSource = this.hotelManagementDataSetBindingSource;
            // 
            // SOIField
            // 
            this.SOIField.Enabled = false;
            this.SOIField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SOIField.Location = new System.Drawing.Point(283, 91);
            this.SOIField.Name = "SOIField";
            this.SOIField.Size = new System.Drawing.Size(221, 34);
            this.SOIField.TabIndex = 89;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblHoTen.Location = new System.Drawing.Point(535, 94);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(115, 29);
            this.lblHoTen.TabIndex = 93;
            this.lblHoTen.Text = "Mã khách";
            // 
            // lblMSV
            // 
            this.lblMSV.AutoSize = true;
            this.lblMSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblMSV.Location = new System.Drawing.Point(116, 94);
            this.lblMSV.Name = "lblMSV";
            this.lblMSV.Size = new System.Drawing.Size(137, 29);
            this.lblMSV.TabIndex = 92;
            this.lblMSV.Text = "Mã sử dụng";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(370, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(525, 46);
            this.lblTitle.TabIndex = 90;
            this.lblTitle.Text = "Danh sách sử dụng dịch vụ";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(943, 286);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(235, 50);
            this.btnThoat.TabIndex = 99;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(943, 174);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(235, 50);
            this.btnSua.TabIndex = 98;
            this.btnSua.Text = "Sửa dữ liệu";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(943, 230);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(235, 50);
            this.btnXoa.TabIndex = 97;
            this.btnXoa.Text = "Xóa dữ liệu";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // guestsBindingSource
            // 
            this.guestsBindingSource.DataMember = "Guests";
            this.guestsBindingSource.DataSource = this.hotelManagementDataSet;
            // 
            // guestsTableAdapter
            // 
            this.guestsTableAdapter.ClearBeforeFill = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(943, 117);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(235, 50);
            this.btnLuu.TabIndex = 96;
            this.btnLuu.Text = "Lưu dữ liệu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceOrderID,
            this.GuestID,
            this.serviceIDDataGridViewTextBoxColumn,
            this.EmployeeID,
            this.OrderDate});
            this.dataGridView1.DataSource = this.serviceOrdersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(93, 418);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1085, 248);
            this.dataGridView1.TabIndex = 94;
            // 
            // ServiceOrderID
            // 
            this.ServiceOrderID.DataPropertyName = "ServiceOrderID";
            this.ServiceOrderID.HeaderText = "ServiceOrderID";
            this.ServiceOrderID.MinimumWidth = 6;
            this.ServiceOrderID.Name = "ServiceOrderID";
            this.ServiceOrderID.ReadOnly = true;
            this.ServiceOrderID.Width = 125;
            // 
            // GuestID
            // 
            this.GuestID.DataPropertyName = "GuestID";
            this.GuestID.HeaderText = "GuestID";
            this.GuestID.MinimumWidth = 6;
            this.GuestID.Name = "GuestID";
            this.GuestID.Width = 125;
            // 
            // serviceIDDataGridViewTextBoxColumn
            // 
            this.serviceIDDataGridViewTextBoxColumn.DataPropertyName = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.HeaderText = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceIDDataGridViewTextBoxColumn.Name = "serviceIDDataGridViewTextBoxColumn";
            this.serviceIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "EmployeeID";
            this.EmployeeID.HeaderText = "EmployeeID";
            this.EmployeeID.MinimumWidth = 6;
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Width = 125;
            // 
            // OrderDate
            // 
            this.OrderDate.DataPropertyName = "OrderDate";
            this.OrderDate.HeaderText = "OrderDate";
            this.OrderDate.MinimumWidth = 6;
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Width = 125;
            // 
            // serviceOrdersBindingSource
            // 
            this.serviceOrdersBindingSource.DataMember = "ServiceOrders";
            this.serviceOrdersBindingSource.DataSource = this.hotelManagementDataSetBindingSource;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(535, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 29);
            this.label2.TabIndex = 102;
            this.label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(116, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 101;
            this.label1.Text = "Mã dịch vụ";
            // 
            // btnTao
            // 
            this.btnTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTao.Location = new System.Drawing.Point(943, 61);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(235, 50);
            this.btnTao.TabIndex = 95;
            this.btnTao.Text = "Tạo mới";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            // 
            // pHIEUNHAPBindingSource
            // 
            this.pHIEUNHAPBindingSource.DataMember = "PHIEUNHAP";
            // 
            // serviceOrdersTableAdapter
            // 
            this.serviceOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(114, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 29);
            this.label3.TabIndex = 104;
            this.label3.Text = "Thời gian";
            // 
            // ODField
            // 
            this.ODField.CustomFormat = "dd-MM-yyyy hh:mm:ss";
            this.ODField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ODField.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ODField.Location = new System.Drawing.Point(283, 249);
            this.ODField.Name = "ODField";
            this.ODField.Size = new System.Drawing.Size(640, 34);
            this.ODField.TabIndex = 105;
            // 
            // GIDField
            // 
            this.GIDField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.GIDField.FormattingEnabled = true;
            this.GIDField.Location = new System.Drawing.Point(702, 91);
            this.GIDField.Name = "GIDField";
            this.GIDField.Size = new System.Drawing.Size(221, 37);
            this.GIDField.TabIndex = 106;
            // 
            // SIDField
            // 
            this.SIDField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SIDField.FormattingEnabled = true;
            this.SIDField.Location = new System.Drawing.Point(283, 166);
            this.SIDField.Name = "SIDField";
            this.SIDField.Size = new System.Drawing.Size(221, 37);
            this.SIDField.TabIndex = 107;
            // 
            // EIDField
            // 
            this.EIDField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.EIDField.FormattingEnabled = true;
            this.EIDField.Location = new System.Drawing.Point(702, 166);
            this.EIDField.Name = "EIDField";
            this.EIDField.Size = new System.Drawing.Size(221, 37);
            this.EIDField.TabIndex = 108;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(943, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 50);
            this.button1.TabIndex = 109;
            this.button1.Text = "In Hóa Đơn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormServiceOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 611);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EIDField);
            this.Controls.Add(this.SIDField);
            this.Controls.Add(this.GIDField);
            this.Controls.Add(this.ODField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SOIField);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblMSV);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTao);
            this.Name = "FormServiceOrders";
            this.Text = "FormServiceOrders";
            this.Load += new System.EventHandler(this.FormServiceOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doDongHaiAPMidtermsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private HotelManagementDataSetTableAdapters.ServicesTableAdapter servicesTableAdapter;
		private System.Windows.Forms.BindingSource doDongHaiAPMidtermsDataSetBindingSource;
		private System.Windows.Forms.BindingSource lOPBindingSource;
		private System.Windows.Forms.BindingSource pHIEUNHAPBindingSource;
		private System.Windows.Forms.BindingSource hotelManagementDataSetBindingSource;
		private HotelManagementDataSet hotelManagementDataSet;
		private System.Windows.Forms.BindingSource servicesBindingSource;
		private System.Windows.Forms.TextBox SOIField;
		private System.Windows.Forms.Label lblHoTen;
		private System.Windows.Forms.Label lblMSV;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.BindingSource guestsBindingSource;
		private HotelManagementDataSetTableAdapters.GuestsTableAdapter guestsTableAdapter;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnTao;
		private System.Windows.Forms.BindingSource serviceOrdersBindingSource;
		private HotelManagementDataSetTableAdapters.ServiceOrdersTableAdapter serviceOrdersTableAdapter;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker ODField;
		private System.Windows.Forms.ComboBox GIDField;
		private System.Windows.Forms.ComboBox SIDField;
		private System.Windows.Forms.ComboBox EIDField;
		private System.Windows.Forms.DataGridViewTextBoxColumn ServiceOrderID;
		private System.Windows.Forms.DataGridViewTextBoxColumn GuestID;
		private System.Windows.Forms.DataGridViewTextBoxColumn serviceIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
		private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.Button button1;
    }
}