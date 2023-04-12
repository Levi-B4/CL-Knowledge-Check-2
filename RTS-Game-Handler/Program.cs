namespace RTSGameHandler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfRTSGames = AskUserForNumberOfRTSGames();

            var RTSGameList = new List<RealTimeStrategyGame>();
            for (int i = 0; i < numberOfRTSGames; i++)
            {
                Console.WriteLine($"Game {i+1}:");
                var myClass = new RealTimeStrategyGame();
                RTSGameList.Add(myClass);
            }

            foreach (RealTimeStrategyGame game in RTSGameList)
            {
                Console.WriteLine($"{game.GameName} has {game.NumberOfFactions} Factions.");
            }
            Console.WriteLine("Press Enter to exit Program.");
            Console.ReadLine();


            //Methods
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