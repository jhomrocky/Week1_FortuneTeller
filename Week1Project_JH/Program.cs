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






        }
    }
}
