using System;

namespace extra_18
{
    public class Bird
    {
        private string name;
        private string latinName;
        private int observations;


        public Bird(string name, string latinName)
        {
            this.name = name;
            this.latinName = latinName;
            observations = 0;
        }

        public  string GetName()
        {
            return this.name;
        }

        public override string ToString()
        {
            return this.name + " (" 
             + this.latinName + "): " + this.observations 
             + " observations";
        }

        public void AddObservation()
        {
            this.observations++;
        }
    }
}