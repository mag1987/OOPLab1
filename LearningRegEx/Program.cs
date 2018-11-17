using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LearningRegEx
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Если эта проблема возникла раньше, позвоните по телефону 896 товарищам разработчикам.";
            string s2 = "Если эта проблема возникла раньше, позвоните по телефону (не знаю какому) товарищам разработчикам.";

            Console.WriteLine("{0} {1}", s1, hasDigital(s1));
            Console.WriteLine("{0} {1}", s2, hasDigital(s2));
        }
        static string hasDigital(string s)
        {
            return Regex.IsMatch(s, @"\d") ? 
                "В строке содержатся цифры"
                :"В строке нет цифр";
        }
    }
}
