using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nix_Homework_1
{
    abstract class Point
    {
        public Point() { }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; private set; }

        public int Y { get; private set; }

        public virtual void Move(int deltaX, int deltaY)
        {
            X += deltaX;
            Y += deltaY;
        }

        public abstract void Scale(int ratio);

        public abstract void Print();
    }
}
