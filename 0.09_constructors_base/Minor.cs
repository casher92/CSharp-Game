using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_constructors_base
{
    class Minor : Person
    {
        public Minor(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {

        }

        public Minor(string firstName, string lastName, bool IsInSchool, int age) : base(firstName, lastName, age)
        {
                
        }

        public bool IsInSchool { get; set; }


        public void DemoMethod()
        {
            Console.WriteLine("Demo method for minor class");
        }
    }
}
