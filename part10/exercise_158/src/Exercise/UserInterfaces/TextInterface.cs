namespace Exercise
{
  using System;
  using System.Collections.Generic;
  public class TextInterface
  {
    // Create the userinterface here
    public List<Book> books;
  
    public TextInterface()
    {
       this.books = new List<Book>();
    }

    public void Start()
    {
      Book item;
      string name = ""; 
      string line = "";
      int age = 0;
      while(true)
      {
        System.Console.WriteLine("Input the name of the book, empty stops:");
        name = System.Console.ReadLine();
        if(name == "") {break;}
        System.Console.WriteLine("Input the age recommendation:");
        line = System.Console.ReadLine();  
        age =  Convert.ToInt32(line);     
        item = new Book(name, age);
        books.Add(item);
      }

      System.Console.WriteLine("{0} books in total.", books.Count);
      System.Console.WriteLine("Books:");       

      books.Sort();
      foreach(Book iitem in books)
      {
        System.Console.WriteLine(iitem.ToString());
      }
      
    }
  }
}