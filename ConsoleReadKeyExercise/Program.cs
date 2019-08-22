using System;
using System.Collections.Generic;

namespace ConsoleReadKeyExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo enteredKey;

            do
            {
                enteredKey = Console.ReadKey();
                Console.WriteLine($"You pressed the {enteredKey.Key.ToString()} key");

            } while (enteredKey.Key != ConsoleKey.Escape);

            string sentence;

            do
            {
                Console.WriteLine("Type in a sentence. Press enter when done.");
                sentence = Console.ReadLine();
                Console.WriteLine($"You entered the sentence: {sentence}");

            } while (sentence != "quit");

        }
    }
}
