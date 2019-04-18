using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testProject
{
    public partial class FrmWelcome : Form
    {
        public FrmWelcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            frmDangNhap.Show();
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Are you sure ?", "Warning!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); if (traloi == DialogResult.OK) Close();
        }

        private void FrmWelcome_Load(object sender, EventArgs e)
        {

        }
    }
}
