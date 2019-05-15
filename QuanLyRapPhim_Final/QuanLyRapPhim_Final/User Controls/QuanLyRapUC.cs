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

namespace QuanLyRapPhim_Final.User_Controls
{
    public partial class QuanLyRapUC : UserControl
    {
        bool them;
        bool Them;
        string err;
        BLRap dbRap = new BLRap();
        DataTable dt = new DataTable();

        public QuanLyRapUC()
        {
            InitializeComponent();
        }

        private void QuanLyRapUC_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {

            // Xóa trống các đối tượng trong Panel
            txtMaRap.ResetText();
            txtSoDayGhe.ResetText();
            txtSoLuongGhe.ResetText();
            cbbLoaiPhim.ResetText();



            // Không cho thao tác trên các nút Lưu / Hủy
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDel.Enabled = true;
            try
            {
                this.rapTableAdapter.Fill(this.quanLyRapPhimDataSet_RAP.Rap);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table NHANVIEN. Lỗi rồi!!!");
            }
        }
        private void BtnAdd_Click_1(object sender, EventArgs e)
        {
            Them = true;

            txtMaRap.Enabled = true;

            txtMaRap.ResetText();
            txtSoDayGhe.Enabled = true;
            txtSoDayGhe.ResetText();
            txtSoLuongGhe.Enabled = true;
            txtSoLuongGhe.ResetText();

            cbbLoaiPhim.Enabled = true;
            cbbLoaiPhim.ResetText();

            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

            Them = false;

            Dgv_RAP_CellClick(null, null);
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;

            txtMaRap.Enabled = false;
        }
        private void Dgv_RAP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_RAP.CurrentCell.RowIndex;
            txtMaRap.Text = dgv_RAP.Rows[r].Cells[0].Value.ToString();
            txtSoDayGhe.Text = dgv_RAP.Rows[r].Cells[1].Value.ToString();
            txtSoLuongGhe.Text = dgv_RAP.Rows[r].Cells[2].Value.ToString();
            cbbLoaiPhim.Text = dgv_RAP.Rows[r].Cells[3].Value.ToString();
        }
    }
}
