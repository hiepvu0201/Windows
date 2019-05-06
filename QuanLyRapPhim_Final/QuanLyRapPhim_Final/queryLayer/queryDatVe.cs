using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyRapPhim_Final.DBLayer;
using System.Data;

namespace QuanLyRapPhim_Final.queryLayer
{
    class queryDatVe
    {
        DBMain db = null;
        public queryDatVe()
        {
            db = new DBMain();
        }
        public DataSet LayDatVe()
        {
            return db.ExecuteQueryDataSet("select * from DatVe", CommandType.Text);
        }
        public DataSet findDay(string MaRap)
        {
            return db.ExecuteQueryDataSet($"select Day from DatVe where MaRap='{MaRap.Trim()}'",CommandType.Text);
        }
    }
}
