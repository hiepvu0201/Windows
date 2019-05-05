using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyRapPhim_Final.User_Controls;
using QuanLyRapPhim_Final.queryLayer;

namespace QuanLyRapPhim_Final.User_Controls
{
    public partial class DatVeUC : UserControl
    {
        DataTable dtRap = null;
        queryRap dbRap = new queryRap();

        public DatVeUC()
        {
            InitializeComponent();
        }

        private void DatVeUC_Load(object sender, EventArgs e)
        {
            this.datVeTableAdapter.Fill(this.quanLyRapPhimDataSet_DATVE.DatVe);
            dtRap = new DataTable();
            dtRap.Clear();
            DataSet ds = dbRap.LayRap();
            dtRap = ds.Tables[0];
            comboBox1.DataSource = dtRap;
            comboBox1.DisplayMember = "MaRap";
            comboBox1.ValueMember = "MaRap";
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
