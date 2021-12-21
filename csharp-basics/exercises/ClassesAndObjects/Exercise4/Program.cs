using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie[] movies = {
                new ("Casino Royale", "Eon Productions", "PG­13"),
                new ("Glass", "Buena Vista International", "PG­13"),
                new ("Spider-Man: Into the Spider-Verse", "Columbia Pictures")};

            foreach (var movie in Movie.GetPG(movies))
            {
                Console.WriteLine(movie.Title);
            }
        }
    }
}
