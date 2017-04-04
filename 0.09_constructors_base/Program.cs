using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_constructors_base
{
    class Program
    {
        static void Main(string[] args)
        {

            Person Chris = new Person("Chris", "Sullivan");
            Chris.TestMethod();
            

            Minor Sophie = new Minor("Sophia", "O'Connor", true, 5);
            Sophie.DemoMethod();
            Sophie.TestMethod();


            Person Kenn = new Minor("Kenn", "Pascascio", true, 17);
            Kenn.TestMethod();


        }
    }
}
