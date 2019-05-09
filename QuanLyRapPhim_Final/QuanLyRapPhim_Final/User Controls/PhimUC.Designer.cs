namespace QuanLyRapPhim_Final.User_Controls
{
    partial class PhimUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhimUC));
            this.pbAvengers = new System.Windows.Forms.PictureBox();
            this.pbLatMat = new System.Windows.Forms.PictureBox();
            this.pbCorgi = new System.Windows.Forms.PictureBox();
            this.pbUpinIpin = new System.Windows.Forms.PictureBox();
            this.dgv_PHIM = new System.Windows.Forms.DataGridView();
            this.tenPhimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaVeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posterDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.phimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyRapPhimDataSet_PHIM = new QuanLyRapPhim_Final.QuanLyRapPhimDataSet_PHIM();
            this.phimTableAdapter = new QuanLyRapPhim_Final.QuanLyRapPhimDataSet_PHIMTableAdapters.PhimTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvengers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLatMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCorgi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpinIpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PHIM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyRapPhimDataSet_PHIM)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAvengers
            // 
            this.pbAvengers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAvengers.Image = ((System.Drawing.Image)(resources.GetObject("pbAvengers.Image")));
            this.pbAvengers.Location = new System.Drawing.Point(14, 13);
            this.pbAvengers.Name = "pbAvengers";
            this.pbAvengers.Size = new System.Drawing.Size(175, 231);
            this.pbAvengers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvengers.TabIndex = 0;
            this.pbAvengers.TabStop = false;
            // 
            // pbLatMat
            // 
            this.pbLatMat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLatMat.Image = ((System.Drawing.Image)(resources.GetObject("pbLatMat.Image")));
            this.pbLatMat.Location = new System.Drawing.Point(206, 13);
            this.pbLatMat.Name = "pbLatMat";
            this.pbLatMat.Size = new System.Drawing.Size(175, 231);
            this.pbLatMat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLatMat.TabIndex = 1;
            this.pbLatMat.TabStop = false;
            // 
            // pbCorgi
            // 
            this.pbCorgi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCorgi.Image = ((System.Drawing.Image)(resources.GetObject("pbCorgi.Image")));
            this.pbCorgi.Location = new System.Drawing.Point(401, 13);
            this.pbCorgi.Name = "pbCorgi";
            this.pbCorgi.Size = new System.Drawing.Size(175, 231);
            this.pbCorgi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCorgi.TabIndex = 2;
            this.pbCorgi.TabStop = false;
            // 
            // pbUpinIpin
            // 
            this.pbUpinIpin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbUpinIpin.Image = ((System.Drawing.Image)(resources.GetObject("pbUpinIpin.Image")));
            this.pbUpinIpin.Location = new System.Drawing.Point(601, 13);
            this.pbUpinIpin.Name = "pbUpinIpin";
            this.pbUpinIpin.Size = new System.Drawing.Size(175, 231);
            this.pbUpinIpin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUpinIpin.TabIndex = 3;
            this.pbUpinIpin.TabStop = false;
            // 
            // dgv_PHIM
            // 
            this.dgv_PHIM.AutoGenerateColumns = false;
            this.dgv_PHIM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PHIM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PHIM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenPhimDataGridViewTextBoxColumn,
            this.maPhimDataGridViewTextBoxColumn,
            this.giaVeDataGridViewTextBoxColumn,
            this.posterDataGridViewImageColumn});
            this.dgv_PHIM.DataSource = this.phimBindingSource;
            this.dgv_PHIM.Location = new System.Drawing.Point(14, 280);
            this.dgv_PHIM.Name = "dgv_PHIM";
            this.dgv_PHIM.Size = new System.Drawing.Size(762, 202);
            this.dgv_PHIM.TabIndex = 4;
            // 
            // tenPhimDataGridViewTextBoxColumn
            // 
            this.tenPhimDataGridViewTextBoxColumn.DataPropertyName = "TenPhim";
            this.tenPhimDataGridViewTextBoxColumn.HeaderText = "TenPhim";
            this.tenPhimDataGridViewTextBoxColumn.Name = "tenPhimDataGridViewTextBoxColumn";
            // 
            // maPhimDataGridViewTextBoxColumn
            // 
            this.maPhimDataGridViewTextBoxColumn.DataPropertyName = "MaPhim";
            this.maPhimDataGridViewTextBoxColumn.HeaderText = "MaPhim";
            this.maPhimDataGridViewTextBoxColumn.Name = "maPhimDataGridViewTextBoxColumn";
            // 
            // giaVeDataGridViewTextBoxColumn
            // 
            this.giaVeDataGridViewTextBoxColumn.DataPropertyName = "GiaVe";
            this.giaVeDataGridViewTextBoxColumn.HeaderText = "GiaVe";
            this.giaVeDataGridViewTextBoxColumn.Name = "giaVeDataGridViewTextBoxColumn";
            // 
            // posterDataGridViewImageColumn
            // 
            this.posterDataGridViewImageColumn.DataPropertyName = "Poster";
            this.posterDataGridViewImageColumn.HeaderText = "Poster";
            this.posterDataGridViewImageColumn.Name = "posterDataGridViewImageColumn";
            // 
            // phimBindingSource
            // 
            this.phimBindingSource.DataMember = "Phim";
            this.phimBindingSource.DataSource = this.quanLyRapPhimDataSet_PHIM;
            // 
            // quanLyRapPhimDataSet_PHIM
            // 
            this.quanLyRapPhimDataSet_PHIM.DataSetName = "QuanLyRapPhimDataSet_PHIM";
            this.quanLyRapPhimDataSet_PHIM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phimTableAdapter
            // 
            this.phimTableAdapter.ClearBeforeFill = true;
            // 
            // PhimUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_PHIM);
            this.Controls.Add(this.pbUpinIpin);
            this.Controls.Add(this.pbCorgi);
            this.Controls.Add(this.pbLatMat);
            this.Controls.Add(this.pbAvengers);
            this.Name = "PhimUC";
            this.Size = new System.Drawing.Size(896, 504);
            this.Load += new System.EventHandler(this.PhimUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvengers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLatMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCorgi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpinIpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PHIM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyRapPhimDataSet_PHIM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAvengers;
        private System.Windows.Forms.PictureBox pbLatMat;
        private System.Windows.Forms.PictureBox pbCorgi;
        private System.Windows.Forms.PictureBox pbUpinIpin;
        private System.Windows.Forms.DataGridView dgv_PHIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPhimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaVeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn posterDataGridViewImageColumn;
        private System.Windows.Forms.BindingSource phimBindingSource;
        private QuanLyRapPhimDataSet_PHIM quanLyRapPhimDataSet_PHIM;
        private QuanLyRapPhimDataSet_PHIMTableAdapters.PhimTableAdapter phimTableAdapter;
    }
}
