using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nix_Homework_1
{
    class Circle : Point
    {
        public Circle(int x, int y, int radius):base(x,y)
        {
            Radius = radius;
        }

        public int Radius { get; private set; }

        public override void Scale(int ratio)
        {
            Radius *= ratio;
        }

        public override void Print()
        {
            Console.WriteLine($"Hello! I`m Circle! My center point [{X},{Y}], radius = {Radius}");
        }
    }
}
