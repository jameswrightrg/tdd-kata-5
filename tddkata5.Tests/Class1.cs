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
            var expected = CardSorter.Sort(actual);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SwapsTwoCards()
        {
            var input = "32";
            var expected = "23";
            var output = CardSorter.Sort(input);

            Assert.That(expected, Is.EqualTo(output));
        }
    }
}
