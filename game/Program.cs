using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there welcome to the dungeon!");
            int milliseconds = 2000;
            Thread.Sleep(milliseconds);
            Console.WriteLine("Your task is to espace the maze...");

            string yn_input;

            Console.WriteLine("Do you have what it takes to make it through!? yes/no ?");
            yn_input = Console.ReadLine();
            if (yn_input == "no")
            {

                Console.WriteLine();
                Thread.Sleep(1000);
                Console.WriteLine("Okay. You will be escorted out!");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine("Good luck with your journey!");
                Thread.Sleep(2500);

                Environment.Exit(0);

                Console.ReadLine();
            }
            if (yn_input == "yes")
            {

                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Great. Lets get started! ");
                Thread.Sleep(1500);

                Console.WriteLine("What is your name warrior!? ");
                var myname = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"Greetings " + myname);

                Console.WriteLine("You enter a decaying room. How do you escape? ");
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "           xx\r\n           xx\r\n           xx\r\n           xx\r\n           xx\r\n           xx\r\n    xxxxxxxxxxxxxxxx\r\n    x +-          +x\r\n    x v          + x\r\n    x    +        |x\r\n    x+ +       -- |x\r\n    xx  xxxxxxxx  xx"));




                Console.ReadLine();

            }

        }


    }
}