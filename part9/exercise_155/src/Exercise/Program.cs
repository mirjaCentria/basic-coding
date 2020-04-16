using System;

namespace Exercise
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Dog dog = new Dog();
      dog.Bark();
      dog.Eat();
      dog.Sleep();

      Dog fido = new Dog("Fido");
      fido.Bark();
      fido.Eat();
      fido.Sleep();

      Console.WriteLine();

      Cat cat = new Cat();
      cat.Purr();
      cat.Eat();
      cat.Sleep();

      Cat garfield = new Cat("Garfield");
      garfield.Purr();
      garfield.Eat();
      garfield.Sleep();

      Console.WriteLine();

      INoiseCapable noisyDog = new Dog();
      noisyDog.MakeNoise();
      INoiseCapable snoopy = new Dog("Snoopy");
      snoopy.MakeNoise();

      INoiseCapable noisyCat = new Cat("Garfield");
      noisyCat.MakeNoise();
      INoiseCapable justCat = new Cat();
      justCat.MakeNoise();

      Cat c = (Cat)noisyCat;
      c.Purr();
    }
  }
}
