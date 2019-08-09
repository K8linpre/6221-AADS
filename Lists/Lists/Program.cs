using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web.Script.Serialization;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string json = new WebClient().DownloadString("https://uinames.com/api/?amount=2");
            List<CustomObject> data = new JavaScriptSerializer().Deserialize<List<CustomObject>>(json);

            foreach (CustomObject x in data)
            {
                Console.WriteLine("Name {0} {1}\nGender: {2}\nRegion: {3}\n", x.name, x.surname, x.gender, x.region);
            }
        }
    }

    class CustomObject
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string gender { get; set; }
        public string region { get; set; }
    }
}
