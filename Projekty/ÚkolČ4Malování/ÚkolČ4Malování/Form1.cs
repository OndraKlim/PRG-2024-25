using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÚkolČ4Malování
{
    public partial class FormMalovani : Form
    {
        bool isDrawing = false;
        Point previousPoint;
        Color currentColor = Color.Black;
        float lineWidth = 2;
        Point startPoint;
        
        
        public FormMalovani()
        {
            InitializeComponent();
        }

        enum DrawingMode { FreeDraw, drawRectangle, drawEllipse, fillRectangle, fillEllipse, drawLine }
        DrawingMode currentMode = DrawingMode.FreeDraw;

        private void panelPaint_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            previousPoint = e.Location;
            startPoint = e.Location;
        }

        private void panelPaint_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing && currentMode == DrawingMode.FreeDraw)
            {
                Graphics g = panelPaint.CreateGraphics();
                Pen pen = new Pen(currentColor, lineWidth);

                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                g.DrawLine(pen, previousPoint, e.Location);
                previousPoint = e.Location;

                g.Dispose();
            }
        }

        private void panelPaint_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;

            if (currentMode == DrawingMode.drawRectangle || currentMode == DrawingMode.drawEllipse)
            {
                Graphics g = panelPaint.CreateGraphics();
                Pen pen = new Pen(currentColor, lineWidth);

                Rectangle rect = new Rectangle(
                    Math.Min(startPoint.X, e.X),
                    Math.Min(startPoint.Y, e.Y),
                    Math.Abs(startPoint.X - e.X),
                    Math.Abs(startPoint.Y - e.Y)
                );

                if (currentMode == DrawingMode.drawRectangle)
                    g.DrawRectangle(pen, rect);
                else if (currentMode == DrawingMode.drawEllipse)
                    g.DrawEllipse(pen, rect);

                g.Dispose();
            }
            if (currentMode == DrawingMode.drawLine)
            {
                Graphics g = panelPaint.CreateGraphics();
                Pen pen = new Pen(currentColor, lineWidth);
                g.DrawLine(pen, startPoint, e.Location);
                g.Dispose();
            }

            if (currentMode == DrawingMode.fillRectangle || currentMode == DrawingMode.fillEllipse)
            {
                Graphics g = panelPaint.CreateGraphics();
                Brush brush = new SolidBrush (currentColor);

                Rectangle rect = new Rectangle(
                    Math.Min(startPoint.X, e.X),
                    Math.Min(startPoint.Y, e.Y),
                    Math.Abs(startPoint.X - e.X),
                    Math.Abs(startPoint.Y - e.Y)
                );

                if (currentMode == DrawingMode.fillRectangle)
                    g.FillRectangle(brush, rect);
                else if (currentMode == DrawingMode.fillEllipse)
                    g.FillEllipse(brush, rect);

                g.Dispose();
            }
        }
        private void buttonBlack_Click(object sender, EventArgs e)
        {currentColor = Color.Black;}

        private void buttonRed_Click(object sender, EventArgs e)
        {currentColor = Color.Red;}

        private void buttonGreen_Click(object sender, EventArgs e)
        {currentColor = Color.Green;}

        private void buttonGray_Click(object sender, EventArgs e)
        {currentColor = Color.Gray;}

        private void buttonOrange_Click(object sender, EventArgs e)
        {currentColor = Color.Orange;}

        private void buttonLightBlue_Click(object sender, EventArgs e)
        {currentColor = Color.LightBlue;}

        private void buttonBrown_Click(object sender, EventArgs e)
        {currentColor = Color.Brown;}

        private void buttonYellow_Click(object sender, EventArgs e)
        {currentColor = Color.Yellow;}

        private void buttonBlue_Click(object sender, EventArgs e)
        {currentColor = Color.Blue;}

        private void buttonDarkRed_Click(object sender, EventArgs e)
        {currentColor = Color.DarkRed;}

        private void buttonLightGreen_Click(object sender, EventArgs e)
        {currentColor = Color.LightGreen;}

        private void buttonPurple_Click(object sender, EventArgs e)
        {currentColor = Color.Purple;}
        private void button1_Click(object sender, EventArgs e)
        { currentColor = Color.WhiteSmoke;}

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            lineWidth = (float)lineWidthMover.Value;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Graphics g = panelPaint.CreateGraphics();
            g.Clear(Color.WhiteSmoke);
            
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            currentMode = DrawingMode.drawRectangle;
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            currentMode = DrawingMode.drawEllipse;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentMode = DrawingMode.FreeDraw;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentMode = DrawingMode.fillEllipse;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            currentMode = DrawingMode.fillRectangle;
        }

        private void buttonDrawLine_Click(object sender, EventArgs e)
        {
            currentMode = DrawingMode.drawLine;
        }
    }
}
