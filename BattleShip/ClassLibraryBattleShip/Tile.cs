using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassLibraryBattleShip
{
    public class Tile
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Tile(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}