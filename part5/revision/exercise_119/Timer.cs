using System;

namespace exercise_119
{
    public class Timer
    {
        private ClockHand seconds;
        private ClockHand hundreds;

        public Timer()
        {           
            this.seconds = new ClockHand(60);
            this.hundreds = new ClockHand(100);
        }

        public void Advance()
        {
            this.hundreds.Advance();
            if(this.hundreds.value == 0) this.seconds.Advance();
        }

        public override string ToString()
        {
            string line = this.seconds.ToString() + ":" + this.hundreds.ToString();
            return line;
        } 
    }

}