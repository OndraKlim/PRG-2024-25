using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
    internal class Rectangle
    {
        private double width; private double height; public int x; public int y;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public double GetArea() { return width * height; }
        public double GetWidth() { return width; }
        public double GetHeight() { return height; }
        public double GetAspectRatio() { return width / height; }
        public bool GetContainsPoint() 
        {
            if (x < width && y < height) return true;
            else return false;
        }
    }
}
