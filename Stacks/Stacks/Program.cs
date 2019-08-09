using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack s1 = new Stack();

            Console.WriteLine("Please enter 10 numbers:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Number {i}:");
                s1.Push(double.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Please enter a number to search for:");
            double input = double.Parse(Console.ReadLine());

            if (s1.Contains(input))
            {
                int counter = s1.Count;
                for (int i = 0; i < counter; i++)
                {
                    if (double.Parse(s1.Peek().ToString()) != input)
                    {
                        Console.WriteLine("LIFO: " + s1.Peek() + "\nCount: " + s1.Count);
                        s1.Pop();
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine($"{input} wasn't found in the collection...");
            }

            foreach(object x in s1)
            {
                Console.WriteLine(x);
            }
        }
    }
}
