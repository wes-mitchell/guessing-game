using System;

namespace GuessingGame
{
  class Program
  {
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Secret Number game!"); 
        Console.WriteLine("Choose your difficulty: ");
        Console.Write("");
        Console.WriteLine("(1) : Easy");
        Console.WriteLine("(2) : Medium");
        Console.WriteLine("(3) : Hard");
        int diffResponse = int.Parse(Console.ReadLine());
        int guesses = 0;
        Random r = new Random();
        int secretNum = r.Next(1, 101);

        if (diffResponse == 1) 
        {
            guesses = 8;
        }
        else if (diffResponse == 2)
        {
            guesses = 6;
        } 
        else if (diffResponse == 3)
        {
            guesses = 4;
        }
        else 
        {
            Console.WriteLine("Hmmmm, try again next time.");
        }

        while (guesses != 0)
        {
            Console.Write("Guess the secret number...");
            int response = int.Parse(Console.ReadLine());

        if (guesses == 1)
        {
            Console.WriteLine("");
            Console.WriteLine($"Try again next time! The Secret Number was {secretNum}");
            break;
        }
        else if (response == secretNum)
        {
            Console.WriteLine("Damn, you guessed the secret number!! See you next time. :) ");
            break;
        }
        else if ((response > secretNum) && guesses != 1 )
        {
            Console.WriteLine($"Bummer, try again. Your last guess, ( {response} ) was too high.");
            Console.Write($"You've got ({guesses - 1}) guesses left => ");
        }  
        else if ((response < secretNum) && guesses != 1 )
        {
            Console.WriteLine($"Bummer, try again. Your last guess, ( {response} ) was too low.");
            Console.Write($"You've got ({guesses - 1}) guesses left => ");
        }
            guesses--;
        }
    }
    }
  }