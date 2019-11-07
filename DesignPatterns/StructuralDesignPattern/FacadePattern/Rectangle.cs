using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralDesignPattern.FacadePattern
{
    public class Rectangle:Shape
    {
        public void draw()
        {
            Console.WriteLine("Rectangle::draw()");
        }
    }
}
