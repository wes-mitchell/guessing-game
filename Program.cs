using System;

namespace GuessingGame
{
  class Program
  {
    static void Main(string[] args)
    {
        Console.WriteLine("Yo, can you guess the secret number???");
        for (int i = 0; i < 4; i++) {
        string response = Console.ReadLine();
        int SecretNum = 51;
        if (int.Parse(response) == SecretNum)
        {
          i = 5;
          Console.WriteLine("Damn, you guessed the secret number!! See you next time. :) ");
        }
        else
        {
          Console.WriteLine("Bummer, try again. :( ");
        }
    };
    }
  }
}

// Give the user four chances to guess the number.
// Continue to display the success or failure messages as in phase 2