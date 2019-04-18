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

namespace testProject
{
    public partial class FrmWin : Form
    {
        
        public FrmWin()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            lbUser.Text = FrmDangNhap.curr_user;
            lbpoint.Text = Form1.curr_point.ToString();
            QuanlyUserDataContext qluser = new QuanlyUserDataContext();


            var gameQuery =
                (from game in qluser.dtbGames
                 where game.TaiKhoan == FrmDangNhap.curr_user
                 select game).SingleOrDefault();
            int temp = Int32.Parse(gameQuery.Point);

            if (Form1.curr_point > temp)
            {
                gameQuery.Point = Form1.curr_point.ToString();
                qluser.SubmitChanges();
            }

        }
        private void FrmWin_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmWelcome frmWelcome = new FrmWelcome();
            frmWelcome.ShowDialog();
            Form1.curr_point = 0;
        }

     
    }
}
