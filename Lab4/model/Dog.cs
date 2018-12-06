using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.model
{
    public class Dog : Animal
    {
        public Dog()
        {
        }

        public Dog(string name) : base(name)
        {
        }

        public override string Run() => Name + " is runnig";

        public override string Voice() => Name + " says: Woof! Woof!";

        public virtual string Bite() => Name + " is biting you";

        public string Jump() => Name + " is jumping";

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
