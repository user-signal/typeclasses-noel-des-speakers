package net.sigusr.implicit1

import scala.collection.mutable.ArrayBuffer

object Algorithm {
  def Sort[T : Ordered](source: Vector[T]): Vector[T] = {
    val result = ArrayBuffer[T]()
    for (s <- source) {
      val position = result.indexWhere(r => implicitly[Ordered[T]].gt(r, s)) match {
        case -1 => result.length
        case p => p
      }
      result.insert(position, s)
    }
    result.toVector
  }
  
  def Equality[T : Ordered](vector1 : Vector[T], vector2 : Vector[T]): Boolean =
    vector1.length == vector2.length &&
      vector1.zip(vector2).forall(p => implicitly[Ordered[T]].eq(p._1, p._2))
}
