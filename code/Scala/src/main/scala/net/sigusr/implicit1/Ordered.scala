package net.sigusr.implicit1

sealed trait Ordered[-T] {
  def gt(l: T, r: T): Boolean
  def eq(l: T, r: T): Boolean
}

object instances {
  implicit val intOrd: Ordered[Int] = new Ordered[Int] {
    override def gt(l: Int, r: Int): Boolean = l > r
    override def eq(l: Int, r: Int): Boolean = l == r
  }

  implicit val stringOrd: Ordered[String] = new Ordered[String] {
    override def gt(l: String, r: String): Boolean = l > r
    override def eq(l: String, r: String): Boolean = l == r
  } 
}

