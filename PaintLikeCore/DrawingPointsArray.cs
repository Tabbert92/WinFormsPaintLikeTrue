using System;
using System.Drawing;

namespace PaintLikeCore
{
    public class DrawingPointsArray
    {
        private int _index;
        private Point[] _points;

        public DrawingPointsArray(int size)
        {
            _points = new Point[size];
        }

        public void SetPoint(int x, int y)
        {
            if (_index >= _points.Length)
            {
                _index = 0;
            }
            _points[_index] = new Point(x, y);
            _index++;
        }

        public void RestPointIndex()
        {
            _index = 0;
        }

        public int GetPointIndex()
        {
            return _index;
        }

        public Point[] GetPoints()
        {
            return _points;
        }
    }
}
