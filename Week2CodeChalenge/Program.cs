using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2CodeChalenge
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 21; i++)
            {
                FizzBuzz(i);
            }

            Console.WriteLine();
            LetterCounter('i', "I love biscuits and gravy. It's the best brekfast ever.");
            LetterCounter('n', "Never gonna give you up. Never gonna let you down.");
            LetterCounter('s', "Sally sells seashells down by the seashore. She's from Sussex.");

            Console.WriteLine();
            TextStats("The monkey jumped over the dog. A cat is being lazy and fat. That cloud is shaped like a spaceship.");

            Console.ReadKey();
        }

        static void FizzBuzz(int number)
        {
            if (number % 5 == 0 && number % 3 == 0)
            {
                Console.WriteLine("Fizz Buzz");
            } 
            else if (number % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(number);
            }
        }
        static void LetterCounter(char letter, string inString)
        {
            
            int lowCount = 0;
            int upCount = 0;

            for (int i = 0; i < inString.Length; i++)
            {
                if (inString[i] == (char.ToLower(letter)))
                {
                    lowCount++;
                }
                else if (inString[i] == (char.ToUpper(letter)))
                {
                    upCount++;
                }
            }
             int total = lowCount + upCount;

            
            Console.WriteLine("Input: " + inString +
                "\n" + "Number of lowercase " + letter + "'s found: " + lowCount +
                "\n" + "Number of UPPERCASE " + letter + "'s found: " + upCount +
                "\n" + "Total Number of " + letter + "'s found: " + total);
        }
        static void TextStats(string input)
        {
            Console.WriteLine("Original input; " + input);

            // number of characters  it can be int numberOfCaracters = input.Length;
            Console.WriteLine("Number of caracters: " + input.Length);
            //number of words
            Console.WriteLine("# of words: " + input.Split(' ').Length);

            int numVowels = 0;
            int numCons = 0;
            int specChars = 0;
            var numChar = input.Length;
            var numCharSplit = input.Split(' ');
            var numWords = numCharSplit.Length;

            var biggestWord = "";
            var shortestWord = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
            
            
            for (int i = 0; i < numCharSplit.Length; i++)
            {

                if (numCharSplit[i].Length > biggestWord.Length)
                {
                    biggestWord = numCharSplit[i];
                }
            }

            for (int i = 0; i < numCharSplit.Length; i++)
            {
                if (numCharSplit[i].Length < shortestWord.Length)
                {
                    shortestWord = numCharSplit[i];
                }
            }
            
            for (int i = 0; i < input.Length; i++)
            {   
                //grrabing one letter from the string
                // by it's index
                char letter = input[i];
                //number of vowels
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    //found a vowel! add 1 to the vowel count
                    numVowels = numVowels + 1;
                }
                else if (letter == '.' || letter == ' ' || letter == ',')
                //number of special characters
                {
                    specChars = specChars + 1;
                }
                //number of constinants
                else
                {
                    numCons = numCons + 1;
                }
                
            }

            //output number of vowels, cons, 
            // and 
            Console.WriteLine("# of vowels: " + numVowels);
            Console.WriteLine("# of consonants: " + numCons);
            Console.WriteLine("# of special characters: " + specChars);
            Console.WriteLine("Shortest word: " + shortestWord);
            Console.WriteLine("Longest word: " + biggestWord);
        }
    }
}
