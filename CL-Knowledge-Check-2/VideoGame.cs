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
            int maxNameLength = 20;
            bool nameVerified = false;
            do
            {
                Console.WriteLine($"What is the name of this game? (Max characters: {maxNameLength})");
                string gameName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(gameName) && gameName.Length <= maxNameLength)
                {
                    GameName = gameName;
                    nameVerified = true;
                }
                else Console.WriteLine("Please enter a valid name.");

            } while (!nameVerified);
        }
    }
}
