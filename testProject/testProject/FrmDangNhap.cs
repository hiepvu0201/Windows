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
using testProject.BSLayer;

using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace testProject
{

    public partial class FrmDangNhap : Form
    {
        string err;
        BLUser dbTP = new BLUser();
        public static string curr_user = "";
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            BLUser blUser = new BLUser();
            if (blUser.KtDangNhap(this.txtUser.Text, this.txtPasswords.Text, ref err) == true)
            {
                MessageBox.Show("Đăng nhập thành công!");
                curr_user = txtUser.Text;
                this.Close();
                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }
            txtUser.ResetText();
            txtPasswords.ResetText();
            txtUser.Focus();

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmDangKy frmDangKy = new FrmDangKy();
            frmDangKy.Show();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
