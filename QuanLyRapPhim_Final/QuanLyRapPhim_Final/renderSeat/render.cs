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

        public int Row { get => row; set => row = value; }
        public int Col { get => col; set => col = value; }

        public render()
        {
            
        }
        public render(int r,int c)
        {
            this.row = r;
            this.col = c;
        }

        public void drawTable( Graphics gp)
        {
            Program.myColor = Color.Red;
            Program.myPen= new Pen(Program.myColor, 1);

            CellTable cell = new CellTable();

            for (int i = 0; i <= cell.LineCol; i++)
            {
                gp.DrawLine(Program.myPen, i * cell.CellWidth, 0, i * cell.CellWidth, Row * cell.CellHeight);
            }

            for (int j = 0; j <= cell.LineRow; j++)
            {
                gp.DrawLine(Program.myPen, 0, j * cell.CellHeight, Col * cell.CellWidth, j * cell.CellHeight);
            }
        }

        public class CellTable
        {
            private int cellWidth = 75;
            private int cellHeight = 75;
            private int lineCol = 15;
            private int lineRow = 5;
            public int CellWidth { get => cellWidth; set => cellWidth = value; }
            public int CellHeight { get => cellHeight; set => cellHeight = value; }
            public int LineCol { get => lineCol; set => lineCol = value; }
            public int LineRow { get => lineRow; set => lineRow = value; }
        }

    }

}
