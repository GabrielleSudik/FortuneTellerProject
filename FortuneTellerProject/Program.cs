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
            Console.WriteLine("If you get scared at any point, type \"quit\" and your reading will end.");

            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            if (firstName.ToLower() == "quit")
            {
                Console.WriteLine("Nobody likes a quitter!");
                return;
            }

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            if (lastName.ToLower() == "quit")
            {
                Console.WriteLine("Nobody likes a quitter!");
                return;
            }

            Console.WriteLine("How old are you? Round numbers only, please.");
            string ageText = Console.ReadLine();
            //might need to accept a string then convert to int?  maybe try the answer as an if/else
            if (ageText.ToLower() == "quit")
            {
                Console.WriteLine("Nobody likes a quitter!");
                return;
            }

            int age = Convert.ToInt32(ageText);

            Console.WriteLine("In what month were you born? Please use the number... January is 1, etc.");
            string monthText = Console.ReadLine();
            //same problem
            if (monthText.ToLower() == "quit")
            {
                Console.WriteLine("Nobody likes a quitter!");
                return;
            }

            int month = Convert.ToInt32(monthText);

            Console.WriteLine("How many siblings do you have?");
            string sibsText = Console.ReadLine();
            //same problem
            if (sibsText.ToLower() == "quit")
            {
                Console.WriteLine("Nobody likes a quitter!");
                return;
            }

            int sibs = Convert.ToInt32(sibsText);

            //get favorite color
            //offer option for help
            //make not case sensitive

            Console.WriteLine("And what is your favorite Roy G. Biv color?");
            Console.WriteLine("(Type \"help\" if you don't know Roy G. Biv.)");
            string colorChoice = Console.ReadLine().ToLower();
            string colorHelp = "help";

            if (colorChoice == colorHelp)
            {
                Console.WriteLine("The Roy G. Biv colors are red, orange, yellow, green, blue, indigo, violet.");
                Console.WriteLine("Now that you know Roy G. Biv, what is your favorite color?");
                colorChoice = Console.ReadLine().ToLower();
            }

            //same problem
            if (colorChoice == "quit")
            {
                Console.WriteLine("Nobody likes a quitter!");
                return;
            }
            
            Console.WriteLine($"So you like {colorChoice}, eh? Me too.");
            Console.WriteLine("\nIf you are ready for your fortune, press enter...\n");
            string possQuitPlace1 = Console.ReadLine();

            if (possQuitPlace1 == "quit")
            {
                Console.WriteLine("Nobody likes a quitter!");
                return;
            }
            
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

            string vacayHome = "";

            if (sibs < 0)
            {
                vacayHome = "Aleppo, Syria";
            }
            else if (sibs == 0)
            {
                vacayHome = "Put-in-Bay";
            }
            else if (sibs == 1)
            {
                vacayHome = "The Rocky Mountains";
            }
            else if (sibs == 2)
            {
                vacayHome = "Key West";
            }
            else if (sibs >= 3)
            {
                vacayHome = "London, England";
            }

            //predictions about trandportation and colors

            string transport = "";

            switch (colorChoice)
            {
                case "red":
                    transport = "car";
                    break;
                case "orange":
                    transport = "pogo stick";
                    break;
                case "yellow":
                    transport = "bicycle";
                    break;
                case "green":
                    transport = "spaceship";
                    break;
                case "blue":
                    transport = "boat";
                    break;
                case "indigo":
                    transport = "skateboard";
                    break;
                case "violet":
                    transport = "Harley Davidson";
                    break;
            }

            //dollars in bank and birth month predictions

            double dollars;

            if (month >= 1 && month <= 4)
            {
                dollars = 25000;
            }
            else if (month >=5 && month <= 8)
            {
                dollars = 300000;
            }
            else if (month >=9 && month <= 12)
            {
                dollars = 6.37;
            }
            else
            {
                dollars = 0;
            }

            //final predictions

            Console.WriteLine($"{firstName} {lastName}, you will retire in {retYears} years " + 
                $"with ${dollars} in the bank, \na vacation home in {vacayHome} " +
                $"and a {transport}.");
            Console.WriteLine("\nOh, and make sure you look both ways before you cross the street today.");

            Console.ReadLine();
        }
    }
}
