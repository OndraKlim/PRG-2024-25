using System.Drawing;
using System.Windows.Forms;

namespace Vzkaz
{
    public partial class Form1 : Form
    {
        bool play = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void panelVzkaz_Paint(object sender, PaintEventArgs e)
        {
            if (play)
            {
                Graphics g = panelVzkaz.CreateGraphics();

                // Nastavení fontu a barvy pro text
                Font font = new Font("Arial", 30);
                Brush brush = Brushes.Yellow;

                // Pozice, kde se text zobrazí
                PointF point = new PointF(20, 20);

                // Kreslení textu na panelu
                g.DrawString("Hello, Gymvod!", font, brush, point);
            }
        }

        private void buttonWrite_Click(object sender, System.EventArgs e)
        {
            play = true;
            panelVzkaz.Refresh();

        }
    }
}
