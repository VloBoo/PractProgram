using System;

namespace lab1_4
{
    class lab1_4
    {
        //Variant 26
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number 'b': ");
            double b = Convert.ToDouble(Console.ReadLine());
            const double t = 2;

            double a = Math.Pow(b + Math.Pow(t, 2), 0.5);
            Console.WriteLine($"a = {a}");

            double x = Math.Pow(Math.Cos(b), 2) + Math.Pow(Math.Sin(a), 2);
            Console.WriteLine($"x = {x}");

            double y = Math.Pow(x, 2) + Math.Pow(Math.Abs(a), 1.0/3);
            Console.WriteLine($"y = {y}");
        }
    }
}