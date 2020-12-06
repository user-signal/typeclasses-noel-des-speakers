package net.sigusr.implicit1

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

  implicit def PairOrd[A, B](implicit modelA: Ordered[A], modelB: Ordered[B]): Ordered[(A, B)] = new Ordered[(A, B)] {
    override def gt(l: (A, B), r: (A, B)): Boolean = 
      modelA.gt(l._1, r._1) || 
        (modelA.eq(l._1, r._1) && modelB.gt(l._2, r._2))
    override def eq(l: (A, B), r: (A, B)): Boolean = modelA.eq(l._1, r._1) && modelB.eq(l._2, r._2)
  }
}

