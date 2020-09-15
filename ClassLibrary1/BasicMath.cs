using System;
using Humanizer;
using Microsoft.VisualBasic.CompilerServices;

namespace MathLib
{
    public class Fraction
    {
        private int n, d;

        public Fraction(int num = 0, int den = 1)
        {
            if (n < 0 && d < 0)
            {
                n *= -1;
                d *= -1;
            }
            n = num;
            if (den == 0) // data validation
                throw new ArgumentOutOfRangeException("denominator may not be 0");
            d = den;
        }

        //props

        //Operators overload
    }


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