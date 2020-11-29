namespace Typeclasses.Concept
{
    public interface Ordered<in T>
    {
        bool gt(T l, T r);
        bool eq(T @this, T that);
    }

    public class IntOrdered : Ordered<int>
    {
        public bool gt(int l, int r) => l > r;
        public bool eq(int @this, int that) => @this == that;
    }
    
    public class StringOrdered : Ordered<string>
    {
        public bool gt(string l, string r) => string.CompareOrdinal(l, r) > 0;
        public bool eq(string @this, string that) => string.CompareOrdinal(@this, that) == 0;
    }

    
    public class PairOrdered<A , B> : Ordered<(A, B)>
    {
        public Ordered<A> evA { get; set; }
        public Ordered<B> evB { get; set; }
        public bool gt((A, B) l, (A, B) r) => evA.gt(l.Item1, r.Item1) || (evA.eq(l.Item1, r.Item1) && evB.gt(l.Item2, r.Item2));
        public bool eq((A, B) l, (A, B) r) => evA.eq(l.Item1, r.Item1) && evB.eq(l.Item2, r.Item2);
    }
}