using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SharkovMS.Sprint0.Task2.V0.Lib;

namespace Tyuiu.SharkovMS.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Игорь";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Игорь", res);
        }
    }
}
