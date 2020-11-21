namespace Typeclasses.FBounded
{
    public interface Ord<in T>
    {
        bool gt(T that);
        bool eq(T that);
    }

    public class IntOrd : Ord<IntOrd>
    {
        public int Value { get; set; }

        public bool gt(IntOrd that) => this.Value > that.Value;
        public bool eq(IntOrd that) => this.Value == that.Value;
    }
    
    public class StringOrd : Ord<StringOrd>
    {
        public string Value { get; set; }

        public bool gt(StringOrd that) => string.CompareOrdinal(this.Value, that.Value) > 0;
        public bool eq(StringOrd that) => string.CompareOrdinal(this.Value, that.Value) == 0;
    }
}