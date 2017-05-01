using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._18_kenns_challenge
{
   public interface IRegularPolygon
    {
        int NumberOfSides { get; set; }
        int SideLength { get; set; }


        double GetPerimeter();

        double GetArea();


    }
}
