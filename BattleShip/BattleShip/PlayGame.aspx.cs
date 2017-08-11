using ClassLibraryBattleShip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
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
            Player player = new Player();

            if (Session["Player"] != null)
            {
                player = (Player)Session["Player"];
            }
            else
            {
                player = new Player();
                player.Name = playerName;
                Session["Player"] = player;
            }

            if (Session["gamePlan"] != null)
            {
                gameBoard = (List<Tile>)Session["gamePlan"];
                DrawGameBoard(gameBoard, rows, columns);

            }
            else
            {

                gameBoard = CreateGameBoard(rows, columns);
                Session["gamePlan"] = gameBoard;
                DrawGameBoard(gameBoard, rows, columns);
            }

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
                    tile.Width = 50;
                    tile.Height = 50;
                    tile.Click += TryHit;
                    tiles.Add(tile);
                }
            }

            tiles = PlaceShip(tiles, 3);
            return tiles;
        }
        private List<Tile> PlaceShip(List<Tile> tiles, int boatCount)
        {
            int size = random.Next(0, 2);
            int position = random.Next(0, tiles.Count);

            while (true)
            {
                bool isVågrät = random.Next(0, 2) == 1;

                if (isVågrät)
                {
                    while (true)
                    {
                        if ((position + 1) / Convert.ToInt32(Request["Columns"]) % 2 == 0 && tiles[position - 1].IsShip == false)
                        {
                            tiles[position].IsShip = true;
                            tiles[position - 1].IsShip = true;
                            break;
                        }
                        else if (position / Convert.ToInt32(Request["Columns"]) % 2 == 0 && tiles[position + 1].IsShip == false)
                        {
                            tiles[position].IsShip = true;
                            tiles[position + 1].IsShip = true;
                            break;
                        }
                        else
                        {
                            bool tmp = random.Next(0, 2) == 1;
                            int tmpInt;

                            if (tmp)
                            {
                                tmpInt = 1;
                            }
                        }
                    }
                }
            }

            //Player player = (Player)Session["Player"];
            //player.Hits = boatCount;
            //int placeCheck = 0;
            //while (placeCheck < 3)
            //{
            //    int position = random.Next(0, tiles.Count);
            //    if (tiles[position].IsShip == false)
            //    {
            //        tiles[position].IsShip = true;
            //        tiles[position].BackColor = System.Drawing.Color.Black;
            //        placeCheck++;
            //    }
            //}
            //Session["Player"] = player;
            //return tiles;
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
                        Player player = (Player)Session["Player"];
                        player.Hits--;

                        if (player.Hits == 0)
                        {
                            player.Win = true;
                            Session["gamePlan"] = null;
                        }

                        Session["Player"] = player;
                        if (player.Win)
                        {
                            player = (Player)Session["Player"];
                            if (player.Win)
                            {
                                LabelWinLoose.Text = $"Congratulations {player.Name}! You won!";
                            }
                            else
                            {
                                LabelWinLoose.Text = $"Sorry {player.Name}! You lost!";
                            }
                            WarPanel.Enabled = false;
                            EndgamePanel.Visible = true;
                        }
                    }
                    else
                    {
                        currentTile.BackColor = System.Drawing.Color.Green;
                    }
                }
            }
        }

        protected void ButtonYes_Click(object sender, EventArgs e)
        {
            Session["gamePlan"] = null;
            Server.Transfer("Index.aspx");
        }
    }
}