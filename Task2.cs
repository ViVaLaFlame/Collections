using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Task2
{
    static void Main()
    {
        Console.Write("Введите путь до файла с текстом: ");
        string filePath = Console.ReadLine();

        if (File.Exists(filePath))
        {
            string text = File.ReadAllText(filePath);

            string[] words = text.Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            var wordFrequency = words.GroupBy(word => word)
                                    .ToDictionary(group => group.Key, group => group.Count());

            var sortedWords = wordFrequency.OrderByDescending(pair => pair.Value);

            int topWordsCount = 10;
            int count = 0;
            foreach (var pair in sortedWords)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value} раз");
                count++;

                if (count >= topWordsCount)
                    break;
            }
        }
        else
        {
            Console.WriteLine("Файл не найден.");
        }
    }
}
