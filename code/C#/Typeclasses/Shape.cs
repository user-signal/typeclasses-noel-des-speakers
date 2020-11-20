using System;

namespace Typeclasses
{
    interface Shape
    {
        public double Area { get; }
    }

    class Square : Shape {
        public double Side { get; set; }
        public double Area => Side * Side;
    }    
                    
    class Circle : Shape {
        public double Radius { get; set; }
        public double Area => Radius * Radius * Math.PI;
    }
}