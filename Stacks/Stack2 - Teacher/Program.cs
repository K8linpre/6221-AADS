using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack2___Teacher
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s1 = new Stack();
            Console.Write("How many numbers would you like to enter?");
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                for (int i = 0; i < result; i++)
                {
                    Console.WriteLine($"Please enter a number {i+1}:");
                    s1.Push(int.Parse(Console.ReadLine()));

                }
            }

            int counter = s1.Count;

            Console.WriteLine($"List of Numbers:");
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine(s1.Pop());
            }
        }
    }
}
