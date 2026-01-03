using System;
using System.Collections.Generic;
using System.Text;

namespace MovieLibrary
{
    public interface IFilm
    {
         string Title {  get; set; }
        string Director { get; set; }
        int Year { get; set; }

    }
}
