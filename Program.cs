using System;
using System.Collections.Generic;

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
            Console.ReadLine();
        }
    }
}
