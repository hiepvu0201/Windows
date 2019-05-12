namespace QuanLyRapPhim_Final.User_Controls
{
    partial class DatVeUC
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maPhimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suatChieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maRapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datVeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyRapPhimDataSet_DATVE = new QuanLyRapPhim_Final.QuanLyRapPhimDataSet_DATVE();
            this.datVeTableAdapter = new QuanLyRapPhim_Final.QuanLyRapPhimDataSet_DATVETableAdapters.DatVeTableAdapter();
            this.seatPanel = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datVeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyRapPhimDataSet_DATVE)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhimDataGridViewTextBoxColumn,
            this.suatChieuDataGridViewTextBoxColumn,
            this.maNVDataGridViewTextBoxColumn,
            this.maKHDataGridViewTextBoxColumn,
            this.maRapDataGridViewTextBoxColumn,
            this.dayDataGridViewTextBoxColumn,
            this.soDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.datVeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1180, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(25, 17);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            // 
            // maPhimDataGridViewTextBoxColumn
            // 
            this.maPhimDataGridViewTextBoxColumn.DataPropertyName = "MaPhim";
            this.maPhimDataGridViewTextBoxColumn.HeaderText = "MaPhim";
            this.maPhimDataGridViewTextBoxColumn.Name = "maPhimDataGridViewTextBoxColumn";
            // 
            // suatChieuDataGridViewTextBoxColumn
            // 
            this.suatChieuDataGridViewTextBoxColumn.DataPropertyName = "SuatChieu";
            this.suatChieuDataGridViewTextBoxColumn.HeaderText = "SuatChieu";
            this.suatChieuDataGridViewTextBoxColumn.Name = "suatChieuDataGridViewTextBoxColumn";
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "MaNV";
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            // 
            // maKHDataGridViewTextBoxColumn
            // 
            this.maKHDataGridViewTextBoxColumn.DataPropertyName = "MaKH";
            this.maKHDataGridViewTextBoxColumn.HeaderText = "MaKH";
            this.maKHDataGridViewTextBoxColumn.Name = "maKHDataGridViewTextBoxColumn";
            // 
            // maRapDataGridViewTextBoxColumn
            // 
            this.maRapDataGridViewTextBoxColumn.DataPropertyName = "MaRap";
            this.maRapDataGridViewTextBoxColumn.HeaderText = "MaRap";
            this.maRapDataGridViewTextBoxColumn.Name = "maRapDataGridViewTextBoxColumn";
            // 
            // dayDataGridViewTextBoxColumn
            // 
            this.dayDataGridViewTextBoxColumn.DataPropertyName = "Day";
            this.dayDataGridViewTextBoxColumn.HeaderText = "Day";
            this.dayDataGridViewTextBoxColumn.Name = "dayDataGridViewTextBoxColumn";
            // 
            // soDataGridViewTextBoxColumn
            // 
            this.soDataGridViewTextBoxColumn.DataPropertyName = "So";
            this.soDataGridViewTextBoxColumn.HeaderText = "So";
            this.soDataGridViewTextBoxColumn.Name = "soDataGridViewTextBoxColumn";
            // 
            // datVeBindingSource
            // 
            this.datVeBindingSource.DataMember = "DatVe";
            this.datVeBindingSource.DataSource = this.quanLyRapPhimDataSet_DATVE;
            // 
            // quanLyRapPhimDataSet_DATVE
            // 
            this.quanLyRapPhimDataSet_DATVE.DataSetName = "QuanLyRapPhimDataSet_DATVE";
            this.quanLyRapPhimDataSet_DATVE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datVeTableAdapter
            // 
            this.datVeTableAdapter.ClearBeforeFill = true;
            // 
            // seatPanel
            // 
            this.seatPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seatPanel.Location = new System.Drawing.Point(20, 139);
            this.seatPanel.Name = "seatPanel";
            this.seatPanel.Size = new System.Drawing.Size(1173, 462);
            this.seatPanel.TabIndex = 1;
            this.seatPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.seatPanel_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(70, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rạp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phim:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(70, 63);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(136, 24);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // DatVeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.seatPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DatVeUC";
            this.Size = new System.Drawing.Size(1208, 634);
            this.Load += new System.EventHandler(this.DatVeUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datVeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyRapPhimDataSet_DATVE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suatChieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maRapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource datVeBindingSource;
        private QuanLyRapPhimDataSet_DATVE quanLyRapPhimDataSet_DATVE;
        private QuanLyRapPhimDataSet_DATVETableAdapters.DatVeTableAdapter datVeTableAdapter;
        private System.Windows.Forms.Panel seatPanel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}
