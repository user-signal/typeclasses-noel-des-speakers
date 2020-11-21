using NUnit.Framework;
using static Typeclasses.Concept.Algorithm<string>;
using static Typeclasses.Concept.Algorithm<int>;

namespace Typeclasses.Concept
{
    [TestFixture]
    public class OrdTest
    {
        [Test]
        public void IntOrdTest()
        {
            var ev = new IntOrd();
            var intOrds = new[] {1, -4, 42, 12};
            var actual = Sort(intOrds, ev);
            var expected = new[] {-4, 1, 12, 42};
            Assert.IsTrue(ArrayEquals(actual, expected, ev));
        }

        [Test]
        public void StringOrdTest()
        {
            var ev = new StringOrd();
            var stringOrds = new[] {"a", "z", "e", "r"};
            var actual = Sort(stringOrds, ev);
            var expected = new[] {"a", "e", "r", "z"};
            Assert.IsTrue(ArrayEquals(actual, expected, ev));
        }
    }
}