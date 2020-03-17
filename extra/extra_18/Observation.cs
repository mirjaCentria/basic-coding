using System;

namespace extra_18
{
    public class Observation
    {
        Bird bird;

        public Observation(Bird bird)
        {
            this.bird = bird;
        }

        public override string ToString()
        {
            return  this.bird.ToString();
        }

    }


}