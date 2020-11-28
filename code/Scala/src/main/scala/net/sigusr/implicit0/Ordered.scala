package net.sigusr.implicit0

sealed trait Ordered[-T] {
  def gt(l: T, r: T): Boolean
  def eq(l: T, r: T): Boolean
}

object instances {
  implicit object IntOrd extends Ordered[Int] {
    override def gt(l: Int, r: Int): Boolean = l > r
    override def eq(l: Int, r: Int): Boolean = l == r
  }

  implicit object StringOrd extends Ordered[String] {
    override def gt(l: String, r: String): Boolean = l > r
    override def eq(l: String, r: String): Boolean = l == r
  } 
}

