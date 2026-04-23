namespace Group4Ap
{
	partial class FormServiceRevenue
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
            this.GNField = new System.Windows.Forms.TextBox();
            this.GIDField = new System.Windows.Forms.TextBox();
            this.RIDField = new System.Windows.Forms.TextBox();
            this.lblMaCode = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMSV = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.serviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalRevenueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceRevenueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelManagementDataSet = new Group4Ap.HotelManagementDataSet();
            this.serviceRevenueTableAdapter = new Group4Ap.HotelManagementDataSetTableAdapters.ServiceRevenueTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceRevenueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // GNField
            // 
            this.GNField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GNField.Location = new System.Drawing.Point(244, 184);
            this.GNField.Name = "GNField";
            this.GNField.ReadOnly = true;
            this.GNField.Size = new System.Drawing.Size(328, 34);
            this.GNField.TabIndex = 83;
            // 
            // GIDField
            // 
            this.GIDField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GIDField.Location = new System.Drawing.Point(244, 135);
            this.GIDField.Name = "GIDField";
            this.GIDField.ReadOnly = true;
            this.GIDField.Size = new System.Drawing.Size(328, 34);
            this.GIDField.TabIndex = 80;
            // 
            // RIDField
            // 
            this.RIDField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RIDField.Location = new System.Drawing.Point(244, 79);
            this.RIDField.Name = "RIDField";
            this.RIDField.ReadOnly = true;
            this.RIDField.Size = new System.Drawing.Size(328, 34);
            this.RIDField.TabIndex = 78;
            // 
            // lblMaCode
            // 
            this.lblMaCode.AutoSize = true;
            this.lblMaCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblMaCode.Location = new System.Drawing.Point(35, 187);
            this.lblMaCode.Name = "lblMaCode";
            this.lblMaCode.Size = new System.Drawing.Size(181, 29);
            this.lblMaCode.TabIndex = 84;
            this.lblMaCode.Text = "Tổng doanh thu";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblHoTen.Location = new System.Drawing.Point(79, 135);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(137, 29);
            this.lblHoTen.TabIndex = 82;
            this.lblHoTen.Text = "Tên dịch vụ";
            // 
            // lblMSV
            // 
            this.lblMSV.AutoSize = true;
            this.lblMSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblMSV.Location = new System.Drawing.Point(89, 84);
            this.lblMSV.Name = "lblMSV";
            this.lblMSV.Size = new System.Drawing.Size(127, 29);
            this.lblMSV.TabIndex = 81;
            this.lblMSV.Text = "Mã dịch vụ";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(214, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(358, 46);
            this.lblTitle.TabIndex = 79;
            this.lblTitle.Text = "Doanh thu dịch vụ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceIDDataGridViewTextBoxColumn,
            this.serviceNameDataGridViewTextBoxColumn,
            this.totalRevenueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.serviceRevenueBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(40, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(721, 271);
            this.dataGridView1.TabIndex = 85;
            // 
            // serviceIDDataGridViewTextBoxColumn
            // 
            this.serviceIDDataGridViewTextBoxColumn.DataPropertyName = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.HeaderText = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceIDDataGridViewTextBoxColumn.Name = "serviceIDDataGridViewTextBoxColumn";
            this.serviceIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // serviceNameDataGridViewTextBoxColumn
            // 
            this.serviceNameDataGridViewTextBoxColumn.DataPropertyName = "ServiceName";
            this.serviceNameDataGridViewTextBoxColumn.HeaderText = "ServiceName";
            this.serviceNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceNameDataGridViewTextBoxColumn.Name = "serviceNameDataGridViewTextBoxColumn";
            this.serviceNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalRevenueDataGridViewTextBoxColumn
            // 
            this.totalRevenueDataGridViewTextBoxColumn.DataPropertyName = "TotalRevenue";
            this.totalRevenueDataGridViewTextBoxColumn.HeaderText = "TotalRevenue";
            this.totalRevenueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalRevenueDataGridViewTextBoxColumn.Name = "totalRevenueDataGridViewTextBoxColumn";
            this.totalRevenueDataGridViewTextBoxColumn.Width = 125;
            // 
            // serviceRevenueBindingSource
            // 
            this.serviceRevenueBindingSource.DataMember = "ServiceRevenue";
            this.serviceRevenueBindingSource.DataSource = this.hotelManagementDataSet;
            // 
            // hotelManagementDataSet
            // 
            this.hotelManagementDataSet.DataSetName = "HotelManagementDataSet";
            this.hotelManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceRevenueTableAdapter
            // 
            this.serviceRevenueTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(604, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(321, 50);
            this.button1.TabIndex = 110;
            this.button1.Text = "In Báo Cáo Dịch Vụ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(604, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(321, 50);
            this.button2.TabIndex = 111;
            this.button2.Text = "In Báo Cáo Theo Tháng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormServiceRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 517);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GNField);
            this.Controls.Add(this.GIDField);
            this.Controls.Add(this.RIDField);
            this.Controls.Add(this.lblMaCode);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblMSV);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormServiceRevenue";
            this.Text = "FormServiceRevenue";
            this.Load += new System.EventHandler(this.FormServiceRevenue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceRevenueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox GNField;
		private System.Windows.Forms.TextBox GIDField;
		private System.Windows.Forms.TextBox RIDField;
		private System.Windows.Forms.Label lblMaCode;
		private System.Windows.Forms.Label lblHoTen;
		private System.Windows.Forms.Label lblMSV;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.DataGridView dataGridView1;
		private HotelManagementDataSet hotelManagementDataSet;
		private System.Windows.Forms.BindingSource serviceRevenueBindingSource;
		private HotelManagementDataSetTableAdapters.ServiceRevenueTableAdapter serviceRevenueTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn serviceIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn serviceNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn totalRevenueDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}