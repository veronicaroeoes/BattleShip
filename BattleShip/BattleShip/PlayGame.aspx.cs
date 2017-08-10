using ClassLibraryBattleShip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BattleShip
{
    public partial class PlayGame : System.Web.UI.Page
    {
        static Random random = new Random();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int rows = Convert.ToInt32(Request["rows"]);
                int columns = Convert.ToInt32(Request["columns"]);
                string playerName = Request["playerName"];
                CreateGameBoard(rows, columns);
            }
        }

        private void CreateGameBoard(int rows, int columns)
        {
            int placeShip = random.Next(0, rows * columns + 1);
            int tmp = 1;
            for (int r = 1; r <= rows; r++)
            {
                for (int c = 1; c <= columns; c++)
                {
                    Tile tile = new Tile(r, c);
                    if (tmp++ == placeShip)
                    {
                        tile.IsShip = true;
                    }
                    tile.Click += TryHit();
                    WarPanel.Controls.Add(tile);

                    
                }
                WarPanel.Controls.Add(new LiteralControl("<br />"));
            }
        }

        protected void TryHit_Click(object sender, EventArgs e)
        {
        }

        private void CreateShip()
        {

        }


    }
}