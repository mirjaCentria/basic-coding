using System;

namespace exercise_01
{
    class Program
    {
        public static void Main(string[] args)
        {
            BirdDatabase db = new BirdDatabase();
            UserInterface ui = new UserInterface(db);
            ui.Start();
            
        }
    }
}
