using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap4
{
    class mclass
    {
        public static void Main()
        {
            //First circle 
            double userDia = getInput("1");
            class1 circleR = new class1(userDia/2);
            double area = circleR.getArea();
            Console.WriteLine("The diameter of the first circle is: "+ userDia);
            Console.WriteLine("The area of the first cirle is: "+ area);
            //Second circle 
            double userDia2 = getInput("2");
            class1 circleR2 = new class1(userDia2/2);
            double area2 = circleR2.getArea();                      
            Console.WriteLine("The diameter of the second circle is: "+ userDia2);
            Console.WriteLine("The area of the second cirle is: "+ area2);
            //Total area
            double totalArea = area+area2;
            Console.WriteLine("The total combined area is: " + totalArea);
            Console.ReadKey();
        }
        public static double getInput(string a) 
        {
            string input;
            Console.WriteLine("Please provide the diameter of the circle " + a);
            input = Console.ReadLine();
            double inputD = double.Parse(input);
            return inputD;
        }
    }
}