using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.OsintsevKP.Sprint0.Task2.V0.Lib;
namespace Tyuiu.OsintsevKP.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ChekGetMessageValid()
        {
            var name = "Константин";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Константин", res);
        }
    }
}
