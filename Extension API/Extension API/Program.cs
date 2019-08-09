using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web.Script.Serialization;

namespace Extension_API
{
    class Program
    {
        static void Main(string[] args)
        {
            string female = new WebClient().DownloadString("https://uinames.com/api/?gender=female&amount=10");
            List<CustomObject> femaledata = new JavaScriptSerializer().Deserialize<List<CustomObject>>(female);

            string male = new WebClient().DownloadString("https://uinames.com/api/?gender=male&amount=10");
            List<CustomObject> maledata = new JavaScriptSerializer().Deserialize<List<CustomObject>>(male);

            Console.WriteLine("-------Female Data----------\n");
            foreach (CustomObject x in femaledata)
            {
                Console.WriteLine($"{x.surname}, {x.name}");
            }

            Console.WriteLine("\n-------Male Data----------\n");
            foreach (CustomObject x in maledata)
            {
                Console.WriteLine($"{x.surname}, {x.name}");
            }

        }

        class CustomObject
        {
            public string surname { get; set; }
            public string name { get; set; }
        }
    }
}
