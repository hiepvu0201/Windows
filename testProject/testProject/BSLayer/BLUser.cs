using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace testProject.BSLayer
{
    class BLUser
    {
        public System.Data.Linq.Table<dtbGame> LayDuLieu()
        {
            DataSet ds = new DataSet();
            QuanlyUserDataContext qlUser = new QuanlyUserDataContext();
            return qlUser.dtbGames;
        }
        public bool ThemNguoiDung(string TaiKhoan, string MatKhau, string DienThoai,string Email,string Point,ref string err)
        {
            try
            {
                QuanlyUserDataContext qlUser = new QuanlyUserDataContext();
                dtbGame dtb = new dtbGame();
                dtb.TaiKhoan = TaiKhoan;
                dtb.MatKhau = MatKhau;
                dtb.DienThoai = DienThoai;
                dtb.Email = Email;
                dtb.Point = Point;

                qlUser.dtbGames.InsertOnSubmit(dtb);
                qlUser.dtbGames.Context.SubmitChanges();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thêm được. Lỗi rồi!");
            }
            return true;
        }
        public bool KtDangNhap(string TaiKhoan, string MatKhau, ref string err)
        {
            try
            {
                QuanlyUserDataContext qlUser = new QuanlyUserDataContext();
                var userQuery = (from tk in qlUser.dtbGames
                                 where tk.TaiKhoan == TaiKhoan && tk.MatKhau == MatKhau
                                 select tk).Count();
                if (userQuery == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể đăng nhập. Lỗi rồi!");
            }
            return true;
        }
    }
}
