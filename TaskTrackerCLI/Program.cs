using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTrackerCLI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            int input = 0;

            do
            {
                Console.WriteLine("Main Menu:" +
                "\n1: Add task" +
                "\n2: View tasks" +
                "\n3: Delete a task" +
                "\n4: Exit");
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error)
                {
                    Console.Clear();
                    Console.WriteLine($"Invalid input. {error.Message}" +
                        $"\nPlease try again.");
                }
            } while (input < 1 || input > 4);

            switch (input)
            {
                case 1: break;
                case 2: break;
                case 3: break;
                case 4: Environment.Exit(0); break;
            }
        }
    }
}