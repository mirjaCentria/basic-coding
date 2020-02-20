using System;

namespace exercise_120
{
    public class Cube
    {
        private int edgeLength;

        public Cube (int edgeLength) 
        {
            this.edgeLength = edgeLength;
        }

        public int Volume() 
        {
            return (int)Math.Pow(this.edgeLength,3);
        }

        public override string ToString() 
        {
            string line = "The length of the edge is " + this.edgeLength.ToString() + 
                " and the volume " + this.Volume().ToString();
            return line;
        }
    }
}