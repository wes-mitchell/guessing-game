using System;

namespace GuessingGame
{
  class Program
  {
    static void Main(string[] args)
    {
        Console.WriteLine("Cann you guess the Secret Number? Choose your difficulty, 1 = \"Easy\" 2 = \"Medium\" 3 = \"Hard\" ");
        string difficultyResponse = Console.ReadLine();
        for (int i = 0; i < 4; i++) {
        string response = Console.ReadLine();
        Random r = new Random();
        int SecretNum = r.Next(1, 100);

        if (int.Parse(response) == SecretNum)
        {
          Console.WriteLine("Damn, you guessed the secret number!! See you next time. :) ");
          break;
        }
        else if (int.Parse(response) > SecretNum)
        {
          if (i + 2 <= 4) 
          {
            Console.WriteLine($"Bummer, try again. Your last guess, ({int.Parse(response)}) was too high.");
          }  

          if (i + 2 < 5) 
          {
            Console.Write($"You've got ({3 - i}) guesses left => ");
          }
        }
        else if (int.Parse(response) < SecretNum)
        {
                      if (i + 2 <= 4) 
          {
            Console.WriteLine($"Bummer, try again. Your last guess, ({int.Parse(response)}) was too low.");
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

// Prompt the user for a difficulty level before they are prompted to guess the number.
// The difficulty level should determine how many guesses the user gets. The difficulty levels should be:
// Easy - this gives the user eight guesses.
// Medium - this gives the user six guesses.
// Hard - this gives the user four guesses.