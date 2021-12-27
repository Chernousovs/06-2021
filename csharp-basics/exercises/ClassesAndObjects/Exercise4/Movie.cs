using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    public class Movie
    {
        private string _title, _studio, _rating;

        public Movie(string title, string studio, string rating)
        {
            _title = title;
            _studio = studio;
            _rating = rating;
        }

        public Movie(string title, string studio)
        {
            _title = title;
            _studio = studio;
            _rating = "PG";
        }

        public string Title
        {
            get => _title;
        }

        public string Studio
        {
            get => _studio;
        }

        public string Rating
        {
            get => _rating;
        }

        public static Movie[] GetPG(Movie[] movies)
        {
            List<Movie> pgMovies = new List<Movie>();
            for (var i = 0; i < movies.Length; i++)
            {
                if (movies[i]._rating == "PG")
                {
                    pgMovies.Add(movies[i]);
                }
            }

            return pgMovies.ToArray();
        }
    }
}
