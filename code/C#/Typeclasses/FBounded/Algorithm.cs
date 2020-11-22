using System.Collections.Generic;
using System.Linq;

namespace Typeclasses.FBounded
{
    public static class Algorithm<T> where T : Ord<T>
    {
        public static T[] Sort(T[] a)
        {
            var result = new T[a.Length];
            for (var j = 0; j < a.Length; j++) {
                var key = a[j];
                var i = j-1;
                while (i > -1 && result[i].gt(key)) {
                    result [i+1] = result[i];
                    i--;
                }
                result[i+1] = key;
            }
            return result;
        }

        public static bool ArrayEquals(T[] a, T[] b) => 
            a.Length == b.Length && a.Zip(b).Aggregate(true, (acc, p) => acc && p.First.eq(p.Second));
    }
}