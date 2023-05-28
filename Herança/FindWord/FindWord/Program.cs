using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your word:");
            string word = Console.ReadLine();
            verifyWord(word);
            Console.WriteLine();
            Console.ReadKey();
        }
        public static void verifyWord(string word)
        {
            bool result = false;

            string initWorld = word.Substring(0, (word.Length / 2) + 1);
            string finalWorld = word.Substring(word.Length / 2);

            char[] firstSide = initWorld.ToCharArray();
            Array.Reverse(firstSide);
            if (initWorld  == finalWorld || finalWorld == initWorld )
            {
                result = true;
            }
            Console.WriteLine("The palindromo word is: " + result);
        }
    }
}
