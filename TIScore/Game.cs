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
        public Game()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2(this));
        }

        public void SwitchForms(List<Player> playerList)
        {
            var form1 = new Form1(playerList);
            form1.ShowDialog();
        }
    }
}
