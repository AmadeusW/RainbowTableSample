using System;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace RainbowTableSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int alphabetLength = 25;
            int indexOfA = 97;
            List<char> alphabet = new List<char>(alphabetLength);
            for (int i = indexOfA; i < indexOfA + alphabetLength; i++)
            {
                var letter = (char)i;
                Console.WriteLine(letter);
                alphabet.Add(letter);
            }

            int wordLength = 6;
            int p = 0;
            int maxPermutations = (int)Math.Pow(alphabetLength, wordLength);
            char[] word = new char[wordLength];

            var start = DateTime.Now;

            var sha = SHA256.Create();
            int counter = 0;
            var q = from c1 in alphabet
                    from c2 in alphabet
                    from c3 in alphabet
                    from c4 in alphabet
                    from c5 in alphabet
                    from c6 in alphabet
                    select new char[]
                      { c1, c2, c3, c4, c5, c6 };
            foreach (var w in q)
            {
                var bytes = Encoding.UTF8.GetBytes(w);
                var hash = sha.ComputeHash(bytes);
                if (counter % 1000 == 0)
                    Console.WriteLine($"{counter}/{maxPermutations}");
                counter++;
            }

            var stop = DateTime.Now;
            Console.WriteLine((stop - start).TotalSeconds);
            /*
            do
            {
                for (int letter = 0; letter < wordLength; letter++)
                {
                    var letterCeiling = Math.Pow(alphabetLength, letter);
                    var c = (int)(p / letterCeiling);
                    var r = p - letterCeiling;
                    var c2 = p % Math.Pow(alphabetLength, letter);
                    word[letter] = (char)(c + indexOfA);
                }
                Console.WriteLine(word);
            }
            while (p++ < maxPermutations);
            */
            Console.ReadLine();
        }


    }
}
