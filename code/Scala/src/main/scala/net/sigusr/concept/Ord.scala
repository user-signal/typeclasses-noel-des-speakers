package net.sigusr.concept

sealed trait Ord[-T] {
  def gt(l: T, r: T): Boolean
  def eq(l: T, r: T): Boolean
}

object IntOrd extends Ord[Int] {
  override def gt(l: Int, r: Int): Boolean = l > r
  override def eq(l: Int, r: Int): Boolean = l == r
}

object StringOrd extends Ord[String] {
  override def gt(l: String, r: String): Boolean = l > r
  override def eq(l: String, r: String): Boolean = l == r
}

