using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyRapPhim_Final.DBLayer;
using System.Data;

namespace QuanLyRapPhim_Final.BSLayer
{
    class BLChucVu
    {
        DBMain db = null;
        public BLChucVu()
        {
            db = new DBMain();
        }
        public DataSet LayChucVu()
        {
            return db.ExecuteQueryDataSet("select * from ChucVu",
                CommandType.Text);
        }
        public bool ThemChucVu(string MaCV, string ChucVu,
            int Luong, ref string err)
        {
            string sqlString =
                $"Insert Into NhanVien Values " +
                "( " + " '" + MaCV + " ' ,N'" + ChucVu + "',N'"
                + Luong + "') ";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaChucVu(ref string err, string MaCV)
        {
            string sqlString = "Delete From ChucVu Where MaCV='"
                + MaCV + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatChucVu(string MaCV, string ChucVu, ref string err)
        {
            string sqlString = "Update ChucVu Set ChucVu=N'" + ChucVu +
                "' Where MaCV='" + MaCV + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
