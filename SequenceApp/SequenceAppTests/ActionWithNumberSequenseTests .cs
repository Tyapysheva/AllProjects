using Microsoft.VisualStudio.TestTools.UnitTesting;
using SequenceApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceApp.Tests
{
    [TestClass()]
    public class ActionWithNumberSequenseTests
    {
        [TestMethod()]
        public void CheckSameNumber()
        {
            string testStr = "111";

            int result = ActionWithSequense.CalculateRepetedNumberSequense(testStr);

            Assert.AreEqual(3, result);
        }

        [TestMethod()]
        public void CheckEmptyString()
        {
            string testStr = "";

            int result = ActionWithSequense.CalculateRepetedNumberSequense(testStr);

            Assert.AreEqual(0, result);
        }

        [TestMethod()]
        public void CheckNullString()
        {
            string testStr = null;

            int result = ActionWithSequense.CalculateRepetedNumberSequense(testStr);

            Assert.AreEqual(0, result);
        }


        [TestMethod()]
        public void CheckLetter()
        {
            string testStr = "a";

            int result = ActionWithSequense.CalculateRepetedNumberSequense(testStr);

            Assert.AreEqual(0, result);
        }

        [TestMethod()]
        public void CheckDifferentNumber()
        {
            string testStr = "123";

            int result = ActionWithSequense.CalculateRepetedNumberSequense(testStr);

            Assert.AreEqual(1, result);
        }

        [TestMethod()]
        public void CheckStartSameNumber()
        {
            string testStr = "11122";

            int result = ActionWithSequense.CalculateRepetedNumberSequense(testStr);

            Assert.AreEqual(3, result);
        }

        [TestMethod()]
        public void CheckEndSameNumber()
        {
            string testStr = "11222";

            int result = ActionWithSequense.CalculateRepetedNumberSequense(testStr);

            Assert.AreEqual(3, result);
        }

        [TestMethod()]
        public void CheckMiddleNumber()
        {
            string testStr = "1122233";

            int result = ActionWithSequense.CalculateRepetedNumberSequense(testStr);

            Assert.AreEqual(3, result);
        }

        [TestMethod()]
        public void CheckOneNumber()
        {
            string testStr = "1";

            int result = ActionWithSequense.CalculateRepetedNumberSequense(testStr);

            Assert.AreEqual(1, result);
        }

        [TestMethod()]
        public void CheckDifferent()
        {
            string testStr = "abc";

            int result = ActionWithSequense.CalculateRepetedNumberSequense(testStr);

            Assert.AreEqual(0, result);
        }
    }
}