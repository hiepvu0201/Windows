using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Linq;
using System.Data.Linq.Mapping;
namespace Soudokan
{
    public partial class GameOver : Form
    {
        SqlConnection conec = new SqlConnection (@"Data Source=DESKTOP-F3VTH4B; "
            + "Initial Catalog=SukobanGame;"
           + "Integrated Security=True");
        public GameOver()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            lbUser.Text = curr_user;
            lbLevel.Text = curr_point;
            conec.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conec;
            cmd.CommandType = CommandType.Text;
            // Lệnh Insert InTo
            cmd.CommandText = "Insert Into Point Values('" +
          .Text.Trim() + "',N'" +
            txtTenThanhPho.Text + "')";
            cmd.ExecuteNonQuery();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Form1 frmgame = new Form1();
            frmgame.ShowDialog();
        }



        private void BtnMenu_Click(object sender, EventArgs e)
        {
            FrmWellcome frmwellcome = new FrmWellcome();
            frmwellcome.ShowDialog();
        }
    }
}
