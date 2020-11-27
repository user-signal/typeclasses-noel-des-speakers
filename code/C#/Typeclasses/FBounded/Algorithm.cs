using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Typeclasses.FBounded
{
    public static class Algorithm<T> where T : Ord<T>
    {
        public static List<T> Sort(List<T> source)
        {
            var result = new List<T>();
            foreach (var sourceElem in source)
            {
                var position = result.FindIndex(sortedElem => sortedElem.gt(sourceElem)) switch
                {
                    -1 => result.Count,
                    int p => p
                };
                result.Insert(position, sourceElem);
            }
            return result;
        }

        public static bool Equality(List<T> list1, List<T> list2) => 
            list1.Count == list2.Count && list1.Zip(list2).Aggregate(true, (acc, p) => acc && p.First.eq(p.Second));
    }
}