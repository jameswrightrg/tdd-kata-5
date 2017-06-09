using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace tddkata5.Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void OneCardIsSorted()
        {
            var actual = "A";
            var expected = CardSorter.Sort();

            Assert.AreEqual(expected, actual);
        }
    }
}
