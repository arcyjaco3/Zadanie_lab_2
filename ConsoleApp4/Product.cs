using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class Product
    {
        protected string name;

        public string Name { get => this.name; }

        public virtual void Print(string prefix)
        {
            Console.WriteLine($"Details - name: {name}.");
        }
    }
}
