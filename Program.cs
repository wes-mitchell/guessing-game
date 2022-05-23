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
        int SecretNum = 51;
        if (int.Parse(response) == SecretNum)
        {
          i = 5;
          Console.WriteLine("Damn, you guessed the secret number!! See you next time. :) ");
        }
        else
        {
          if (i + 2 <= 4) 
          {
            Console.WriteLine("Bummer, try again. ");
          }  

          if (i + 2 < 5) 
          {
              Console.Write($"Guess Number ({i + 2}) => ");
          }
        }
    };
    }
  }
}

// Display the number of the user's current guess in the prompt. For example, if the user has already guessed one time, the prommpt should say something like Your guess (2)>.
// End the loop early if the user guesses the correct number.