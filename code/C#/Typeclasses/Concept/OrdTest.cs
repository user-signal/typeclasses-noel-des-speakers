using System.Collections.Generic;
using NUnit.Framework;
using static Typeclasses.Concept.Algorithm<int>;
using static Typeclasses.Concept.Algorithm<string>;
using static Typeclasses.Concept.Algorithm<(int, string)>;

namespace Typeclasses.Concept
{
    [TestFixture]
    public class OrdTest
    {
        [Test]
        public void IntOrdTest()
        {
            var ev = new IntOrdered();
            var intOrds = new List<int> {1, -4, 42, 12};
            var actual = Sort(intOrds, ev);
            var expected = new List<int> {-4, 1, 12, 42};
            Assert.IsTrue(Equality(actual, expected, ev));
        }

        [Test]
        public void StringOrdTest()
        {
            var ev = new StringOrdered();
            var stringOrds = new List<string> {"a", "z", "e", "r"};
            var actual = Sort(stringOrds, ev);
            var expected = new List<string> {"a", "e", "r", "z"};
            Assert.IsTrue(Equality(actual, expected, ev));
        }

        [Test]
        public void PairOrdTest()
        {
            var ev = new PairOrdered<int, string>() { evA = new IntOrdered(), evB = new StringOrdered()};;
            var pairOrds = new List<(int, string)> {(1, "a"), (-4, "z"), (-4, "e"), (42, "r")};
            var actual = Sort(pairOrds, ev);
            var expected = new List<(int, string)> {(-4, "e"), (-4, "z"), (1, "a"), (42, "r")};
            Assert.IsTrue(Equality(actual, expected, ev));
        }
    }
}