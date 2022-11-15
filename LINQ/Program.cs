using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string>() { "God of War", "Call of Duty", "Assassins Creed", "Pac Man", "Super Mario Bros", "Donkey Kong" };
            var Games = videoGames.OrderBy(game => game.Count());
            foreach (var game in Games)
            {
                Console.WriteLine(game);
            }
            
        }
    }
}
