using System;
using System.Windows.Forms;
using PaintLikeCore;

namespace WinFormsPaintLike
{
    public partial class PenOptionsForm : Form
    {
        private readonly DrawingManager _drawingManager;
        private float _penWidth;
        private const int MinPenWidht = 1;
        private const int MaxPenWidht = 50;
        public PenOptionsForm(DrawingManager drawingManager)
        {
            InitializeComponent(MinPenWidht, MaxPenWidht);
            _drawingManager = drawingManager;
            PenWidthNumberTextBox.Text = _drawingManager.Pen.Width.ToString();
        }

        private void PenLengthNumberTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (float.TryParse(PenWidthNumberTextBox.Text, out var parsResult))
                    {
                        if (parsResult < MinPenWidht)
                        {
                            _penWidth = MinPenWidht;
                            PenWidthNumberTextBox.Text = MinPenWidht.ToString();
                        }
                        else if (parsResult > MaxPenWidht)
                        {
                            _penWidth = MaxPenWidht;
                            PenWidthNumberTextBox.Text = MaxPenWidht.ToString();
                        }
                        else
                        {
                            _penWidth = parsResult;
                            PenWidthNumberTextBox.Text = parsResult.ToString();
                        }
                    }
                }
                return;
            }
            e.Handled = true;
        }

        private void PenLengthTrackBarValueChanged(object sender, EventArgs e)
        {
            PenWidthNumberTextBox.Text = PenWidthTrackBar.Value.ToString();
            _penWidth = PenWidthTrackBar.Value;
        }
        private void ApplyBottonClick(object sender, EventArgs e)
        {
            _drawingManager.Pen.Width = _penWidth;
            this.Hide();
        }
    }
}
