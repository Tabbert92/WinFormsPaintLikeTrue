using System.Drawing;

namespace PaintLikeCore
{
    public class DrawingManager
    {
        private readonly DrawingPointsArray _drawingPointArray;
        private readonly Bitmap _bitmap;
        private readonly Graphics _graphics;
        private readonly Pen _pen;

        public DrawingManager(DrawingPointsArray drawingPointArray, Bitmap bitmap, Graphics graphics, Pen pen)
        {
            _drawingPointArray = drawingPointArray;
            _bitmap = bitmap;
            _graphics = graphics;
            _pen = pen;
        }

        public Bitmap StartDrawingLine(int x, int y)
        {
            _drawingPointArray.SetPoint(x, y);
            if (_drawingPointArray.Index >= 2)
            {
                _graphics.DrawLines(_pen, _drawingPointArray.Points);
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

        public void ChangePenColor(Color color)
        {
            _pen.Color = color;
        }
    }
}
