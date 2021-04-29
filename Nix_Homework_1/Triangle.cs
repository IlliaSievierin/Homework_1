using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nix_Homework_1
{
    class Triangle : Rectangle
    {
        public Triangle(int x, int y, int deltaX2, int deltaY2, int deltaX3,int deltaY3) : base(x,y,deltaX2,deltaY2)
        {
            DeltaX3 = deltaX3;
            DeltaY3 = deltaY3;
        }

        public int DeltaX3 { get; private set; }

        public int DeltaY3 { get; private set; }

        public override void Scale(int ratio)
        {
            base.Scale(ratio);
            DeltaX3 *= ratio;
            DeltaY3 *= ratio;
        }
        public override void Print()
        {
            Console.WriteLine($"Hello! I`m Triangle! My points [{X},{Y}], [{X+Width},{Y+Height}], [{X+DeltaX3},{Y+DeltaY3}]");
        }

    }
}
