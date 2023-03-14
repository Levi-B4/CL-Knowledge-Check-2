using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Knowledge_Check_2
{
    internal class RealTimeStrategyGame : VideoGame
    {
        public int NumberOfFactions { get; set; }

        public RealTimeStrategyGame()
        {
            int minNumFactions = 0;
            int maxNumFactions = 50;
            bool NumFactionsVerified = false;
            do
            {
                Console.Write($"How many Factions are in this game, including subfactions as seperate factions.(Min: {minNumFactions} Max: {maxNumFactions})\n");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int userInputInt) &&
                        (minNumFactions < userInputInt && userInputInt <= maxNumFactions))
                {
                    NumberOfFactions = userInputInt;
                    NumFactionsVerified = true;
                }
                else Console.WriteLine("Please make sure to enter the number correctly.");

            } while (!NumFactionsVerified);
        }
    }
}
