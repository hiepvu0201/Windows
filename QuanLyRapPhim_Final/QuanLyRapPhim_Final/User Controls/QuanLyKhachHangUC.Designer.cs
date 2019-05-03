namespace QuanLyRapPhim_Final.User_Controls
{
    partial class QuanLyKhachHangUC
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
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHovalotKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.dgv_KHACHHANG = new System.Windows.Forms.DataGridView();
            this.quanLyRapPhimDataSet_KHACHHANG = new QuanLyRapPhim_Final.QuanLyRapPhimDataSet_KHACHHANG();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khachHangTableAdapter = new QuanLyRapPhim_Final.QuanLyRapPhimDataSet_KHACHHANGTableAdapters.KhachHangTableAdapter();
            this.maKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hovaLotKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KHACHHANG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyRapPhimDataSet_KHACHHANG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khách Hàng :";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(227, 23);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(229, 26);
            this.txtMaKH.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ và tên lót Khách Hàng :";
            // 
            // txtHovalotKH
            // 
            this.txtHovalotKH.Location = new System.Drawing.Point(227, 68);
            this.txtHovalotKH.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtHovalotKH.Name = "txtHovalotKH";
            this.txtHovalotKH.Size = new System.Drawing.Size(229, 26);
            this.txtHovalotKH.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên Khách Hàng :";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(227, 112);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(229, 26);
            this.txtTenKH.TabIndex = 5;
            // 
            // dgv_KHACHHANG
            // 
            this.dgv_KHACHHANG.AutoGenerateColumns = false;
            this.dgv_KHACHHANG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KHACHHANG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKHDataGridViewTextBoxColumn,
            this.hovaLotKHDataGridViewTextBoxColumn,
            this.tenKHDataGridViewTextBoxColumn});
            this.dgv_KHACHHANG.DataSource = this.khachHangBindingSource;
            this.dgv_KHACHHANG.Location = new System.Drawing.Point(33, 182);
            this.dgv_KHACHHANG.Name = "dgv_KHACHHANG";
            this.dgv_KHACHHANG.Size = new System.Drawing.Size(341, 150);
            this.dgv_KHACHHANG.TabIndex = 6;
            // 
            // quanLyRapPhimDataSet_KHACHHANG
            // 
            this.quanLyRapPhimDataSet_KHACHHANG.DataSetName = "QuanLyRapPhimDataSet_KHACHHANG";
            this.quanLyRapPhimDataSet_KHACHHANG.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataMember = "KhachHang";
            this.khachHangBindingSource.DataSource = this.quanLyRapPhimDataSet_KHACHHANG;
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // maKHDataGridViewTextBoxColumn
            // 
            this.maKHDataGridViewTextBoxColumn.DataPropertyName = "MaKH";
            this.maKHDataGridViewTextBoxColumn.HeaderText = "MaKH";
            this.maKHDataGridViewTextBoxColumn.Name = "maKHDataGridViewTextBoxColumn";
            // 
            // hovaLotKHDataGridViewTextBoxColumn
            // 
            this.hovaLotKHDataGridViewTextBoxColumn.DataPropertyName = "HovaLotKH";
            this.hovaLotKHDataGridViewTextBoxColumn.HeaderText = "HovaLotKH";
            this.hovaLotKHDataGridViewTextBoxColumn.Name = "hovaLotKHDataGridViewTextBoxColumn";
            // 
            // tenKHDataGridViewTextBoxColumn
            // 
            this.tenKHDataGridViewTextBoxColumn.DataPropertyName = "TenKH";
            this.tenKHDataGridViewTextBoxColumn.HeaderText = "TenKH";
            this.tenKHDataGridViewTextBoxColumn.Name = "tenKHDataGridViewTextBoxColumn";
            // 
            // QuanLyKhachHangUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_KHACHHANG);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHovalotKH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "QuanLyKhachHangUC";
            this.Size = new System.Drawing.Size(896, 504);
            this.Load += new System.EventHandler(this.QuanLyKhachHangUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KHACHHANG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyRapPhimDataSet_KHACHHANG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHovalotKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.DataGridView dgv_KHACHHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hovaLotKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private QuanLyRapPhimDataSet_KHACHHANG quanLyRapPhimDataSet_KHACHHANG;
        private QuanLyRapPhimDataSet_KHACHHANGTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
    }
}
