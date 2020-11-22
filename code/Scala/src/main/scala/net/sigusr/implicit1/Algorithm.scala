package net.sigusr.implicit1

import scala.collection.mutable.ArrayBuffer

object Algorithm {
  def Sort[T : Ord](a: Vector[T]): Vector[T] = {
    val result = ArrayBuffer.from(a)
    for (j <- a.indices) {
      val key = a(j)
      var i = j - 1
      while (i > -1 && implicitly[Ord[T]].gt(result(i), key)) {
        result(i + 1) = result(i);
        i = i - 1;
      }
      result(i + 1) = key;
    }
    result;
  }.toVector

  def ArrayEquals[T : Ord](a : Vector[T], b : Vector[T]): Boolean =
    a.length == b.length && a.zip(b).forall(p => implicitly[Ord[T]].eq(p._1, p._2))
}
