using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LearningStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string outString;

            string stringPart1 = "Жили-были дед, да баба? Ели";
            string stringPart2 = " кашу с молоком, особенно дед. Дед ";
            string stringPart3 = "на бабу рассердился и пошел кодить на сях.";

            StringBuilder tmp = new StringBuilder();
            tmp.Append(stringPart1);
            tmp.Append(stringPart2);
            tmp.Append(stringPart3);

            Console.WriteLine(tmp);

            string[] sentences = Regex.Split(tmp.ToString(), @"[\.!\?]+");
            
            for (int i =0; i< sentences.Length; i++)
            {
                sentences[i] = Regex.Replace(sentences[i], @"[,;:]*", "");
            }
            
            Console.WriteLine(sentences[0]);
            Console.WriteLine(sentences[1]);
            Console.WriteLine(sentences[2]);

            Console.WriteLine(CommonWord(sentences[0],sentences[2]));

            Console.WriteLine(sentences.Length);
            Console.WriteLine(String.Compare("половник","пол",true));
            Console.WriteLine(String.Compare("пол", "половина", true));
            Console.WriteLine(String.Compare("пОл", "пол", true));
            Console.WriteLine(String.Compare("пол", "пол", true));
            


        }

        static string CommonWord(string a, string b)
        {
            string[] wordsA = Regex.Replace(a, @"[,;:]*", "").Split(' ');
            string[] wordsB = Regex.Replace(b, @"[,;:]*", "").Split(' ');
            string word;
            for (int i = 0; i< wordsA.Length; i++)
            {
                word = wordsA[i];
                for (int j =0; j<wordsB.Length; j++)
                {
                    if (String.Compare(word, wordsB[j], true) == 0)
                        return word;
                }
            }
            return null;
        }
        static string CommonWord(string[] sentences)
        {
            string word = null;
            if (sentences.Length > 1)
            {
                word = CommonWord(sentences[0], sentences[1]);
            }
            for (int i = 2; i < sentences.Length && word != null; i++)
            {
                word = CommonWord(word, sentences[i]);
            }
            
            if (word == null)
                return "Общего слова не найдено";
            else
            
                return word;
        }
    }
}
