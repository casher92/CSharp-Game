using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._18_kenns_challenge
{
    class RegularPolygon
    {
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        public RegularPolygon(int sides, int length)
        {
            this.NumberOfSides = sides;
            this.SideLength = length;
        }

        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
            
        }

        public virtual double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
