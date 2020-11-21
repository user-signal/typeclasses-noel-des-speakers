using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Typeclasses.Polymorphism
{
    [TestFixture]
    public class ShapeTest
    {
        [Test]
        public void Test()
        {
            var shapes = new List<Shape>()
            {
                new Square {Side = 2.0}, new Circle {Radius = 4.0}
            };
            var actual = shapes.Aggregate(0d, (acc, shape) => acc + shape.Area);
            Assert.AreEqual(54.26548245743669, actual);
        }
    }
}