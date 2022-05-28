﻿namespace WinFormsPaintLike
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
            this.PenButton = new System.Windows.Forms.Button();
            this.colorButton = new System.Windows.Forms.Button();
            this.toolsPanel = new System.Windows.Forms.Panel();
            this.ShowColorBotton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.PenWidthLabel = new System.Windows.Forms.Label();
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
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBoxMouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBoxMouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBoxMouseUp);
            // 
            // PenButton
            // 
            this.PenButton.Location = new System.Drawing.Point(12, 12);
            this.PenButton.Name = "PenButton";
            this.PenButton.Size = new System.Drawing.Size(75, 23);
            this.PenButton.TabIndex = 1;
            this.PenButton.Text = "pen";
            this.PenButton.UseVisualStyleBackColor = true;
            this.PenButton.Click += new System.EventHandler(this.PenButtonClick);
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(12, 41);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(75, 23);
            this.colorButton.TabIndex = 2;
            this.colorButton.Text = "color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.ColorButtonClick);
            // 
            // toolsPanel
            // 
            this.toolsPanel.AutoSize = true;
            this.toolsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.toolsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolsPanel.Controls.Add(this.PenWidthLabel);
            this.toolsPanel.Controls.Add(this.ShowColorBotton);
            this.toolsPanel.Controls.Add(this.clearButton);
            this.toolsPanel.Controls.Add(this.PenButton);
            this.toolsPanel.Controls.Add(this.colorButton);
            this.toolsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolsPanel.Location = new System.Drawing.Point(0, 0);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.Size = new System.Drawing.Size(1210, 69);
            this.toolsPanel.TabIndex = 3;
            // 
            // ShowColorBotton
            // 
            this.ShowColorBotton.Location = new System.Drawing.Point(93, 40);
            this.ShowColorBotton.Name = "ShowColorBotton";
            this.ShowColorBotton.Size = new System.Drawing.Size(23, 23);
            this.ShowColorBotton.TabIndex = 4;
            this.ShowColorBotton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(1123, 12);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButtonClick);
            // 
            // PenWidthLabel
            // 
            this.PenWidthLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PenWidthLabel.Location = new System.Drawing.Point(93, 12);
            this.PenWidthLabel.Name = "PenWidthLabel";
            this.PenWidthLabel.Size = new System.Drawing.Size(23, 23);
            this.PenWidthLabel.TabIndex = 5;
            this.PenWidthLabel.Text = "3";
            this.PenWidthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
        private System.Windows.Forms.Button PenButton;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Panel toolsPanel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button ShowColorBotton;
        private System.Windows.Forms.Label PenWidthLabel;
    }
}
