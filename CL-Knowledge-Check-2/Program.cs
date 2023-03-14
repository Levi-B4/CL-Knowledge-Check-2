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
                int minAddedGames = 1;
                int maxAddedGames = 20;
                bool numGamesVerified = false;
                do
                {
                    Console.Write($"How many RTS games do you want to add? (Min: {minAddedGames} Max: {maxAddedGames})\n");
                    string input = Console.ReadLine();
                    
                    if (int.TryParse(input, out int userInputInt) &&
                        (minAddedGames < userInputInt && userInputInt <= maxAddedGames))
                    {
                        numberOfRTSGames = userInputInt;
                        numGamesVerified = true;
                    }else Console.WriteLine("Please make sure to enter the number correctly.");

                } while (!numGamesVerified);
                return numberOfRTSGames;
            }
        }
    }
}