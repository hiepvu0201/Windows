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

namespace testProject
{
    public partial class Form1 : Form
    {
        Graphics gp;
        detail detail1 = new detail();
        render render = new render();
        MapGame map = new MapGame();
        
        public Form1()
        {

            InitializeComponent();
            render.renderObj(mainPan, map.a, "wall");
            render.renderObj(mainPan, map.a, "crate");
            render.renderObj(mainPan, map.a, "miner");
            gp = mainPan.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mainPan_Paint(object sender, PaintEventArgs e)
        {

            Matrix matrix = new Matrix();
            matrix.drawTable(gp);
            render.renderObj(mainPan, map.a,"wall");
            render.renderObj(mainPan, map.a,"crate");
            render.renderObj(mainPan, map.a, "miner");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
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
    public class Matrix
    {
        private int row;
        private int col;
        public Matrix()
        {
            row = 10;
            col = 10;
        }
        public Matrix(int row1, int col1)
        {
            row = row1;
            col = col1;
        }
        public int Row { get => row; set => row = value; }
        public int Col { get => col; set => col = value; }
        public void drawTable(Graphics gp)
        {
            CellGame cell = new CellGame();
            
            for (int i = 0; i <= cell.Line; i++)
            {
                gp.DrawLine(Program.myPen,i*cell.CellWidth ,0,i*cell.CellWidth,row*cell.CellHeight);
            }

            for (int j = 0; j <= cell.Line; j++)
            {
                gp.DrawLine(Program.myPen, 0,j*cell.CellHeight,col*cell.CellWidth,j*cell.CellHeight);
            }
        }
        public Point findCell(int Row, int Col)
        {
            CellGame cell = new CellGame();
            Point point = new Point(Col * cell.CellWidth, Row * cell.CellHeight);
            return point;
        }

    }

}
