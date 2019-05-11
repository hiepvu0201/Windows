using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyRapPhim_Final.BSLayer;

namespace QuanLyRapPhim_Final.User_Controls
{
    public partial class QuanLyNhanVienUC : UserControl
    {
        bool Them;
        string err;
        BLNhanVien dbNV = new BLNhanVien();

        public QuanLyNhanVienUC()
        {
            InitializeComponent();
        }

        private void QuanLyNhanVienUC_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            // Xóa trống các đối tượng trong Panel
            txtMaNV.ResetText();
            txtHovalotNV.ResetText();
            txtTenNV.ResetText();
            // Không cho thao tác trên các nút Lưu / Hủy
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            btnAdd.Enabled = true;
            btnEditNV.Enabled = true;
            btnDelNV.Enabled = true;
            try
            {
                this.nhanVienTableAdapter.Fill(this.quanLyRapPhimDataSet_NHANVIEN.NhanVien);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table THANHPHO. Lỗi rồi!!!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Them = true;

            txtHovalotNV.Enabled = true;
            txtHovalotNV.ResetText();
            txtMaNV.Enabled = true;
            txtMaNV.ResetText();
            txtTenNV.Enabled = true;
            txtTenNV.ResetText();

            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            btnAdd.Enabled = false;
            btnEditNV.Enabled = false;
            btnDelNV.Enabled = false;
        }

        private void btnEditNV_Click(object sender, EventArgs e)
        {
            Them = false;

            dgv_NHANVIEN_CellClick(null, null);
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            btnAdd.Enabled = false;
            btnEditNV.Enabled = false;
            btnDelNV.Enabled = false;

            txtMaNV.Enabled = false;
        }

        private void dgv_NHANVIEN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_NHANVIEN.CurrentCell.RowIndex;

            txtMaNV.Text = dgv_NHANVIEN.Rows[r].Cells[0].Value.ToString();
            txtHovalotNV.Text = dgv_NHANVIEN.Rows[r].Cells[1].Value.ToString();
            txtTenNV.Text = dgv_NHANVIEN.Rows[r].Cells[2].Value.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    BLNhanVien blNV = new BLNhanVien();
                    blNV.ThemNhanVien(this.txtMaNV.Text.Trim(), this.txtHovalotNV.Text.Trim(), this.txtTenNV.Text.Trim(), ref err);
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
                BLNhanVien blNV = new BLNhanVien();
                blNV.CapNhatNhanVien(this.txtMaNV.Text, this.txtTenNV.Text, ref err);
                LoadData();
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnDelNV_Click(object sender, EventArgs e)
        {
            int r = dgv_NHANVIEN.CurrentCell.RowIndex;
            string strNV = dgv_NHANVIEN.Rows[r].Cells[0].Value.ToString();

            DialogResult traloi;
            traloi = MessageBox.Show("Bạn thực sự muốn xóa?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {

                try
                {
                    dbNV.XoaNhanVien(ref err, strNV);
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
