namespace Open_Closed_Principle
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }

    public class CololourSpecification : ISpecification<Product>
    {
        private readonly Colour colour;

        public CololourSpecification(Colour colour)
        {
            this.colour = colour;
        }

        public bool IsSatisfied(Product t)
        {
            return t.Colour == colour;
        }
    }

    public class SizeSpecification : ISpecification<Product>
    {
        private readonly Size size;

        public SizeSpecification(Size size)
        {
            this.size = size;
        }

        public bool IsSatisfied(Product t)
        {
            return t.Size == size;
        }
    }

    public class AndSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> first;
        private readonly ISpecification<T> second;

        public AndSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            this.first = first;
            this.second = second;
        }

        public bool IsSatisfied(T t)
        {
            return first.IsSatisfied(t) && second.IsSatisfied(t);
        }
    }
}