using System;
using System.Collections.Generic;


namespace extra_17
{
  class Program
  {
    public static void Main(string[] args)
    {
      string id = "";
      string name = "";      
      List<Person> persons = new List<Person>();
      bool fSkip = false;

      while(true)
      {     
        System.Console.WriteLine("Identifying number?");
        id = System.Console.ReadLine();
        if(id == "") break;       
        foreach(Person person in persons)
        {
          if(id.Equals(person.GetId()))
          {
            System.Console.WriteLine("The id already exists!");
            fSkip = true; 
            break;
          }
        } 

        if(!fSkip)  
        {
          System.Console.WriteLine("Name? (empty will stop):");    
          name = System.Console.ReadLine();
          if(name == "") break; 

          persons.Add(new Person(id, name));
        }
        else fSkip = false;
        if(name == "") break;

      }

      foreach(Person person in persons)
      {
        System.Console.WriteLine(person.IdNameToString());
      }
    }
  }
}
