namespace Typeclasses.Concept
{
    public interface Ordered<in T>
    {
        bool gt(T @this, T that);
        bool eq(T @this, T that);
    }

    public class IntOrdered : Ordered<int>
    {
        public bool gt(int @this, int that) => @this > that;
        public bool eq(int @this, int that) => @this == that;
    }
    
    public class StringOrdered : Ordered<string>
    {
        public bool gt(string @this, string that) => string.CompareOrdinal(@this, that) > 0;
        public bool eq(string @this, string that) => string.CompareOrdinal(@this, that) == 0;
    }
}