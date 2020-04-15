using System;

namespace Exercise
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Person ada = new Person("Ada Lovelace", "24 Maddox St. London W1S 2QN");
      Person esko = new Person("Esko Ukkonen", "Mannerheimintie 15 00100 Helsinki");
      Student pelle = new Student();
      Console.WriteLine(ada);
      Console.WriteLine(esko);
      Console.WriteLine(pelle);

      Student ollie = new Student("Ollie", "6381 Hollywood Blvd. Los Angeles 90028");
      Console.WriteLine(ollie);
      ollie.Study();
      Console.WriteLine(ollie);
    }
  }
}
