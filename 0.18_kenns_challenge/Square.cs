using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._18_kenns_challenge
{
    class Square : RegularPolygon
    {
        public Square(int length) : base(4, length) { }

        public override double GetArea()
        {
            return SideLength * SideLength;
        }

    }
}
