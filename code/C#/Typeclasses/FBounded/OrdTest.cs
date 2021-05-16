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
                new() {Value = 1}, 
                new() {Value = -4}, 
                new() {Value = 42}, 
                new() {Value = 12}
            };
            var actual = Sort(intOrds);
            var expected = new List<IntOrdered>
            {
                new() {Value = -4}, 
                new() {Value = 1}, 
                new() {Value = 12}, 
                new() {Value = 42}
            };
            Assert.IsTrue(Equality(actual, expected));
        }

        [Test]
        public void StringOrdTest()
        {
            var stringOrds = new List<StringOrdered>
            {
                new() {Value = "a"}, 
                new() {Value = "z"}, 
                new() {Value = "e"}, 
                new() {Value = "r"}
            };
            var actual = Sort(stringOrds);
            var expected = new List<StringOrdered>
            {
                new() {Value = "a"}, 
                new() {Value = "e"}, 
                new() {Value = "r"}, 
                new() {Value = "z"}
            };
            Assert.IsTrue(Equality(actual, expected));
        }
    }
}