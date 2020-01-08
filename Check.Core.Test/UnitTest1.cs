using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Check.Core.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void 檢查是否為時間_是時間()
        {
            // arrange
            IChecker checker = new RegexCheck();
            string militaryTime = "12:22";

            //期望值
            bool expected = true; 

            // 實際結果
            bool actual = checker.MilitaryTimeToRegularTime(militaryTime);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 檢查是否為時間_不是時間()
        {
            // arrange
            IChecker checker = new RegexCheck();
            string militaryTime = "25:22";

            //期望值
            bool expected = false;

            // 實際結果
            bool actual = checker.MilitaryTimeToRegularTime(militaryTime);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
