using System.Drawing;
using System.Dynamic;
using System.Windows.Forms;

namespace PaintLikeCore
{
    public class DrawingManager
    {
        private readonly DrawingPointsArray _drawingPointArray;
        private Graphics _graphics;
        private Bitmap _bitMap;

        public Pen Pen { get; }

        public DrawingManager(DrawingPointsArray drawingPointArray)
        {
            _drawingPointArray = drawingPointArray;

            Rectangle rectangle = Screen.PrimaryScreen.Bounds;
            _bitMap = new Bitmap(rectangle.Width, rectangle.Height);
            _graphics = Graphics.FromImage(_bitMap);

            Pen = new Pen(Color.Black, 3f);
            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        public Bitmap StartDrawingLine(int x, int y)
        {
            _drawingPointArray.SetPoint(x, y);
            if (_drawingPointArray.Index >= 2)
            {
                _graphics.DrawLines(Pen, _drawingPointArray.Points);
                _drawingPointArray.SetPoint(x, y);
            }

            return _bitMap;
        }

        public void StopDrawingLine()
        {
            _drawingPointArray.Index = 0;
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
    }
}
