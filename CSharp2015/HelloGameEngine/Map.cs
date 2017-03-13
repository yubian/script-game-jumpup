﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGameEngine
{
    class Map
    {
        private int[,] maps = new int[20,26]
        {   {0,0 ,0,0 ,0,0 , 0,0 , 0,0,0 ,0,0 ,0,0 ,0,0 , 0,0 , 0,0,0,0,0,0,0},
          {0,0 ,0,0 ,0,0 , 0,0 , 0,0,0 ,0,0 ,0,0 ,0,0 , 0,0 , 0,0,0,0,0,0,0},
            {0,0 ,0,0 ,0,0 , 0,0 , 0,0,0 ,0,0 ,0,0 ,0,0 , 0,0 , 0,0,0,0,0,0,0},
            {0,0 ,0,0 ,0,0 , 0,0 , 0,0,0 ,0,0 ,0,0 ,0,0 , 0,0 , 0,0,0,0,0,0,0},
           {0,0 ,0,0 ,0,0 , 0,0 , 0,0,0 ,0,0 ,0,0 ,0,0 , 0,0 , 0,0,0,0,0,0,0},

            {0,0 ,0,0 ,0,0 , 0,0 , 0,0,0 ,0,0 ,0,0 ,0,0 , 0,0 , 0,0,0,0,0,0,0},
            {0,0 ,0,0 ,0,0 , 0,0 , 0,0,0 ,0,0 ,0,0 ,0,0 , 0,0 , 0,0,0,0,0,0,0},
            {0,0 ,0,0 ,0,0 , 0,0 , 0,0,0 ,0,0 ,0,0 ,0,0 , 0,0 , 0,0,3,0,0,0,0},
            {0,0 ,0,0 ,0,0 , 0,0 , 0,0,0 ,0,0 ,0,0 ,0,0 , 0,0 , 0,0,0,0,0,0,0},
            {0,0 ,0,0 ,0,0 , 0,0 , 0,0,0 ,0,0 ,0,0 ,0,0 , 0,0 , 0,0,0,0,0,0,0},

            {0,0 ,0,0 ,0,0 , 0,0 , 0,0,0 ,0,0 ,0,0 ,0,0 , 0,0 , 0,0,0,0,0,0,0},
            {0,0 ,0,0 ,0,0 , 0,0 , 0,0,0 ,0,0 ,0,0 ,0,0 , 0,0 , 0,0,0,0,0,0,0},
            {0,0 ,0,0 ,0,0 , 0,0 , 0,0,0 ,0,0 ,0,0 ,0,0 , 0,0 , 0,0,0,0,0,0,0},
            {0,0 ,0,0 ,0,0 , 0,2 , 0,0,0 ,0,0 ,0,0 ,0,0 , 0,0 , 0,0,0,0,0,0,0},
            {0,0 ,0,0 ,0,0 , 0,0 , 0,4,0 ,0,0 ,0,0 ,0,0 , 0,0 , 0,0,0,0,0,0,0},

            {0,0 ,0,0 ,0,0 , 0,0 , 0,0,0 ,0,0 ,0,0 ,0,0 , 0,0 , 0,0,0,0,0,0,0},
            {0,0 ,0,0 ,0,0 , 0,0 , 0,0,0 ,0,0 ,0,0 ,0,0 , 0,0 , 0,0,0,0,0,0,0},
            {0,0 ,0,0 ,0,0 , 0,0 , 0,0,0 ,0,0 ,0,0 ,0,0 , 0,0 , 0,0,0,0,0,0,0},
             {0,0 ,0,0 ,0,1 , 1,1 , 1,1,1 ,1,1 ,1,1 ,1,1 , 1,1 ,1,1,1,1,1,1,1},
             { 0,0 ,0,0 ,0,0 , 0,0 , 0,0,0 ,0,0 ,0,0 ,0,0 , 0,0 , 0,0,0,0,0,0,0}

        };
        private int[,] maps2 = new int[3, 26]
        {   {1,1 ,1,1 ,1,1 , 1,1 , 1,1,1 ,1,1 ,1,1 ,1,1 , 1,1 ,1,1,1,1,1,1,1},
            {1,1 ,1,1 ,1,1 , 1,1 , 1,1,1 ,1,1 ,1,1 ,1,1 , 1,1 ,1,1,1,1,1,1,1},
            {1,1 ,1,1 ,1,1 , 1,1 , 1,1,1 ,1,1 ,1,1 ,1,1 , 1,1 ,1,1,1,1,1,1,1}

        };
        private int[,] maps1 = new int[10, 13]
        {
            {0,0,0,0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0,0,0,0},
            {1,1,2,0,0,0,0,0,0,0,0,0,0},
            {1,1,2,0,0,0,3,0,0,0,0,0,0},

            {1,1,2,0,0,0,0,0,0,0,0,0,0},
            {1,1,2,0,0,0,0,0,0,0,0,0,0},
            {1,1,2,0,0,0,0,0,0,0,0,0,0},
            {1,1,2,0,0,0,0,3,0,0,0,0,0},
            {1,1,2,0,0,0,0,0,0,0,0,0,0},
        };
        public int maphiegh()
        {
           return maps.GetLength(0);
        }
        public int mapwidth()
        {
           return maps.GetLength(1);
        }
        public int maphiegh1()
        {
            return maps1.GetLength(0);
        }
        public int mapwidth1()
        {
            return maps1.GetLength(1);
        }
        public int getmaps1(int x, int y)
        {
            return this.maps1[x, y];
        }
    public int getmaps(int x, int y) {
            return this.maps[x, y];
        }
        public int getmaps2(int x, int y)
        {
            return this.maps2[x, y];
        }
    }
}