package net.sigusr.implicit0

import net.sigusr.implicit0.Algorithm.Sort

class OrdTest extends org.scalatest.funsuite.AnyFunSuite {
  
  test("IntOrd Test") {
    import net.sigusr.implicit0.instances.intOrd
    val intOrds = Vector(1, -4, 42, 12)
    val actual = Sort(intOrds)
    val expected = Vector(-4, 1, 12, 42)
    assert(Algorithm.ArrayEquals(actual, expected))
  }

  test("StringOrd Test") {
    import net.sigusr.implicit0.instances.stringOrd
    val stringOrds = Vector("a", "z", "e", "r")
    val actual = Sort(stringOrds)
    val expected = Vector("a", "e", "r", "z")
    assert(Algorithm.ArrayEquals(actual, expected))
  }
}
