using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testProject.BSLayer;

using System.Data.Linq;
using System.Data.Linq.Mapping; 

namespace testProject
{
    public partial class FrmDangKy : Form
    {
        private int i = 10;
        string err;
        BLUser dbTP = new BLUser();

        public FrmDangKy()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbWelcome.Location = new Point(lbWelcome.Location.X+i,lbWelcome.Location.Y);
            if(lbWelcome.Location.X>120||lbWelcome.Location.X<=0)
            {
                i = -i;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            frmDangNhap.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            BLUser blUser = new BLUser();
            blUser.ThemNguoiDung(this.txtNewUser.Text, this.txtNewPasswords.Text,
                this.txtNewPhoneNumber.Text,this.txtNewEmail.Text, 0.ToString(),ref err);
            MessageBox.Show("Đã thêm xong!");
            this.txtNewUser.ResetText();
            this.txtNewPasswords.ResetText();
            this.txtNewPhoneNumber.ResetText();
            this.txtNewEmail.ResetText();
        }
    }
}
