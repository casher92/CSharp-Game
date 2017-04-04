using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_list_Cont
{
    class Program
    {
        static void Main(string[] args)
        {
            List<UsedCar> usedCars = new List<UsedCar>
            {
                new UsedCar (){VIN = "A1", Make = "Chevy", Model = "Cobalt", Price = 4500, Year = 2006},
                new UsedCar (){VIN = "C1", Make = "Chevy", Model = "HHR", Price = 4000, Year = 2007},
                new UsedCar (){VIN = "B1", Make = "Ford", Model = "F150", Price = 6000, Year = 2004},
                new UsedCar (){VIN = "D1", Make = "Ford", Model = "Fiesta", Price = 8000, Year = 2012},
                new UsedCar (){VIN = "E1", Make = "Toyota", Model = "Camry", Price = 5000, Year = 2013},
                new UsedCar (){VIN = "F1", Make = "Toyota", Model = "4Runner", Price = 5500, Year = 2000},
                new UsedCar (){VIN = "G1", Make = "BMW", Model = "55I", Price = 9500, Year = 2005},
                new UsedCar (){VIN = "A1", Make = "BMW", Model = "55I", Price = 4500, Year = 1995}
            };

            var bmws = from car in usedCars
                       where car.Make == "BMW"
                       select car;
            foreach(var bmw in bmws)
            {
                Console.WriteLine("The {0} {1} is a nice used car that cost: {2:C}", bmw.Year, bmw.Model, bmw.Price);
            }
         
            Console.WriteLine("----------");

            var Cheapcars = from car in usedCars
                       where car.Price < 10000 && car.Price > 5000
                       select car;
            foreach (var Cheapcar in Cheapcars)
            {
                Console.WriteLine("The {0} {1} is a nice used car that cost: {2:C}", Cheapcar.Year, Cheapcar.Model, Cheapcar.Price);
            }

            Console.WriteLine("");
           
            var toyotas = usedCars.Where(car => car.Make == "Toyota");
            foreach(var toyota in toyotas)
            {
                Console.WriteLine(toyota.Model);
            }

            var niceUsedCars = usedCars.Where(car => car.Price > 7500 && car.Make == "Ford" || car.Make == "BMW");
            foreach(var niceUsedCar in niceUsedCars)
            {
                Console.WriteLine(niceUsedCar.Model + " " + niceUsedCar.VIN);
            }

            Console.WriteLine("Choose a price you do not want to go over");
            int userInput = Int32.Parse(Console.ReadLine());

            var userCar = usedCars.Where(car => car.Price <= userInput);
            foreach(var car in userCar)
            {
                Console.WriteLine("These cars are at or under your requested price: {0:C}, {1}, {2}, {3}, userInput, car.Year, car.Make, car.Model");
            }

            Console.ReadLine();


        }
    }
    class UsedCar
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
    }
}
