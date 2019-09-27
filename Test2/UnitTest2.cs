using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KTPM;

namespace Test2
{
    [TestClass]
    public class UnitTest2
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\ToaDo.csv", "ToaDo#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void Test()
        {
            double x1 = double.Parse(TestContext.DataRow[0].ToString());
            double y1 = double.Parse(TestContext.DataRow[1].ToString());
            double x2 = double.Parse(TestContext.DataRow[2].ToString());
            double y2 = double.Parse(TestContext.DataRow[3].ToString());
            double expected = double.Parse(TestContext.DataRow[4].ToString());

            Diem d1 = new Diem(x1, y1);
            Diem d2 = new Diem(x2, y2);
            HinhChuNhat h = new HinhChuNhat(d1, d2);
            double actual = h.TinhDienTich();

            Assert.AreEqual(expected, actual);
        }
    }
}