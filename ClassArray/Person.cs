
using System.Reflection.Metadata.Ecma335;

namespace Person1
{/* 
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    } */

    public class Person (string name, int age)
    {
        public string Name { get; } = name;

        public int Age { get; } = age;

        public override string ToString()
        {
            return $"Name: {Name} Age: {Age}";
        }
    }

}
