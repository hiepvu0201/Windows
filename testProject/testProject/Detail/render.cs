﻿using System;
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
        private PictureBox miner = new PictureBox();

        private PictureBox crate1 = new PictureBox();
        private PictureBox crate2 = new PictureBox();
        private PictureBox crate3 = new PictureBox();
        private PictureBox crate4 = new PictureBox();
        private PictureBox crate5 = new PictureBox();
        private PictureBox crate6 = new PictureBox();

        public PictureBox Crate1 { get => crate1; set => crate1 = value; }
        public PictureBox Crate2 { get => crate2; set => crate2 = value; }
        public PictureBox Crate3 { get => crate3; set => crate3 = value; }
        public PictureBox Crate4 { get => crate4; set => crate4 = value; }
        public PictureBox Crate5 { get => crate5; set => crate5 = value; }
        public PictureBox Crate6 { get => crate6; set => crate6 = value; }

        public PictureBox[] createList()
        {
            PictureBox[] listCrates = new PictureBox[6] { Crate1, Crate2, Crate3, Crate4, Crate5, Crate6 };
            return listCrates;
        }
        public PictureBox Miner { get => miner; set => miner = value; }


        public void renderObj(Panel mainPan,int[,] map,string type)
        {
            PictureBox wall = new PictureBox();
            detail rendering = new detail();
            Matrix matrix = new Matrix();
            Point a = new Point();
            int count = 0;
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
                            rendering.createBlock(ref wall1, $"wall{i},{j}", a.X + 1, a.Y + 1, type);
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

                            //CratesList crates = new CratesList();
                            //PictureBox[] container = crates.createList();
                            //a = matrix.findCell(i, j);
                            //rendering.createBlock(ref container[count], $"crate{count}", a.X + 1, a.Y + 1,type);
                            //mainPan.Controls.Add(container[count]);
                            //count++;
                            switch (count)
                            {
                                case 0:
                                    {
                                        a = matrix.findCell(i, j);
                                        rendering.createBlock(ref crate1, $"crate{count+1}", a.X + 1, a.Y + 1, type);
                                        mainPan.Controls.Add(crate1);
                                        break;
                                    }
                                case 1:
                                    {
                                        a = matrix.findCell(i, j);
                                        rendering.createBlock(ref crate2, $"crate{count+1}", a.X + 1, a.Y + 1, type);
                                        mainPan.Controls.Add(crate2);
                                        break;

                                    }
                                case 3:
                                    {
                                        a = matrix.findCell(i, j);
                                        rendering.createBlock(ref crate3, $"crate{count+1}", a.X + 1, a.Y + 1, type);
                                        mainPan.Controls.Add(crate3);
                                        break;

                                    }
                                case 4:
                                    {
                                        a = matrix.findCell(i, j);
                                        rendering.createBlock(ref crate4, $"crate{count+1}", a.X + 1, a.Y + 1, type);
                                        mainPan.Controls.Add(crate4);
                                        break;

                                    }
                                case 5:
                                    {
                                        a = matrix.findCell(i, j);
                                        rendering.createBlock(ref crate5, $"crate{count+1}", a.X + 1, a.Y + 1, type);
                                        mainPan.Controls.Add(crate5);
                                        break;

                                    }
                                case 6:
                                    {
                                        a = matrix.findCell(i, j);
                                        rendering.createBlock(ref crate6, $"crate{count+1}", a.X + 1, a.Y + 1, type);
                                        mainPan.Controls.Add(crate6);

                                        break;
                                    }
                                default:
                                    break;
                            }
                            count++;
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
                            //PictureBox miner = new PictureBox();
                            a = matrix.findCell(i, j);
                            rendering.createBlock(ref miner, $"miner{i},{j}", a.X + 1, a.Y + 1, type);
                            mainPan.Controls.Add(Miner);
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
