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
        Game parentGame;
        System.Resources.ResourceManager rm = new System.Resources.ResourceManager(typeof(TIScore.Properties.Resources));
        List<Player> playerList;

        public Form1(Game inputGame)
        {
            parentGame = inputGame;
            playerList = parentGame.getPlayerList();

            InitializeComponent();
            AnnouncePlayers();
            PopulatePictureBoxes();
        }

        public void AnnouncePlayers() //for debugging
        {
            Console.WriteLine("The players are:");
            foreach(Player currentPlayer in parentGame.getPlayerList())
            {
                Console.WriteLine(currentPlayer.Name + " playing " + currentPlayer.Race);
            }
        }

        public void PopulatePictureBoxes()
        {
            List<PictureBox> pictureBoxes = new List<PictureBox>() {pictureBox1,pictureBox2,pictureBox3,pictureBox4,pictureBox5,pictureBox6,pictureBox7,pictureBox8 };

            /*
            string player1Race = parentGame.getPlayerList()[0].Race;
            object playerImageResource = rm.GetObject(player1Race);

            pictureBoxes[0].Image = (System.Drawing.Image)playerImageResource;

            player1Race = parentGame.getPlayerList()[1].Race;
            playerImageResource = rm.GetObject(player1Race);
            pictureBox2.Image = (System.Drawing.Image)playerImageResource;
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            */

            int BoxCounter=0;
            string currentPlayerRace;
            object playerImageResource;

            foreach(PictureBox thisbox in pictureBoxes)
            {
                if (BoxCounter<playerList.Count)
                {
                    currentPlayerRace = playerList[BoxCounter].Race;
                    playerImageResource = rm.GetObject(currentPlayerRace);
                    pictureBoxes[BoxCounter].Image = (System.Drawing.Image)playerImageResource;
                    pictureBoxes[BoxCounter].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    Console.WriteLine("ADDED PICTURE FOR "+ currentPlayerRace);
                }
                else
                {
                    return;
                }

                BoxCounter += 1;
            }

        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
