package net.sigusr.concept

import net.sigusr.concept.Algorithm.Sort

class OrdTest extends org.scalatest.funsuite.AnyFunSuite {
  
  test("IntOrd Test") {
    val intOrds = Vector(1, -4, 42, 12)
    val actual = Sort(intOrds, IntOrd)
    val expected = Vector(-4, 1, 12, 42)
    assert(Algorithm.ArrayEquals(actual, expected, IntOrd))
  }

  test("StringOrd Test") {
    val stringOrds = Vector("a", "z", "e", "r")
    val actual = Sort(stringOrds, StringOrd)
    val expected = Vector("a", "e", "r", "z")
    assert(Algorithm.ArrayEquals(actual, expected, StringOrd))
  }
}
