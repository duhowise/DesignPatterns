namespace Open_Closed_Principle
{
    internal partial class Program
    {
        private static void Main(string[] args)
        {
            var apple = new Product("Apple", Colour.Green, Size.Small);
            var tree = new Product("Tree", Colour.Green, Size.Large);
            var house = new Product("House", Colour.Blue, Size.Large);

            Product[] products = { apple, tree, house };
            var productFilter = new ProductFilter();
            System.Console.WriteLine("Green products (old):");
            foreach (var product in productFilter.FilterByColour(products, Colour.Green))
            {
                System.Console.WriteLine($" - {product.Name} is {product.Colour}");
            }

            var betterFilter = new BetterFilter();
            System.Console.WriteLine("GreenProducts (new)");
            foreach (var item in betterFilter.Filter(products, new CololourSpecification(Colour.Green)))
            {
                System.Console.WriteLine($" - {item.Name} is {item.Colour}");
            }

            System.Console.WriteLine("For large blue items");
            foreach (var item in betterFilter.Filter(products, new AndSpecification<Product>(new CololourSpecification(Colour.Blue), new SizeSpecification(Size.Large))))
            {
                System.Console.WriteLine($" - {item.Name} is {item.Colour}");
            }

            System.Console.ReadLine();
        }
    }
}