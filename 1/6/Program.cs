using System;

namespace lab1_6
{
    class lab1_6
    {
        //Variant 26
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a 'a': ");
            double a = Convert.ToDouble(Console.ReadLine());

            double z1 = (1 - 2 * Math.Pow(Math.Sin(a), 2)) / (1 + Math.Sin(2 * a));
            double z2 = (1 - Math.Tan(a)) / (1 + Math.Tan(a));

            Console.WriteLine($"z1 = {z1}");
            Console.WriteLine($"z2 = {z2}");
        }
    }
}