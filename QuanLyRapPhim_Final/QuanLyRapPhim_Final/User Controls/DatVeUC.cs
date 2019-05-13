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
using QuanLyRapPhim_Final.BSLayer;
using QuanLyRapPhim_Final.renderSeat;

namespace QuanLyRapPhim_Final.User_Controls
{
    public partial class DatVeUC : UserControl
    {
        DataTable dtRap = null;
        DataTable dtDatVe = null;
        DataTable dtPhim = null;

        BLPhim dbPhim = new BLPhim();
        BLDatVe dbDatVe = new BLDatVe();
        BLRap dbRap = new BLRap();
        Graphics gp;
        private List<string> bookedSeatAlpha ;
        private List<string> bookedSeatNum;
        private string globalRap;
        public DatVeUC()
        {
            InitializeComponent();
        }

        private void DatVeUC_Load(object sender, EventArgs e)
        {

            this.datVeTableAdapter.Fill(this.quanLyRapPhimDataSet_DATVE.DatVe);
            dtRap = new DataTable();
            dtRap.Clear();
            setCombobox2();
            DataSet ds = dbRap.LayRap();
            dtRap = ds.Tables[0];
            //comboBox1.DataSource = dtRap;
            //comboBox1.DisplayMember = "MaRap";
            //comboBox1.ValueMember = "MaRap";
            gp = seatPanel.CreateGraphics();
            seatPanel.Visible=false;
        }
        private void setCombobox2()
        {
            dtPhim = new DataTable();
            dtPhim.Clear();
            DataSet ds = dbPhim.LayPhim();
            dtPhim = ds.Tables[0];
            comboBox2.DataSource = dtPhim;
            comboBox2.DisplayMember = "TenPhim";
            comboBox2.ValueMember = "TenPhim";
            setCombobox1(dtPhim);
        }
        private void setCombobox1(DataTable dt)
        {
            dtDatVe = new DataTable();
            dtDatVe.Clear();
            DataSet ds = dbDatVe.LayThongTinVe();
            dtDatVe = ds.Tables[0];
            for (int i = 0; i < dtPhim.Rows.Count; i++)
            {
                if (comboBox2.Text == dt.Rows[i].ItemArray[0].ToString())
                {
                    globalRap = dtDatVe.Rows[i].ItemArray[4].ToString();
                }
            }


        }
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //seatPanel.Visible = true;
            //render seatLoader = new render();
            //dtRap = new DataTable();
            //dtRap.Clear();
            //DataSet ds = dbRap.findRap(comboBox1.SelectedValue.ToString());
            //dtRap = ds.Tables[0];
            //if (dtRap.Rows.Count != 0)
            //{
            //    ds = dbRap.findSoDayGhe(comboBox1.SelectedValue.ToString());
            //    dtRap = ds.Tables[0];
            //    Program.hangGhe = Convert.ToInt32(dtRap.Rows[0].ItemArray[0].ToString());
            //    ds = dbRap.findSoLuongGhe(comboBox1.SelectedValue.ToString());
            //    dtRap = ds.Tables[0];
            //    Program.soGhe = Convert.ToInt32(dtRap.Rows[0].ItemArray[0].ToString());
            //    seatLoader.removeSeat(ref seatPanel);
            //    seatPanel.Refresh();
            //    getBookedSeat();
            //    seatLoader.renderSeat(ref seatPanel, bookedSeatAlpha, bookedSeatNum);
            //}

        }

        private void seatPanel_Paint(object sender, PaintEventArgs e)
        {
            render matrix = new render(seatPanel.Width,seatPanel.Height);
            matrix.drawTable(gp);
        }
        private void getBookedSeat()
        {
            dtDatVe = new DataTable();
            dtDatVe.Clear();
            //comboBox1.SelectedValue.ToString()
            DataSet ds = dbDatVe.findBookedSeat(globalRap);
            dtDatVe = ds.Tables[0];
            bookedSeatAlpha = new List<string>();
            bookedSeatNum = new List<string>();
            if (dtDatVe.Rows.Count!=0)
            {
                for (int i = 0; i < dtDatVe.Rows.Count; i++)   //2 cột
                {

                    bookedSeatAlpha.Add(dtDatVe.Rows[i].ItemArray[0].ToString());
                    bookedSeatNum.Add(dtDatVe.Rows[i].ItemArray[1].ToString());

                }
            }
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string time;
            dtPhim = new DataTable();
            dtPhim.Clear();
            DataSet dsPhim = dbPhim.LayPhim();
            dtPhim = dsPhim.Tables[0];
            setCombobox1(dtPhim);
            //render chỗ khi change index
            seatPanel.Visible = true;
            render seatLoader = new render();
            dtRap = new DataTable();
            dtRap.Clear();
            DataSet ds = dbRap.findRap(globalRap);
            dtRap = ds.Tables[0];


            if (dtRap.Rows.Count != 0)
            {
                ds = dbRap.findSoDayGhe(globalRap);
                dtRap = ds.Tables[0];
                Program.hangGhe = Convert.ToInt32(dtRap.Rows[0].ItemArray[0].ToString());
                ds = dbRap.findSoLuongGhe(globalRap);
                dtRap = ds.Tables[0];
                Program.soGhe = Convert.ToInt32(dtRap.Rows[0].ItemArray[0].ToString());
                seatLoader.removeSeat(ref seatPanel);
                seatPanel.Refresh();
                time = getHour();
                getBookedSeat();
                seatLoader.renderSeat(ref seatPanel, bookedSeatAlpha, bookedSeatNum,time);
            }

        }
        private string getHour()
        {
            dtDatVe = new DataTable();
            dtDatVe.Clear();
            DataSet dsDatVe = dbDatVe.findHour();
            dtDatVe = dsDatVe.Tables[0];
            for (int i = 0; i < dtDatVe.Rows.Count; i++)
            {
                if (comboBox2.Text==dtDatVe.Rows[i].ItemArray[0].ToString())
                {
                    return dtDatVe.Rows[i].ItemArray[1].ToString();
                }
            }
            return "";
        }
    }
}
