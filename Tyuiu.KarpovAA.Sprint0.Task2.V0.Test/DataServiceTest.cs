using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KarpovAA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.KarpovAA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создания методов тестировантия, из библиотеки
            var name = "Андрей";
            var res = DataService.GetMessage(name);

            // Вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет..., Андрей", res);
        }
    }
}
