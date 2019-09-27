using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KTPM;

namespace Test2
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }
        [TestMethod]
        public void TestMethod1()
        {
            double expected = 1;
            double actual = MyPower.Power(5, 0);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestWithPositiveN1()
        {
            double expected = 4;
            double actual = MyPower.Power(2, 2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestWithPositiveN2()
        {
            double expected = 27;
            double actual = MyPower.Power(3, 3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestWithPositiveN3()
        {
            double expected = 4;
            double actual = MyPower.Power(-2, 2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestNegativeN1()
        {
            double expected = -8;
            double actual = MyPower.Power(-2, 3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestNegativeN2()
        {
            double expected = -8;
            double actual = MyPower.Power(-2, 3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestNegativeN3()
        {
            double expected = -0.5;
            double actual = MyPower.Power(-2, -1);
            Assert.AreEqual(expected, actual);
        }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestWithDataSource()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            int expected = int.Parse(TestContext.DataRow[2].ToString());
            Calculation c = new Calculation(a, b);
            int actual = c.execute("+");
            Assert.AreEqual(expected, actual);
        }
    }   

}
