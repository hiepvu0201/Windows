namespace QuanLyRapPhim_Final
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDatVe = new System.Windows.Forms.Button();
            this.btnQuanLyRap = new System.Windows.Forms.Button();
            this.btnQuanLyNhanVien = new System.Windows.Forms.Button();
            this.btnQuanLyKhachHang = new System.Windows.Forms.Button();
            this.pnlClick = new System.Windows.Forms.Panel();
            this.btnQuanLyPhim = new System.Windows.Forms.Button();
            this.btnWelcome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.datVeUC1 = new QuanLyRapPhim_Final.User_Controls.DatVeUC();
            this.quanLyRapUC1 = new QuanLyRapPhim_Final.User_Controls.QuanLyRapUC();
            this.quanLyNhanVienUC1 = new QuanLyRapPhim_Final.User_Controls.QuanLyNhanVienUC();
            this.quanLyKhachHangUC1 = new QuanLyRapPhim_Final.User_Controls.QuanLyKhachHangUC();
            this.phimUC1 = new QuanLyRapPhim_Final.User_Controls.PhimUC();
            this.welcomeUC1 = new QuanLyRapPhim_Final.User_Controls.WelcomeUC();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnDatVe);
            this.panel1.Controls.Add(this.btnQuanLyRap);
            this.panel1.Controls.Add(this.btnQuanLyNhanVien);
            this.panel1.Controls.Add(this.btnQuanLyKhachHang);
            this.panel1.Controls.Add(this.pnlClick);
            this.panel1.Controls.Add(this.btnQuanLyPhim);
            this.panel1.Controls.Add(this.btnWelcome);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 756);
            this.panel1.TabIndex = 0;
            // 
            // btnDatVe
            // 
            this.btnDatVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatVe.ForeColor = System.Drawing.Color.Transparent;
            this.btnDatVe.Location = new System.Drawing.Point(4, 538);
            this.btnDatVe.Margin = new System.Windows.Forms.Padding(4);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(288, 71);
            this.btnDatVe.TabIndex = 8;
            this.btnDatVe.Text = "Đặt vé";
            this.btnDatVe.UseVisualStyleBackColor = true;
            this.btnDatVe.Click += new System.EventHandler(this.btnDatVe_Click);
            // 
            // btnQuanLyRap
            // 
            this.btnQuanLyRap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyRap.ForeColor = System.Drawing.Color.Transparent;
            this.btnQuanLyRap.Location = new System.Drawing.Point(4, 459);
            this.btnQuanLyRap.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuanLyRap.Name = "btnQuanLyRap";
            this.btnQuanLyRap.Size = new System.Drawing.Size(288, 71);
            this.btnQuanLyRap.TabIndex = 7;
            this.btnQuanLyRap.Text = "Quản lý rạp";
            this.btnQuanLyRap.UseVisualStyleBackColor = true;
            this.btnQuanLyRap.Click += new System.EventHandler(this.btnQuanLyRap_Click);
            // 
            // btnQuanLyNhanVien
            // 
            this.btnQuanLyNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyNhanVien.ForeColor = System.Drawing.Color.Transparent;
            this.btnQuanLyNhanVien.Location = new System.Drawing.Point(4, 380);
            this.btnQuanLyNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            this.btnQuanLyNhanVien.Size = new System.Drawing.Size(288, 71);
            this.btnQuanLyNhanVien.TabIndex = 6;
            this.btnQuanLyNhanVien.Text = "Quản lý nhân viên";
            this.btnQuanLyNhanVien.UseVisualStyleBackColor = true;
            this.btnQuanLyNhanVien.Click += new System.EventHandler(this.btnQuanLyNhanVien_Click);
            // 
            // btnQuanLyKhachHang
            // 
            this.btnQuanLyKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyKhachHang.ForeColor = System.Drawing.Color.Transparent;
            this.btnQuanLyKhachHang.Location = new System.Drawing.Point(4, 302);
            this.btnQuanLyKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuanLyKhachHang.Name = "btnQuanLyKhachHang";
            this.btnQuanLyKhachHang.Size = new System.Drawing.Size(288, 71);
            this.btnQuanLyKhachHang.TabIndex = 5;
            this.btnQuanLyKhachHang.Text = "Quản lý khách hàng";
            this.btnQuanLyKhachHang.UseVisualStyleBackColor = true;
            this.btnQuanLyKhachHang.Click += new System.EventHandler(this.btnQuanLyKhachHang_Click);
            // 
            // pnlClick
            // 
            this.pnlClick.BackColor = System.Drawing.Color.White;
            this.pnlClick.Location = new System.Drawing.Point(4, 144);
            this.pnlClick.Margin = new System.Windows.Forms.Padding(4);
            this.pnlClick.Name = "pnlClick";
            this.pnlClick.Size = new System.Drawing.Size(24, 71);
            this.pnlClick.TabIndex = 4;
            // 
            // btnQuanLyPhim
            // 
            this.btnQuanLyPhim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyPhim.ForeColor = System.Drawing.Color.Transparent;
            this.btnQuanLyPhim.Location = new System.Drawing.Point(4, 223);
            this.btnQuanLyPhim.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuanLyPhim.Name = "btnQuanLyPhim";
            this.btnQuanLyPhim.Size = new System.Drawing.Size(288, 71);
            this.btnQuanLyPhim.TabIndex = 3;
            this.btnQuanLyPhim.Text = "Phim đang chiếu";
            this.btnQuanLyPhim.UseVisualStyleBackColor = true;
            this.btnQuanLyPhim.Click += new System.EventHandler(this.btnQuanLyPhim_Click);
            // 
            // btnWelcome
            // 
            this.btnWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWelcome.ForeColor = System.Drawing.Color.Transparent;
            this.btnWelcome.Location = new System.Drawing.Point(4, 144);
            this.btnWelcome.Margin = new System.Windows.Forms.Padding(4);
            this.btnWelcome.Name = "btnWelcome";
            this.btnWelcome.Size = new System.Drawing.Size(288, 71);
            this.btnWelcome.TabIndex = 1;
            this.btnWelcome.Text = "Welcome";
            this.btnWelcome.UseVisualStyleBackColor = true;
            this.btnWelcome.Click += new System.EventHandler(this.btnWelcome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.datVeUC1);
            this.panel2.Controls.Add(this.quanLyRapUC1);
            this.panel2.Controls.Add(this.quanLyNhanVienUC1);
            this.panel2.Controls.Add(this.quanLyKhachHangUC1);
            this.panel2.Controls.Add(this.phimUC1);
            this.panel2.Controls.Add(this.welcomeUC1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panelHeader);
            this.panel2.Location = new System.Drawing.Point(304, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1208, 756);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(1, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1195, 75);
            this.label1.TabIndex = 3;
            this.label1.Text = "PHẦN MỀM QUẢN LÝ RẠP PHIM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panelHeader.Controls.Add(this.pbClose);
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Location = new System.Drawing.Point(4, 79);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1195, 60);
            this.panelHeader.TabIndex = 1;
            // 
            // pbClose
            // 
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(1084, -1);
            this.pbClose.Margin = new System.Windows.Forms.Padding(4);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(76, 58);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 1;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(63, 12);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(149, 38);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Welcome";
            // 
            // datVeUC1
            // 
            this.datVeUC1.Location = new System.Drawing.Point(2, 136);
            this.datVeUC1.Margin = new System.Windows.Forms.Padding(4);
            this.datVeUC1.Name = "datVeUC1";
            this.datVeUC1.Size = new System.Drawing.Size(1195, 620);
            this.datVeUC1.TabIndex = 9;
            // 
            // quanLyRapUC1
            // 
            this.quanLyRapUC1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanLyRapUC1.Location = new System.Drawing.Point(2, 145);
            this.quanLyRapUC1.Margin = new System.Windows.Forms.Padding(5);
            this.quanLyRapUC1.Name = "quanLyRapUC1";
            this.quanLyRapUC1.Size = new System.Drawing.Size(1216, 618);
            this.quanLyRapUC1.TabIndex = 8;
            // 
            // quanLyNhanVienUC1
            // 
            this.quanLyNhanVienUC1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanLyNhanVienUC1.Location = new System.Drawing.Point(3, 143);
            this.quanLyNhanVienUC1.Margin = new System.Windows.Forms.Padding(5);
            this.quanLyNhanVienUC1.Name = "quanLyNhanVienUC1";
            this.quanLyNhanVienUC1.Size = new System.Drawing.Size(1792, 907);
            this.quanLyNhanVienUC1.TabIndex = 7;
            // 
            // quanLyKhachHangUC1
            // 
            this.quanLyKhachHangUC1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanLyKhachHangUC1.Location = new System.Drawing.Point(3, 143);
            this.quanLyKhachHangUC1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.quanLyKhachHangUC1.Name = "quanLyKhachHangUC1";
            this.quanLyKhachHangUC1.Size = new System.Drawing.Size(1195, 620);
            this.quanLyKhachHangUC1.TabIndex = 6;
            // 
            // phimUC1
            // 
            this.phimUC1.Location = new System.Drawing.Point(4, 143);
            this.phimUC1.Margin = new System.Windows.Forms.Padding(5);
            this.phimUC1.Name = "phimUC1";
            this.phimUC1.Size = new System.Drawing.Size(1195, 620);
            this.phimUC1.TabIndex = 5;
            // 
            // welcomeUC1
            // 
            this.welcomeUC1.Location = new System.Drawing.Point(5, 143);
            this.welcomeUC1.Margin = new System.Windows.Forms.Padding(5);
            this.welcomeUC1.Name = "welcomeUC1";
            this.welcomeUC1.Size = new System.Drawing.Size(1195, 620);
            this.welcomeUC1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 758);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlClick;
        private System.Windows.Forms.Button btnQuanLyPhim;
        private System.Windows.Forms.Button btnWelcome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Label lblHeader;
        private User_Controls.WelcomeUC welcomeUC1;
        private User_Controls.PhimUC phimUC1;
        private System.Windows.Forms.Button btnQuanLyKhachHang;
        private User_Controls.QuanLyKhachHangUC quanLyKhachHangUC1;
        private System.Windows.Forms.Button btnQuanLyNhanVien;
        private User_Controls.QuanLyNhanVienUC quanLyNhanVienUC1;
        private User_Controls.QuanLyRapUC quanLyRapUC1;
        private System.Windows.Forms.Button btnQuanLyRap;
        private System.Windows.Forms.Button btnDatVe;
        private User_Controls.DatVeUC datVeUC1;
    }
}

