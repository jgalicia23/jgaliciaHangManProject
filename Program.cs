using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManProject2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hangman!");
            Console.WriteLine("Choose your words carefully");

            //available words
            string[] wordList = new string[] { "flowers", "garden", "ocean", "crimson", "thorn", "sunflower" };

            Random rand = new Random();
            int word = rand.Next(wordList.Length);

            string wordToGuess = wordList[word];

            //Random rnd = new Random();
            //int index = rnd.Next(wordList.Length);
            //string word = wordList[index];
            //lives count
            int lives = 7;
            Console.WriteLine("You have " + lives + " lives left.");

            if (lives <= 0)
            {
                Console.WriteLine("You lost! The word was " + word);
            }

            //call out function for each word
            foreach (char ch in wordToGuess)
            {
                Console.Write("_");
                //Console.Write(ch);
            }
            int wordToGuessLength = wordToGuess.Length;
            char[] answerBook = new char[wordToGuessLength];

            for (int answerBookIndex = 0; answerBookIndex < answerBook.Length; answerBookIndex++)
            {
                answerBook[answerBookIndex] = '_';
            }

            while (true)
            {
                //for (int answerBookIndex = 0; answerBookIndex < answerBook.Length; answerBookIndex++)

                string playerInput = Console.ReadLine();

                if (playerInput != null && wordToGuess.Contains(playerInput[0]))
                {
                    Console.WriteLine("Correct!");

                    int currentIndex = wordToGuess.IndexOf(playerInput[0]);
                    answerBook[currentIndex] = playerInput[0];
                }

                else
                {
                    Console.WriteLine("Incorrect!");
                    lives--;
                    Console.WriteLine("You have " + lives + " lives left.");
                }

                if (Array.IndexOf(answerBook, '_') == -1)
                {
                    Console.WriteLine("You won!");
                    break;
                }

            }
        }
    }
}
