using ConsoleAppAsia07Figury.GeometryModel;
using System;

namespace ConsoleAppAsia07Figury
{
    class Program
    {
        static void Main(string[] args)
        {
            Point pos = new Point(2.1,5.8);
            //Figure fig = new Figure();
            //fig.Position = pos;
            Circle cir = new Circle(pos, 1);
            Console.WriteLine(cir.Area());
            Console.WriteLine(cir.Perimeter());
            Console.WriteLine("Hello World!");
        }
    }
}
