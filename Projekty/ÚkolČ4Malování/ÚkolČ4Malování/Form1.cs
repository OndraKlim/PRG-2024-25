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
        Graphics g;
        int lastPositionX;
        int lastPositionY;
        int currentPositionX;
        int currentPositionY;
        public FormMalovani()
        {
            InitializeComponent();
            g = panelPaint.CreateGraphics();
        }

        private void panelPaint_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
