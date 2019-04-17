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


namespace testProject
{

    public partial class FrmDangNhap : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-F3VTH4B;" +
            "Initial Catalog=SukobanGame;" +
            "Integrated Security=True");
        public static string curr_user = "";
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string sql = "Select *From dtbGame Where TaiKhoan='" +
                    txtUser.Text.Trim() + "' AND MatKhau='" + txtPasswords.Text.Trim() + "'";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    curr_user = txtUser.Text;
                    //FrmMain.User = txtUser.Text;
                    //FrmMain.Pass = txtPass.Text;
                    txtUser.ResetText();
                    txtPasswords.ResetText();
                    txtUser.Focus();
                    this.Close();
                    Form1 form1 = new Form1();
                    form1.Show();

                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                    txtUser.Focus();
                    txtPasswords.Focus();

                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi rồi!");
            }
            finally
            {
                conn.Close();
            }
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
