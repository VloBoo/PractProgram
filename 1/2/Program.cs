using System;

namespace lab1_2
{
    class lab1_2
    {
        //Variant 26
        static void Main(string[] args)
        {
            int x = 2;
            int y = 3;
            int k = 3;
            double U = (double)((Math.Log(Math.Pow(x,3)+y)-Math.Pow(y,4))/(Math.Pow(Math.E,y)+5.4*Math.Pow(k,3)));
            Console.WriteLine(U);
        }
    }
}
