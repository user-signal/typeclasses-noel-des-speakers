package net.sigusr.concept

import scala.collection.mutable.ArrayBuffer

object Algorithm {
  def Sort[T](source: Vector[T], ev: Ord[T]): Vector[T] = {
    val result = ArrayBuffer[T]()
    for (sourceElem <- source) {
      val position = result.indexWhere(sortedElem => ev.gt(sortedElem, sourceElem)) match {
        case -1 => result.length
        case p => p
      }
      result.insert(position, sourceElem)
    }
    result.toVector
  }

  def Equality[T](vector1 : Vector[T], vector2 : Vector[T], ev : Ord[T]): Boolean =
    vector1.length == vector2.length && vector1.zip(vector2).forall(p => ev.eq(p._1, p._2))
}
