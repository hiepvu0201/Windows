﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyRapPhim_Final.DBLayer;
using System.Data;

namespace QuanLyRapPhim_Final.BSLayer
{
    class BLDatVe
    {
        DBMain db = null;
        public BLDatVe()
        {
            db = new DBMain();
        }
        public DataSet LayThongTinVe()
        {
            return db.ExecuteQueryDataSet("select * from DatVe",
                CommandType.Text);
        }

        public DataSet findBookedSeat(string MaRap,string tgChieu)
        {

            return db.ExecuteQueryDataSet($"select Day,So from DatVe where MaRap='{MaRap.Trim()}' and SuatChieu='{tgChieu.Trim()}'",CommandType.Text);

            //return db.ExecuteQueryDataSet(
            //    $"select Day,So from DatVe where MaRap=" +
            //    $"'{MaRap.Trim()}'",CommandType.Text);

        }
        public DataSet findHour(string tgChieu)
        {

            return db.ExecuteQueryDataSet("select A.SuatChieu,B.TenPhim,B.MaPhim from DatVe as A inner join Phim as B on A.MaPhim = B.MaPhim",CommandType.Text);

            //return db.ExecuteQueryDataSet(
            //    "select A.SuatChieu,B.TenPhim from DatVe as A " +
            //    "inner join Phim as B on A.MaPhim = B.MaPhim",
            //    CommandType.Text);

        }

    }
}
