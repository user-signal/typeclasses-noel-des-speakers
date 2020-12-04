using System.Collections.Generic;
using System.Linq;

namespace Typeclasses.Concept
{
    public static class Algorithm<T>
    {
        public static List<T> Sort(List<T> source, Ordered<T> ev)
        {
            var result = new List<T>();
            foreach (var s in source)
            {
                var position = result.FindIndex(r => ev.gt(r, s)) switch
                {
                    -1 => result.Count,
                    int p => p
                };
                result.Insert(position, s);
            }

            return result;
        }

        public static bool Equality(List<T> list1, List<T> list2, Ordered<T> ev) =>
            list1.Count == list2.Count &&
            list1.Zip(list2)
                .Aggregate(true, (acc, p) => acc && ev.eq(p.First, p.Second));
    }
}