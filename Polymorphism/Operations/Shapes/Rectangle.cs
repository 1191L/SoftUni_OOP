using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle:Shape
    {
        double height;
        double width;
        public double Height { get => height; set { if (value < 1) throw new ArgumentException("Value must be above 0"); else height = value; } }
        public double Width { get => width; set {if (value < 1) throw new ArgumentException("Value must be above 0"); else width = value; } }
        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public override double CalculateArea()
        {
            return Math.Round(Height * Width,2);
        }
        public override double CalculatePerimeter()
        {
           return Math.Round(2 * (Height + Width),2);
        }
        public override string Draw()
        {
            return base.Draw() + this.GetType().Name;
        }
    }
}
