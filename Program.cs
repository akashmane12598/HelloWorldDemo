using System;
using HelloWorld;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Guys........");
            String xyz = Console.ReadLine();
            Console.WriteLine(xyz);
            Calculation cal = new Calculation();
            int c =cal.AddNumber(3, 6);
            Console.WriteLine(c);
           

        }
    }
}
