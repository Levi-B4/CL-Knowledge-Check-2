namespace CL_Knowledge_Check_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfRTSGames = AskUserForNumberOfRTSGames();

            var RTSGameList = new List<RealTimeStrategyGame>();
            for (int i = 0; i < numberOfRTSGames; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                Console.WriteLine($"Game {i+1}:");
                var myClass = new RealTimeStrategyGame();
                RTSGameList.Add(myClass);
            }

            // Print out the list of records using Console.WriteLine()
            foreach (RealTimeStrategyGame game in RTSGameList)
            {
                Console.WriteLine($"{game.GameName} has {game.NumberOfFactions} Factions.");
            }


            //methods (Not putting in Repo class so that the two requested classes are more clear)

            int AskUserForNumberOfRTSGames()
            {
                int numberOfRTSGames = default(int);
                do
                {
                    Console.Write("How many RTS games do you want to add?\n");
                    if (int.TryParse(Console.ReadLine(), out int userInputInt))
                    {
                        numberOfRTSGames = userInputInt;
                    }
                    else Console.WriteLine("Please make sure to enter the number correctly.");

                } while (numberOfRTSGames == default(int));
                return numberOfRTSGames;
            }
        }
    }
}