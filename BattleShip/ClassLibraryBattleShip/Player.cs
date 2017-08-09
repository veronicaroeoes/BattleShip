using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassLibraryBattleShip
{
    public class Player
    {
        public string Name { get; set; }
        public int WinCount { get; set; }
        public bool Win { get; set; }
        public GameBoard GameBoard { get; set; }




    }
}