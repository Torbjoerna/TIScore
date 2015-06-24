using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIScore
{
    public enum EnumRaces
    {
        None,
        Lazax,
        Arborec,
        Letnev,
        Saar,
        Embers,
        Hacan,
        Sol,
        Ghosts,
        Lizix,
        Mentak,
        Naalu,
        Nekro,
        Sardakk,
        Jolnar,
        Winnu,
        Xxcha,
        Yin,
        Yssaril
    };
    

    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form2());
            Game currentGame = new Game();
        }
    }
}
