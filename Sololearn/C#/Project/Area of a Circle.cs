using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            double radius;
            
            //your code goes here
            double area;
            radius= Convert.ToDouble(Console.ReadLine());
area= Math.Pow(radius, 2)*pi;
Console.WriteLine(area);
            
        }
    }
}