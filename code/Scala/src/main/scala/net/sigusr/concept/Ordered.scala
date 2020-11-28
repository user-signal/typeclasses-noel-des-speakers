package net.sigusr.concept

sealed trait Ordered[-T] {
  def gt(l: T, r: T): Boolean
  def eq(l: T, r: T): Boolean
}

object instances {
  object IntOrd extends Ordered[Int] {
    override def gt(l: Int, r: Int): Boolean = l > r
    override def eq(l: Int, r: Int): Boolean = l == r
  }

  object StringOrd extends Ordered[String] {
    override def gt(l: String, r: String): Boolean = l > r
    override def eq(l: String, r: String): Boolean = l == r
  }
}

