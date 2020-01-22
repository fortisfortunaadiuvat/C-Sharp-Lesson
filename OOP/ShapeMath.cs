using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class ShapeMath
    {
        public static double GetArea(string shape = "",
                                    double length = 0,
                                    double width = 0)
        {
            if (String.Equals("Rectangle", shape , StringComparison.OrdinalIgnoreCase))
            {
                return length * width;
            }
            else if (String.Equals("Triangle", shape, StringComparison.OrdinalIgnoreCase))
            {
                    return length * width / 2;
            }
            else if (String.Equals("Circle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return  Math.PI * Math.Pow(length,2);
            }
            else
            {
                return -1;            }
        }
    }
}
