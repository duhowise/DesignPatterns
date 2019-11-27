using System.Collections.Generic;

namespace Open_Closed_Principle
{
    public class ProductFilter
    {
        public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            foreach (var product in products)
            {
                if (product.Size == size)
                {
                    yield return product;
                }
            }
        }

        public IEnumerable<Product> FilterByColour(IEnumerable<Product> products, Colour colour)
        {
            foreach (var product in products)
            {
                if (product.Colour == colour)
                {
                    yield return product;
                }
            }
        }

        public IEnumerable<Product> FilterBySizeAndColour(IEnumerable<Product> products, Colour colour, Size size)
        {
            foreach (var product in products)
            {
                if (product.Colour == colour && product.Size == size)
                {
                    yield return product;
                }
            }
        }
    }
}