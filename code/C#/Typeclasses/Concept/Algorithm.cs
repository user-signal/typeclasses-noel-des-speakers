using System.Linq;

namespace Typeclasses.Concept
{
    public static class Algorithm<T>
    {
        public static T[] Sort(T[] a, Ord<T> ev)
        {
            var result = new T[a.Length];
            for (var j = 0; j < a.Length; j++) {
                var key = a[j];
                var i = j-1;
                while (i > -1 && ev.gt(result[i], key)) {
                    result [i+1] = result[i];
                    i--;
                }
                result[i+1] = key;
            }
            return result;
        }

        public static bool ArrayEquals(T[] a, T[] b, Ord<T> ev) => 
            a.Length == b.Length && a.Zip(b).Aggregate(true, (acc, p) => acc && ev.eq(p.First, p.Second));
    }
}