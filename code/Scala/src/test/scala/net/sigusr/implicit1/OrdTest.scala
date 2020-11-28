package net.sigusr.implicit1

import net.sigusr.implicit1.Algorithm.Sort

class OrdTest extends org.scalatest.funsuite.AnyFunSuite {
  
  test("IntOrd Test") {
    import net.sigusr.implicit1.instances.IntOrd
    val intOrds = Vector(1, -4, 42, 12)
    val actual = Sort(intOrds)
    val expected = Vector(-4, 1, 12, 42)
    assert(Algorithm.Equality(actual, expected))
  }

  test("StringOrd Test") {
    import net.sigusr.implicit1.instances.StringOrd
    val stringOrds = Vector("a", "z", "e", "r")
    val actual = Sort(stringOrds)
    val expected = Vector("a", "e", "r", "z")
    assert(Algorithm.Equality(actual, expected))
  }

  test("PairOrd Test") {
    import net.sigusr.implicit1.instances.{IntOrd, PairOrd, StringOrd}
    val pairOrds = Vector((1, "a"), (-4, "z"), (-4, "e"), (42, "r"))
    val actual = Sort(pairOrds)
    val expected = Vector((-4, "e"), (-4, "z"), (1, "a"), (42, "r"))
    assert(Algorithm.Equality(actual, expected))
  }
}
