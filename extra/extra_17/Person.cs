using System;
namespace extra_17
{

    public class Person
    {
        int age;
        string name;
        string idnumber; 
        int height;
        int weight;

        public string GetId()
        {
            return this.idnumber;
        }

        public Person(string name)
        {
            this.name = name;
            this.idnumber = "";
            this.age = 0;
            this.height = 0;
            this.weight = 0;
        }

        public Person(string id, String name)
        {
            this.idnumber = id;
            this.name = name;
            this.age = 0;
            this.height = 0;
            this.weight = 0;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.idnumber = "";
            this.age = age;
            this.height = 0;
            this.weight = 0;
        }

        public Person(string name, int age, int height, int weight)
        {
            this.name = name;
            this.idnumber = "";
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

        public string IdNameToString()
        {
            return this.idnumber + ": " + this.name;
        }

        public void GrowOlder(int years)
        {
            this.age += years;
        }
    }
}