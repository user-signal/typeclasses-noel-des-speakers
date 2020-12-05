using System.Collections.Generic;
using NUnit.Framework;
using static Typeclasses.FBounded.Algorithm<Typeclasses.FBounded.StringOrdered>;
using static Typeclasses.FBounded.Algorithm<Typeclasses.FBounded.IntOrdered>;

namespace Typeclasses.FBounded
{
    [TestFixture]
    public class OrdTest
    {
        [Test]
        public void IntOrdTest()
        {
            var intOrds = new List<IntOrdered>
            {
                new IntOrdered {Value = 1}, 
                new IntOrdered {Value = -4}, 
                new IntOrdered {Value = 42}, 
                new IntOrdered {Value = 12}
            };
            var actual = Sort(intOrds);
            var expected = new List<IntOrdered>
            {
                new IntOrdered {Value = -4}, 
                new IntOrdered {Value = 1}, 
                new IntOrdered {Value = 12}, 
                new IntOrdered {Value = 42}
            };
            Assert.IsTrue(Equality(actual, expected));
        }

        [Test]
        public void StringOrdTest()
        {
            var stringOrds = new List<StringOrdered>
            {
                new StringOrdered {Value = "a"}, 
                new StringOrdered {Value = "z"}, 
                new StringOrdered {Value = "e"}, 
                new StringOrdered {Value = "r"}
            };
            var actual = Sort(stringOrds);
            var expected = new List<StringOrdered>
            {
                new StringOrdered {Value = "a"}, 
                new StringOrdered {Value = "e"}, 
                new StringOrdered {Value = "r"}, 
                new StringOrdered {Value = "z"}
            };
            Assert.IsTrue(Equality(actual, expected));
        }
    }
}