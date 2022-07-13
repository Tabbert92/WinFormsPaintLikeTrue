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
        private int _toolIndex = 1;
        public PaintLike(DrawingManager drawingManager, PenOptionsForm penOptionsForm)
        {
            InitializeComponent();
            _drawingManager = drawingManager;
            _drawingManager.CreateBitmap(pictureBox.Width, pictureBox.Height);

            _penOptionsForm = penOptionsForm;
            ShowColorBotton.BackColor = _drawingManager.Pen.Color;
            PenWidthLabel.Text = _drawingManager.Pen.Width.ToString();
        }

        private void PictureBoxMouseDown(object sender, MouseEventArgs e)
        {
            if (_toolIndex == 1)
            {
                _isMouseBottonDown = true;
                _drawingManager.SetStartDrawingPoint(e.Location);

            }

            if (_toolIndex == 2)
            {
                pictureBox.Image = _drawingManager.Fill(e.Location);
            }
            
        }

        private void PictureBoxMouseUp(object sender, MouseEventArgs e)
        {
            _isMouseBottonDown = false;
        }

        private void PictureBoxMouseMove(object sender, MouseEventArgs e)
        {
            if (_isMouseBottonDown)
                pictureBox.Image = _drawingManager.DrawLine(e.Location);
        }

        private void ClearButtonClick(object sender, EventArgs e)
        {
            pictureBox.Image = _drawingManager.Clear(pictureBox.BackColor);
        }

        private void ColorButtonClick(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _drawingManager.SetColor(colorDialog.Color);
                ShowColorBotton.BackColor = colorDialog.Color;
            }
        }

        private void WidthButtonClick(object sender, EventArgs e)
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

        private void FillButtonClick(object sender, EventArgs e)
        {
            _toolIndex = 2;
        }

        private void PenButtonClick(object sender, EventArgs e)
        {
            _toolIndex = 1;
        }
    }
}
