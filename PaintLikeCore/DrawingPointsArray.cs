using System;
using System.Drawing;

namespace PaintLikeCore
{
    public class DrawingPointsArray
    {
        public int Index { get; set; }
        public Point[] Points { get; }

        public DrawingPointsArray(int size)
        {
            Points = new Point[size];
        }

        public void SetPoint(int x, int y)
        {
            if (Index >= Points.Length)
            {
                Index = 0;
            }
            Points[Index] = new Point(x, y);
            Index++;
        }
    }
}
