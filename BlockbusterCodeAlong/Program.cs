using System;
using System.Collections.Generic;

namespace BlockbusterCodeAlong
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //adding a new movie object:
                Movie m = new Movie("The Little Rascals", Genre.Comedy, 95, "The fire", "a ballarina", "The talentshow");


               // Movie m1 = new Movie("Inception", "Drama", 105);
               // Movie m2 = new Movie("Charlie's Angle", "Action", 60);
                //testing my code
                // m.PrintInfo();
                //Console.WriteLine(m);
                //m.PrintScenes();

                //adding a new dvd object:
                DVD d = new DVD("Charlie's Angle", Genre.Action, 60, "the explosion", "the hair sniffer", "the playboy");

                VHS a = new VHS("Guess Who", Genre.Comedy, 60, "The wedding", "The apology", "They breakup");

                Blockbuster store = new Blockbuster();

                List<Movie> results = store.SearchByGenres(Genre.Horror, Genre.Action );

                foreach(Movie result in results)
                {
                    result.PrintInfo();
                }

                //store.GetMovie(4);
            }
        }
    }
}
