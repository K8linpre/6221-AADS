using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack numbers = new Stack();

            while (true){

                Console.WriteLine("Please enter a number:");
                numbers.Push(int.Parse(Console.ReadLine()));

                Console.WriteLine("Would you like to enter another number? (y/n)");
                if (Console.ReadLine().ToLower() == "n")
                {
                    break;
                }
            }

            int counter = numbers.Count;

            Console.WriteLine($"List of Numbers:");
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine(numbers.Pop());
            }

        }
    }
}
