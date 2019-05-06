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
using QuanLyRapPhim_Final.renderSeat;

namespace QuanLyRapPhim_Final.User_Controls
{
    public partial class DatVeUC : UserControl
    {
        DataTable dtRap = null;
        queryRap dbRap = new queryRap();
        Graphics gp;

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
            gp = seatPanel.CreateGraphics();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            dtRap = new DataTable();
            dtRap.Clear();
            DataSet ds = dbRap.findRap(comboBox1.SelectedValue.ToString());
            dtRap = ds.Tables[0];
            if (dtRap.Rows.Count!=0)
            {
                ds = dbRap.findSoDayGhe(comboBox1.SelectedValue.ToString());
                dtRap = ds.Tables[0];
                Program.hangGhe = Convert.ToInt32(dtRap.Rows[0].ItemArray[0].ToString());
                ds = dbRap.findSoLuongGhe(comboBox1.SelectedValue.ToString());
                dtRap = ds.Tables[0];
                Program.soGhe = Convert.ToInt32(dtRap.Rows[0].ItemArray[0].ToString());
                seatPanel.Refresh();
            }

        }

        private void seatPanel_Paint(object sender, PaintEventArgs e)
        {
            render matrix = new render(seatPanel.Width,seatPanel.Height);


            matrix.drawTable(gp);
        }
    }
}
