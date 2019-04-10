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
    class CheckWin
    {
        MapGame map = new MapGame();
        render render = new render();
        public bool check(int numBerCrate, PictureBox[] crates, PictureBox[] holes)
        {
            int count=0;
            render.createHole();
            for (int i = 0; i < numBerCrate; i++)
            {
                for (int j = 0; j < numBerCrate; j++)
                {
                    if (crates[i].Location.X==holes[j].Location.X && crates[i].Location.Y == holes[j].Location.Y)
                    {
                        count++;
                    }
                }
            }
            if (count== numBerCrate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
