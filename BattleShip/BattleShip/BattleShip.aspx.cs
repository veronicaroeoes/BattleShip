using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryBattleShip;

namespace BattleShip
{
    public partial class WebForm1 : System.Web.UI.Page
    {        
        protected void Page_Load(object sender, EventArgs e)
        {
            // StartGame(); 
        }

        private void StartGame(string playerName, string gameBoardSize)
        {
            // Player name
            // Size of game board, hårdkodadt 4x5 tiles


        }

        protected void btnPlayGame_Click(object sender, EventArgs e)
        {
            
            if (Request["action"] != null)
            {
                string gameBoardSize = "4,5";
                string playerName = TextBoxPlayerName.Text;

                
                StartGame(playerName, gameBoardSize);
            }
        }
    }
}