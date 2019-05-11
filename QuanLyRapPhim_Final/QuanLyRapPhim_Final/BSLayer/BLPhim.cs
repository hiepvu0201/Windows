using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyRapPhim_Final.DBLayer;
using System.Data;

namespace QuanLyRapPhim_Final.BSLayer
{
    class BLPhim
    {
        DBMain db = null;
        public BLPhim()
        {
            db = new DBMain();
        }
        public DataSet LayPhim()
        {
            return db.ExecuteQueryDataSet("select * from Phim", CommandType.Text);
        }
        public bool ThemPhim(string TenPhim, string MaPhim, int GiaVe,   ref string err)
        {
            string sqlString = "Insert Into Phim Values(" + "'" + TenPhim + "',N'" + MaPhim + "',N'" + GiaVe /*+ "',N'" + ThanhPho*/ + "',N'"  + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaPhim(ref string err, string MaPhim)
        {
            string sqlString = "Delete From Phim Where MaPhim='" + MaPhim + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatPhim(string MaPhim, string TenPhim, ref string err)
        {
            string sqlString = "Update Phim Set TenPhim=N'" + TenPhim + "' Where MaPhim='" + MaPhim + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
