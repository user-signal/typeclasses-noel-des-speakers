namespace Typeclasses.Concept
{
    public interface Ordered<in T>
    {
        bool gt(T l, T r);
        bool eq(T l, T r);
    }

    public class IntOrdered : Ordered<int>
    {
        public bool gt(int l, int r) => l > r;
        public bool eq(int l, int r) => l == r;
    }
    
    public class StringOrdered : Ordered<string>
    {
        public bool gt(string l, string r) => string.CompareOrdinal(l, r) > 0;
        public bool eq(string l, string r) => string.CompareOrdinal(l, r) == 0;
    }

    
    public class PairOrdered<A , B> : Ordered<(A, B)>
    {
        public Ordered<A> modelA { get; set; }
        public Ordered<B> modelB { get; set; }
        
        public bool gt((A, B) l, (A, B) r) => 
            modelA.gt(l.Item1, r.Item1) || 
            modelA.eq(l.Item1, r.Item1) && modelB.gt(l.Item2, r.Item2);
        public bool eq((A, B) l, (A, B) r) => 
            modelA.eq(l.Item1, r.Item1) && modelB.eq(l.Item2, r.Item2);
    }
}