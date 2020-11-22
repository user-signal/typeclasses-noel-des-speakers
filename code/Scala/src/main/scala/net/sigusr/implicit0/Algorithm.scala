package net.sigusr.implicit0

import scala.collection.mutable.ArrayBuffer

object Algorithm {
  def Sort[T](a: Vector[T])(implicit ev: Ord[T]): Vector[T] = {
    val result = ArrayBuffer.from(a)
    for (j <- a.indices) {
      val key = a(j)
      var i = j - 1
      while (i > -1 && ev.gt(result(i), key)) {
        result(i + 1) = result(i);
        i = i - 1;
      }
      result(i + 1) = key;
    }
    result;
  }.toVector

  def ArrayEquals[T](a : Vector[T], b : Vector[T])(implicit ev : Ord[T]): Boolean =
    a.length == b.length && a.zip(b).forall(p => ev.eq(p._1, p._2))
}
