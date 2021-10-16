using System;

namespace LinearExpressions
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
            Console.Write("d = ");
            double d = Convert.ToDouble(Console.ReadLine());
            double x, y, z, r;
            x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - Math.Pow(a, 2) / Math.Pow(b, 2);
            y = 5*(a + b)*( c - d) / (1.0*c/2) + (Math.Pow(d, 2)*( Math.Pow(a, 2) - Math.Pow(b, 2)))/(b-a);
            z = (Math.Pow(x * x - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b)/(5*a+3*b);
            r = (1.0 * a / 2 + 3.0 * b / 4 - 7.0 / 5) / (3 * c + 1) + (1.0 / (a - c));
            Console.WriteLine($"x = {x}, y = {y}, z = {z}, r = {r}");
        }
    }
}
