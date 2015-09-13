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
    public partial class Form2 : Form
    {
        List<String> raceList = new List<String>
        {
            "Not playing",
            "Lazax",
            "Arborec",
            "Letnev",
            "Saar",
            "Embers",
            "Hacan",
            "Sol",
            "Ghosts",
            "Lizix",
            "Mentak",
            "Naalu",
            "Nekro",
            "Sardakk",
            "Jol-nar",
            "Winnu",
            "Xxcha",
            "Yin",
            "Yssaril"
        };

        List<Player> playerListForm2 = new List<Player>();
        Game parentGame;
        public Form2(Game inputParentGame)
        {
            parentGame = inputParentGame;
            InitializeComponent();
            populateRaces();
            Console.WriteLine("Initiated Form2");
        }

        private void populateRaces()//populate comboboxes with enums from namespace
        {
            this.comboBox1.DataSource = Enum.GetNames(typeof(EnumRaces));
            this.comboBox2.DataSource = Enum.GetNames(typeof(EnumRaces));
            this.comboBox3.DataSource = Enum.GetNames(typeof(EnumRaces));
            this.comboBox4.DataSource = Enum.GetNames(typeof(EnumRaces));
            this.comboBox5.DataSource = Enum.GetNames(typeof(EnumRaces));
            this.comboBox6.DataSource = Enum.GetNames(typeof(EnumRaces));
            this.comboBox7.DataSource = Enum.GetNames(typeof(EnumRaces));
            this.comboBox8.DataSource = Enum.GetNames(typeof(EnumRaces));
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void populatePlayers()
        {
            String[] listOfNames = new String[8];
            String[] listOfRaces = new String[8];

            int x = 0;
            foreach (ComboBox cb in this.tableLayoutPanel1.Controls.OfType<ComboBox>())
            {
                listOfRaces[x] = (String) cb.SelectedValue;
                Console.WriteLine("added " + x + " RACES total");
                x += 1;
            }
            x = 0;
            foreach(TextBox tb in this.tableLayoutPanel1.Controls.OfType<TextBox>())
            {
                listOfNames[x] = tb.Text;
                Console.WriteLine("added " + x + " NAMES total");
                x += 1;
            }

            String noPlayer = "None";
            for (int i = 0; i < listOfRaces.Length; i++)
            {             
                if (!listOfRaces[i].Equals(noPlayer, StringComparison.Ordinal))
                {
                    playerListForm2.Add(new Player(listOfNames[i], listOfRaces[i]));
                    //Console.WriteLine("Added player " + listOfNames[i] + " playing " +listOfRaces[i]);
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            populatePlayers();
            this.Hide();
            parentGame.SetPlayerList(playerListForm2);
            parentGame.SwitchForms();
            //var form1 = new Form1(playerList);
            //form1.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
