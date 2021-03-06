﻿namespace QuanLyRapPhim_Final.User_Controls
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.txtMaPhim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGiaVe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbPoster = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEditFilm = new System.Windows.Forms.Button();
            this.btnDelFilm = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTinhPhim = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvengers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLatMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCorgi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpinIpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PHIM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyRapPhimDataSet_PHIM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbAvengers
            // 
            this.pbAvengers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAvengers.Image = ((System.Drawing.Image)(resources.GetObject("pbAvengers.Image")));
            this.pbAvengers.Location = new System.Drawing.Point(19, 16);
            this.pbAvengers.Margin = new System.Windows.Forms.Padding(4);
            this.pbAvengers.Name = "pbAvengers";
            this.pbAvengers.Size = new System.Drawing.Size(233, 284);
            this.pbAvengers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvengers.TabIndex = 0;
            this.pbAvengers.TabStop = false;
            // 
            // pbLatMat
            // 
            this.pbLatMat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLatMat.Image = ((System.Drawing.Image)(resources.GetObject("pbLatMat.Image")));
            this.pbLatMat.Location = new System.Drawing.Point(275, 16);
            this.pbLatMat.Margin = new System.Windows.Forms.Padding(4);
            this.pbLatMat.Name = "pbLatMat";
            this.pbLatMat.Size = new System.Drawing.Size(233, 284);
            this.pbLatMat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLatMat.TabIndex = 1;
            this.pbLatMat.TabStop = false;
            // 
            // pbCorgi
            // 
            this.pbCorgi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCorgi.Image = ((System.Drawing.Image)(resources.GetObject("pbCorgi.Image")));
            this.pbCorgi.Location = new System.Drawing.Point(535, 16);
            this.pbCorgi.Margin = new System.Windows.Forms.Padding(4);
            this.pbCorgi.Name = "pbCorgi";
            this.pbCorgi.Size = new System.Drawing.Size(233, 284);
            this.pbCorgi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCorgi.TabIndex = 2;
            this.pbCorgi.TabStop = false;
            // 
            // pbUpinIpin
            // 
            this.pbUpinIpin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbUpinIpin.Image = ((System.Drawing.Image)(resources.GetObject("pbUpinIpin.Image")));
            this.pbUpinIpin.Location = new System.Drawing.Point(801, 16);
            this.pbUpinIpin.Margin = new System.Windows.Forms.Padding(4);
            this.pbUpinIpin.Name = "pbUpinIpin";
            this.pbUpinIpin.Size = new System.Drawing.Size(233, 284);
            this.pbUpinIpin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUpinIpin.TabIndex = 3;
            this.pbUpinIpin.TabStop = false;
            // 
            // dgv_PHIM
            // 
            this.dgv_PHIM.AllowUserToAddRows = false;
            this.dgv_PHIM.AllowUserToResizeColumns = false;
            this.dgv_PHIM.AllowUserToResizeRows = false;
            this.dgv_PHIM.AutoGenerateColumns = false;
            this.dgv_PHIM.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgv_PHIM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PHIM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenPhimDataGridViewTextBoxColumn,
            this.maPhimDataGridViewTextBoxColumn,
            this.giaVeDataGridViewTextBoxColumn,
            this.posterDataGridViewImageColumn});
            this.dgv_PHIM.DataSource = this.phimBindingSource;
            this.dgv_PHIM.Location = new System.Drawing.Point(19, 320);
            this.dgv_PHIM.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_PHIM.Name = "dgv_PHIM";
            this.dgv_PHIM.RowHeadersWidth = 40;
            this.dgv_PHIM.RowTemplate.Height = 90;
            this.dgv_PHIM.Size = new System.Drawing.Size(1016, 454);
            this.dgv_PHIM.TabIndex = 4;
            // 
            // tenPhimDataGridViewTextBoxColumn
            // 
            this.tenPhimDataGridViewTextBoxColumn.DataPropertyName = "TenPhim";
            this.tenPhimDataGridViewTextBoxColumn.FillWeight = 116.9477F;
            this.tenPhimDataGridViewTextBoxColumn.HeaderText = "TenPhim";
            this.tenPhimDataGridViewTextBoxColumn.Name = "tenPhimDataGridViewTextBoxColumn";
            this.tenPhimDataGridViewTextBoxColumn.Width = 208;
            // 
            // maPhimDataGridViewTextBoxColumn
            // 
            this.maPhimDataGridViewTextBoxColumn.DataPropertyName = "MaPhim";
            this.maPhimDataGridViewTextBoxColumn.FillWeight = 77.69075F;
            this.maPhimDataGridViewTextBoxColumn.HeaderText = "MaPhim";
            this.maPhimDataGridViewTextBoxColumn.Name = "maPhimDataGridViewTextBoxColumn";
            this.maPhimDataGridViewTextBoxColumn.Width = 138;
            // 
            // giaVeDataGridViewTextBoxColumn
            // 
            this.giaVeDataGridViewTextBoxColumn.DataPropertyName = "GiaVe";
            this.giaVeDataGridViewTextBoxColumn.FillWeight = 101.5228F;
            this.giaVeDataGridViewTextBoxColumn.HeaderText = "GiaVe";
            this.giaVeDataGridViewTextBoxColumn.Name = "giaVeDataGridViewTextBoxColumn";
            this.giaVeDataGridViewTextBoxColumn.Width = 180;
            // 
            // posterDataGridViewImageColumn
            // 
            this.posterDataGridViewImageColumn.DataPropertyName = "Poster";
            this.posterDataGridViewImageColumn.FillWeight = 103.8387F;
            this.posterDataGridViewImageColumn.HeaderText = "Poster";
            this.posterDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.posterDataGridViewImageColumn.Name = "posterDataGridViewImageColumn";
            this.posterDataGridViewImageColumn.Width = 184;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 833);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên phim :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 881);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã phim :";
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.Location = new System.Drawing.Point(227, 830);
            this.txtTenPhim.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.Size = new System.Drawing.Size(252, 22);
            this.txtTenPhim.TabIndex = 7;
            // 
            // txtMaPhim
            // 
            this.txtMaPhim.Location = new System.Drawing.Point(227, 878);
            this.txtMaPhim.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPhim.Name = "txtMaPhim";
            this.txtMaPhim.Size = new System.Drawing.Size(252, 22);
            this.txtMaPhim.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 933);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Giá vé :";
            // 
            // txtGiaVe
            // 
            this.txtGiaVe.Location = new System.Drawing.Point(227, 929);
            this.txtGiaVe.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaVe.Name = "txtGiaVe";
            this.txtGiaVe.Size = new System.Drawing.Size(252, 22);
            this.txtGiaVe.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(600, 793);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Poster :";
            // 
            // pbPoster
            // 
            this.pbPoster.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbPoster.Location = new System.Drawing.Point(572, 812);
            this.pbPoster.Margin = new System.Windows.Forms.Padding(4);
            this.pbPoster.Name = "pbPoster";
            this.pbPoster.Size = new System.Drawing.Size(133, 153);
            this.pbPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPoster.TabIndex = 12;
            this.pbPoster.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(772, 827);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 28);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEditFilm
            // 
            this.btnEditFilm.AutoSize = true;
            this.btnEditFilm.Location = new System.Drawing.Point(772, 875);
            this.btnEditFilm.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditFilm.Name = "btnEditFilm";
            this.btnEditFilm.Size = new System.Drawing.Size(145, 28);
            this.btnEditFilm.TabIndex = 14;
            this.btnEditFilm.Text = "Sửa Thông Tin Film";
            this.btnEditFilm.UseVisualStyleBackColor = true;
            this.btnEditFilm.Click += new System.EventHandler(this.btnEditFilm_Click);
            // 
            // btnDelFilm
            // 
            this.btnDelFilm.AutoSize = true;
            this.btnDelFilm.Location = new System.Drawing.Point(772, 927);
            this.btnDelFilm.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelFilm.Name = "btnDelFilm";
            this.btnDelFilm.Size = new System.Drawing.Size(145, 28);
            this.btnDelFilm.TabIndex = 15;
            this.btnDelFilm.Text = "Xóa Phim";
            this.btnDelFilm.UseVisualStyleBackColor = true;
            this.btnDelFilm.Click += new System.EventHandler(this.btnDelFilm_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(959, 827);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(145, 28);
            this.btnReload.TabIndex = 16;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(959, 875);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 28);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(959, 927);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 28);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(572, 972);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(145, 28);
            this.btnBrowse.TabIndex = 19;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblKetQua);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbTinhPhim);
            this.groupBox1.Location = new System.Drawing.Point(3, 1030);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1189, 100);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doanh Thu";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(396, 34);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(57, 17);
            this.lblKetQua.TabIndex = 3;
            this.lblKetQua.Text = "Kết quả";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tính";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Phim";
            // 
            // cbTinhPhim
            // 
            this.cbTinhPhim.FormattingEnabled = true;
            this.cbTinhPhim.Location = new System.Drawing.Point(88, 31);
            this.cbTinhPhim.Name = "cbTinhPhim";
            this.cbTinhPhim.Size = new System.Drawing.Size(198, 24);
            this.cbTinhPhim.TabIndex = 0;
            this.cbTinhPhim.SelectedIndexChanged += new System.EventHandler(this.cbPhim_SelectedIndexChanged);
            // 
            // PhimUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnDelFilm);
            this.Controls.Add(this.btnEditFilm);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pbPoster);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGiaVe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaPhim);
            this.Controls.Add(this.txtTenPhim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_PHIM);
            this.Controls.Add(this.pbUpinIpin);
            this.Controls.Add(this.pbCorgi);
            this.Controls.Add(this.pbLatMat);
            this.Controls.Add(this.pbAvengers);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PhimUC";
            this.Size = new System.Drawing.Size(1195, 1130);
            this.Load += new System.EventHandler(this.PhimUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvengers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLatMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCorgi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpinIpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PHIM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyRapPhimDataSet_PHIM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAvengers;
        private System.Windows.Forms.PictureBox pbLatMat;
        private System.Windows.Forms.PictureBox pbCorgi;
        private System.Windows.Forms.PictureBox pbUpinIpin;
        private System.Windows.Forms.DataGridView dgv_PHIM;
        private System.Windows.Forms.BindingSource phimBindingSource;
        private QuanLyRapPhimDataSet_PHIM quanLyRapPhimDataSet_PHIM;
        private QuanLyRapPhimDataSet_PHIMTableAdapters.PhimTableAdapter phimTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenPhim;
        private System.Windows.Forms.TextBox txtMaPhim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGiaVe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbPoster;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEditFilm;
        private System.Windows.Forms.Button btnDelFilm;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPhimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaVeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn posterDataGridViewImageColumn;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTinhPhim;
    }
}