using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testProject.Map;
using testProject.Detail;
using System.Drawing;
using System.Windows.Forms;
namespace testProject.Logic
{
    class Budget
    {
        MapGame map = new MapGame();
        render render = new render();
        public Budget()
        {

        }
        private void findCurCell(ref int row,ref int col,Point cur)
        {
            col = (cur.X - 1) / 50;  //tim cot
            row = (cur.Y - 1) / 50;  //tim hang

        }
        public bool IsGoing(string direction,Point curPos)//kt có đi được hay không
        {
            int col=0; 
            int row=0;
            findCurCell(ref row, ref col, curPos);
            if (direction == "left")    //xem ô trái có đi được hay không
            {
                if (col==0) //trái cùng
                {
                    return false;
                }
                else
                {
                    if (map.A[row,col-1]==1)    //ko đi được
                    {
                        return false;
                    }
                    else if (map.A[row, col - 1] == 0)
                    {
                        return true;
                    }
                }
            }
            else if (direction=="down")
            {
                if (map.A[row+1,col]==1)
                {
                    return false;
                }
                else if (map.A[row + 1, col] == 0)
                {
                    return true;
                }
            }
            else if (direction=="up")
            {
                if (map.A[row - 1, col] == 1)
                {
                    return false;
                }
                else if (map.A[row - 1, col] == 0)
                {
                    return true;
                }

            }
            else if (direction=="right")
            {
                if (map.A[row, col+1] == 1)
                {
                    return false;
                }
                else if (map.A[row, col+1] == 0)
                {
                    return true;
                }

            }
            return false;
        }
        public void updateMatrix(Point curPos,string direction,int type)
        {
            int col = 0;
            int row = 0;
            findCurCell(ref row,ref col, curPos);
            int moveX=0;
            int moveY=0;
            if (IsGoing(direction,curPos)==false)
            {
                return;
            }
            switch (direction)
            {
                case "up":
                    {
                        moveY = -1;
                        break;
                    }
                case "down":
                    {

                        moveY = 1;
                        break;
                    }
                case "left":
                    {
                        moveX = -1;
                        break;
                    }
                case "right":
                    {
                        moveX = 1;
                        break;
                    }
                default: break;
            }
            map.A[row + moveY, col + moveX] = type;
            map.A[row, col] = 0;
        }
        public bool isCrate(string direction, Point curPos)//cur của miner  //phải hộp hay không
        {
            int col = 0;
            int row = 0;
            findCurCell(ref row, ref col, curPos);
            int moveX = 0;
            int moveY = 0;
            switch (direction)
            {
                case "left":
                    {
                        moveX = -1;
                        break;
                    }
                case "right":
                    {
                        moveX = 1;
                        break;
                    }
                case "up":
                    {
                        moveY = -1;
                        break;
                    }
                case "down":
                    {
                        moveY = 1;
                        break;
                    }
                default:
                    break;
            }
            if (map.A[row + moveY, col + moveX] == 3)
            {
                return true;
            }
            else return false;
        }
        public bool IsGoingCrate(string direction,Point curBox)//cur của hộp    //hộp có đi được ô tiếp theo không ?
        {
            int col = 0;
            int row = 0;
            findCurCell(ref row, ref col, curBox);
            int moveY = 0;
            int moveX = 0;
            switch (direction)
            {
                case "up":
                    {
                        moveY = -1;
                        break;
                    }
                case "down":
                    {

                        moveY = 1;
                        break;
                    }
                case "left":
                    {
                        moveX = -1;
                        break;
                    }
                case "right":
                    {
                        moveX = 1;
                        break;
                    }
                default:
                    break;
            }
            if (map.A[row + moveY, col + moveX] == 0)
            {
                return true;
            }
            else return false;
        }
        public void pullBox(Point cur,string direction) //cur của hộp
        {
            int col = 0;
            int row = 0;
            findCurCell(ref row, ref col, cur);

            if (isCrate(direction,cur)==true) //là box
            {
                if (IsGoingCrate(direction,cur)==true)  //đi được theo hướng direction
                {
                    
                }
                else    //0 đi được
                {

                }
            }
        }
        public int findCrate(Point curPos)
        {
            PictureBox[] list= render.createList();
            for (int i = 0; i < list.Length; i++)
            {
                if (curPos.X==list[i].Location.X && curPos.Y==list[i].Location.Y)
                {
                    return i;
                }
            }
            return -1;
            
        }
    }
}
