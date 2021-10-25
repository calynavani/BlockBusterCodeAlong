using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlockbusterCodeAlong
{
    //Stores the movies and lets us check them out
    //also known as a runner class, this is becasue
    // the main job is to manage and delegate to other classes 
    class Blockbuster
    {
        
        List<Movie> Movies { get; set; } = new List<Movie>();

        //we'll use the constructor to fill in the movie list

        public Blockbuster()
        {
            Movies.Add(new DVD("28 Days Later", Genre.Horror, 130, "Infected attack", "He wakes up from a coma"));
            Movies.Add(new DVD("Forest Gump", Genre.Drama, 150, "Running scene", "He wakes up from a coma"));
            Movies.Add(new DVD("Dawn of the dead", Genre.Horror, 135, " mall take over", "He wakes up from a coma"));




            Movies.Add(new VHS("Set It Off", Genre.Action, 90, "The robbery", "the shoot out"));
            Movies.Add(new VHS("Billy Madison", Genre.Comedy, 110, "Billy goes back to school", "field trip"));
            Movies.Add(new VHS("2021", Genre.Horror, 110, "the acoplypse", "the takeover"));


        }

        public Movie GetMovie(int index)
        {
            Movie m = Movies[index];
            //m.rewind wil ever work since it does not exist in the movie class, only in VHS
            //m.Rewind();

            //while(true) // test loop
            //{
            //    //When i call m.Play c# see that m is a VHS and tried to find play in VHS first
            //    //then if play is not found it goes up to Movie
            //    m.Play();
            //}

            return m;
        }
            
        
        public List<Movie> SearchByGenres(params Genre[] searchTypes)
        {

        
            
            //make an output list
            //loop throuhg movies
            //if movie type == searchType, add it to output
            //return outout
            List<Movie> outputs = new List<Movie>();
            for (int i = 0; i < Movies.Count; i++)
            {
                Movie m = Movies[i];

                if(searchTypes.Contains(m.Category))
                {
                    outputs.Add(m);
                }


                //if (m.Category == searchType)
                //{
                //    outputs.Add(m);
                //}

            }
            return outputs;

         }   
    }
}
