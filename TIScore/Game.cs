using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIScore
{
    public class Game
    {
        List<Player> gamePlayerList = new List<Player>();


        public Game()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2(this));
        }

        public void SetPlayerList(List<Player> playerList)
        {
            gamePlayerList = playerList;
        }

        public List<Player> getPlayerList()
        {
            return gamePlayerList;
        }

        public void SwitchForms()
        {
            var form1 = new Form1(this);
            form1.ShowDialog();
        }
    }
}
