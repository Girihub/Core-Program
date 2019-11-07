using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralDesignPattern.FacadePattern
{
    public class Circle:Shape
    {
        public void draw()
        {
            Console.WriteLine("Circle::draw()");
        }
    }
}
