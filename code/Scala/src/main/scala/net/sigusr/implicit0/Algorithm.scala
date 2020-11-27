package net.sigusr.implicit0

import scala.collection.mutable.ArrayBuffer

object Algorithm {
  def Sort[T](source: Vector[T])(implicit ev: Ordered[T]): Vector[T] = {
    val result = ArrayBuffer[T]()
    for (source_elem <- source) {
      val position = result.indexWhere(sorted_elem => ev.gt(sorted_elem, source_elem)) match {
        case -1 => result.length
        case p => p
      }
      result.insert(position, source_elem)
    }
    result.toVector
  }

  def Equality[T](vector1 : Vector[T], vector2 : Vector[T])(implicit ev : Ordered[T]): Boolean =
    vector1.length == vector2.length && vector1.zip(vector2).forall(p => ev.eq(p._1, p._2))
}
