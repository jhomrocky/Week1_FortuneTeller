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
            Console.WriteLine("Welcome to the fortune teller! You may type \"Quit\" at any time to quit.\nPlease enter your first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please enter your numerical age:");
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the corresponding number for your birth month:");
            int userBirthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your favorite ROYGBIV color. If you need help here, please type \"Help\" without quotes.");
            string colorAnswer = Console.ReadLine().ToLower();
            string favColor = colorAnswer;

            switch (colorAnswer)
            {
                case "Help":
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
                    favColor = "red";
                    break;
                case "orange":
                    favColor = "orange";
                    break;
                case "yellow":
                    favColor = "yellow";
                    break;
                case "green":
                    favColor = "green";
                    break;
                case "indigo":
                    favColor = "indigo";
                    break;
                case "violet":
                    favColor = "violet";
                    break;
                default:
                    Console.WriteLine("You entered an invalid color.");
                    break;
            }

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

            string vacHome = null;

            if (siblingNum == 0)
            {
                vacHome = "Place1";
            }
            else if (siblingNum == 1)
            {
                vacHome = "Place2";
            }
            else if (siblingNum == 2)
            {
                vacHome = "Place3";
            }
            else if (siblingNum == 3)
            {
                vacHome = "Place4";
            }
            else if (siblingNum > 3)
            {
                vacHome = "Place5";
            }
            else
            {
                vacHome = "Dumpster";
            }

            string rideType = null;
            if (favColor == "red")
            {
                rideType = "ride1";
            }
            else if (favColor == "orange")
            {
                rideType = "ride2";
            }
            else if (favColor == "yellow")
            {
                rideType = "ride3";
            }
            else if (favColor == "green")
            {
                rideType = "ride4";
            }
            else if (favColor == "blue")
            {
                rideType = "ride5";
            }
            else if (favColor == "indigo")
            {
                rideType = "ride6";
            }
            else if (favColor == "violet")
            {
                rideType = "ride7";
            }
            else if (favColor == "Quit")
            {
                rideType = "quit";
            }
            else
            {
                Console.WriteLine("error");
            }
            

        }
    }
}
