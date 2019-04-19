﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

namespace testProject.Map
{
    class MapGame
    {
        private int[,] a;
        private int[,] b;

        public MapGame()
        {
            b = new int[10, 10] {
                                { 9,9,1,1,1,1,1,9,9,9 },
                                { 1,1,1,3,0,0,1,9,9,9 },
                                { 1,0,0,2,1,0,1,1,9,9 },
                                { 1,0,1,0,0,0,4,1,9,9 },
                                { 1,0,0,0,0,1,0,1,9,9 },
                                { 1,1,0,1,0,0,0,1,9,9 },
                                { 9,1,0,0,0,1,1,1,9,9 },
                                { 9,1,1,1,1,1,9,9,9,9 },
                                { 9,9,9,9,9,9,9,9,9,9 },
                                { 9,9,9,9,9,9,9,9,9,9 }};
            a = new int[10, 10]
            {
                { 9,9,1,1,1,1,1,9,9,9},
                { 1,1,1,3,0,0,1,9,9,9},
                { 1,4,0,0,2,0,1,9,9,9},
                { 1,1,1,0,0,0,1,9,9,9},
                { 1,4,1,1,2,0,1,9,9,9},
                { 1,0,1,0,4,0,1,1,9,9},
                { 1,2,0,4,2,0,4,1,9,9},
                { 1,0,0,0,4,2,0,1,9,9},
                { 1,1,1,1,1,1,1,1,9,9},
                { 9,9,9,9,9,9,9,9,9,9}
            };
           
        }
       
            

        public int[,] A { get => a; set => a = value; }

        public int crateCount()
        {
            int count=0;
            for (int i = 0; i < a.GetLength(1); i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    if (a[i,j]==2)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public int holeCount()
        {
            int count = 0;
            for (int i = 0; i < a.GetLength(1); i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    if (a[i, j] == 4)
                    {
                        count++;
                    }
                }
            }
            return count;

        }
        public void clearHole()
        {

            for (int i = 0; i < a.GetLength(1); i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    if (A[i, j] == 4)
                    {
                        this.A[i, j] = 0;
                    }
                }
            }
        }
    }
}
