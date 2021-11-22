using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema68.Entity
{
    class Movie : Account
    {
        string movie_director { get; set; }
        DateTime movie_releasedate { get; set; }
        TimeSpan movie_length { get; set; }
        string movie_genre { get; set; }
        int movie_rating { get; set; }
        string movie_name { get; set; }
        DateTime movie_dates { get; set; }
        string movie_synopsis { get; set; }
        string movie_picture;
        int movie_id;

        //constructor
        //movie_id and movie_picture are not in constructor as 
        //dbconnector has yet to be implemeneted
        public Movie(string mname, int mrating, string mgenre, TimeSpan mlength, DateTime mreleasedate, DateTime mdates, string mdirector, string msynopsis)
        {
            movie_releasedate = mdates;
            movie_length = mlength;
            movie_name = mname;
            movie_dates = mdates;
            movie_genre = mgenre;
            //these are error checked functions
            setMovieRating(mrating);
            setMovieDirector(mdirector);
            setMovieSynopsis(msynopsis);
        }

        //check to make sure director's name is only letters
        void setMovieDirector(string director)
        {
            if (director.All(char.IsLetter))
                movie_director = director;
        }
        //check to make sure rating is inbetween 0 and 5
        void setMovieRating(int rating)
        {
            if (rating >= 0 && rating <= 5)
                movie_rating = rating;
            else
                throw new ArgumentException("rating must be between 0 and 5");
        }
        //check to make sure synopsis is not longer than 50 words
        void setMovieSynopsis(string synopsis)
        {
            int wordlength = synopsis.Split(' ').Length;
            if (wordlength < 50)
                movie_synopsis = synopsis;
            else
            {
                throw new ArgumentException("synopsis cannot be longer than 50 words");
            }
        }
        //the rest of the set functions are to be implemented with dbconnector
        void setMoviePicture(string filename)
        {
            movie_picture = filename;
        }
        //increment the last movie ID that was assigned to a movie
        void MovieID()
        {
            movie_id++;
        }
    }
}
