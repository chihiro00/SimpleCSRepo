using ConsoleAppAsia07Figury.GeometryModel;
using System;
using System.Collections.Generic;

namespace ConsoleAppAsia07Figury
{
    class Program
    {
        static void Main(string[] args)
        {
            Point pos1 = new Point(2.1,5.8);
            //Figure fig = new Figure();
            //fig.Position = pos;
            Circle cir = new Circle(pos1, 1);
            cir.Radius = 2;
            Console.WriteLine(cir.Area());
            Console.WriteLine(cir.Perimeter());
            Console.WriteLine(cir);
            Point pos2 = new Point(14.6, 9.2);
            Rectangle rec2 = new Rectangle(pos2,5.0,2.0);
            Console.WriteLine(rec2);
            Console.WriteLine(rec2.Area());
            Console.WriteLine(rec2.Perimeter());
            Point pos3 = new Point(14.6, 9.2);
            Rectangle rec3 = new Rectangle(pos2, 2.0, 3.0);
            Console.WriteLine("Hello World!");
            Console.WriteLine("Figury");
            List<Figure> lf = new List<Figure>();
            lf.Add(cir);
            lf.Add(rec3);
            lf.Add(rec2);
            foreach(Figure fig in lf)
            {
                Console.WriteLine(fig);
            }
        }
    }
}
