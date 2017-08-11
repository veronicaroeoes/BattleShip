using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ClassLibraryBattleShip
{
    public class Tile : Button
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsShip { get; set; }

        public Tile(int x, int y)
        {
            X = x;
            Y = y;
            IsShip = false;
            this.BackColor = System.Drawing.Color.Gray;
        }

    }
}