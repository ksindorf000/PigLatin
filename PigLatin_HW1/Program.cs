using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin_HW1
{
    class Program
    {
        static void Main(string[] args)
        {

            //bool isUserWrong = true;

            //while (isUserWrong)
            //{

            //    Console.WriteLine("Please enter a single word that contains" +
            //        " 5 characters or less: ");

            //    string userStr = Console.ReadLine();

            //    if (userStr.Length <= 5)
            //    {
            //        ChangeString(userStr);
            //        isUserWrong = false;
            //    }
            //    else
            //    {
            //        Console.WriteLine("String is not the right length." +
            //            " Please try again. ");
            //        Console.ReadLine();
            //        Console.Clear();
            //    };
            //}

            Console.WriteLine("Please enter your word or phrase: ");

            string userStr = Console.ReadLine();

            string lowerStr = userStr.ToLower();
            char[] vowelArray = { 'a', 'e', 'i', 'o', 'u' };

            foreach (string word in lowerStr.Split(' ')) {
                //If a word starts with a vowel, add the word "way" to the end of the word
                if (vowelArray.Contains<char>(word[0]))
                {
                    Console.Write(word + "way ");
                }

                //If a word starts with two consonants, move the two first letters
                //to the end of the word and add "ay"
                else if (!vowelArray.Contains<char>(word[0]) &&
                !vowelArray.Contains<char>(word[1]))
                {
                    Console.Write(word.Substring(2) + word[0] +
                        word[1] + "ay ");
                }

                //If a word starts with a consonant and a vowel, put the first letter at
                //the end of the word and add "ay"
                else if (!vowelArray.Contains<char>(word[0]) &&
                vowelArray.Contains<char>(word[1]))
                {
                    Console.Write(word.Substring(1) + word[0] + "ay ");
                }
            }

            Console.ReadLine();

        }
    }
}

