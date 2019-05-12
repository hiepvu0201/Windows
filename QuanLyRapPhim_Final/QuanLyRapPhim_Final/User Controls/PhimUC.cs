﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyRapPhim_Final.BSLayer;
using System.Data.SqlClient;

namespace QuanLyRapPhim_Final.User_Controls
{
    public partial class PhimUC : UserControl
    {
        DataTable dtPhim = null;
        bool Them = false;
        string err;
        BLPhim dbPhim = new BLPhim();

        public PhimUC()
        {
            InitializeComponent();
        }

        private void PhimUC_Load(object sender, EventArgs e)
        {
            this.phimTableAdapter.Fill(this.quanLyRapPhimDataSet_PHIM.Phim);
        }
        void LoadData()
        {
            try
            {
                dtPhim = new DataTable();
                dtPhim.Clear();
                DataSet ds = dbPhim.LayPhim();
                dtPhim = ds.Tables[0];

                dgv_PHIM.DataSource = dtPhim;
                dgv_PHIM.AutoResizeColumns();

                txtMaPhim.ResetText();
                txtTenPhim.ResetText();
                txtGiaVe.ResetText();
                txtMaPhim.Enabled = false;

                btnCancel.Enabled = false;
                btnSave.Enabled = false;
                btnAdd.Enabled = true;
                btnEditFilm.Enabled = true;
                btnDelFilm.Enabled = true;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table KHACHHANG. Lỗi rồi!!!");
            }
        }

        private void btnEditFilm_Click(object sender, EventArgs e)
        {
            Them = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnAdd.Enabled = false;
            btnEditFilm.Enabled = false;
            btnDelFilm.Enabled = false;
            txtMaPhim.Enabled = false;
            txtTenPhim.Focus();
            txtGiaVe.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Them = true;
            txtMaPhim.Enabled = true;
            txtMaPhim.ResetText();
            txtTenPhim.ResetText();
            txtGiaVe.ResetText();

            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnAdd.Enabled = false;
            btnEditFilm.Enabled = false;
            btnDelFilm.Enabled = false;
            txtMaPhim.Focus();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMaPhim.ResetText();
            txtTenPhim.ResetText();
            txtGiaVe.ResetText();
            btnAdd.Enabled = true;
            btnEditFilm.Enabled = true;
            btnDelFilm.Enabled = true;
            btnCancel.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    BLPhim blPhim = new BLPhim();
                    blPhim.ThemPhim(this.txtTenPhim.Text.Trim(), this.txtMaPhim.Text.Trim(), int.Parse(txtGiaVe.Text.ToString()), ref err);
                    LoadData();
                    MessageBox.Show("Đã thêm xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");

                }
            }
            else
            {
                try
                {
                    BLPhim blPhim = new BLPhim();
                    blPhim.CapNhatPhim(this.txtMaPhim.Text.Trim(), this.txtTenPhim.Text.Trim(), ref err);
                    LoadData();
                    MessageBox.Show("Đã sửa xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không sửa được. Lỗi rồi!");
                }
            }
        }

        private void btnDelFilm_Click(object sender, EventArgs e)
        {
            int r = dgv_PHIM.CurrentCell.RowIndex;
            string strPhim = dgv_PHIM.Rows[r].Cells[0].Value.ToString();

            DialogResult traloi;
            traloi = MessageBox.Show("Bạn thực sự muốn xóa?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {

                try
                {
                    dbPhim.XoaPhim(ref err, strPhim);
                    LoadData();
                    MessageBox.Show("Đã xóa!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Lỗi!!! Xóa thất bại!");
                }

            }
        }
    }
}