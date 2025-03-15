using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle : Shape
    {
        double radius;
        public double Radius { get => radius; set { if (value < 1) throw new ArgumentException("Value must be above 0"); else radius = value; } }
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.Round(Math.PI * Radius * Radius, 2);
        }

        public override double CalculatePerimeter()
        {
            return Math.Round(2 * Math.PI * Radius, 2);
        }
        public override string Draw()
        {
            return base.Draw() + this.GetType().Name;
        }
    }
}
