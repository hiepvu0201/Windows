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

namespace DoAnGiuaKi
{
    public partial class FrmDangKy : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-S5V3TOI\SQLEXPRESS;" +
            "Initial Catalog=SukobanGame;" +
            "Integrated Security=True");

        private int i = 10;

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
            if (!txtNewUser.Text.Trim().Equals(""))
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();

                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Insert Into dtbGame Values('" + txtNewUser.Text.Trim() + "',N'"
                        + txtNewPasswords.Text.Trim() + "',N'"+ txtNewEmail.Text.Trim() + "',N'" + txtNewPhoneNumber.Text.Trim() +"')";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Đã thêm xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");

                }
                conn.Close();
            }
        }
    }
}
