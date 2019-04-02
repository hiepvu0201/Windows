using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testProject.Detail;
using testProject.Map;
using testProject;
namespace testProject.Detail
{
    class render
    {

        public void renderObj(Panel mainPan,int[,] map,string type)
        {
            PictureBox wall = new PictureBox();
            detail rendering = new detail();
            Matrix matrix = new Matrix();
            Point a = new Point();
            if (type == "wall")
            {
                for (int i = 0; i < map.GetLength(1); i++)
                {
                    for (int j = 0; j < map.GetLength(0); j++)
                    {
                        if (map[i, j] == 1)
                        {
                            PictureBox wall1 = new PictureBox();
                            a = matrix.findCell(i, j);
                            rendering.createBlock(wall1, $"wall{i},{j}", a.X + 1, a.Y + 1, type);
                            mainPan.Controls.Add(wall1);
                        }
                    }
                }
            }
            else if (type == "crate")
            {
                for (int i = 0; i < map.GetLength(1); i++)
                {
                    for (int j = 0; j < map.GetLength(0); j++)
                    {
                        if (map[i, j] == 2)
                        {
                            PictureBox crate = new PictureBox();
                            a = matrix.findCell(i, j);
                            rendering.createBlock(crate, $"crate{i},{j}", a.X + 1, a.Y + 1,type);
                            mainPan.Controls.Add(crate);
                        }
                    }
                }
            }
            else if (type == "miner")
            {
                for (int i = 0; i < map.GetLength(1); i++)
                {
                    for (int j = 0; j < map.GetLength(0); j++)
                    {
                        if (map[i, j] == 3)
                        {
                            PictureBox miner = new PictureBox();
                            a = matrix.findCell(i, j);
                            rendering.createBlock(miner, $"miner{i},{j}", a.X + 1, a.Y + 1, type);
                            mainPan.Controls.Add(miner);
                        }
                    }
                }

            }
        }
    }
    static class Model
    {
        public static string StrWall = @"D:\Working !\Window Progaming\testProject\testProject\Detail\wall2.png";
        public static string StrCrate = @"D:\Working !\Window Progaming\testProject\testProject\Detail\crate.png";
        public static string StrMiner = @"D:\Working !\Window Progaming\testProject\testProject\Detail\Miner.png";
    }
}
