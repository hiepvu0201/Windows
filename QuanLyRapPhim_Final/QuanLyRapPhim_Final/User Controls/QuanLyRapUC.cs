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
    public partial class QuanLyRapUC : UserControl
    {
        public QuanLyRapUC()
        {
            InitializeComponent();
        }

        private void QuanLyRapUC_Load(object sender, EventArgs e)
        {
            this.rapTableAdapter.Fill(this.quanLyRapPhimDataSet_RAP.Rap);
        }
    }
}
