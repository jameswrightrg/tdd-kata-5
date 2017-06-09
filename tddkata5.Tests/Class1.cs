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
        [TestCase("A","A")]
        [TestCase("32","23")]
        [TestCase("32", "23")]
        [TestCase("3A", "A3")]
        [TestCase("KJ", "JK")]
        [TestCase("23A", "A23")]
        [TestCase("23A6742QT", "A223467TQ")]
        public void SortsAsExpected(string input, string expected)
        {
            var output = CardSorter.Sort(input);

            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void InvalidCardExceptionIsThrown()
        {
            var input = "23Z";

            Assert.That(() => CardSorter.Sort(input), Throws.Exception.TypeOf<Exception>());
        }
    }
}
