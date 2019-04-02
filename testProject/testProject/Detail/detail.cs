using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testProject;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

namespace testProject.Detail
{
    class detail
    {
        public PictureBox createBlock(PictureBox picture,string name,int xPos,int Ypos,string type)
        {
            
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));

            picture.Location = new Point(xPos, Ypos);
            picture.Name = name;
            picture.Size = new Size(49, 49);
            if (type == "wall")
            {
                picture.Image = Image.FromFile(Model.StrWall);
            }
            else if (type == "crate")
            {
                picture.Image = Image.FromFile(Model.StrCrate);
            }
            else if (type == "miner")
            {
                picture.Image = Image.FromFile(Model.StrMiner);
            }
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.TabIndex = 0;
            picture.TabStop = false;
            return picture;
        }
    }
    class WallConfig
    {

        WallConfig()
        {
            Size sizeWall = new Size(49,49);
            
        }
    }
    class MapConfig         
    {
        private int row;
        private int col;
        public MapConfig()
        {

        }
        public int Row { get => row; set => row = value; }
        public int Col { get => col; set => col = value; }
    }
}
