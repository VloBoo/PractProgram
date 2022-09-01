using System;

namespace lab1_7
{
    class lab1_7
    {
        //Variant 26
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a nubmer 'x': ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a nubmer 'y': ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a nubmer 'z': ");
            double z = Convert.ToDouble(Console.ReadLine());

            double check1 = x + y;
            if(check1 <= 0 ){
                Console.WriteLine("Error");
                return;
            }

            double check2 = Math.Exp(Math.Abs(x-y))+x/2.0;
            if(check2 == 0 ){
                Console.WriteLine("Error");
                return;
            }

            double b = Math.Pow(y,Math.Pow(Math.Abs(x),1/3.0)) + Math.Pow(Math.Cos(y),3) * (Math.Abs(x-y) * (1 + Math.Pow(z,2)/Math.Sqrt(check1)))/(check2);
            

            Console.WriteLine($"b = {b}");
            
        }
    }
}