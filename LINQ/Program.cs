namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates an array of Game objects with various titles, ESRB reatings, and genres
            Game[] games = new Game[]
        {
            new Game("Minecraft", 'E', "Sandbox"),
            new Game("Zelda", 'E', "Adventure"),
            new Game("Mario", 'E', "Platformer"),
            new Game("Overwatch", 'T', "Shooter"),
            new Game("Halo", 'M', "FPS"),
            new Game("Doom", 'M', "FPS"),
            new Game("Stardew Valley", 'E', "Simulation"),
            new Game("FIFA", 'E', "Sports"),
            new Game("Fortnite", 'T', "Battle Royale"),
            new Game("Resident Evil", 'M', "Horror")
        };
          
          // Query to select games with title shorter than 9 characters
          var shortGames = from game in games
                           where game.Title.Length < 9
                           select $"Game Title: {game.Title.ToUpper()}";
          // Prints each short game title in uppercase  
          foreach (var game in shortGames)
            {
                Console.WriteLine(game);
            }

          // Query to find and display details of the game "Minecraft"
          var mineCraft = games.Where(game => game.Title == "Minecraft")
                           .Select(game => $"Title: {game.Title}, ESRB: {game.Esrb}, Genre: {game.Genre}");

          Console.WriteLine(mineCraft.FirstOrDefault());

          var tRated = from game in games
                       where game.Esrb == 'T'
                       select game.Title;
          
          //Prints each game that is rated t  
          Console.WriteLine("T rated Games;");
          foreach(var game in tRated)
          {
              Console.WriteLine(game); 
          }

            var eRatedAction = from game in games
                               where game.Esrb == 'E' && game.Genre.Contains("Action")
                               select game.Title;

            //Prints each game that is rated E
            Console.WriteLine("E Rated Action Games");
            foreach (var game in eRatedAction)
            {
                Console.WriteLine(game);
            }

        }
    }
}
