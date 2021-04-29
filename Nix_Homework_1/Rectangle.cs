using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nix_Homework_1
{
    class Rectangle : Point
    {
        public Rectangle(int x,int y,int width,int height) : base(x,y)
        {
            Width  = width;
            Height = height;
        }
        public int Width { get; private set; }

        public int Height { get; private set; }

        public override void Scale(int ratio)
        {
            Width  *= ratio;
            Height *= ratio;
        }

        public override void Print()
        {
            Console.WriteLine($"Hello! I`m rectangle! My width = {Width}, height = {Height}." +
                $" My points [{X},{Y}],[{X+Width},{Y}],[{X+Width},{Y-Height}],[{X},{Y-Height}]");
        }

    }
}
