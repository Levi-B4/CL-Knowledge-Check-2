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
            do
            {
                Console.Write("How many Factions are in this game, including subfactions as seperate factions.\n");
                if (int.TryParse(Console.ReadLine(), out int numberOfFactions))
                {
                    NumberOfFactions = numberOfFactions;
                }
                else Console.WriteLine("Please make sure to enter the number correctly.");

            } while (NumberOfFactions == default(int));
        }
    }
}
