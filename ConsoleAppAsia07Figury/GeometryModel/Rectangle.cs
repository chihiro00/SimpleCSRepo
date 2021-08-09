using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppAsia07Figury.GeometryModel
{
    class Rectangle: Polygon
    {
        public double A;
        public double B;

        public Rectangle(Point _pos, double _A, double _B)
        {
            this.Position = _pos;
            this.A = _A;
            this.B = _B;
        }

        public override double Area()
        {
            return A*B;
        }
        public override double Perimeter()
        {
            return 2 * A + 2 * B;
        }

        public override string ToString()
        {
            return "Klasa: "+ base.ToString() + "\n" + $"Boki: {A},{B}";
        }
    }
}
