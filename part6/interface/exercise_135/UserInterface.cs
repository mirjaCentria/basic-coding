namespace exercise_135
{
  using System;
  public class UserInterface
  {
    private JokeManager jokemanager;

    public UserInterface(JokeManager jokemanager)
    {
      this.jokemanager = jokemanager;
    }

    public void Start()
    { 
      while (true)
      {
        Console.WriteLine("Commands:");
        Console.WriteLine(" 1 - add a joke");
        Console.WriteLine(" 2 - draw a joke");
        Console.WriteLine(" 3 - list jokes");
        Console.WriteLine(" X - stop");

        string command = Console.ReadLine();

        if (command == "X" || command == "x") 
        {
          break;
        }

        if (command == "1")
        {
          Console.WriteLine("Write the joke to be added:");
          string joke = Console.ReadLine();
          this.jokemanager.AddJoke(joke);
        }
        else if (command == "2")
        {
          Console.WriteLine("Drawing a joke.");
          Console.WriteLine(this.jokemanager.DrawJoke());
        }
        else if (command == "3")
        {
          Console.WriteLine("Printing the jokes.");
          this.jokemanager.PrintJokes();
        }
      }
    }
   }
  }