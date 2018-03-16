using System;
using KITBOX_project;

namespace Main_Project
{
     
    class MainClass
    {
        
        public static void Main(string[] args)
        {
            Battens bat = new Battens("br", 15);
            bat.Color = "red";
            Console.WriteLine(bat); 
            Console.WriteLine("Hello World!");
        }
    }
}
