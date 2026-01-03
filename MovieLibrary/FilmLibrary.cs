using System;
using System.Collections.Generic;
using System.Text;

namespace MovieLibrary
{
    public class FilmLibrary : IFilmLibrary
    {
        private static  List<IFilm> _film =new List<IFilm>();
        public bool AddFilm(IFilm film)
        {
            if(film != null)
            {
                _film.Add(film);
                return true;
            }
            throw new FilmException("There is no data. We r not able to store this film");
            return false;
        }

        public void GetFilm()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("List of the Films");
            Console.WriteLine("||\tTitle\t||\tDirector Name\t||\t Year\t||");
            foreach (var i in _film)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("|"+i.Title+"\t|\t"+i.Director+"\t|\t"+i.Year+"\t|");

            }
            Console.ResetColor();
        }

        public int GetTotalFilmCount()
        {
            int count = _film.Count;
            return count;

        }

        public bool RemoveFilm(string title)
        {
            IFilm film = _film.Find(f=> f.Title == title);
            if (film != null)
            {
                _film.Remove(film);
                return true;
            }
            return false;
        }
        public IFilm SearchFilms(string title)
        {
            IFilm film = _film.Find(f=>f.Title == title);
            if(film != null)
            {
                return film;
            }
            throw new FilmException("There is no film with the title: " + title);
        }
    }
}
