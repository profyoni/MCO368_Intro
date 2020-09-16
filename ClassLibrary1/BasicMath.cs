using System;
using System.Text;
using Humanizer;
using Microsoft.VisualBasic.CompilerServices;

namespace MathLib
{
    public class Fraction
    {
        private int d;

        public Fraction(int num = 0, int den = 1)// default par must be compiler constants
        {
            Numerator = num;
            Denominator = den;
            Simplify();
        }

        private void Simplify()
        {
            if (Numerator < 0 && d < 0)
            {
                Numerator *= -1;
                d *= -1;
            }
            Reduce();
        }

        private void Reduce()
        {
            // TODO
        }

        //properties - Looks like a variable, but it's really a method
        public int Numerator
        {
            get;set;
        }

        // C# In Depth
        public int Denominator
        {
            get 
            {
                return d; 
            }
            set 
            {
                if (value == 0) // data validation
                    throw new ArgumentOutOfRangeException("denominator may not be 0");

                d = value; 
            }
        }

        //Overloading Operators

        public static Fraction operator +(Fraction f1, Fraction f2)
        {// TODO
            return new Fraction(f1.Numerator + f2.Numerator, f1.Denominator);
        }
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