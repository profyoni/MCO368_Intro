using System;
using Humanizer;

namespace MathLib
{
    public class BasicMath
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static String OmerTextEnglish(int i)
        {// "today is " + i.towords + " kl"
            return $"Today is day {i.ToWords()} in the Omer";
            //return @"http://www.example.com"; // verbatim string
        }
    }
}