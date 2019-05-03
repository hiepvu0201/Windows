namespace QuanLyRapPhim_Final.User_Controls
{
    partial class QuanLyNhanVienUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtHovalotNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.dgv_NHANVIEN = new System.Windows.Forms.DataGridView();
            this.quanLyRapPhimDataSet_NHANVIEN = new QuanLyRapPhim_Final.QuanLyRapPhimDataSet_NHANVIEN();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new QuanLyRapPhim_Final.QuanLyRapPhimDataSet_NHANVIENTableAdapters.NhanVienTableAdapter();
            this.hovaLotNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NHANVIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyRapPhimDataSet_NHANVIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Nhân Viên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ và tên lót Nhân Viên :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên Nhân Viên :";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(229, 26);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(229, 26);
            this.txtMaNV.TabIndex = 6;
            // 
            // txtHovalotNV
            // 
            this.txtHovalotNV.Location = new System.Drawing.Point(227, 68);
            this.txtHovalotNV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtHovalotNV.Name = "txtHovalotNV";
            this.txtHovalotNV.Size = new System.Drawing.Size(229, 26);
            this.txtHovalotNV.TabIndex = 7;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(227, 112);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(229, 26);
            this.txtTenNV.TabIndex = 8;
            // 
            // dgv_NHANVIEN
            // 
            this.dgv_NHANVIEN.AutoGenerateColumns = false;
            this.dgv_NHANVIEN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NHANVIEN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hovaLotNVDataGridViewTextBoxColumn,
            this.tenNVDataGridViewTextBoxColumn,
            this.maNVDataGridViewTextBoxColumn});
            this.dgv_NHANVIEN.DataSource = this.nhanVienBindingSource;
            this.dgv_NHANVIEN.Location = new System.Drawing.Point(33, 173);
            this.dgv_NHANVIEN.Name = "dgv_NHANVIEN";
            this.dgv_NHANVIEN.Size = new System.Drawing.Size(343, 150);
            this.dgv_NHANVIEN.TabIndex = 9;
            // 
            // quanLyRapPhimDataSet_NHANVIEN
            // 
            this.quanLyRapPhimDataSet_NHANVIEN.DataSetName = "QuanLyRapPhimDataSet_NHANVIEN";
            this.quanLyRapPhimDataSet_NHANVIEN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.quanLyRapPhimDataSet_NHANVIEN;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // hovaLotNVDataGridViewTextBoxColumn
            // 
            this.hovaLotNVDataGridViewTextBoxColumn.DataPropertyName = "HovaLotNV";
            this.hovaLotNVDataGridViewTextBoxColumn.HeaderText = "HovaLotNV";
            this.hovaLotNVDataGridViewTextBoxColumn.Name = "hovaLotNVDataGridViewTextBoxColumn";
            // 
            // tenNVDataGridViewTextBoxColumn
            // 
            this.tenNVDataGridViewTextBoxColumn.DataPropertyName = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.HeaderText = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.Name = "tenNVDataGridViewTextBoxColumn";
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "MaNV";
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            // 
            // QuanLyNhanVienUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_NHANVIEN);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtHovalotNV);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QuanLyNhanVienUC";
            this.Size = new System.Drawing.Size(1344, 737);
            this.Load += new System.EventHandler(this.QuanLyNhanVienUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NHANVIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyRapPhimDataSet_NHANVIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtHovalotNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.DataGridView dgv_NHANVIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn hovaLotNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QuanLyRapPhimDataSet_NHANVIEN quanLyRapPhimDataSet_NHANVIEN;
        private QuanLyRapPhimDataSet_NHANVIENTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
    }
}
