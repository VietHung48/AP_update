namespace Group4Ap
{
	partial class FormRooms
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
            this.rBtnNo = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.MPField = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMSV = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.employeesTableAdapter = new Group4Ap.HotelManagementDataSetTableAdapters.EmployeesTableAdapter();
            this.g1 = new System.Windows.Forms.GroupBox();
            this.rBtnYes = new System.Windows.Forms.RadioButton();
            this.MTField = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelManagementDataSet = new Group4Ap.HotelManagementDataSet();
            this.guestsTableAdapter = new Group4Ap.HotelManagementDataSetTableAdapters.GuestsTableAdapter();
            this.guestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SPField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTao = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.towerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomFloorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isUnderMaintenanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter = new Group4Ap.HotelManagementDataSetTableAdapters.RoomsTableAdapter();
            this.MLPField = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.doDongHaiAPMidtermsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUNHAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.g1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doDongHaiAPMidtermsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rBtnNo
            // 
            this.rBtnNo.AutoSize = true;
            this.rBtnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rBtnNo.Location = new System.Drawing.Point(212, 19);
            this.rBtnNo.Name = "rBtnNo";
            this.rBtnNo.Size = new System.Drawing.Size(91, 29);
            this.rBtnNo.TabIndex = 1;
            this.rBtnNo.Text = "Không";
            this.rBtnNo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(539, 100);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(143, 29);
            this.label3.TabIndex = 112;
            this.label3.Text = "Đang bảo trì";
            // 
            // MPField
            // 
            this.MPField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MPField.Location = new System.Drawing.Point(193, 98);
            this.MPField.Name = "MPField";
            this.MPField.Size = new System.Drawing.Size(309, 34);
            this.MPField.TabIndex = 96;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblHoTen.Location = new System.Drawing.Point(10, 161);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHoTen.Size = new System.Drawing.Size(165, 29);
            this.lblHoTen.TabIndex = 100;
            this.lblHoTen.Text = "Mã loại phòng";
            // 
            // lblMSV
            // 
            this.lblMSV.AutoSize = true;
            this.lblMSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblMSV.Location = new System.Drawing.Point(55, 101);
            this.lblMSV.Name = "lblMSV";
            this.lblMSV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMSV.Size = new System.Drawing.Size(120, 29);
            this.lblMSV.TabIndex = 99;
            this.lblMSV.Text = "Mã phòng";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(423, -2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(522, 46);
            this.lblTitle.TabIndex = 97;
            this.lblTitle.Text = "Danh sách thông tin phòng";
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // g1
            // 
            this.g1.Controls.Add(this.rBtnYes);
            this.g1.Controls.Add(this.rBtnNo);
            this.g1.Location = new System.Drawing.Point(698, 82);
            this.g1.Name = "g1";
            this.g1.Size = new System.Drawing.Size(309, 57);
            this.g1.TabIndex = 117;
            this.g1.TabStop = false;
            // 
            // rBtnYes
            // 
            this.rBtnYes.AutoSize = true;
            this.rBtnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rBtnYes.Location = new System.Drawing.Point(6, 19);
            this.rBtnYes.Name = "rBtnYes";
            this.rBtnYes.Size = new System.Drawing.Size(59, 29);
            this.rBtnYes.TabIndex = 0;
            this.rBtnYes.Text = "Có";
            this.rBtnYes.UseVisualStyleBackColor = true;
            // 
            // MTField
            // 
            this.MTField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.MTField.FormattingEnabled = true;
            this.MTField.Location = new System.Drawing.Point(698, 161);
            this.MTField.Name = "MTField";
            this.MTField.Size = new System.Drawing.Size(309, 37);
            this.MTField.TabIndex = 116;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(597, 164);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(85, 29);
            this.label4.TabIndex = 114;
            this.label4.Text = "Mã tòa";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1031, 281);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(235, 50);
            this.btnThoat.TabIndex = 108;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.hotelManagementDataSet;
            // 
            // hotelManagementDataSet
            // 
            this.hotelManagementDataSet.DataSetName = "HotelManagementDataSet";
            this.hotelManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guestsTableAdapter
            // 
            this.guestsTableAdapter.ClearBeforeFill = true;
            // 
            // guestsBindingSource
            // 
            this.guestsBindingSource.DataMember = "Guests";
            this.guestsBindingSource.DataSource = this.hotelManagementDataSet;
            // 
            // TField
            // 
            this.TField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TField.Location = new System.Drawing.Point(193, 229);
            this.TField.Name = "TField";
            this.TField.Size = new System.Drawing.Size(309, 34);
            this.TField.TabIndex = 113;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(106, 231);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 111;
            this.label2.Text = "Tầng";
            // 
            // SPField
            // 
            this.SPField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPField.Location = new System.Drawing.Point(698, 230);
            this.SPField.Name = "SPField";
            this.SPField.Size = new System.Drawing.Size(309, 34);
            this.SPField.TabIndex = 109;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(565, 230);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 110;
            this.label1.Text = "Số phòng";
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(1031, 159);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(235, 50);
            this.btnSua.TabIndex = 107;
            this.btnSua.Text = "Sửa dữ liệu";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(1031, 220);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(235, 50);
            this.btnXoa.TabIndex = 106;
            this.btnXoa.Text = "Xóa dữ liệu";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(1031, 97);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(235, 50);
            this.btnLuu.TabIndex = 105;
            this.btnLuu.Text = "Lưu dữ liệu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTao
            // 
            this.btnTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTao.Location = new System.Drawing.Point(1031, 35);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(235, 50);
            this.btnTao.TabIndex = 104;
            this.btnTao.Text = "Tạo mới";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomIDDataGridViewTextBoxColumn,
            this.roomTypeIDDataGridViewTextBoxColumn,
            this.towerIDDataGridViewTextBoxColumn,
            this.roomNumberDataGridViewTextBoxColumn,
            this.roomFloorDataGridViewTextBoxColumn,
            this.isUnderMaintenanceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.roomsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 340);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1278, 286);
            this.dataGridView1.TabIndex = 103;
            // 
            // roomIDDataGridViewTextBoxColumn
            // 
            this.roomIDDataGridViewTextBoxColumn.DataPropertyName = "RoomID";
            this.roomIDDataGridViewTextBoxColumn.HeaderText = "RoomID";
            this.roomIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomIDDataGridViewTextBoxColumn.Name = "roomIDDataGridViewTextBoxColumn";
            this.roomIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomTypeIDDataGridViewTextBoxColumn
            // 
            this.roomTypeIDDataGridViewTextBoxColumn.DataPropertyName = "RoomTypeID";
            this.roomTypeIDDataGridViewTextBoxColumn.HeaderText = "RoomTypeID";
            this.roomTypeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomTypeIDDataGridViewTextBoxColumn.Name = "roomTypeIDDataGridViewTextBoxColumn";
            this.roomTypeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // towerIDDataGridViewTextBoxColumn
            // 
            this.towerIDDataGridViewTextBoxColumn.DataPropertyName = "TowerID";
            this.towerIDDataGridViewTextBoxColumn.HeaderText = "TowerID";
            this.towerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.towerIDDataGridViewTextBoxColumn.Name = "towerIDDataGridViewTextBoxColumn";
            this.towerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            this.roomNumberDataGridViewTextBoxColumn.DataPropertyName = "RoomNumber";
            this.roomNumberDataGridViewTextBoxColumn.HeaderText = "RoomNumber";
            this.roomNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            this.roomNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomFloorDataGridViewTextBoxColumn
            // 
            this.roomFloorDataGridViewTextBoxColumn.DataPropertyName = "RoomFloor";
            this.roomFloorDataGridViewTextBoxColumn.HeaderText = "RoomFloor";
            this.roomFloorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomFloorDataGridViewTextBoxColumn.Name = "roomFloorDataGridViewTextBoxColumn";
            this.roomFloorDataGridViewTextBoxColumn.Width = 125;
            // 
            // isUnderMaintenanceDataGridViewTextBoxColumn
            // 
            this.isUnderMaintenanceDataGridViewTextBoxColumn.DataPropertyName = "IsUnderMaintenance";
            this.isUnderMaintenanceDataGridViewTextBoxColumn.HeaderText = "IsUnderMaintenance";
            this.isUnderMaintenanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isUnderMaintenanceDataGridViewTextBoxColumn.Name = "isUnderMaintenanceDataGridViewTextBoxColumn";
            this.isUnderMaintenanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.hotelManagementDataSet;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // MLPField
            // 
            this.MLPField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.MLPField.FormattingEnabled = true;
            this.MLPField.Location = new System.Drawing.Point(193, 158);
            this.MLPField.Name = "MLPField";
            this.MLPField.Size = new System.Drawing.Size(309, 37);
            this.MLPField.TabIndex = 118;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(790, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 50);
            this.button1.TabIndex = 119;
            this.button1.Text = "In báo cáo tỷ lệ sử dụng phòng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            // 
            // pHIEUNHAPBindingSource
            // 
            this.pHIEUNHAPBindingSource.DataMember = "PHIEUNHAP";
            // 
            // FormRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 638);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MLPField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MPField);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblMSV);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.g1);
            this.Controls.Add(this.MTField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.TField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SPField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormRooms";
            this.Text = "FormRooms";
            this.Load += new System.EventHandler(this.FormRooms_Load);
            this.g1.ResumeLayout(false);
            this.g1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doDongHaiAPMidtermsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton rBtnNo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox MPField;
		private System.Windows.Forms.Label lblHoTen;
		private System.Windows.Forms.Label lblMSV;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.BindingSource doDongHaiAPMidtermsDataSetBindingSource;
		private System.Windows.Forms.BindingSource lOPBindingSource;
		private System.Windows.Forms.BindingSource pHIEUNHAPBindingSource;
		private HotelManagementDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
		private System.Windows.Forms.GroupBox g1;
		private System.Windows.Forms.RadioButton rBtnYes;
		private System.Windows.Forms.ComboBox MTField;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.BindingSource employeesBindingSource;
		private HotelManagementDataSet hotelManagementDataSet;
		private HotelManagementDataSetTableAdapters.GuestsTableAdapter guestsTableAdapter;
		private System.Windows.Forms.BindingSource guestsBindingSource;
		private System.Windows.Forms.TextBox TField;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox SPField;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Button btnTao;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource roomsBindingSource;
		private HotelManagementDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn roomTypeIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn towerIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn roomFloorDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn isUnderMaintenanceDataGridViewTextBoxColumn;
		private System.Windows.Forms.ComboBox MLPField;
        private System.Windows.Forms.Button button1;
    }
}