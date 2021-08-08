using ConsoleAppAsia07Figury.GeometryModel;
using System;

namespace ConsoleAppAsia07Figury
{
    class Program
    {
        static void Main(string[] args)
        {
            Point pos = new Point(2.1,5.8);
            Figure fig = new Figure();
            fig.Position = pos;
            Console.WriteLine("Hello World!");
        }
    }
}
