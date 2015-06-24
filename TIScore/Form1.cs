using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIScore
{
    public partial class Form1 : Form
    {
        List<Player> playerListForm1;



        public Form1(List<Player> inputPlayerList)
        {
            InitializeComponent();
            playerListForm1 = inputPlayerList;
            announcePlayers();
        }

        public void announcePlayers() //primarily for debugging
        {
            Console.WriteLine("The players are:");
            foreach(Player currentPlayer in playerListForm1)
            {
                Console.WriteLine(currentPlayer.Name + " playing " + currentPlayer.Race);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
