using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyRapPhim_Final;
using System.Drawing;
namespace QuanLyRapPhim_Final.renderSeat
{
    class render
    {
        public static Pen myPen;
        public static Color myColor;
        render()
        {
            myColor = Color.Blue;
            myPen = new Pen(myColor, 1);
        }

    }
}
