using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStock
{
    public class Program
    {
        public static List<Movie> MovieList = new List<Movie>();
        public void AddMovie(string MovieDetails)
        {
            String[] movie = MovieDetails.Split(',');
            Movie m = new Movie();
            m.Title = movie[0];
            m.Artist = movie[1];
            m.Genre = movie[2];
            m.Ratings = Convert.ToInt32(movie[3]);

            MovieList.Add(m);
        }
        public List<Movie> ViewMoviesByGenre(string genre)
        {
            var ls = MovieList.Where(x=>x.Genre == genre).ToList();
            return ls;
        }
        public List<Movie> ViewMoviesByrating()
        {
            var ls = from data in MovieList
                     orderby data.Ratings
                     select data;
            return ls.ToList();
        }
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the details to store a movie in a string (Title, Artist, Genre, Rating)");
            string moviedetails = Console.ReadLine();
            Program pObj = new Program();
            pObj.AddMovie(moviedetails);

            List<Movie> moviesByRating = pObj.ViewMoviesByrating();
            Console.WriteLine("Movies by rating");
            foreach(var i in  moviesByRating)
            {
                Console.Write($"\n Movie Title: {i.Title}, Artist: {i.Artist}, Genre: {i.Genre}, Rating: {i.Ratings}\n");
            }

            Console.WriteLine("Enter the genre name whoch u want to see: ");
            string genre = Console.ReadLine();
            List<Movie> moviesByGenre = pObj.ViewMoviesByGenre(genre);
            if (moviesByGenre.Count > 0)
            {
                Console.WriteLine("Movie: ");
                foreach (var i in moviesByGenre)
                {
                    Console.Write($"\n Movie Title: {i.Title}, Artist: {i.Artist}, Genre: {i.Genre}, Rating: {i.Ratings}");
                }
            }
            else
            {
                Console.WriteLine("No Movies found in genre"+genre);
            }

        }
    }
    public class Movie
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public int Ratings { get; set; }
    }

}
