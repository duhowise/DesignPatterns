namespace Open_Closed_Principle
{
    public class Product
    {
        public string Name;
        public Colour Colour;
        public Size Size;

        public Product(string name, Colour colour, Size size)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new System.ArgumentException("message", nameof(name));
            }
            Name = name;
            Colour = colour;
            Size = size;
        }
    }
}