using System;

namespace GuessingGame
{
  class Program
  {
    static void Main(string[] args)
    {
        Console.WriteLine("Yo, can you guess the secret number??? You've got four shots.");

        for (int i = 0; i < 4; i++) {
        string response = Console.ReadLine();
        Random r = new Random();
        int SecretNum = r.Next(1, 100);
        if (int.Parse(response) == SecretNum)
        {
          Console.WriteLine("Damn, you guessed the secret number!! See you next time. :) ");
          break;
        }
        else
        {
          if (i + 2 <= 4) 
          {
            Console.WriteLine($"Bummer, try again. Your last guess was ({int.Parse(response)})");
          }  

          if (i + 2 < 5) 
          {
            Console.Write($"You've got ({3 - i}) guesses left => ");
          }
        }
    };
    }
  }
}

// Inform the user if their guess was too high or too low, when they guess incorrectly.