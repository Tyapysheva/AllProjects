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
    public class ActionWithUniqueSequenseTests
    {
        [TestMethod()]
        public void CheckSameNumber()
        {
            string testStr = "111";

            int result = ActionWithSequense.CalculateUniqueSequense(testStr);

            Assert.AreEqual(1, result, $"Expected 0 - Actual {result}");
        }

        [TestMethod()]
        public void CheckEmptyString()
        {
            string testStr = "";

            int result = ActionWithSequense.CalculateUniqueSequense(testStr);

            Assert.AreEqual(0, result, $"Expected 0 - Actual {result}");
        }

        [TestMethod()]
        public void CheckNullString()
        {
            string testStr = null;

            int result = ActionWithSequense.CalculateUniqueSequense(testStr);

            Assert.AreEqual(0, result, $"Expected 0 - Actual {result}");
        }


        [TestMethod()]
        public void CheckOneChar()
        {
            string testStr = "a";

            int result = ActionWithSequense.CalculateUniqueSequense(testStr);

            Assert.AreEqual(1, result, $"Expected 1 - Actual {result}");
        }

        [TestMethod()]
        public void CheckDifferentNumber()
        {
            string testStr = "123";

            int result = ActionWithSequense.CalculateUniqueSequense(testStr);

            Assert.AreEqual(3, result, $"Expected 3 - Actual {result}");
        }

        [TestMethod()]
        public void CheckStartDifferentNumber()
        {
            string testStr = "123444";

            int result = ActionWithSequense.CalculateUniqueSequense(testStr);

            Assert.AreEqual(4, result, $"Expected 4 - Actual {result}");
        }

        [TestMethod()]
        public void CheckEndDifferentNumber()
        {
            string testStr = "111234a";

            int result = ActionWithSequense.CalculateUniqueSequense(testStr);

            Assert.AreEqual(5, result, $"Expected 5 - Actual {result}");
        }

        [TestMethod()]
        public void CheckMiddleDifferentNumber()
        {
            string testStr = "a11123444";

            int result = ActionWithSequense.CalculateUniqueSequense(testStr);

            Assert.AreEqual(4, result,$"Expected 4 - Actual {result}");
        }

        [TestMethod()]
        public void CheckDifferent()
        {
            string testStr = "abc";

            int result = ActionWithSequense.CalculateUniqueSequense(testStr);

            Assert.AreEqual(3, result, $"Expected 3 - Actual {result}");
        }
    }
}