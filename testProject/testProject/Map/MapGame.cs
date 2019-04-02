using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testProject.Map
{
    class MapGame
    {
        public int[,] a;
        public MapGame()
        {
            a = new int[10, 10] {
                                { 0,0,1,1,1,1,1,0,0,0 },
                                { 1,1,1,0,0,0,1,0,0,0 },
                                { 1,0,2,0,1,0,1,1,0,0 },
                                { 1,3,1,0,0,0,0,1,0,0 },
                                { 1,0,0,0,0,1,0,1,0,0 },
                                { 1,1,0,1,0,0,0,1,0,0 },
                                { 0,1,0,0,0,1,1,1,0,0 },
                                { 0,1,1,1,1,1,0,0,0,0 },
                                { 0,0,0,0,0,0,0,0,0,0 },
                                { 0,0,0,0,0,0,0,0,0,0 }};
            
        }

    }
}
