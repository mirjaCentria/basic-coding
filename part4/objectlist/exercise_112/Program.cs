using System;
using System.Collections.Generic;

namespace exercise_112
{
  class Program
  {
    public static void Main(string[] args)
    {
      // IMPLEMENT YOUR CODE IN HERE!
     // TelevisionProgram(string name, int duration)

      List<TelevisionProgram> list = new List<TelevisionProgram>();
      string nameanswer;
      int timeanswer, limitanswer;
      string nameQuestion = "Name: ";
      string timeQuestion = "Duration: ";
      string limitQuestion = "Program's maximum duration? ";
         
      while (true )     
      {
        Console.Write(nameQuestion);
        nameanswer = Console.ReadLine();  
        if(nameanswer == "") break;

        Console.Write(timeQuestion);
        timeanswer = Convert.ToInt32(Console.ReadLine());  

        TelevisionProgram newItem = 
          new TelevisionProgram(nameanswer, timeanswer);
        list.Add(newItem);
      }

      Console.WriteLine();
      Console.Write(limitQuestion);
      limitanswer = Convert.ToInt32(Console.ReadLine()); 
      
      foreach(TelevisionProgram item in list)
      {
        if(item.duration <= limitanswer)
         Console.WriteLine(item.name + ", " + item.duration + " minutes");
      }

    }
  }
}




