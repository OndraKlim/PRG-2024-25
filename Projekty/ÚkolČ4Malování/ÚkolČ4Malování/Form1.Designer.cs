namespace ÚkolČ4Malování
{
    partial class FormMalovani
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
        private void InitializeComponent()
        {
            this.panelPaint = new System.Windows.Forms.Panel();
            this.buttonBlack = new System.Windows.Forms.Button();
            this.buttonLightGreen = new System.Windows.Forms.Button();
            this.buttonYellow = new System.Windows.Forms.Button();
            this.buttonOrange = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonDarkRed = new System.Windows.Forms.Button();
            this.buttonBrown = new System.Windows.Forms.Button();
            this.buttonGray = new System.Windows.Forms.Button();
            this.buttonPurple = new System.Windows.Forms.Button();
            this.buttonBlue = new System.Windows.Forms.Button();
            this.buttonLightBlue = new System.Windows.Forms.Button();
            this.buttonGreen = new System.Windows.Forms.Button();
            this.lineWidthMover = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEraser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDrawLine = new System.Windows.Forms.Button();
            this.buttonFillEllipse = new System.Windows.Forms.Button();
            this.buttonFillRectangle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDrawRectangle = new System.Windows.Forms.Button();
            this.buttonDrawEllipse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lineWidthMover)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPaint
            // 
            this.panelPaint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelPaint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPaint.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panelPaint.Location = new System.Drawing.Point(12, 132);
            this.panelPaint.Name = "panelPaint";
            this.panelPaint.Size = new System.Drawing.Size(1000, 564);
            this.panelPaint.TabIndex = 0;
            this.panelPaint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelPaint_MouseDown);
            this.panelPaint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelPaint_MouseMove);
            this.panelPaint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelPaint_MouseUp);
            // 
            // buttonBlack
            // 
            this.buttonBlack.BackColor = System.Drawing.Color.Black;
            this.buttonBlack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBlack.Location = new System.Drawing.Point(15, 15);
            this.buttonBlack.Name = "buttonBlack";
            this.buttonBlack.Size = new System.Drawing.Size(25, 25);
            this.buttonBlack.TabIndex = 1;
            this.buttonBlack.UseVisualStyleBackColor = false;
            this.buttonBlack.Click += new System.EventHandler(this.buttonBlack_Click);
            // 
            // buttonLightGreen
            // 
            this.buttonLightGreen.BackColor = System.Drawing.Color.LightGreen;
            this.buttonLightGreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLightGreen.Location = new System.Drawing.Point(108, 46);
            this.buttonLightGreen.Name = "buttonLightGreen";
            this.buttonLightGreen.Size = new System.Drawing.Size(25, 25);
            this.buttonLightGreen.TabIndex = 2;
            this.buttonLightGreen.UseVisualStyleBackColor = false;
            this.buttonLightGreen.Click += new System.EventHandler(this.buttonLightGreen_Click);
            // 
            // buttonYellow
            // 
            this.buttonYellow.BackColor = System.Drawing.Color.Yellow;
            this.buttonYellow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonYellow.Location = new System.Drawing.Point(77, 46);
            this.buttonYellow.Name = "buttonYellow";
            this.buttonYellow.Size = new System.Drawing.Size(25, 25);
            this.buttonYellow.TabIndex = 3;
            this.buttonYellow.UseVisualStyleBackColor = false;
            this.buttonYellow.Click += new System.EventHandler(this.buttonYellow_Click);
            // 
            // buttonOrange
            // 
            this.buttonOrange.BackColor = System.Drawing.Color.Orange;
            this.buttonOrange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOrange.Location = new System.Drawing.Point(46, 46);
            this.buttonOrange.Name = "buttonOrange";
            this.buttonOrange.Size = new System.Drawing.Size(25, 25);
            this.buttonOrange.TabIndex = 4;
            this.buttonOrange.UseVisualStyleBackColor = false;
            this.buttonOrange.Click += new System.EventHandler(this.buttonOrange_Click);
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.Color.Red;
            this.buttonRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRed.Location = new System.Drawing.Point(15, 46);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(25, 25);
            this.buttonRed.TabIndex = 5;
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // buttonDarkRed
            // 
            this.buttonDarkRed.BackColor = System.Drawing.Color.DarkRed;
            this.buttonDarkRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDarkRed.Location = new System.Drawing.Point(108, 15);
            this.buttonDarkRed.Name = "buttonDarkRed";
            this.buttonDarkRed.Size = new System.Drawing.Size(25, 25);
            this.buttonDarkRed.TabIndex = 6;
            this.buttonDarkRed.UseVisualStyleBackColor = false;
            this.buttonDarkRed.Click += new System.EventHandler(this.buttonDarkRed_Click);
            // 
            // buttonBrown
            // 
            this.buttonBrown.BackColor = System.Drawing.Color.Brown;
            this.buttonBrown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBrown.Location = new System.Drawing.Point(77, 15);
            this.buttonBrown.Name = "buttonBrown";
            this.buttonBrown.Size = new System.Drawing.Size(25, 25);
            this.buttonBrown.TabIndex = 7;
            this.buttonBrown.UseVisualStyleBackColor = false;
            this.buttonBrown.Click += new System.EventHandler(this.buttonBrown_Click);
            // 
            // buttonGray
            // 
            this.buttonGray.BackColor = System.Drawing.Color.Gray;
            this.buttonGray.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGray.Location = new System.Drawing.Point(46, 15);
            this.buttonGray.Name = "buttonGray";
            this.buttonGray.Size = new System.Drawing.Size(25, 25);
            this.buttonGray.TabIndex = 8;
            this.buttonGray.UseVisualStyleBackColor = false;
            this.buttonGray.Click += new System.EventHandler(this.buttonGray_Click);
            // 
            // buttonPurple
            // 
            this.buttonPurple.BackColor = System.Drawing.Color.Purple;
            this.buttonPurple.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPurple.Location = new System.Drawing.Point(108, 77);
            this.buttonPurple.Name = "buttonPurple";
            this.buttonPurple.Size = new System.Drawing.Size(25, 25);
            this.buttonPurple.TabIndex = 9;
            this.buttonPurple.UseVisualStyleBackColor = false;
            this.buttonPurple.Click += new System.EventHandler(this.buttonPurple_Click);
            // 
            // buttonBlue
            // 
            this.buttonBlue.BackColor = System.Drawing.Color.Blue;
            this.buttonBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBlue.Location = new System.Drawing.Point(77, 77);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(25, 25);
            this.buttonBlue.TabIndex = 10;
            this.buttonBlue.UseVisualStyleBackColor = false;
            this.buttonBlue.Click += new System.EventHandler(this.buttonBlue_Click);
            // 
            // buttonLightBlue
            // 
            this.buttonLightBlue.BackColor = System.Drawing.Color.LightBlue;
            this.buttonLightBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLightBlue.Location = new System.Drawing.Point(46, 77);
            this.buttonLightBlue.Name = "buttonLightBlue";
            this.buttonLightBlue.Size = new System.Drawing.Size(25, 25);
            this.buttonLightBlue.TabIndex = 11;
            this.buttonLightBlue.UseVisualStyleBackColor = false;
            this.buttonLightBlue.Click += new System.EventHandler(this.buttonLightBlue_Click);
            // 
            // buttonGreen
            // 
            this.buttonGreen.BackColor = System.Drawing.Color.Green;
            this.buttonGreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGreen.Location = new System.Drawing.Point(15, 77);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(25, 25);
            this.buttonGreen.TabIndex = 12;
            this.buttonGreen.UseVisualStyleBackColor = false;
            this.buttonGreen.Click += new System.EventHandler(this.buttonGreen_Click);
            // 
            // lineWidthMover
            // 
            this.lineWidthMover.Location = new System.Drawing.Point(920, 12);
            this.lineWidthMover.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lineWidthMover.Name = "lineWidthMover";
            this.lineWidthMover.Size = new System.Drawing.Size(92, 26);
            this.lineWidthMover.TabIndex = 15;
            this.lineWidthMover.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.lineWidthMover.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(877, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "size:";
            // 
            // buttonEraser
            // 
            this.buttonEraser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonEraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEraser.Location = new System.Drawing.Point(156, 15);
            this.buttonEraser.Name = "buttonEraser";
            this.buttonEraser.Size = new System.Drawing.Size(25, 25);
            this.buttonEraser.TabIndex = 19;
            this.buttonEraser.UseVisualStyleBackColor = false;
            this.buttonEraser.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Colors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Eraser";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Shapes";
            // 
            // buttonDrawLine
            // 
            this.buttonDrawLine.BackgroundImage = global::ÚkolČ4Malování.Properties.Resources.Straight_Line;
            this.buttonDrawLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDrawLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDrawLine.ForeColor = System.Drawing.Color.White;
            this.buttonDrawLine.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttonDrawLine.Location = new System.Drawing.Point(254, 12);
            this.buttonDrawLine.Name = "buttonDrawLine";
            this.buttonDrawLine.Size = new System.Drawing.Size(40, 40);
            this.buttonDrawLine.TabIndex = 26;
            this.buttonDrawLine.UseVisualStyleBackColor = true;
            this.buttonDrawLine.Click += new System.EventHandler(this.buttonDrawLine_Click);
            // 
            // buttonFillEllipse
            // 
            this.buttonFillEllipse.BackgroundImage = global::ÚkolČ4Malování.Properties.Resources.fillEllipse;
            this.buttonFillEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonFillEllipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFillEllipse.ForeColor = System.Drawing.Color.White;
            this.buttonFillEllipse.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttonFillEllipse.Location = new System.Drawing.Point(346, 62);
            this.buttonFillEllipse.Name = "buttonFillEllipse";
            this.buttonFillEllipse.Size = new System.Drawing.Size(40, 40);
            this.buttonFillEllipse.TabIndex = 25;
            this.buttonFillEllipse.UseVisualStyleBackColor = true;
            this.buttonFillEllipse.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonFillRectangle
            // 
            this.buttonFillRectangle.BackgroundImage = global::ÚkolČ4Malování.Properties.Resources.fillRectangle;
            this.buttonFillRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonFillRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFillRectangle.ForeColor = System.Drawing.Color.White;
            this.buttonFillRectangle.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttonFillRectangle.Location = new System.Drawing.Point(300, 62);
            this.buttonFillRectangle.Name = "buttonFillRectangle";
            this.buttonFillRectangle.Size = new System.Drawing.Size(40, 40);
            this.buttonFillRectangle.TabIndex = 24;
            this.buttonFillRectangle.UseVisualStyleBackColor = true;
            this.buttonFillRectangle.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::ÚkolČ4Malování.Properties.Resources.pen;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button2.Location = new System.Drawing.Point(208, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 22;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackgroundImage = global::ÚkolČ4Malování.Properties.Resources.cross_mark_emoji_clipart_xl;
            this.buttonClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Image = global::ÚkolČ4Malování.Properties.Resources.cross_mark_emoji_clipart_xl;
            this.buttonClear.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttonClear.Location = new System.Drawing.Point(959, 55);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(55, 55);
            this.buttonClear.TabIndex = 17;
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDrawRectangle
            // 
            this.buttonDrawRectangle.BackgroundImage = global::ÚkolČ4Malování.Properties.Resources.Square___black_simple_svg;
            this.buttonDrawRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDrawRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDrawRectangle.ForeColor = System.Drawing.Color.White;
            this.buttonDrawRectangle.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttonDrawRectangle.Location = new System.Drawing.Point(208, 62);
            this.buttonDrawRectangle.Name = "buttonDrawRectangle";
            this.buttonDrawRectangle.Size = new System.Drawing.Size(40, 40);
            this.buttonDrawRectangle.TabIndex = 14;
            this.buttonDrawRectangle.UseVisualStyleBackColor = true;
            this.buttonDrawRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            // 
            // buttonDrawEllipse
            // 
            this.buttonDrawEllipse.BackgroundImage = global::ÚkolČ4Malování.Properties.Resources.pngimg_com___circle_PNG63;
            this.buttonDrawEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDrawEllipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDrawEllipse.ForeColor = System.Drawing.Color.White;
            this.buttonDrawEllipse.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttonDrawEllipse.Location = new System.Drawing.Point(254, 61);
            this.buttonDrawEllipse.Name = "buttonDrawEllipse";
            this.buttonDrawEllipse.Size = new System.Drawing.Size(40, 40);
            this.buttonDrawEllipse.TabIndex = 13;
            this.buttonDrawEllipse.UseVisualStyleBackColor = true;
            this.buttonDrawEllipse.Click += new System.EventHandler(this.buttonEllipse_Click);
            // 
            // FormMalovani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 689);
            this.Controls.Add(this.buttonDrawLine);
            this.Controls.Add(this.buttonFillEllipse);
            this.Controls.Add(this.buttonFillRectangle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonEraser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.lineWidthMover);
            this.Controls.Add(this.buttonDrawRectangle);
            this.Controls.Add(this.buttonDrawEllipse);
            this.Controls.Add(this.buttonGreen);
            this.Controls.Add(this.buttonLightBlue);
            this.Controls.Add(this.buttonBlue);
            this.Controls.Add(this.buttonPurple);
            this.Controls.Add(this.buttonGray);
            this.Controls.Add(this.buttonBrown);
            this.Controls.Add(this.buttonDarkRed);
            this.Controls.Add(this.buttonRed);
            this.Controls.Add(this.buttonOrange);
            this.Controls.Add(this.buttonYellow);
            this.Controls.Add(this.buttonLightGreen);
            this.Controls.Add(this.buttonBlack);
            this.Controls.Add(this.panelPaint);
            this.Name = "FormMalovani";
            ((System.ComponentModel.ISupportInitialize)(this.lineWidthMover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPaint;
        private System.Windows.Forms.Button buttonBlack;
        private System.Windows.Forms.Button buttonLightGreen;
        private System.Windows.Forms.Button buttonYellow;
        private System.Windows.Forms.Button buttonOrange;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonDarkRed;
        private System.Windows.Forms.Button buttonBrown;
        private System.Windows.Forms.Button buttonGray;
        private System.Windows.Forms.Button buttonPurple;
        private System.Windows.Forms.Button buttonBlue;
        private System.Windows.Forms.Button buttonLightBlue;
        private System.Windows.Forms.Button buttonGreen;
        private System.Windows.Forms.Button buttonDrawEllipse;
        private System.Windows.Forms.Button buttonDrawRectangle;
        private System.Windows.Forms.NumericUpDown lineWidthMover;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEraser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonFillRectangle;
        private System.Windows.Forms.Button buttonFillEllipse;
        private System.Windows.Forms.Button buttonDrawLine;
    }
}

