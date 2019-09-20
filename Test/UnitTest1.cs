using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KTPM;
namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        private int a, b, c, d;
        [TestInitialize]
        public void intit()
        {
            a = 5;
            b = 10;
            c = -6;
            d = -11;
        }
        [TestMethod]
        public void testconghaiso()
        {
            Calculation cal = new Calculation(this.a,this.b);
            int expected = 15;
            int actual = cal.execute("+");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void testconghaisoam()
        {
            Calculation cal = new Calculation(this.c,this.d);
            int expected = -17;
            int actual = cal.execute("+");
            Assert.AreEqual(expected, actual);
        }
    }
}
