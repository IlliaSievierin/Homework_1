using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nix_Homework_1
{
    class Picture : Point
    {
        public Picture()
        {
            points = new Point[10];
        }

        private Point[] points;

        public int Count { get; private set; }

        public void Add(Point figure)
        {
            if(Count == points.Length)
            {
                Array.Resize(ref points, points.Length + 10);
            }
            points[Count] = figure;
            Count++;
        }

        public override void Scale(int ratio)
        {
            for (int i = 0; i < Count; i++)
            {
                points[i].Scale(ratio);
            }
        }

        public override void Print()
        {
            for(int i = 0; i < Count; i++)
            {
                points[i].Print();
            }
        }

        public override void Move(int deltaX, int deltaY)
        {
            for (int i = 0; i < Count; i++)
            {
                points[i].Move(deltaX, deltaY);
            }
        }


    }
}
