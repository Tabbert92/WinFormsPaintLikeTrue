using System.Collections.Generic;
using System.Drawing;

namespace PaintLikeCore
{
    public class DrawingManager
    {
        private Graphics _graphics;
        private Bitmap _bitMap;
        private Point _startLinePoint;
        
        public Pen Pen { get;}
        public Color FillColor { get; set; } = Color.Aqua;

        public DrawingManager()
        {
            Pen = new Pen(Color.Black, 3f);
            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        public void CreateBitmap (int width, int heigth)
        {
            _bitMap = new Bitmap(width, heigth);
            _graphics = Graphics.FromImage(_bitMap);
        }

        public void SetStartDrawingPoint(Point StartPoint)
        {
            _startLinePoint = StartPoint;
        }

        public void SetColor(Color color)
        {
            FillColor = color;
            Pen.Color = color;
        }

        public Bitmap DrawLine(Point drawPoint)
        {
            _graphics.DrawLine(Pen, _startLinePoint, drawPoint);
            _startLinePoint = drawPoint;

            return _bitMap;
        }

        public Bitmap Clear(Color color)
        {
            _graphics.Clear(color);
            return _bitMap;
        }

        public Bitmap LoadBitmap(Bitmap loadedBitmap)
        {
            _bitMap = loadedBitmap;
            _graphics = Graphics.FromImage(_bitMap);
            return _bitMap;
        }

        public Bitmap Fill (Point point)
        {
            var oldColor = _bitMap.GetPixel(point.X, point.Y);
            var points = new Stack<Point>();
            points.Push(point);
            _bitMap.SetPixel(point.X, point.Y, FillColor);
            if (oldColor == FillColor) return _bitMap;
            
            while (points.Count > 0)
            {
                Point pt = points.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < _bitMap.Width-1 && pt.Y < _bitMap.Height -1)
                {
                    Validate(_bitMap, points, pt.X - 1, pt.Y, oldColor, FillColor);
                    Validate(_bitMap, points, pt.X, pt.Y - 1, oldColor, FillColor);
                    Validate(_bitMap, points, pt.X + 1, pt.Y, oldColor, FillColor);
                    Validate(_bitMap, points, pt.X, pt.Y + 1, oldColor, FillColor);
                }
            }
            return _bitMap;
        }

        private void Validate(Bitmap bitmap, Stack<Point> points, int x, int y, Color oldColor, Color newColor)
        {
            Color currentColor = bitmap.GetPixel(x, y);
            if (currentColor == oldColor)
            {
                points.Push(new Point(x,y));
                bitmap.SetPixel(x,y,newColor);
            }
        }

    }
}
