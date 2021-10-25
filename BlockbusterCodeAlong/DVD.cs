using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterCodeAlong
{
    class DVD: Movie
    {
        public DVD(string Title, Genre Category, int RunTime, params string[] Scenes)
           : base(Title, Category, RunTime, Scenes)
        {

        }




        Blockbuster blockbuster = new Blockbuster();



        public override void Play()
        {
            PrintScenes();
            Console.WriteLine($"Which secne would you like to watch? (select by index) ");
            int userPick = int.Parse(Console.ReadLine());
            string scene = Scenes[userPick];
            Console.WriteLine(scene);



        }
    }
}
