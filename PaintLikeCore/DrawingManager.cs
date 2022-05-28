using System.Drawing;
using System.Dynamic;

namespace PaintLikeCore
{
    public class DrawingManager
    {
        private readonly DrawingPointsArray _drawingPointArray;
        private readonly Bitmap _bitmap;
        private readonly Graphics _graphics;

        public Pen Pen { get; }

        public DrawingManager(DrawingPointsArray drawingPointArray, Bitmap bitmap, Graphics graphics, Pen pen)
        {
            _drawingPointArray = drawingPointArray;
            _bitmap = bitmap;
            _graphics = graphics;
            Pen = pen;
        }

        public Bitmap StartDrawingLine(int x, int y)
        {
            _drawingPointArray.SetPoint(x, y);
            if (_drawingPointArray.Index >= 2)
            {
                _graphics.DrawLines(Pen, _drawingPointArray.Points);
                _drawingPointArray.SetPoint(x, y);
            }

            return _bitmap;
        }

        public void StopDrawingLine()
        {
            _drawingPointArray.Index = 0;
        }
        public Bitmap Clear(Color color)
        {
            _graphics.Clear(color);
            return _bitmap;
        }
    }
}
