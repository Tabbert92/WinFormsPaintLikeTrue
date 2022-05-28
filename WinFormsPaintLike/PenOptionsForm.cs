using System;
using System.Windows.Forms;
using PaintLikeCore;

namespace WinFormsPaintLike
{
    public partial class PenOptionsForm : Form
    {
        private readonly DrawingManager _drawingManager;
        private float _penWidth;

        public PenOptionsForm(DrawingManager drawingManager)
        {
            InitializeComponent();
            _drawingManager = drawingManager;
            CurrentWidthLabel.Text = _drawingManager.Pen.Width.ToString();
        }

        private void PenLengthNumberTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar is >= '0' and <= '9')
            {
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    var parsResult = PenWidthNumberParser(PenWidthNumberTextBox.Text);
                    if (parsResult != -1)
                    {
                        if (parsResult <= 50)
                        {
                            _penWidth = parsResult;
                            CurrentWidthLabel.Text = parsResult.ToString();
                        }
                        else
                        {
                            _penWidth = 50;
                            CurrentWidthLabel.Text = "50";
                        }
                    }
                }
                return;
            }

            e.Handled = true;
        }

        private void PenLengthTrackBarValueChanged(object sender, EventArgs e)
        {
            CurrentWidthLabel.Text = PenWidthTrackBar.Value.ToString();
            _penWidth = PenWidthTrackBar.Value;
        }

        private float PenWidthNumberParser(string numberForParsing)
        {
            try
            {
                return float.Parse(numberForParsing);
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _drawingManager.Pen.Width = _penWidth;
            this.Hide();
        }
    }
}
