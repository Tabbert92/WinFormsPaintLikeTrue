namespace WinFormsPaintLike
{
    partial class PenOptionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(int minPenWidht, int maxPenWidht)
        {
            this.PenWidthTrackBar = new System.Windows.Forms.TrackBar();
            this.ApplyBotton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PenWidthNumberTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PenWidthTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // PenWidthTrackBar
            // 
            this.PenWidthTrackBar.Location = new System.Drawing.Point(12, 61);
            this.PenWidthTrackBar.Maximum = maxPenWidht;
            this.PenWidthTrackBar.Minimum = minPenWidht;
            this.PenWidthTrackBar.Name = "PenWidthTrackBar";
            this.PenWidthTrackBar.Size = new System.Drawing.Size(194, 45);
            this.PenWidthTrackBar.TabIndex = 0;
            this.PenWidthTrackBar.Value = 1;
            this.PenWidthTrackBar.ValueChanged += new System.EventHandler(this.PenLengthTrackBarValueChanged);
            // 
            // ApplyBotton
            // 
            this.ApplyBotton.Location = new System.Drawing.Point(54, 112);
            this.ApplyBotton.Name = "ApplyBotton";
            this.ApplyBotton.Size = new System.Drawing.Size(106, 34);
            this.ApplyBotton.TabIndex = 1;
            this.ApplyBotton.Text = "Аpply";
            this.ApplyBotton.UseVisualStyleBackColor = true;
            this.ApplyBotton.Click += new System.EventHandler(this.ApplyBottonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "CurrentLWidth";
            // 
            // PenWidthNumberTextBox
            // 
            this.PenWidthNumberTextBox.Location = new System.Drawing.Point(140, 19);
            this.PenWidthNumberTextBox.Name = "PenWidthNumberTextBox";
            this.PenWidthNumberTextBox.Size = new System.Drawing.Size(57, 23);
            this.PenWidthNumberTextBox.TabIndex = 4;
            this.PenWidthNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PenLengthNumberTextBoxKeyPress);
            // 
            // PenOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 158);
            this.Controls.Add(this.PenWidthNumberTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ApplyBotton);
            this.Controls.Add(this.PenWidthTrackBar);
            this.Name = "PenOptionsForm";
            this.Text = "_pen length";
            ((System.ComponentModel.ISupportInitialize)(this.PenWidthTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar PenWidthTrackBar;
        private System.Windows.Forms.Button ApplyBotton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PenWidthNumberTextBox;
    }
}