using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PaintLikeCore;

namespace WinFormsPaintLike
{
    public partial class PaintLike : Form
    {
        private bool isMouseBottonDown = false;
        private DrawingPointsArray drawingPointArray;
        private Bitmap bitmap;
        private Graphics graphics;
        private Pen pen;
        public PaintLike(DrawingPointsArray drawingPointArray, Bitmap bitmap, Graphics graphics, Pen pen)
        {
            InitializeComponent();
            this.drawingPointArray = drawingPointArray;
            this.bitmap = bitmap;
            this.graphics = graphics;
            this.pen = pen;
        }
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseBottonDown = true;
        }
        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseBottonDown = false;
            drawingPointArray.RestPointIndex();
        }
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMouseBottonDown) return;
            else
            {
                drawingPointArray.SetPoint(e.X,e.Y);
                if (drawingPointArray.GetPointIndex() >= 2)
                {
                    graphics.DrawLines(pen, drawingPointArray.GetPoints());
                    pictureBox.Image = bitmap;
                    drawingPointArray.SetPoint(e.X,e.Y);
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            graphics.Clear(pictureBox.BackColor);
            pictureBox.Image = bitmap;
        }
    }
}
