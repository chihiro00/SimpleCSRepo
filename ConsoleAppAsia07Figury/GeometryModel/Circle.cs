using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppAsia07Figury.GeometryModel
{
    class Circle: Figure
    {
        public double Radius;
        public Circle(Point _center, double _radius)
        {
            this.Position = _center;
            this.Radius = _radius;

        }

        public override double Area()
        {
            //throw new NotImplementedException();
            return  Math.PI* Radius * Radius;

        }

        public override double Perimeter()
        {
            //throw new NotImplementedException();
            return 2 * Math.PI * Radius;
        }
    }
}
