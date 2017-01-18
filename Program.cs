using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter side length: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter height length: ");
            double h = double.Parse(Console.ReadLine());
            Console.Write("Triangle area = ");
            Console.WriteLine(TriangleArea(a, h));
        }
        static double TriangleArea(double sideA, double hight)
        {
            double area = sideA * hight / 2;
            return area;
        }
    }
}
