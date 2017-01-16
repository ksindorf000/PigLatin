using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PigLatin_HW1
{
    class Program
    {
        static void Main(string[] args)
        {

            bool userStop = true;

            while (userStop)
            {

                Console.WriteLine("Please enter your word or phrase: ");
                string userStr = Console.ReadLine();

                string noSpecials = RemoveSpecials(userStr);

                string lowerStr = noSpecials.ToLower();

                char[] vowelArray = { 'a', 'e', 'i', 'o', 'u' };

                foreach (string word in lowerStr.Split(' '))
                {

                    //If a word starts with a vowel, add the word "way" to the end of the word
                    if (vowelArray.Contains(word[0]))
                    {
                        Console.Write(word + "way ");
                    }

                    //If a word starts with two consonants, move the two first letters
                    //to the end of the word and add "ay"
                    else if (!vowelArray.Contains(word[0]) &&
                    !vowelArray.Contains(word[1]))
                    {
                        Console.Write(word.Substring(2) + word[0] +
                            word[1] + "ay ");
                    }

                    //If a word starts with a consonant and a vowel, put the first letter at
                    //the end of the word and add "ay"
                    else if (!vowelArray.Contains(word[0]) &&
                    vowelArray.Contains(word[1]))
                    {
                        Console.Write(word.Substring(1) + word[0] + "ay ");
                    }

                }

                Console.WriteLine();

                Console.WriteLine("Enter 'STOP' to exit. Enter 'AGAIN' to continue.");
                string again = Console.ReadLine();

                if (again.ToUpper() == "STOP")
                {
                    userStop = false;
                }

            }
        }

        public static string RemoveSpecials(string userStr)
        {
            userStr = userStr.Replace("!", "");
            userStr = userStr.Replace(".", "");
            userStr = userStr.Replace("'", "");
            userStr = userStr.Replace("\"", "");
            return userStr;
        }
    }
}

