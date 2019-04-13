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
        string curr_user = "hiepvu123";
        string curr_point = "10";
        static bool sua = true;
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
            if (!lbUser.Text.Equals(""))
            {
                if (conec.State == ConnectionState.Open)
                    conec.Close();
                conec.Open();
                if (sua)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conec;
                        cmd.CommandType = CommandType.Text;

                        cmd.CommandText =
                        "UPDATE  dtbGame  SET Point = ' " + lbLevel.Text.Trim()
                        + " ' Where TaiKhoan = ' " + lbUser.Text.Trim() + "'";
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
                
        }
           
       

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            //Form1 frmgame = new Form1();
            //frmgame.ShowDialog();
        }



        private void BtnMenu_Click(object sender, EventArgs e)
        {
            //FrmWellcome frmwellcome = new FrmWellcome();
            //frmwellcome.ShowDialog();
        }

        private void GameOver_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
