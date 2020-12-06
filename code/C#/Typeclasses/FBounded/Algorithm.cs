using System.Collections.Generic;
using System.Linq;

namespace Typeclasses.FBounded
{
    public static class Algorithm<T> where T : Ordered<T>
    {
        public static List<T> Sort(List<T> source)
        {
            var result = new List<T>();
            foreach (var s in source)
            {
                var position = result.FindIndex(r => r.gt(s)) switch
                {
                    -1 => result.Count,
                    int p => p
                };
                result.Insert(position, s);
            }

            return result;
        }

        public static bool Equality(List<T> list1, List<T> list2) =>
            list1.Count == list2.Count && list1.Zip(list2).All(p => p.First.eq(p.Second));
    }
}