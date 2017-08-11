using ClassLibraryBattleShip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BattleShip
{
    public partial class EndGame : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Player player = new Player();
            if (Session["Player"] != null)
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
            } 
        }

        protected void ButtonYes_Click(object sender, EventArgs e)
        {
            Server.Transfer("Index.aspx");

            Server.Transfer("Index.aspx");

        }
    }
}