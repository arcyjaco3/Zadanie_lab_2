using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class Person
    {
        protected string name;
        protected int age;

        public string Name { get => this.name; }
        public int Age { get => this.age; }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }


        public virtual void Print()
        {
            Console.WriteLine($"Details - name: {this.name}, age: {this.age}");
        }

    }
}
