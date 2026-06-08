using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SklyarovAM.Sprint2.Task4.V15.Lib;
namespace Tyuiu.SklyarovAM.Sprint2.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 20;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(45, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 20;
            double y = 30;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(45, res);
        }
    }
}
