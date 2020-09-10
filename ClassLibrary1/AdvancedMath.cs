using System;
using Humanizer;

namespace MathLib
{
    public class AdvancedMath
    {
        public static int Add2(int x, int y)
        {
            return x + y;
        }

        public static String OmerTextEnglish2(int i)
        {// "today is " + i.towords + " kl"
            return $"Today is day {i.ToWords()} in the Omer";
            //return @"http://www.example.com"; // verbatim string
        }
    }


}
