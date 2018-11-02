using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap4
{
    class class1
    {
        public double Radius;

        public class1() // constructor w/ no parameters
        {
            Radius = 1;
        } 
        public class1(double newRadius)
        {
            Radius = newRadius;
        }

        public double getArea()
        {
            return Radius*Radius*3.14;
        }
    }
}