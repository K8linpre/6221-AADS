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
            Queue q2 = new Queue(q1);

            //for (int i = 0; i < counter; i++)
            //{
            //    Console.WriteLine(q1.Dequeue());
            //}


            Console.Write("What name would you like to check?");
            string name = Console.ReadLine();
            if (q2.Contains(name))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{name} was found in the queue...");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{name} was not found in the queue...");
                Console.ForegroundColor = ConsoleColor.White;
            }

            List<string> ordered = new List<string>();
            foreach(object x in q1)
            {
                ordered.Add(x.ToString());
            }

            ordered.Sort();
            q2.Clear();
            foreach(string x in ordered)
            {
                q2.Enqueue(x);
            }

            for (int i = 0; i < q1.Count; i++)
            {
                Console.Write($"{q2.Dequeue()} ");
            }


        }
    }
}
