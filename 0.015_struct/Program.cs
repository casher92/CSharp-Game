using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._015_struct
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookEntry Paul = new AddressBookEntry()
            {
                Adress = "123 Coder Pl",
                City = "WestField",
                State = "IN",
                Zipcode = "44056",
                FirstName = "Paul",
                LastName = "O'Connor",
                Age = "40",
            };
            
            AddressBookEntry Craig = new AddressBookEntry()
            {
                Adress = "303 E King",
                City = "Franklin",
                State = "IN",
                Zipcode = "46131",

            };

            AddressBookEntry Zack = new AddressBookEntry()
            {
                Adress = "1234 Main Blvd",
                City = "Greenwood",
                State = "IN",
                Zipcode = ("46262"),

            }; 
            Console.WriteLine(Paul.GetAddress());
            Console.WriteLine("");
            Console.WriteLine(Craig.GetAddress());
            Console.WriteLine("");
            Console.WriteLine(Zack.GetAddress());
            Console.ReadLine();
            
        }
        struct AddressBookEntry
        {
            public string FirstName;
            public string LastName;
            public string Age;
            public string Adress;
            public string City;
            public string State;
            public string Zipcode;

            public AddressBookEntry(string first, string last, string age)
            {
                public int age { get; set; }
            
        {
           

            public string GetAddress()
            {
                return $"Address:{Adress}\nCity:{City}\nState:{State}\nZipcode:{Zipcode}";
            }
        }
    }
}
