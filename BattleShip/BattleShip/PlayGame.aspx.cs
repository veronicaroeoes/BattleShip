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

            int rows = Convert.ToInt32(Request["rows"]);
            int columns = Convert.ToInt32(Request["columns"]);
            string playerName = Request["playerName"];

            List<Tile> gameBoard = new List<Tile>();

            

            if (Session["gamePlan"] != null)
            {
                gameBoard = (List<Tile>)Session["gamePlan"];
                DrawGameBoard(gameBoard, rows, columns);
            }
            else
            {
                gameBoard = CreateGameBoard(rows, columns);
                DrawGameBoard(gameBoard, rows, columns);
            }
            //if (!IsPostBack)
            //{
            //    gameBoard = CreateGameBoard(rows, columns);
            //    DrawGameBoard(gameBoard, rows, columns);
            //}
            //else
            //{
            //    DrawGameBoard(gameBoard, rows, columns);
            //}
        }

        private void DrawGameBoard(List<Tile> gameBoard, int rows, int columns)
        {
            for (int r = 1; r <= rows; r++)
            {
                for (int c = 1; c <= columns; c++)
                {
                    Tile tile = gameBoard
                        .FirstOrDefault(t => t.X == r && t.Y == c);

                    tile.Click += TryHit;
                    WarPanel.Controls.Add(tile);
                }
                WarPanel.Controls.Add(new LiteralControl("<br />"));
            }
        }

        private List<Tile> CreateGameBoard(int rows, int columns)
        {
            List<Tile> tiles = new List<Tile>();
            for (int r = 1; r <= rows; r++)
            {
                for (int c = 1; c <= columns; c++)
                {
                    Tile tile = new Tile(r, c);

                    tile.Click += TryHit;
                    tiles.Add(tile);
                }
            }
            int placeShip = random.Next(0, tiles.Count);
            tiles[placeShip].IsShip = true;
            return tiles;
        }

        private void TryHit(object sender, EventArgs e)
        {
            if (sender is Tile)
            {
                Tile currentTile = sender as Tile;
                if (currentTile != null)
                {
                    if (currentTile.IsShip)
                    {
                        currentTile.BackColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        currentTile.BackColor = System.Drawing.Color.Green;
                    }
                }
            }
        }

        private void CreateShip()
        {

        }


    }
}