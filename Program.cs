using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleAreaMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine(TriangleArea(a, h));
        }
        static double TriangleArea(double sideA, double hight)
        {
            double area = sideA * hight / 2;
            return area;
        }
    }
}
