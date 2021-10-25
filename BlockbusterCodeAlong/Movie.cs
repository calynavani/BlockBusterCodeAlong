using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlockbusterCodeAlong
{
    class Movie
    {
        public string Title { get; set; }

        //put inthe Enum for our cateogry
        public Genre Category { get; set; }
        public int RunTime { get; set; }

        public int CurrentTime { get; set; }
        //make sure with lists you have using system.collections.generic
        // you must create/initialize the list before doing anything else because theuy are objects
        //do not put the list in the constrcutor 
        public List<string> Scenes { get; set; } = new List<string>();


        //what does the params keyword do? 
        //They allow su to fill in  our method calls with as many inputs as we sih/
        //Paras must be set on the last parameter in your method
        //for params you may feed in comma seperated values or an array
        //Handy for when you don't know the number of inputs you need
        //or for filling in a list or array.

        public Movie(string Title, Genre Category, int RunTime, params string[] Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = RunTime;
            this.Scenes = Scenes.ToList();

            string drama, comedy, horror, romance, action;

        }
        public Movie(string Title, Genre Category, int RunTime, List<string> Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = RunTime;
            this.Scenes = Scenes;
        }




        public override string ToString()
        {
            string output = $"Title: {Title}";
            output += $"Category: {Category}";
            output += $"Run Time: {RunTime}";

            return output;
        }
        //ToString lets you print the bject directly 


        //print and saves the scenes
        //child can ovverride but if they dont the method/priperty will pass as is
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Categore: {Category}");
            Console.WriteLine($"Run Time: {RunTime}");
        }

        //PrintScenes is not virtual because it does not need to change, the children take as is
        public void PrintScenes()
        {
            for (int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine($"{i} : {Scenes[i]}");
            }
        }
        //The children of Movie calss must created theri own play method!!!!
        public virtual void Play()
        {

        }
    }
}
