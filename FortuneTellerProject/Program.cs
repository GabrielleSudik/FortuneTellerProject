using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //WCCI week 2 project. Fortune teller.
            //start with getting basic info

            Console.WriteLine("I am the Great GatlantisS and I will read your fortune!\n");

            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("How old are you? Round numbers only, please.");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("In what month were you born? Please use the number... January is 1, etc.");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("How many siblings do you have?");
            int sibs = int.Parse(Console.ReadLine());

            //tricky part... get favorite color
            //offer option for help
            //make not case sensitive

            Console.WriteLine("And what is your favorite Roy G. Biv color?");
            Console.WriteLine("(Type \"help\" if you don't know Roy G. Biv.)");
            string colorChoice = Console.ReadLine().ToLower();
            string colorHelp = "help";

            if (colorChoice == colorHelp /*|| colorChoice == colorHelp.ToUpper() || colorChoice == colorHelp.ToLower()*/)
            {
                Console.WriteLine("The Roy G. Biv colors are red, orange, yellow, green, blue, indigo, violet.");
                Console.WriteLine("Now that you know Roy G. Biv, what is your favorite color?");
                colorChoice = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"So you like {colorChoice}, eh? Me too.");
            Console.WriteLine("\nIf you are ready for your fortune, press enter...\n");

            //predict years until retirement from age

            int retYears;

            if (age % 2 == 0)
            {
                retYears = 5;
            }
            else
            {
                retYears = 10;
            }

            //predict vacation home from number of sibs

            string vacayHome;
            switch (sibs)
            {
                case 0:
                    vacayHome = "Put-in-Bay"
            }
            

            //string secondColorChoice = 
            Console.ReadLine();
        }
    }
}
