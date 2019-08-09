using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack words = new Stack();

            Console.WriteLine("Please enter a string:");
            char[] sentence = Console.ReadLine().ToCharArray();

            foreach(char x in sentence)
            {
                words.Push(x);
            }

            int end = words.Count;
            for(int i = 0; i < end; i++)
            {
                Console.Write(words.Pop());

            }
            Console.WriteLine();

        }
    }
}
