using System;
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
            return db.ExecuteQueryDataSet("select * from DatVe", CommandType.Text);
        }

        public DataSet findBookedSeat(string MaRap)
        {
            return db.ExecuteQueryDataSet($"select Day,So from DatVe where MaRap='{MaRap.Trim()}'",CommandType.Text);
        }

    }
}
