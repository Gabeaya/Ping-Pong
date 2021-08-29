using System;
using System.Collections.Generic;

public class Program{

  public static void Main()
  {
    Console.WriteLine("Give me a number:");
    string stringNumber = Console.ReadLine();
    int intNumber = int.Parse(stringNumber);

    Console.WriteLine("Here's your Ping Pong number:");
    for (int number=1; number<=intNumber; number++){
      if (number % 3 == 0)
      {
        Console.WriteLine("ping");
      }
      else if(number % 5 == 0)
      {
        Console.WriteLine("pong");
      }
      else if(number % 3 == 0 && number % 5 ==0 )
      {
        Console.WriteLine("ping-pong");
      } else
      {
        Console.WriteLine(number);
      }

    }
  }

}