using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            while (true)
            {
                Console.WriteLine("Please enter a key and a value:");
                dict.Add(Console.ReadLine(), Console.ReadLine());

                Console.WriteLine("Would you like to enter another name? (y/n)");
                if (Console.ReadLine().ToLower() == "n")
                {
                    break;
                }
            }

            foreach (KeyValuePair<string, string> x in dict)
            {
                Console.WriteLine("\n\tKey: " + x.Key + "\tValue: " + x.Value);
            }


        }
    }
}
