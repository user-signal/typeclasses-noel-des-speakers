using System.Collections.Generic;
using System.Linq;

namespace Typeclasses.Concept
{
    public static class Algorithm
    {
        public static List<T> Sort<T>(List<T> source, Ordered<T> model)
        {
            var result = new List<T>();
            foreach (var s in source)
            {
                var position = result.FindIndex(r => model.gt(r, s)) switch
                {
                    -1 => result.Count,
                    int p => p
                };
                result.Insert(position, s);
            }

            return result;
        }

        public static bool Equality<T>(List<T> list1, List<T> list2, Ordered<T> model) =>
            list1.Count == list2.Count && list1.Zip(list2).All(p => model.eq(p.First, p.Second));
    }
}