using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

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

                Thread.Sleep(1500);
                Console.WriteLine();
                Console.WriteLine("You enter a decaying room. How do you escape? ");
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "           xx\r\n           xx\r\n           xx\r\n           xx\r\n           xx\r\n           xx\r\n    xxxxxxxxxxxxxxxx\r\n    x +-          +x\r\n    x v          + x\r\n    x    +        |x\r\n    x+ +       -- |x\r\n    xx  xxxxxxxx  xx"));
                Console.WriteLine();
                {
                string choice;

                Console.WriteLine("a. Search the lampshade.");
                Console.WriteLine("b. Search the cabinet.");
                Console.WriteLine("c. Search the Under the mattress.");
                Console.WriteLine();
                Console.WriteLine("Please state your choice: ");
                choice = Console.ReadLine().ToLower();
                Console.Clear();

                switch (choice)
                {
                    case "a":
                        {
                            Console.WriteLine("You cautiously tip-toe over to the lampshade");
                            Thread.Sleep(1500);
                            Console.WriteLine("minding your bare feet on the cracked stone floor.");
                            Thread.Sleep(1500);
                            Console.WriteLine("You lift up the lampshade to check inside and underneath.");
                            Thread.Sleep(1500);
                            Console.WriteLine("You found nothing. Please look elsewhere.");
                            Thread.Sleep(1500);
                            Console.WriteLine("Press 'Enter' to continue. ");
                            Console.ReadLine();                            
                            break;
                        }
                    case "b":
                            {
                                Console.WriteLine("You pounce to the cabinet,");
                                Thread.Sleep(1500);
                                Console.WriteLine("the freezing cold floor gives you goosebumps.");
                                Thread.Sleep(1500);
                                Console.WriteLine("you stretch to the rusty handle and yank it open,");
                                Thread.Sleep(1500);
                                Console.WriteLine("what you find haunts you");
                                Thread.Sleep(1500);
                                Console.WriteLine("A decomposing arm. You step back. Please look elsewhere.");
                                Thread.Sleep(1500);
                                Console.WriteLine("Press 'Enter' to continue. ");
                                Console.ReadLine();
                                break;
                            }
                    case "c":
                            {
                                Console.WriteLine("You waddle over to the moist mattress");
                                Thread.Sleep(1500);
                                Console.WriteLine("you examine the mattress.");
                                Thread.Sleep(1500);
                                Console.WriteLine("You flip over the mattress.");
                                Thread.Sleep(1500);
                                Console.WriteLine("You find the skelton key,");
                                Thread.Sleep(1500);
                                Console.WriteLine("a sense of accomplishment passes over you.");
                                Thread.Sleep(1500);
                                Console.WriteLine("Press 'Enter' to continue. ");
                                Console.ReadLine();
                                break;
                            }
                }

                }



                Console.ReadLine();

            }
           
        }
        static void lampshade()
        {

        }
            
    }
}
