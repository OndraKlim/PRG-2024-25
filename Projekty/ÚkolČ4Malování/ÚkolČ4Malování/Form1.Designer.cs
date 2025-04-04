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
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.buttonEllipse = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lineWidthMover)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPaint
            // 
            this.panelPaint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelPaint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPaint.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panelPaint.Location = new System.Drawing.Point(12, 121);
            this.panelPaint.Name = "panelPaint";
            this.panelPaint.Size = new System.Drawing.Size(1000, 575);
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
            // buttonRectangle
            // 
            this.buttonRectangle.BackgroundImage = global::ÚkolČ4Malování.Properties.Resources.Square___black_simple_svg;
            this.buttonRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRectangle.ForeColor = System.Drawing.Color.White;
            this.buttonRectangle.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttonRectangle.Location = new System.Drawing.Point(172, 62);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(40, 40);
            this.buttonRectangle.TabIndex = 14;
            this.buttonRectangle.UseVisualStyleBackColor = true;
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.BackgroundImage = global::ÚkolČ4Malování.Properties.Resources.pngimg_com___circle_PNG63;
            this.buttonEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEllipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEllipse.ForeColor = System.Drawing.Color.White;
            this.buttonEllipse.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttonEllipse.Location = new System.Drawing.Point(172, 15);
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(40, 40);
            this.buttonEllipse.TabIndex = 13;
            this.buttonEllipse.UseVisualStyleBackColor = true;
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
            // FormMalovani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 689);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.lineWidthMover);
            this.Controls.Add(this.buttonRectangle);
            this.Controls.Add(this.buttonEllipse);
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
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.lineWidthMover)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button buttonEllipse;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.NumericUpDown lineWidthMover;
        private System.Windows.Forms.Button buttonClear;
    }
}

