using System;
using HelloWorld;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Guys........");
            Console.WriteLine("Hello DemoBranch!!!!!!!!");
            String xyz = Console.ReadLine();
            Console.WriteLine(xyz);
            Calculation cal = new Calculation();
            int c =cal.AddNumber(3, 6);
            Console.WriteLine(c);
           

        }
    }
}
