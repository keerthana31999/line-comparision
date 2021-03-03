using System;

namespace Line_comparision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the line comparision program using c-sharp");
            int x1, x2, y1, y2;
            Console.WriteLine("pass the values x1 & y1");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("pass the values x2 & y2");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("The length of the Line is : " + length);
        }
    }
}
