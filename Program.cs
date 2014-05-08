using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  homework5_ver3.Animals;

namespace ConsoleApplication1
{
    class Program
    {
        static string DisplayMenu()
        {
            Console.WriteLine("================");
            Console.WriteLine("Zoo Meal Planner");
            Console.WriteLine("================");
            Console.WriteLine("What kind of animal?");
            Console.WriteLine("1. Monkey");
            Console.WriteLine("2. Bear");
            Console.WriteLine("3. Quit");
            Console.Write("Selection:      ");
            string response = Console.ReadLine();
            Console.WriteLine("");

            return response;
        }

        static void ShowMenu()
        {
            bool response = false;
            string userSelection = DisplayMenu();
            while (!response)
            {
                if (userSelection == "1")
                {
                    // GET type of Monkey
                    Monkey monkey = new Monkey();
                    monkey.GetMonkeyType();
                    ShowMenu(); 
                    response = true;
                }
                else if (userSelection == "2")
                {
                    Bear bear = new Bear();
                    bear.GetBearType();
                    ShowMenu(); 
                    response = true;
                }
                else if (userSelection == "3")
                {
                    response = true;
                    Console.WriteLine("Thank you your program has ended"); 
                }
                else {
                    response = true;
                    Console.WriteLine("invalid entry ");
                    ShowMenu();
                }

            }
        }
        static void Main(string[] args)
        {
            ShowMenu();
            Console.ReadLine();
            
        }
    }
}
