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

        [TestCase("32","23")]
        [TestCase("3A", "A3")]
        [TestCase("JK", "JK")]
        public void SwapsTwoCards(string input, string expected)
        {
            var output = CardSorter.Sort(input);

            Assert.That(expected, Is.EqualTo(output));
        }

        [Test]
        public void KeepsOrderWhenInputWasAlreadySorted()
        {
            var input = "23";
            var expected = "23";
            var output = CardSorter.Sort(input);

            Assert.That(expected, Is.EqualTo(output));
        }

        [Test]
        public void SortThreeCards()
        {
            var input = "23A";
            var expected = "A23";
            var output = CardSorter.Sort(input);

            Assert.That(expected, Is.EqualTo(output));
        }

        [Test]
        public void InvalidCardExceptionIsThrown()
        {
            var input = "23Z";

            Assert.That(() => CardSorter.Sort(input), Throws.Exception.TypeOf<Exception>());
        }
    }
}
