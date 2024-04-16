using System;
using System.Collections.Generic;

namespace Overriding_Program
{
    public class Canvas
    {
        public void DrawShapes( List<Shape> shapes)
        { 
         foreach (var shape in shapes)
            {
                shape.Draw();
            
            }
        }
    }
}
