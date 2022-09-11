using Microsoft.VisualStudio.TestTools.UnitTesting;
using Z2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z2.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void InputErrorMoreTrue()
        {
            Boolean mistake = Logic.IsMistake(6);
            Assert.AreEqual(true, mistake);
        }

        [TestMethod()]
        public void InputErrorLessTrue()
        {
            Boolean mistake = Logic.IsMistake(-15);
            Assert.AreEqual(true, mistake);
        }

        [TestMethod()]
        public void InputErrorFalse()
        {
            Boolean mistake = Logic.IsMistake(4);
            Assert.AreEqual(false, mistake);
        }
    }
}