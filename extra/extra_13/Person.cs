using System;
namespace extra_13
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

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
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