using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralDesignPattern.FacadePattern
{
    public class FacadePatternTest
    {
        public void FacadeTest()
        {
            ShapeMaker shapeMaker = new ShapeMaker();
            shapeMaker.drawCircle();
            shapeMaker.drawRectangle();
            shapeMaker.drawSquare();
        }
    }
}
