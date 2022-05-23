using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yo, can you guess the secret number???");
            string response = Console.ReadLine();
            Console.WriteLine($"You guessed {response}.");
        }
    }
}



// Display a message to the user asking them to guess the secret number.
// Display a prompt for the user's guess.
// Take the user's guess as input and save it as a variable.
// Display the user's guess back to the screen.
