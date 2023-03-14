using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Knowledge_Check_2
{
    internal class VideoGame
    {
        public string GameName { get; set; }

        public VideoGame()
        {
            do
            {
                Console.WriteLine("What is the name of this game? ");
                string gameName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(gameName))
                {
                    GameName = gameName;
                }
                else Console.WriteLine("Please enter the name of the game.");

            } while (GameName == default(string));
        }
    }
}
