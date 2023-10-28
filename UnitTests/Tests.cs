using System;
using Golden_ratio_method;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class Form1Tests
    {
        [Test]
        public void GoldenSectionSearchTest_1()
        {
            GoldenMethod goldenMethod = new GoldenMethod();
            Func<double, double> fx = x => Math.Pow(x - 4, 2);
            goldenMethod.Search(fx, -10, 10, 0.001);
            Assert.AreEqual(goldenMethod.Optimal, 4.0, 0.001);
        }
        
        [Test]
        public void GoldenSectionSearchTest_2()
        {
            GoldenMethod goldenMethod = new GoldenMethod();
            Func<double, double> fx = x => 4 - Math.Pow(x, 2) - 0.2 * Math.Pow(x, 3);
            goldenMethod.Search(fx, -4, -3, 0.001);
            Assert.AreEqual(goldenMethod.Optimal, -3.333, 0.001);
        }
        
        [Test]
        public void GoldenSectionSearchTest_3()
        {
            GoldenMethod goldenMethod = new GoldenMethod();
            Func<double, double> fx = x => 4 - Math.Pow(x, 2) - 0.2 * Math.Pow(x, 3);
            goldenMethod.Search(fx, -2, 0, 0.001);
            Assert.AreEqual(goldenMethod.Optimal, -2.0, 0.001);
        }
        
        [Test]
        public void GoldenSectionSearchTest_4()
        {
            GoldenMethod goldenMethod = new GoldenMethod();
            Func<double, double> fx = x => Math.Atan(x) * Math.Cos(x) + 1;
            goldenMethod.Search(fx, 0, 2, 0.001);
            Assert.AreEqual(goldenMethod.Optimal, 2.0, 0.001);
        }
    }
}