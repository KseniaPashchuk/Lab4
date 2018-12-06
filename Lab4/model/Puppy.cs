using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.model
{
    public class Puppy : Dog
    {
        public Puppy()
        {
        }

        public Puppy(string Name) : base(Name)
        {
        }

        public override string Voice() => Name + " says: Aw! Aw!";
        public override string Bite() => Name + " is tweaking you";

        public override bool Equals(object obj)
        {
            var dog = obj as Dog;
            return dog != null &&
                   Name == dog.Name;
        }

        public override int GetHashCode() => base.GetHashCode();

        public override string ToString() => $"Dog: Name: {Name};";
    }
}
