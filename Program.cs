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
        int SecretNum = r.Next(0, 100);
        if (int.Parse(response) == SecretNum)
        {
          i = 5;
          Console.WriteLine("Damn, you guessed the secret number!! See you next time. :) ");
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

// Display the number of the user's current guess in the prompt. For example, if the user has already guessed one time, the prommpt should say something like Your guess (2)>.
// End the loop early if the user guesses the correct number.