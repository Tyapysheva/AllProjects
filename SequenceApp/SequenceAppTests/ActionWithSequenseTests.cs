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
    public class ActionWithSequenseTests
    {
        [TestMethod()]
        public void CheckSameLetter()
        {
            string testStr = "aaa";

            int result = ActionWithSequense.CalculateRepetedSequense(testStr);

            Assert.AreEqual(3, result);
        }

        [TestMethod()]
        public void CheckEmptyString()
        {
            string testStr = "";

            int result = ActionWithSequense.CalculateRepetedSequense(testStr);

            Assert.AreEqual(0, result);
        }

        [TestMethod()]
        public void CheckNullString()
        {
            string testStr = null;

            int result = ActionWithSequense.CalculateRepetedSequense(testStr);

            Assert.AreEqual(0, result);
        }

        [TestMethod()]
        public void CheckSameUpperLetter()
        {
            string testStr = "AAA";

            int result = ActionWithSequense.CalculateRepetedSequense(testStr);

            Assert.AreEqual(3, result);
        }

        [TestMethod()]
        public void CheckNumber()
        {
            string testStr = "1";

            int result = ActionWithSequense.CalculateRepetedSequense(testStr);

            Assert.AreEqual(0, result);
        }

        [TestMethod()]
        public void CheckDifferentLetter()
        {
            string testStr = "abc";

            int result = ActionWithSequense.CalculateRepetedSequense(testStr);

            Assert.AreEqual(1, result);
        }

        [TestMethod()]
        public void CheckStartSameLetter()
        {
            string testStr = "aaabb";

            int result = ActionWithSequense.CalculateRepetedSequense(testStr);

            Assert.AreEqual(3, result);
        }

        [TestMethod()]
        public void CheckEndSameLetter()
        {
            string testStr = "aabbb";

            int result = ActionWithSequense.CalculateRepetedSequense(testStr);

            Assert.AreEqual(3, result);
        }

        [TestMethod()]
        public void CheckMiddleLetter()
        {
            string testStr = "aabbbcc";

            int result = ActionWithSequense.CalculateRepetedSequense(testStr);

            Assert.AreEqual(3, result);
        }

        [TestMethod()]
        public void CheckOneLetter()
        {
            string testStr = "a";

            int result = ActionWithSequense.CalculateRepetedSequense(testStr);

            Assert.AreEqual(1, result);
        }

        [TestMethod()]
        public void CheckDifferent()
        {
            string testStr = "abc";

            int result = ActionWithSequense.CalculateRepetedSequense(testStr);

            Assert.AreEqual(1, result);
        }


    }
}