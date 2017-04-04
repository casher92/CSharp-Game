using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>
            {
                "James", "Paul", "Kenn", "Jenn", "TheSherrif"
            };
            /*
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
            names.Add("Craig");
            Console.WriteLine("------------");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            names.Remove("Craig");
            Console.WriteLine("------------");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            */
            Console.WriteLine("Lambda expressions with .ForEach");
            names.ForEach(name => Console.WriteLine(name)); // Remember this line
            Console.ReadLine();
        }
    }
}
