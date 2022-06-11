using System.Drawing;
using System.Windows.Forms;
using PaintLikeCore;

namespace WinFormsPaintLike
{
    internal class StartupConfigurationManager
    {
        public PaintLike ConfigurateApplication()
        {
            DrawingPointsArray drawingPointsArray = new DrawingPointsArray(2);

            var drawingManager = new DrawingManager(drawingPointsArray);
            var penOptionsForm = new PenOptionsForm(drawingManager);

            return new PaintLike(drawingManager, penOptionsForm);
        }
    }
}
