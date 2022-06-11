using System;
using System.Drawing;
using System.Windows.Forms;
using PaintLikeCore;

namespace WinFormsPaintLike
{
    public partial class PaintLike : Form
    {
        private bool _isMouseBottonDown;
        private readonly DrawingManager _drawingManager;
        private readonly PenOptionsForm _penOptionsForm;
        public PaintLike(DrawingManager drawingManager, PenOptionsForm penOptionsForm)
        {
            InitializeComponent();
            _drawingManager = drawingManager;
            _penOptionsForm = penOptionsForm;
            ShowColorBotton.BackColor = _drawingManager.Pen.Color;
            PenWidthLabel.Text = _drawingManager.Pen.Width.ToString();
        }

        private void PictureBoxMouseDown(object sender, MouseEventArgs e)
        {
            _isMouseBottonDown = true;
        }

        private void PictureBoxMouseUp(object sender, MouseEventArgs e)
        {
            _isMouseBottonDown = false;
            _drawingManager.StopDrawingLine();
        }

        private void PictureBoxMouseMove(object sender, MouseEventArgs e)
        {
            if (_isMouseBottonDown)
                pictureBox.Image = _drawingManager.StartDrawingLine(e.X, e.Y);
        }

        private void ClearButtonClick(object sender, EventArgs e)
        {
            pictureBox.Image = _drawingManager.Clear(pictureBox.BackColor);
        }

        private void ColorButtonClick(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _drawingManager.Pen.Color = colorDialog.Color;
                ShowColorBotton.BackColor = colorDialog.Color;
            }
        }

        private void PenButtonClick(object sender, EventArgs e)
        {
            _penOptionsForm.ShowDialog();
            PenWidthLabel.Text = _drawingManager.Pen.Width.ToString();
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "JPG(*.JPG)|*.jpg";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image.Save(saveFileDialog.FileName);
            }
        }

        private void LoadButtonClick(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image files(*.BMP;*.JPG;*.PNG)|*.bmp;*.jpg;*.png|All files (*.*)|*.*";
            if(openFileDialog.ShowDialog()== DialogResult.OK)
            {
                try
                {
                    var loadedBitMap = new Bitmap(openFileDialog.FileName);
                    pictureBox.Image = _drawingManager.LoadBitmap(loadedBitMap);
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
        }
    }
}
