using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim_Final.User_Controls
{
    public partial class PhimUC : UserControl
    {
        public PhimUC()
        {
            InitializeComponent();
        }

        private void PhimUC_Load(object sender, EventArgs e)
        {
            this.phimTableAdapter.Fill(this.quanLyRapPhimDataSet_PHIM.Phim);
        }
    }
}
