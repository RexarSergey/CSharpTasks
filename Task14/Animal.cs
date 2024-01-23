using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    internal abstract class Animal
    {
        public abstract string Name { get; set; }

        public Animal(string name = "None")
        {
            Name = name;
        }

        public abstract string Say();
        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Say());
        }
    }

    internal class Cat : Animal
    {
        private string name_;
        public override string Name 
        { 
            get => name_; 
            set => name_ = value; 
        }

        public Cat(string name)
            :base(name) 
        {}

        public override string Say()
        {
            return "Мяу";
        }
    }

    internal class Dog : Animal
    {
        private string name_;
        public override string Name
        {
            get => name_;
            set => name_ = value;
        }

        public Dog(string name)
            : base(name)
        { }

        public override string Say()
        {
            return "Гав";
        }
    }
}
