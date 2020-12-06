package net.sigusr.implicit0

import scala.collection.mutable.ArrayBuffer

object Algorithm {
  def Sort[T](source: Vector[T])(implicit model: Ordered[T]): Vector[T] = {
    val result = ArrayBuffer[T]()
    for (s <- source) {
      val position = result.indexWhere(r => model.gt(r, s)) match {
        case -1 => result.length
        case p => p
      }
      result.insert(position, s)
    }
    result.toVector
  }

  def Equality[T](vector1 : Vector[T], vector2 : Vector[T])(implicit model : Ordered[T]): Boolean =
    vector1.length == vector2.length && 
      vector1.zip(vector2).forall(p => model.eq(p._1, p._2))
}
