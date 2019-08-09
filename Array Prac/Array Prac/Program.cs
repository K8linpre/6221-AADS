using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Prac
{
    class Program
    {
        public static void Main()
        {
            Random rand = new Random();

            Double[] num = new Double[10];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = rand.NextDouble() * 10;
                Console.Write("{0,0:N4}\t", num[i]);
                Print(i);
            }



            Console.WriteLine("\nCopy of Array \n");
            Double[] newNum = new Double[10];
            Array.Copy(num, newNum, num.Length);


            var Greater = from number in newNum
                        where (number > 2)
                        select number;

            foreach (Double x in Greater)
            {
                Console.Write("{0,0:N4}\t ", x);
            }


            Console.ReadLine();
        }
        static void Print(int i)
        {
            int rowCount = 10;
            if ((i + 1) % rowCount == 0)
                Console.WriteLine();                

        }
    }

}
