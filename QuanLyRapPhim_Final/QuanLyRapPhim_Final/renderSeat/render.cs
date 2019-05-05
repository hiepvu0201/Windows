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
        private int row;
        private int col;
        public static Pen myPen;
        public static Color myColor;

        public int Row { get => row; set => row = value; }
        public int Col { get => col; set => col = value; }

        public render()
        {
            
            myColor = Color.Blue;
            myPen = new Pen(myColor, 1);
        }
        public render(int row,int col)
        {
            this.Row = row;
            this.Col = col;
        }

        public void drawTable(Graphics gp)
        {
            CellGame cell = new CellGame();

            for (int i = 0; i <= cell.Line; i++)
            {
                gp.DrawLine(myPen, i * cell.CellWidth, 0, i * cell.CellWidth, Row * cell.CellHeight);
            }

            for (int j = 0; j <= cell.Line; j++)
            {
                gp.DrawLine(myPen, 0, j * cell.CellHeight, Col * cell.CellWidth, j * cell.CellHeight);
            }
        }

        public class CellGame
        {
            private int cellWidth = 50;
            private int cellHeight = 50;
            private int line = 10;
            public int CellWidth { get => cellWidth; set => cellWidth = value; }
            public int CellHeight { get => cellHeight; set => cellHeight = value; }
            public int Line { get => line; set => line = value; }
        }

    }

}
