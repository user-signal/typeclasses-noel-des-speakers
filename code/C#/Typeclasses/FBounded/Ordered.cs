namespace Typeclasses.FBounded
{
    public interface Ordered<in T>
    {
        bool gt(T that);
        bool eq(T that);
    }

    public class IntOrdered : Ordered<IntOrdered>
    {
        public int Value { get; set; }

        public bool gt(IntOrdered that) => this.Value > that.Value;
        public bool eq(IntOrdered that) => this.Value == that.Value;
    }
    
    public class StringOrdered : Ordered<StringOrdered>
    {
        public string Value { get; set; }

        public bool gt(StringOrdered that) => string.CompareOrdinal(this.Value, that.Value) > 0;
        public bool eq(StringOrdered that) => string.CompareOrdinal(this.Value, that.Value) == 0;
    }
}