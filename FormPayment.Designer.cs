namespace Group4Ap
{
	partial class FormPayment
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
            this.RCField = new System.Windows.Forms.TextBox();
            this.GNField = new System.Windows.Forms.TextBox();
            this.GIDField = new System.Windows.Forms.TextBox();
            this.RIDField = new System.Windows.Forms.TextBox();
            this.lblMaCode = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMSV = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.hotelManagementDataSet = new Group4Ap.HotelManagementDataSet();
            this.guestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guestsTableAdapter = new Group4Ap.HotelManagementDataSetTableAdapters.GuestsTableAdapter();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reserIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stayDurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationInvoiceDetailsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hotelManagementDataSet1 = new Group4Ap.HotelManagementDataSet1();
            this.reservationInvoiceDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reservationInvoiceDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUNHAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doDongHaiAPMidtermsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SDField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SCField = new System.Windows.Forms.TextBox();
            this.reservationInvoiceDetailsTableAdapter = new Group4Ap.HotelManagementDataSetTableAdapters.ReservationInvoiceDetailsTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.TCField = new System.Windows.Forms.TextBox();
            this.reservationInvoiceDetailsTableAdapter1 = new Group4Ap.HotelManagementDataSet1TableAdapters.ReservationInvoiceDetailsTableAdapter();
            this.PSField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationInvoiceDetailsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationInvoiceDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationInvoiceDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doDongHaiAPMidtermsDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RCField
            // 
            this.RCField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RCField.Location = new System.Drawing.Point(859, 182);
            this.RCField.Name = "RCField";
            this.RCField.ReadOnly = true;
            this.RCField.Size = new System.Drawing.Size(328, 34);
            this.RCField.TabIndex = 88;
            // 
            // GNField
            // 
            this.GNField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GNField.Location = new System.Drawing.Point(859, 120);
            this.GNField.Name = "GNField";
            this.GNField.ReadOnly = true;
            this.GNField.Size = new System.Drawing.Size(328, 34);
            this.GNField.TabIndex = 75;
            // 
            // GIDField
            // 
            this.GIDField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GIDField.Location = new System.Drawing.Point(334, 120);
            this.GIDField.Name = "GIDField";
            this.GIDField.ReadOnly = true;
            this.GIDField.Size = new System.Drawing.Size(328, 34);
            this.GIDField.TabIndex = 72;
            // 
            // RIDField
            // 
            this.RIDField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RIDField.Location = new System.Drawing.Point(334, 64);
            this.RIDField.Name = "RIDField";
            this.RIDField.ReadOnly = true;
            this.RIDField.Size = new System.Drawing.Size(328, 34);
            this.RIDField.TabIndex = 70;
            // 
            // lblMaCode
            // 
            this.lblMaCode.AutoSize = true;
            this.lblMaCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblMaCode.Location = new System.Drawing.Point(717, 123);
            this.lblMaCode.Name = "lblMaCode";
            this.lblMaCode.Size = new System.Drawing.Size(125, 29);
            this.lblMaCode.TabIndex = 76;
            this.lblMaCode.Text = "Tên khách";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblHoTen.Location = new System.Drawing.Point(125, 120);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(115, 29);
            this.lblHoTen.TabIndex = 74;
            this.lblHoTen.Text = "Mã khách";
            // 
            // lblMSV
            // 
            this.lblMSV.AutoSize = true;
            this.lblMSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblMSV.Location = new System.Drawing.Point(125, 64);
            this.lblMSV.Name = "lblMSV";
            this.lblMSV.Size = new System.Drawing.Size(159, 29);
            this.lblMSV.TabIndex = 73;
            this.lblMSV.Text = "Mã đặt phòng";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(468, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(405, 46);
            this.lblTitle.TabIndex = 71;
            this.lblTitle.Text = "Thông tin thanh toán";
            // 
            // hotelManagementDataSet
            // 
            this.hotelManagementDataSet.DataSetName = "HotelManagementDataSet";
            this.hotelManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnLuu.Location = new System.Drawing.Point(859, 296);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(328, 50);
            this.btnLuu.TabIndex = 79;
            this.btnLuu.Text = "Xác nhận thanh toán";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reserIDDataGridViewTextBoxColumn,
            this.guestIDDataGridViewTextBoxColumn,
            this.guestNameDataGridViewTextBoxColumn,
            this.stayDurationDataGridViewTextBoxColumn,
            this.roomCostDataGridViewTextBoxColumn,
            this.serviceCostDataGridViewTextBoxColumn,
            this.totalCostDataGridViewTextBoxColumn,
            this.PaymentStatus});
            this.dataGridView1.DataSource = this.reservationInvoiceDetailsBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(102, 364);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1085, 271);
            this.dataGridView1.TabIndex = 77;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // reserIDDataGridViewTextBoxColumn
            // 
            this.reserIDDataGridViewTextBoxColumn.DataPropertyName = "ReserID";
            this.reserIDDataGridViewTextBoxColumn.HeaderText = "ReserID";
            this.reserIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reserIDDataGridViewTextBoxColumn.Name = "reserIDDataGridViewTextBoxColumn";
            this.reserIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // guestIDDataGridViewTextBoxColumn
            // 
            this.guestIDDataGridViewTextBoxColumn.DataPropertyName = "GuestID";
            this.guestIDDataGridViewTextBoxColumn.HeaderText = "GuestID";
            this.guestIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.guestIDDataGridViewTextBoxColumn.Name = "guestIDDataGridViewTextBoxColumn";
            this.guestIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // guestNameDataGridViewTextBoxColumn
            // 
            this.guestNameDataGridViewTextBoxColumn.DataPropertyName = "GuestName";
            this.guestNameDataGridViewTextBoxColumn.HeaderText = "GuestName";
            this.guestNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.guestNameDataGridViewTextBoxColumn.Name = "guestNameDataGridViewTextBoxColumn";
            this.guestNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.guestNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // stayDurationDataGridViewTextBoxColumn
            // 
            this.stayDurationDataGridViewTextBoxColumn.DataPropertyName = "StayDuration";
            this.stayDurationDataGridViewTextBoxColumn.HeaderText = "StayDuration";
            this.stayDurationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stayDurationDataGridViewTextBoxColumn.Name = "stayDurationDataGridViewTextBoxColumn";
            this.stayDurationDataGridViewTextBoxColumn.ReadOnly = true;
            this.stayDurationDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomCostDataGridViewTextBoxColumn
            // 
            this.roomCostDataGridViewTextBoxColumn.DataPropertyName = "RoomCost";
            this.roomCostDataGridViewTextBoxColumn.HeaderText = "RoomCost";
            this.roomCostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomCostDataGridViewTextBoxColumn.Name = "roomCostDataGridViewTextBoxColumn";
            this.roomCostDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomCostDataGridViewTextBoxColumn.Width = 125;
            // 
            // serviceCostDataGridViewTextBoxColumn
            // 
            this.serviceCostDataGridViewTextBoxColumn.DataPropertyName = "ServiceCost";
            this.serviceCostDataGridViewTextBoxColumn.HeaderText = "ServiceCost";
            this.serviceCostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceCostDataGridViewTextBoxColumn.Name = "serviceCostDataGridViewTextBoxColumn";
            this.serviceCostDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceCostDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalCostDataGridViewTextBoxColumn
            // 
            this.totalCostDataGridViewTextBoxColumn.DataPropertyName = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.HeaderText = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalCostDataGridViewTextBoxColumn.Name = "totalCostDataGridViewTextBoxColumn";
            this.totalCostDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalCostDataGridViewTextBoxColumn.Width = 125;
            // 
            // PaymentStatus
            // 
            this.PaymentStatus.DataPropertyName = "PaymentStatus";
            this.PaymentStatus.HeaderText = "PaymentStatus";
            this.PaymentStatus.MinimumWidth = 6;
            this.PaymentStatus.Name = "PaymentStatus";
            this.PaymentStatus.Width = 125;
            // 
            // reservationInvoiceDetailsBindingSource2
            // 
            this.reservationInvoiceDetailsBindingSource2.DataMember = "ReservationInvoiceDetails";
            this.reservationInvoiceDetailsBindingSource2.DataSource = this.hotelManagementDataSet1;
            // 
            // hotelManagementDataSet1
            // 
            this.hotelManagementDataSet1.DataSetName = "HotelManagementDataSet1";
            this.hotelManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservationInvoiceDetailsBindingSource1
            // 
            this.reservationInvoiceDetailsBindingSource1.DataMember = "ReservationInvoiceDetails";
            this.reservationInvoiceDetailsBindingSource1.DataSource = this.hotelManagementDataSet;
            // 
            // reservationInvoiceDetailsBindingSource
            // 
            this.reservationInvoiceDetailsBindingSource.DataMember = "ReservationInvoiceDetails";
            this.reservationInvoiceDetailsBindingSource.DataSource = this.hotelManagementDataSet;
            // 
            // pHIEUNHAPBindingSource
            // 
            this.pHIEUNHAPBindingSource.DataMember = "PHIEUNHAP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(123, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 29);
            this.label3.TabIndex = 87;
            this.label3.Text = "Tiền dịch vụ";
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(706, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 29);
            this.label2.TabIndex = 85;
            this.label2.Text = "Tiền phòng";
            // 
            // SDField
            // 
            this.SDField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDField.Location = new System.Drawing.Point(334, 177);
            this.SDField.Name = "SDField";
            this.SDField.ReadOnly = true;
            this.SDField.Size = new System.Drawing.Size(328, 34);
            this.SDField.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(125, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 29);
            this.label1.TabIndex = 84;
            this.label1.Text = "Số ngày ở phòng";
            // 
            // SCField
            // 
            this.SCField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SCField.Location = new System.Drawing.Point(334, 238);
            this.SCField.Name = "SCField";
            this.SCField.ReadOnly = true;
            this.SCField.Size = new System.Drawing.Size(328, 34);
            this.SCField.TabIndex = 86;
            // 
            // reservationInvoiceDetailsTableAdapter
            // 
            this.reservationInvoiceDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(123, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 29);
            this.label4.TabIndex = 90;
            this.label4.Text = "Tổng tiền";
            // 
            // TCField
            // 
            this.TCField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCField.Location = new System.Drawing.Point(334, 304);
            this.TCField.Name = "TCField";
            this.TCField.ReadOnly = true;
            this.TCField.Size = new System.Drawing.Size(328, 34);
            this.TCField.TabIndex = 89;
            // 
            // reservationInvoiceDetailsTableAdapter1
            // 
            this.reservationInvoiceDetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // PSField
            // 
            this.PSField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PSField.Location = new System.Drawing.Point(859, 243);
            this.PSField.Name = "PSField";
            this.PSField.ReadOnly = true;
            this.PSField.Size = new System.Drawing.Size(328, 34);
            this.PSField.TabIndex = 92;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(706, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 29);
            this.label5.TabIndex = 91;
            this.label5.Text = "Tình trạng";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(668, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 50);
            this.button1.TabIndex = 93;
            this.button1.Text = "In Hóa đơn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 651);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PSField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TCField);
            this.Controls.Add(this.RCField);
            this.Controls.Add(this.GNField);
            this.Controls.Add(this.GIDField);
            this.Controls.Add(this.RIDField);
            this.Controls.Add(this.lblMaCode);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblMSV);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SDField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SCField);
            this.Name = "FormPayment";
            this.Text = "FormPayment";
            this.Load += new System.EventHandler(this.FormPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationInvoiceDetailsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationInvoiceDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationInvoiceDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doDongHaiAPMidtermsDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox RCField;
		private System.Windows.Forms.TextBox GNField;
		private System.Windows.Forms.TextBox GIDField;
		private System.Windows.Forms.TextBox RIDField;
		private System.Windows.Forms.Label lblMaCode;
		private System.Windows.Forms.Label lblHoTen;
		private System.Windows.Forms.Label lblMSV;
		private System.Windows.Forms.Label lblTitle;
		private HotelManagementDataSet hotelManagementDataSet;
		private System.Windows.Forms.BindingSource guestsBindingSource;
		private HotelManagementDataSetTableAdapters.GuestsTableAdapter guestsTableAdapter;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource pHIEUNHAPBindingSource;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.BindingSource lOPBindingSource;
		private System.Windows.Forms.BindingSource doDongHaiAPMidtermsDataSetBindingSource;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox SDField;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox SCField;
		private System.Windows.Forms.BindingSource reservationInvoiceDetailsBindingSource;
		private HotelManagementDataSetTableAdapters.ReservationInvoiceDetailsTableAdapter reservationInvoiceDetailsTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn reserIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn guestIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn guestNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn stayDurationDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn roomCostDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn serviceCostDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox TCField;
		private System.Windows.Forms.BindingSource reservationInvoiceDetailsBindingSource1;
		private HotelManagementDataSet1 hotelManagementDataSet1;
		private System.Windows.Forms.BindingSource reservationInvoiceDetailsBindingSource2;
		private HotelManagementDataSet1TableAdapters.ReservationInvoiceDetailsTableAdapter reservationInvoiceDetailsTableAdapter1;
		private System.Windows.Forms.DataGridViewTextBoxColumn PaymentStatus;
		private System.Windows.Forms.TextBox PSField;
		private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}