using System;
using System.Text;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.OutputEncoding = Encoding.UTF8;
            double D = b * b - 4 * a * c;
            Console.WriteLine($"Дискримінант: {D}");
            if (D < 0) {
                Console.WriteLine("Дискримінант менше 0!");
            }else if (D == 0)
            {
                Console.WriteLine($"Корінь: {-b*1.0/(2*a)}");
            }
            else
            {
                Console.WriteLine($"Корінь 1: {(-b * 1.0 + Math.Sqrt(D)) / (2 * a)}");
                Console.WriteLine($"Корінь 2: {(-b * 1.0 - Math.Sqrt(D)) / (2 * a)}");
            }
        }
    }
}
