using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SklyarovAM.Sprint2.Task5.V15.Lib;
namespace Tyuiu.SklyarovAM.Sprint2.Task5.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayNumber()
        {
            DataService ds = new DataService();
            Assert.AreEqual("понедельник", ds);
        }
    }
}
