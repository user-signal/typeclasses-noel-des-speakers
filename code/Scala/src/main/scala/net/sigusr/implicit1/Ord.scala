package net.sigusr.implicit1

sealed trait Ord[-T] {
  def gt(l: T, r: T): Boolean
  def eq(l: T, r: T): Boolean
}

object instances {
  implicit val intOrd: Ord[Int] = new Ord[Int] {
    override def gt(l: Int, r: Int): Boolean = l > r
    override def eq(l: Int, r: Int): Boolean = l == r
  }

  implicit val stringOrd: Ord[String] = new Ord[String] {
    override def gt(l: String, r: String): Boolean = l > r
    override def eq(l: String, r: String): Boolean = l == r
  } 
}

