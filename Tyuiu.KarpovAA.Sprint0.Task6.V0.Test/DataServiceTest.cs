using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KarpovAA.Sprint0.Task6.V0.Lib;

namespace Tyuiu.KarpovAA.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionArray(numbers);
            Assert.AreEqual(15, res);
        }
        [TestMethod]
        public void CheckSubstractionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.SubstractionArray(numbers);
            Assert.AreEqual(-15, res);
        }
        [TestMethod]
        public void CheckMultitionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MultitionArray(numbers);
            Assert.AreEqual(120, res);
        }

    }
}
