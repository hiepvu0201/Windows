using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyRapPhim_Final.User_Controls;
using System.Windows.Forms;

namespace QuanLyRapPhim_Final.renderSeat
{
    class createObject
    {
        
        public Button createButton (ref Button btn)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatVeUC));
            btn = new Button();
            btn.Location = new System.Drawing.Point(255, 160);
            btn.Name = "button1";
            btn.Size = new System.Drawing.Size(75, 23);
            btn.TabIndex = 0;
            btn.Text = "button1";
            btn.UseVisualStyleBackColor = true;
            return btn;
        }


    }
}
