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

        }

        protected void btnPlayGame_Click(object sender, EventArgs e)
        {
            int rows = Convert.ToInt32(TextBoxRows.Text);
            int columns = Convert.ToInt32(TextBoxColumns.Text);
            string playerName = TextBoxPlayerName.Text;

            Server.Transfer($"PlayGame.aspx?rows={rows}&columns={columns}&playerName={playerName}");
        }
    }
}