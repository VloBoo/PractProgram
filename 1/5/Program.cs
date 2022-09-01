using System;

namespace lab1_5
{
    class lab1_5
    {
        //Variant 26
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a 'R': ");
            double R = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a 'r': ");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a 'h': ");
            double h = Convert.ToDouble(Console.ReadLine());

            double S1 = Math.PI * Math.Pow(R, 2);
            double S2 = Math.PI * Math.Pow(r, 2);


            double V = h * (S1 + Math.Pow(S1*S2,0.5) + S2)/3;
            Console.WriteLine($"V = {V}");
        }
    }
}