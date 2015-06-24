using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIScore
{
    public class Player
    {
        // TODO 
        //
        //Replace playerRace with the enums in namespace and/or use enums for playerRace
        //
        //
        //
        //
        private String playerName;
        private String playerRace;

        public Player(String inputName, String inputRace)
        {
            playerName = inputName;
            playerRace = inputRace;
        }

        public String Name
        {
            get
            {
                return playerName;
            }

            set
            {
                playerName = value;
            }
        }

        public String Race
        {
            get
            {
                return playerRace;
            }

            set
            {
                playerRace = value;
            }
        }
    }
}
