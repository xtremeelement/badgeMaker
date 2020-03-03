using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> employees = new List<string>();



            while (true)
            {
                Console.WriteLine("Please enter a name:\n");
                string input = Console.ReadLine();

                if (input == "")
                {
                    break;
                }

                employees.Add(input);
            }



            foreach (string employee in employees)
            {
                Console.WriteLine(employee);
            }


        }
    }
}
