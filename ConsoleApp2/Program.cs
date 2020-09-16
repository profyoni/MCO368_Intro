using System;
using System.Reflection;
using MathLib;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            PropertyInfo[] myPropertyInfo;
            // Get the properties of 'Type' class object.
            myPropertyInfo = Type.GetType("System.String").GetProperties();
            Console.WriteLine("Properties of System.Type are:");
            for (int i = 0; i < myPropertyInfo.Length; i++)
            {
                Console.WriteLine(myPropertyInfo[i].ToString());
            }

            Console.WriteLine("Hello World!");
            int a = BasicMath.Add(3, 4);
            Console.WriteLine(a);
            Console.WriteLine("Press any key to end");
            Console.ReadKey();
        }
    }
}
