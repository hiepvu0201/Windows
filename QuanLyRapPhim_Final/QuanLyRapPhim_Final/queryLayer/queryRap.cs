using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyRapPhim_Final.DBLayer;
using System.Data;

namespace QuanLyRapPhim_Final.queryLayer
{
    class queryRap
    {
        DBMain db = null;
        public queryRap()
        {
            db = new DBMain();
        }
        public DataSet LayRap()
        {
            return db.ExecuteQueryDataSet("select MaRap from Rap", CommandType.Text);
        }
    }
}
