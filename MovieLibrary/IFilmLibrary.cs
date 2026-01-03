using System;
using System.Collections.Generic;
using System.Text;

namespace MovieLibrary
{
    public interface IFilmLibrary
    {
        public bool AddFilm(IFilm film);
        public bool RemoveFilm(string title);
        public void GetFilm();

        public IFilm SearchFilms(string title);
        public int GetTotalFilmCount();
    }
}
