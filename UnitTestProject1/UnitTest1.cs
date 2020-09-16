using System.Globalization;
using FluentAssertions;
using Humanizer;
using MathLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
    
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = BasicMath.Add(1, 2);
            Assert.AreEqual(3,x);
            x.Should().Be(3);
            x.ToWords(CultureInfo.GetCultureInfo("he-IL")).Should().Be("שלוש");
        }

        [TestMethod]
        public void OmerTextEnglish()
        {
            var actual = BasicMath.OmerTextEnglish(1);
            actual.Should().Be("Today is day one in the Omer");
        }

        [TestMethod]
        public void LanguageTest()
        {
            "C:\\\\www.example.com".Should().Be(@"C:\\www.example.com");
        }

        [TestMethod]
        public void LanguageTest2()
        {
            var f = new Fraction();

            f.Numerator = 5;
            f.Denominator = 9;

            int a = f.Numerator;

            Fraction f3 = f + f; // f1.Add(f1)

            f3.Numerator.Should().Be(10);
        }



    }
}
