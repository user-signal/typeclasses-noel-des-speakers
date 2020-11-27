package net.sigusr.implicit1

import scala.collection.mutable.ArrayBuffer

object Algorithm {
  def Sort[T : Ord](source: Vector[T]): Vector[T] = {
    val result = ArrayBuffer[T]()
    for (source_elem <- source) {
      val position = result.indexWhere(sorted_elem => implicitly[Ord[T]].gt(sorted_elem, source_elem)) match {
        case -1 => result.length
        case p => p
      }
      result.insert(position, source_elem)
    }
    result.toVector
  }
  
  def Equality[T : Ord](vector1 : Vector[T], vector2 : Vector[T]): Boolean =
    vector1.length == vector2.length && vector1.zip(vector2).forall(p => implicitly[Ord[T]].eq(p._1, p._2))
}
