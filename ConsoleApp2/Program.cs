using System;
using MathLib;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = BasicMath.Add(3, 4);
            Console.WriteLine(a);
            Console.WriteLine("Press any key to end");
            Console.ReadKey();
        }
    }
}
