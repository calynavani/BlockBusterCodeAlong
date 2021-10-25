using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterCodeAlong
{
    class VHS: Movie
    {
        public int CurrentTime { get; set; } = 0;


        public VHS(string Title, Genre Category, int RunTime, params string[] Scenes)
            : base(Title, Category, RunTime, Scenes)
        {


        }


        //print the scene at the current time
        //Increment the current time
        //if the current time is greater than the length of the movie rewind ir


        public override void Play()
        {
            if (CurrentTime < Scenes.Count)
            {
                string scene = Scenes[CurrentTime];
                CurrentTime++;
                Console.WriteLine(scene);
            }
            else
            {
                Rewind();
            }

        }

        public void Rewind()
        {
            Console.WriteLine($"Now Rewinding: {Title}");
            CurrentTime = 0;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
        }
    }
}
