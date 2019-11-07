using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralDesignPattern.FacadePattern
{
    public class Square:Shape
    {
        public void draw()
        {
            Console.WriteLine("Square::draw()");
        }
    }
}
