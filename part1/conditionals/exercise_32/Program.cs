using System;

namespace exercise_32
{
  class Program
  {
    public static void Main(string[] args)
    {
          string sPrompt = "Speak, friend, and enter!";
          string sAnswer = "Mellon";
          string sFail = "They've got a cave troll!";
          string sWelcome ="Welcome, friend!";
          string sRequest ="";
    
          Console.WriteLine(sPrompt);
          sRequest = Console.ReadLine();

          if(sRequest == sAnswer) Console.WriteLine(sWelcome);
            else Console.WriteLine(sFail);

    }
  }
}
