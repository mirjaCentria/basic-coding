using System;

namespace exercise_124
{
    public class NullObject
    {
        int value;

        public NullObject(int value)
        {
            this.value = value;
        }

        public void ChangeValue(int newValue)
        {
            this.value = newValue;
        }
    }

}