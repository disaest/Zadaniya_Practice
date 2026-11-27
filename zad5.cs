using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> words = new Dictionary<string, int>();

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Введите слово: ");
            string word = Console.ReadLine() ?? "";

            if (word.Length == 0)
            {
                Console.WriteLine("Слово не должно быть пустым.");
                i--;
                continue;
            }

            if (words.ContainsKey(word))
            {
                words[word]++;
            }
            else
            {
                words.Add(word, 1);
            }

            Console.WriteLine($"{{{word}:{words[word]}}}");
        }
    }
}
