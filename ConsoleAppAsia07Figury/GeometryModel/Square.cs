using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppAsia07Figury.GeometryModel
{
    
    class Square: Rectangle
    {
        public Square(Point _pos, double _A) : base(_pos,_A,_A)
        {
            /*
            this.Position = _pos;
            this.A = _A;
            this.B = _A;
            */
        }
    } 
   
}
