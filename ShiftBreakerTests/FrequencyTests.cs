using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShiftBreaker;

namespace ShiftBreakerTests
{
    [TestClass]
    public class FrequencyTests
    {
        [TestMethod]
        public void Ba2Black1Sheep1()
        {
            Frequency frequency = new Frequency();

            Dictionary<string, int> expected = new Dictionary<string, int>()
            {
                {"ba", 2 },
                {"black", 1 },
                {"sheep", 1 }
            };
            Dictionary<string, int> actual = frequency.WordCount(new string[] { "ba", "ba", "black", "sheep" });
            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TwoATwoBOneC()
        {
            Frequency frequency = new Frequency();

            Dictionary<string, int> expected = new Dictionary<string, int>()
            {
                {"a", 2 },
                {"b", 2 },
                {"c", 1 }

            };
            Dictionary<string, int> actual = frequency.WordCount(new string[] { "a", "b", "a", "c", "b" });
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
