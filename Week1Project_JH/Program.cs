using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Project_JH
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basic Questions

            Console.WriteLine("Welcome to the fortune teller! First, I need to gather some information...");
            Console.WriteLine("Please enter your first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please enter your numerical age:");
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the corresponding number for your birth month:");
            int userBirthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your favorite ROYGBIV color. If you need help here, please type \"Help\" without quotes.");
            string colorAnswer = Console.ReadLine().ToLower();
            
            //Rainbow Color case

            switch (colorAnswer)
            {
                case "help":
                    Console.WriteLine("ROYGBIV correlates to the colors of the rainbow.");
                    Console.WriteLine("R = Red");
                    Console.WriteLine("O = Orange");
                    Console.WriteLine("Y = Yellow");
                    Console.WriteLine("G = Green");
                    Console.WriteLine("B = Blue");
                    Console.WriteLine("I = Indigo");
                    Console.WriteLine("V = Violet");
                    break;
                case "red":
                    colorAnswer = "red";
                    break;
                case "orange":
                    colorAnswer = "orange";
                    break;
                case "yellow":
                    colorAnswer = "yellow";
                    break;
                case "green":
                    colorAnswer = "green";
                    break;
                case "blue":
                    colorAnswer = "blue";
                    break;
                case "indigo":
                    colorAnswer = "indigo";
                    break;
                case "violet":
                    colorAnswer = "violet";
                    break;
                default:
                    Console.WriteLine("You entered an invalid color.");
                    break;
            }
            if (colorAnswer == "help")
            {
                Console.WriteLine("Now please enter your favorite color");
                colorAnswer = Console.ReadLine().ToLower();
            }
                
            //Sibling Count

            Console.WriteLine("How many siblings do you have? (Number, not word)");
            int siblingNum = int.Parse(Console.ReadLine());

            int retireTime = (userAge % 2);

            if (userAge % 2 == 0)
            {
                retireTime = 31;
            }
            else if (userAge % 2 == 1)
            {
                retireTime = 30;
            }


            //Vacation Home

            string vacHome = null;

            if (siblingNum == 0)
            {
                vacHome = "Hawaii";
            }
            else if (siblingNum == 1)
            {
                vacHome = "Florida";
            }
            else if (siblingNum == 2)
            {
                vacHome = "Thailand";
            }
            else if (siblingNum == 3)
            {
                vacHome = "Paris";
            }
            else if (siblingNum > 3)
            {
                vacHome = "Greece";
            }
            else
            {
                vacHome = "Dumpster";
            }

            //Modes of Transportation

            string rideType = null;
            if (colorAnswer == "red")
            {
                rideType = "jetpack";
            }
            else if (colorAnswer == "orange")
            {
                rideType = "personal helicopter";
            }
            else if (colorAnswer == "yellow")
            {
                rideType = "sports car";
            }
            else if (colorAnswer == "green")
            {
                rideType = "speedboat";
            }
            else if (colorAnswer == "blue")
            {
                rideType = "motorcycle";
            }
            else if (colorAnswer == "indigo")
            {
                rideType = "segway";
            }
            else if (colorAnswer == "violet")
            {
                rideType = "submarine";
            }
            else
            {
                Console.WriteLine("You entered an invalid color.");
            }

            //Money in the bank based on birth month

            int bankMoney = userBirthMonth;
            if (userBirthMonth > 0 && userBirthMonth <= 4) 
            {
                bankMoney = 1000000;
            }
            else if (userBirthMonth > 4 && userBirthMonth <= 8) 
            {
                bankMoney = 500000;
            }
            else if (userBirthMonth > 8 && userBirthMonth <= 12) 
            {
                bankMoney = 250000;
            }
            else
            {
                bankMoney = 0;
            }

            Console.WriteLine("Your fortune has been read! Here are the results...");
            Console.WriteLine(firstName + " " + lastName + " " + "will retire in " + retireTime + " years with $" + bankMoney + " in the bank,\n a vacation home in " + vacHome + " and a " + rideType + " to get around.");
            
            //As a side note, I inadvertantly gave myself the best vacation home/ride. The rest was intentional, but it was a
            //fairly funny thing to see when I put in my personal info.
            //Your mileage may vary.
        }
    }
}
