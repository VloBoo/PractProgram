using System;

namespace lab1_3
{
    class lab1_3
    {
        //Variant 26
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a temperature F: ");
            double ft = Convert.ToDouble(Console.ReadLine());
            double ct = (ft-32)*5/9;
        
            Console.WriteLine($"{ft}F = {ct}C");
        }
    }
}