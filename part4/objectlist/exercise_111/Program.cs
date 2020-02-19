using System;
using System.Collections.Generic;

namespace exercise_111
{
  class Program
  {
    public static void Main(string[] args)
    {
      // IMPLEMENT YOUR CODE IN HERE! 
      List<PersonalInformation> list = new List<PersonalInformation>();
      string firstanswer, lastanswer, idanswer;
      string firstQuestion = "First name:";
      string lastQuestion = "Last name:";
      string idQuestion = "Identification number:";
     
      while (true )     
      {
        Console.WriteLine(firstQuestion);
        firstanswer = Console.ReadLine();  
        if(firstanswer == "") break;

        Console.WriteLine(lastQuestion);
        lastanswer = Console.ReadLine();  
        if(lastanswer == "") break;

        Console.WriteLine(idQuestion);
        idanswer = Console.ReadLine();  
        if(idanswer == "") break;

        PersonalInformation newItem = 
          new PersonalInformation(firstanswer, lastanswer, idanswer);
        list.Add(newItem);
      }

      Console.WriteLine();
      
      foreach(PersonalInformation item in list)
      {
         Console.WriteLine(item.firstName + " " + item.lastName);
      }
    }
  }
}




