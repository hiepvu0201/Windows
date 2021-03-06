﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyRapPhim_Final.DBLayer;
using System.Data;

namespace QuanLyRapPhim_Final.BSLayer
{
    class BLNhanVien
    {
        DBMain db = null;
        public BLNhanVien()
        {
            db = new DBMain();
        }
        public DataSet LayNhanVien()
        {
            return db.ExecuteQueryDataSet("select * from NhanVien",
                CommandType.Text);
        }
        public bool ThemNhanVien(string MaNV, string HovaTenLotNV, 
            string TenNV, string MaCV,ref string err)
        {
            string sqlString =
                $"Insert Into NhanVien Values " +
                "( " + " '" + MaNV + " ' ,N'" + HovaTenLotNV + "',N'" 
                + TenNV + "',N'" + MaCV + "') ";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaNhanVien(ref string err, string MaNV)
        {
            string sqlString = "Delete From NhanVien Where MaNV='"
                + MaNV + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatNhanVien(string MaNV, string TenNV, ref string err)
        {
            string sqlString = "Update NhanVien Set TenNV=N'" + TenNV +
                "' Where MaNV='" + MaNV + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}