using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppAsia07Figury.GeometryModel
{
    class Circle: Figure
    {
        private double radius;

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value > 0)
                    radius = value;
                else
                    throw (new ApplicationException("Promien nie moze byc mniejszy od 0"));        
            }
        }
        public Circle(Point _center, double _radius)
        {
            this.Position = _center;
            this.radius = _radius;

        }

        public override double Area()
        {
            //throw new NotImplementedException();
            return  Math.PI* radius * radius;

        }

        public override double Perimeter()
        {
            //throw new NotImplementedException();
            return 2 * Math.PI * radius;
        }

        public override string ToString()
        {
            
            return "Klasa: "  + base.ToString() + "\n" + $"Promien: {radius}";

        }
    }
}
