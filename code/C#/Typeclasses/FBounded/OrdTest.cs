using NUnit.Framework;
using static Typeclasses.FBounded.Algorithm<Typeclasses.FBounded.StringOrd>;
using static Typeclasses.FBounded.Algorithm<Typeclasses.FBounded.IntOrd>;

namespace Typeclasses.FBounded
{
    [TestFixture]
    public class OrdTest
    {
        [Test]
        public void IntOrdTest()
        {
            var intOrds = new[] {new IntOrd {Value = 1}, new IntOrd {Value = -4}, new IntOrd {Value = 42}, new IntOrd {Value = 12}};
            var actual = Sort(intOrds);
            var expected = new[] {new IntOrd {Value = -4}, new IntOrd {Value = 1}, new IntOrd {Value = 12}, new IntOrd {Value = 42}};
            Assert.IsTrue(ArrayEquals(actual, expected));
        }

        [Test]
        public void StringOrdTest()
        {
            var stringOrds = new[] {new StringOrd {Value = "a"}, new StringOrd {Value = "z"}, new StringOrd {Value = "e"}, new StringOrd {Value = "r"}};
            var actual = Sort(stringOrds);
            var expected = new[] {new StringOrd {Value = "a"}, new StringOrd {Value = "e"}, new StringOrd {Value = "r"}, new StringOrd {Value = "z"}};
            Assert.IsTrue(ArrayEquals(actual, expected));
        }
    }
}