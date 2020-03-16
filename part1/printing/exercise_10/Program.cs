using System;

namespace exercise_10
{
    class Program
    {
        public static void Main(string[] args)
        {
           string sPrompt = "I will tell a story, but I need some information.";
           string sName = "Give a name for main character:";
           string sProfession = "Give the character a profession:";
           string name ="";
           string profession ="";
 
            Console.WriteLine(sPrompt);

            Console.WriteLine(sName);
            name = Console.ReadLine();
            
            Console.WriteLine(sProfession);
            profession = Console.ReadLine();

            Console.WriteLine("Here is the story:\nOnce upon a time there was a " + profession
                + " called " + name + "\nOn her way to work, " + name + " often pondered what being "
                + profession + " meant to them.\nWhen you work as a " + profession + " you meet interesting people.\n" 
                + name + " enjoys their work as " + profession + ", The end.");

            /*//// This works but the test did not like it            
            string sStory = $"Here is the story:\nOnce upon a time there was a {profession} called {name}\nOn her way to work, {name} often pondered what being {profession} meant to them. \nWhen you work as a {profession} you meet interesting people.\n{name} enjoys their work as {profession}, The end.";
            Console.WriteLine(sStory);*/
            ////
        }
    }
}
