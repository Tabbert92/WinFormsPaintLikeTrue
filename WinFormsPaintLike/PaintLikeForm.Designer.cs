namespace WinFormsPaintLike
{
    partial class PaintLike
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.penButton = new System.Windows.Forms.Button();
            this.colorButton = new System.Windows.Forms.Button();
            this.toolsPanel = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.toolsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox.Location = new System.Drawing.Point(0, 71);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1210, 707);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // penButton
            // 
            this.penButton.Location = new System.Drawing.Point(12, 12);
            this.penButton.Name = "penButton";
            this.penButton.Size = new System.Drawing.Size(75, 23);
            this.penButton.TabIndex = 1;
            this.penButton.Text = "pen";
            this.penButton.UseVisualStyleBackColor = true;
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(12, 41);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(75, 23);
            this.colorButton.TabIndex = 2;
            this.colorButton.Text = "color";
            this.colorButton.UseVisualStyleBackColor = true;
            // 
            // toolsPanel
            // 
            this.toolsPanel.AutoSize = true;
            this.toolsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.toolsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolsPanel.Controls.Add(this.clearButton);
            this.toolsPanel.Controls.Add(this.penButton);
            this.toolsPanel.Controls.Add(this.colorButton);
            this.toolsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolsPanel.Location = new System.Drawing.Point(0, 0);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.Size = new System.Drawing.Size(1210, 69);
            this.toolsPanel.TabIndex = 3;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(1123, 12);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // PaintLike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 778);
            this.Controls.Add(this.toolsPanel);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaintLike";
            this.Text = "PaintLike";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.toolsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button penButton;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Panel toolsPanel;
        private System.Windows.Forms.Button clearButton;
    }
}
