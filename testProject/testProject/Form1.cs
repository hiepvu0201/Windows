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
using testProject.Logic;

namespace testProject
{
    public partial class Form1 : Form
    {
        Graphics gp;
        Budget budget = new Budget(); 
        detail detail1 = new detail();
        render render = new render();
        MapGame map = new MapGame();
        Matrix matrix = new Matrix();
        int crateIndex = 0;
        int ktCrate = 1;
        int ktChay = 1;
        int runCrate = 0;
        int runTime=0;
        string direction;
        public Form1()
        {

            InitializeComponent();
            render.renderObj(mainPan, map.A, "wall");
            render.renderObj(mainPan, map.A, "crate");
            render.renderObj(mainPan, map.A, "miner");
            gp = mainPan.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //PictureBox[] list = render.createList();
            //MessageBox.Show($"crate1:{list[0].Name}");
        }

        private void mainPan_Paint(object sender, PaintEventArgs e)
        {


            matrix.drawTable(gp);
            //render.renderObj(mainPan, map.a,"wall");
            //render.renderObj(mainPan, map.a,"crate");
            //render.renderObj(mainPan, map.a, "miner");
        }
        bool isMoving = false;

        private void moveRepeat()
        {

            if (runTime == 9)
            {
                runTime = 0;
                timer1.Stop();
            }
            else
            {
                runTime++;
            }
        }
        private bool ktCanGo(bool canGo,Point cur,string direction)
        {
            var valid = true;
            if (ktChay == 1)
            {
                budget.updateMatrix(cur, direction,3);
                if (canGo == false)
                {
                    timer1.Stop();
                    ktChay = 1;
                    ktCrate = 1;
                    return false;
                }

            }
            ktChay = 0; //làm cho biến cango chỉ chạy 1 lần
            return valid;
        }
        private int CrateMove(string direction, Point curPos)//curPos này của miner
        {
            if (budget.isCrate(direction,curPos)==false) //kt ô tiếp phải hộp ko 
            {
                return -1;
            }
            ktCrate = 0;
            //phải hộp thì xem ô kế có đi được không
            PictureBox[] list = render.createList();
            int deltaX = 0;
            int deltaY = 0;
            switch (direction)
            {
                case "left":
                    {
                        deltaX = -50;
                        break;
                    }
                case "right":
                    {
                        deltaX = 50;
                        break;
                    }
                case "up":
                    {
                        deltaY = -50;
                        break;
                    }
                case "down":
                    {
                        deltaY = 50;
                        break;
                    }

                default:
                    break;
            }
            Point curPosCrate = new Point(curPos.X + deltaX, curPos.Y + deltaY);
            int currentCrate = budget.findCrate(curPosCrate,list);
            bool canGo =budget.IsGoingCrate(direction,curPosCrate);
            if (canGo==false)
            {
                return -1;
            }
        return currentCrate;

        }
        private void MinerMove(string direction,Point cur)
        {
            cur = render.Miner.Location;
            PictureBox[] list = render.createList();
            Point temp = new Point();
            if (ktCrate == 1)
            {
                int tempValue = CrateMove(direction, cur);
                if (tempValue != -1)
                {
                    crateIndex =tempValue;
                    temp.X = list[crateIndex].Location.X;
                    temp.Y = list[crateIndex].Location.Y;
                    budget.updateMatrix(temp, direction, 2);
                    runCrate = 1;
                }
                ktCrate = 0;
            }
            bool canGo = budget.IsGoing(direction, render.Miner.Location);
            if(!ktCanGo(canGo,render.Miner.Location,direction))
            {
                return;
            }


            var deltaX = 0;
            var deltaY = 0;

            switch (direction)
            {
                case "left":
                    {
                        deltaX = -5;
                        break;
                    }
                case "right":
                    {
                        deltaX = 5;
                        break;
                    }
                case "up":
                    {
                        deltaY = -5;
                        break;
                    }
                case "down":
                    {
                        deltaY = 5;
                        break;
                    }
                default: break;
            }
            render.Miner.Location = new Point(cur.X + deltaX, cur.Y + deltaY);

            if (runCrate==1)
            {
                temp.X = list[crateIndex].Location.X;
                temp.Y = list[crateIndex].Location.Y;
                list[crateIndex].Location = new Point(temp.X + deltaX, temp.Y + deltaY);
            }

            //nếu có hộp thì cùng di chuyển
            moveRepeat();


        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            Point cur = new Point();
            if (direction=="left") 
            {
                MinerMove(direction, cur);
            }
            else if (direction=="down")
            {
                MinerMove(direction, cur);
            }
            else if (direction=="up")
            {
                MinerMove(direction, cur);
            }
            else if (direction=="right")
            {
                MinerMove(direction, cur);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Point cur;
            cur=render.Miner.Location;
            switch (e.KeyCode)
            {
                case Keys.Left:
                    {
                        ktCrate = 1;
                        runCrate = 0;
                        ktChay = 1;
                        direction = "left";
                        timer1.Interval = 4;
                        timer1.Start();
                        
                    }
                    break;
                case Keys.Up:
                    {
                        ktCrate = 1;
                        runCrate = 0;
                        ktChay = 1;
                        direction = "up";
                        timer1.Interval = 4;
                        timer1.Start();

                    }
                    break;
                case Keys.Right:
                    {
                        runCrate = 0;
                        ktCrate = 1;
                        ktChay = 1;
                        direction = "right";
                        timer1.Interval = 4;
                        timer1.Start();

                    }
                    break;
                case Keys.Down:
                    {
                        ktCrate = 1;
                        runCrate = 0;
                        ktChay = 1;
                        direction = "down";
                        timer1.Interval = 4;
                        timer1.Start();
                    }
                    break;
                case Keys.A:
                    break;
                case Keys.D:
                    break;
                case Keys.S:
                    break;
                case Keys.W:
                    break;
                default:
                    break;
            }
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
        public void findMiner(int[,] map,ref Point mark)
        {
            for (int i = 0; i < map.GetLength(1); i++)
            {
                for (int j = 0; j < map.GetLength(0); j++)
                {
                    if (map[i,j]==3)
                    {
                        mark = findCell(i, j);
                    }
                }
            }
        }
    }

}
