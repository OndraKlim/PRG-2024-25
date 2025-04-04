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
        
        
        public FormMalovani()
        {
            InitializeComponent();
        }

        private void panelPaint_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing == true)
            {
                Graphics g = panelPaint.CreateGraphics();
                Pen pen = new Pen(currentColor, lineWidth);

                Point currentPoint = new Point(e.X, e.Y);
                g.DrawLine(pen, previousPoint, currentPoint);

                previousPoint = currentPoint;
                g.Dispose();
            }
        }

        private void panelPaint_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            previousPoint = new Point(e.X, e.Y);
        }

        private void panelPaint_MouseUp(object sender, MouseEventArgs e)
        {isDrawing = false;}

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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            lineWidth = (float)lineWidthMover.Value;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Graphics g = panelPaint.CreateGraphics();
            g.Clear(Color.White);
            
        }
    }
}
