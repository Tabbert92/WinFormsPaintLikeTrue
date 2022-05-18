﻿using System.Drawing;
using System.Windows.Forms;
using PaintLikeCore;

namespace WinFormsPaintLike
{
    internal class StartupConfigurationManager
    {
        public PaintLike ConfigurateApplication()
        {
            DrawingPointsArray drawingPointsArray = new DrawingPointsArray(2);

            Rectangle rectangle = Screen.PrimaryScreen.Bounds;
            var bitMap = new Bitmap(rectangle.Width, rectangle.Height);

            var graphics = Graphics.FromImage(bitMap);

            var pen = new Pen(Color.Black, 3f);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            DrawingManager drawingManager = new DrawingManager(drawingPointsArray, bitMap, graphics, pen);

            return new PaintLike(drawingManager);
        }
    }
}
