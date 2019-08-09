using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q1 = new Queue();

            //Console.WriteLine("Please enter five names:");
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine($"Name No.{i}:");
            //    q1.Enqueue(Console.ReadLine());
            //}

            while (true)
            {
                Console.WriteLine("Please enter a name:");
                q1.Enqueue(Console.ReadLine());

                Console.WriteLine("Would you like to enter another name? (y/n)");
                if (Console.ReadLine().ToLower() == "n")
                {
                    break;
                }
            }

            int counter = q1.Count;

            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine("FIFO: " + q1.Dequeue() + "\nCount: " + q1.Count);
            }

        }
    }
}
