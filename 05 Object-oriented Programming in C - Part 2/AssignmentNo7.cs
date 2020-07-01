using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieNamespace;

namespace AssignmentNo7
{
    class AssignmentNo7
    {
        static void Main(string[] args)
        {
            MovieNamespace.Movie InceptionInstance = new MovieNamespace.Movie();
            MovieNamespace.Movie WildTalesInstance = new MovieNamespace.Movie();


            InceptionInstance.MovieName = "Inception";
            InceptionInstance.Rate = 8.8;
            InceptionInstance.ReleaseDate = new DateTime(2010, 7, 16);


            InceptionInstance.Languages = new Language[3];
            InceptionInstance.Languages[0] = Language.English;
            InceptionInstance.Languages[1] = Language.French;
            InceptionInstance.Languages[2] = Language.Japanese;


            InceptionInstance.Countries2 = new Country[2];
            InceptionInstance.Countries2[0] = Country.UnitedStatesofAmerica;
            InceptionInstance.Countries2[1] = Country.UnitedKingdom;


            InceptionInstance.Genres = new Genres[3];
            InceptionInstance.Genres[0] = Genres.Action;
            InceptionInstance.Genres[1] = Genres.Adventure;
            InceptionInstance.Genres[2] = Genres.SciFi;


            WildTalesInstance.MovieName = "Wild Tales";
            WildTalesInstance.Rate = 8.1;
            WildTalesInstance.ReleaseDate = new DateTime(2014, 8, 21);


            WildTalesInstance.Languages = new Language[1];
            WildTalesInstance.Languages[0] = Language.Spanish;


            WildTalesInstance.Countries2 = new Country[2];
            WildTalesInstance.Countries2[0] = Country.Argentina;
            WildTalesInstance.Countries2[1] = Country.Spain;


            WildTalesInstance.Genres = new Genres[3];
            WildTalesInstance.Genres[0] = Genres.Comedy;
            WildTalesInstance.Genres[1] = Genres.Drama;
            WildTalesInstance.Genres[2] = Genres.Thriller;


            InceptionInstance.DisplayMovieInformation();
            WildTalesInstance.DisplayMovieInformation();
        }
    }
}
