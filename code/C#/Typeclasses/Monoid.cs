namespace Typeclasses
{
    public interface Monoid<T>
    {
        public T Empty { get; }
        public T Add(T other);
    }
    
    public class IntMonoid : 
}