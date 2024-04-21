using System.Text;

namespace DesignPatterns.Builder
{
    public class Product
    {
        public Product()
        {
            _parts = new List<string>();
        }

        private List<string> _parts;

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public string GetResult()
        {
            StringBuilder product = new();

            product.AppendLine("Product Components are:");
            for (int i = 0; i < _parts.Count; i++)
                product.AppendLine($"   [{i + 1}]. {_parts[i]}");

            return product.ToString();
        }
    }
}
