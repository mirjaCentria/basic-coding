using System;
namespace extra_12
{

    public class Person
    {
        int age;
        string name;

        public Person(string name)
        {
            this.name = name;
            this.age = 0;
        }

        public override string ToString()
        {
            return this.name + ", age " + this.age;
        }

        public void GrowOlder(int years)
        {
            this.age += years;
        }
    }
}