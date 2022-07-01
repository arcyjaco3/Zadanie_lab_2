using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Buyer : Person
    {
        public Buyer(string name, int age) : base(name, age) { }

        public List<Product> Products = new List<Product>();

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public override void Print()
        {
            Console.WriteLine($"Buyer: {this.Name} ({this.Age} y.o.)");
            foreach (Product product in Products)
            {
                product.Print("");
            }
        }
    }
}
