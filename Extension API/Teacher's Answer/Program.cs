using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web.Script.Serialization;

namespace Teacher_s_Answer
{
    class Program
    {
        static void Main(string[] args)
        {
            string json = new WebClient().DownloadString("https://uinames.com/api/?amount=20");
            List<CustomObject> data = new JavaScriptSerializer().Deserialize<List<CustomObject>>(json);

            List<string> femaleData = new List<string>();
            List<string> maleData = new List<string>();

            Console.WriteLine("-----List of All Names------\n");
            foreach (CustomObject x in data)
            {
                if (x.gender == "female")
                {
                    femaleData.Add($"{x.surname} {x.name}");
                    Console.WriteLine($"Female : {x.surname}, {x.name}");
                }
                else
                {
                    maleData.Add($"{x.surname} {x.name}");
                    Console.WriteLine($"Male : {x.surname}, {x.name}");
                }

            }


            string[] mensNames = new string[maleData.Count];
            maleData.CopyTo(mensNames);
            Array.Sort(mensNames);
            Console.WriteLine("\n-----Sorted Male Names------\n");
            foreach (string x in mensNames){
                Console.WriteLine($"Male : {x}");
            }

            femaleData.Sort();
            Console.WriteLine($"\n------Sorted Female Names-----\n");
            foreach (string x in femaleData)
            {
                Console.WriteLine($"Female : {x}");
            }

            Console.WriteLine($"\n------Male Ages-----\n");

            List<int> maleAges = new List<int>();
            foreach (CustomObject x in data)
            {
                Console.WriteLine(x.age);
                if (maleData.Contains($"{x.surname} {x.name}"))
                {
                    maleAges.Add(x.age);
                    //Console.WriteLine(x.age);
                }
            }
            //maleAges.Sort();
            //foreach (int x in maleAges)
            //{
            //    Console.WriteLine(x);
            //    Console.WriteLine($"{maleAges.Sum() / maleAges.Count}");
            //}


        }

        class CustomObject
        {
            public string surname { get; set; }
            public string name { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
        }
    }
}
