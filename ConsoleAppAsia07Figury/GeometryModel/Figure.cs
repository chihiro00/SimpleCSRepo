
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppAsia07Figury.GeometryModel
{
    abstract class Figure
    {
        public Point Position;
        abstract public double Area();
        abstract public double Perimeter();
    }
}
