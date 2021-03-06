﻿using System;
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
            Player player = new Player();
            if (Session["Player"] != null)
            {
                player = (Player)Session["Player"];
                TextBoxPlayerName.Text = $"{player.Name}";
                Session["Player"] = null;
            }
        }

        protected void btnPlayGame_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                int rows = Convert.ToInt32(TextBoxRows.Text);
                int columns = Convert.ToInt32(TextBoxColumns.Text);
                string playerName = TextBoxPlayerName.Text;

                Server.Transfer($"PlayGame.aspx?rows={rows}&columns={columns}&playerName={playerName}");
            }
        }
    }
}