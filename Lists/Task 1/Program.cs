using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web.Script.Serialization;
using System.Diagnostics;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch st = new Stopwatch();
            st.Start();

            string json = new WebClient().DownloadString("https://uinames.com/api/?ext&amount=2");
            List<CustomObject> data = new JavaScriptSerializer().Deserialize<List<CustomObject>>(json);

            st.Stop();
            foreach (CustomObject x in data)
            {
                Console.WriteLine("Name: {0}\nSurname: {1}\nGender: {2}\nRegion: {3}\nAge: {4}\nTitle: {5}\nPhone: {6}\nBirthday:\ndmy: {7}\nmdy: {8}\nraw: {9}\nEmail: {10}\nPassword: {11}\nCredit Card:\nExpiration: {12}\nNumber: {13}\nPin: {14}\nSecurity: {15}\nPhoto: {16}\n", x.name, x.surname, x.gender, x.region, x.age, x.title, x.phone, x.birthday.dmy, x.birthday.mdy, x.birthday.raw, x.email, x.password, x.credit_card.expiration, x.credit_card.number, x.credit_card.pin, x.credit_card.security, x.photo);
            }

            foreach (CustomObject x in data)
            {
                Console.WriteLine("Name: {0} {1}\n****Credit Card****\nNumber: {2}\nPin: {3}\nSecurity: {4}\nExpiration: {5}\n", x.name, x.surname, x.credit_card.number, x.credit_card.pin, x.credit_card.security, x.credit_card.expiration);
            }

            Console.WriteLine("Time to populate list: {0}ms\n", st.ElapsedMilliseconds);
        }
    }

    class CustomObject
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string gender { get; set; }
        public string region { get; set; }
        public int age { get; set; }
        public string title { get; set; }
        public string phone { get; set; }
        public Birthday birthday { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public Credit credit_card { get; set; }

        public string photo { get; set; }
    }
    class Birthday
    {
        public string dmy { get; set; }
        public string mdy { get; set; }
        public int raw { get; set; }
    }

    class Credit
    {
        public string expiration { get; set; }
        public string number { get; set; }
        public string pin { get; set; }
        public string security { get; set; }
    }
}
