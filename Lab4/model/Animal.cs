using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.model
{
    public abstract class Animal
    {
        private String name;

        public Animal()
        {
        }

        public Animal(string name) 
        {
            Name = name;
        }

        public string Name { get => name; set => name = value; }

        public abstract String Voice();

        public abstract String Run();

        public override bool Equals(object obj)
        {
            var animal = obj as Animal;
            return animal != null &&
                   Name == animal.Name;
        }

        public override int GetHashCode() => 539060726 + EqualityComparer<string>.Default.GetHashCode(Name);

        public override string ToString() => $"Animal: Name: {Name};";
    }
}
