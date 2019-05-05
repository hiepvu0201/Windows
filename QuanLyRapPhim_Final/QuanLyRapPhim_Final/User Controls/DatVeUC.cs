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
        private int hangGhe;
        private int soGhe;
        string alPha = "abcdefghijklmnopqrstuvwxyz";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtRap = new DataTable();
            dtRap.Clear();
            DataSet ds = dbRap.findRap(comboBox1.Text);
            dtRap = ds.Tables[0];
            try
            {
                if(dtRap.Rows[0].ItemArray[0]!= null)
                {
                    ds = dbRap.findSoDayGhe(comboBox1.Text);
                    dtRap = ds.Tables[0];

                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void seatPanel_Paint(object sender, PaintEventArgs e)
        {
            render matrix = new render(seatPanel.Width,seatPanel.Height);
            matrix.drawTable(gp);
        }
    }
}
