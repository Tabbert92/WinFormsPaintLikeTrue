using System;
using System.Windows.Forms;
using PaintLikeCore;

namespace WinFormsPaintLike
{
    public partial class PaintLike : Form
    {
        private bool _isMouseBottonDown;
        private readonly DrawingManager _drawingManager;
        public PaintLike(DrawingManager drawingManager)
        {
            InitializeComponent();
            _drawingManager = drawingManager;
        }
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            _isMouseBottonDown = true;
        }
        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            _isMouseBottonDown = false;
            _drawingManager.StopDrawingLine();
        }
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isMouseBottonDown)
                pictureBox.Image = _drawingManager.StartDrawingLine(e.X, e.Y);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = _drawingManager.Clear(pictureBox.BackColor);
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _drawingManager.ChangePenColor(colorDialog.Color);
                ShowColorBotton.BackColor = colorDialog.Color;
            }
        }
    }
}
