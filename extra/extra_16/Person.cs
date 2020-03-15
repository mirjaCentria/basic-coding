using System;
namespace extra_16
{

    public class Person
    {
        int age;
        string name;
        int height;
        int weight;

        public Person(string name)
        {
            this.name = name;
            this.age = 0;
            this.height = 0;
            this.weight = 0;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.height = 0;
            this.weight = 0;
        }

        public Person(string name, int age, int height, int weight)
        {
            this.name = name;
            this.age = age;
            this.height = height;
            this.weight = weight;
        }


        public override string ToString()
        {
            return this.name 
            + ", age " + this.age 
            + ", height " + this.height 
            + "cm, weight " + this.weight
            + "kg";
        }

        public void GrowOlder(int years)
        {
            this.age += years;
        }
    }
}