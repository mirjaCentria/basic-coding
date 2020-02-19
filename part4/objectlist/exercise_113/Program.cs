using System;
using System.Collections.Generic;

namespace exercise_113
{
  class Program
  {
    public static void Main(string[] args)
    {
      // IMPLEMENT YOUR CODE IN HERE!
      // Remember also to create the file Book.cs and class in it!

      List<Book> list = new List<Book>();
      string nameanswer, printanswer;
      int pagesanswer, yearanswer;
      string nameQuestion = "Name: ";
      string pagesQuestion = "Pages: ";
      string yearQuestion = "Publication year: ";
      string printQuestion = "What information will be printed? ";
             
      while (true )     
      {
        Console.Write(nameQuestion);
        nameanswer = Console.ReadLine();  
        if(nameanswer == "") break;

        Console.Write(pagesQuestion);
        pagesanswer = Convert.ToInt32(Console.ReadLine());  

        Console.Write(yearQuestion);
        yearanswer = Convert.ToInt32(Console.ReadLine());  

        Book newItem = 
          new Book(nameanswer, pagesanswer, yearanswer);
        list.Add(newItem);
      }

      Console.WriteLine();
      Console.Write(printQuestion);
      printanswer = Console.ReadLine(); 

      if(printanswer == "everything")
      {      
        foreach(Book item in list)
        {
          Console.WriteLine(item.title + ", " + item.pages + " pages, " + item.year);
        }
      } 
      else if(printanswer == "title")
      {
        foreach(Book item in list)
        {
          Console.WriteLine(item.title);
        }
      }    
    }
  }
}




