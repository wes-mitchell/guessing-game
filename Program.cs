using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yo, can you guess the secret number???");
            string response = Console.ReadLine();
            int SecretNum = 51;
            if (int.Parse(response) == SecretNum) 
            {
                Console.Write("Damn, you guess the secret number!! Nice :) ");
            }
            else 
            {
                Console.Write("Bummer, better luck next time. :( ");
            }
        }
    }
}


// Create a variable to contain the secret number. This number should be hard-coded for now. 42 is a nice number.
// No longer display the user's guess. They know what they guessed, right?
// Compare the user's guess with the secret number. Display a success message if the guess is correct, otherwise display a failure message.
