using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string message1 = Console.ReadLine();

        Console.WriteLine(CanEqualizeCharacterCounts(message1).ToString().ToLower());
    }

    static bool CanEqualizeCharacterCounts(string message)
    {
        // Проходим по каждому символу и симулируем его удаление
        for (int i = 0; i < message.Length; i++)
        {
            char charToRemove = message[i];
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            // Подсчитываем количество оставшихся символов после удаления
            for (int j = 0; j < message.Length; j++)
            {
                if (j != i) // Пропускаем удаляемый символ
                {
                    if (charCount.ContainsKey(message[j]))
                    {
                        charCount[message[j]]++;
                    }
                    else
                    {
                        charCount[message[j]] = 1;
                    }
                }
            }

            // Проверяем, равны ли все количества оставшихся символов
            if (charCount.Values.Distinct().Count() == 1)
            {
                return true; // Найдено удаление, которое уравнивает количества
            }
        }

        return false; // Не найдено подходящее удаление, которое уравнивает количества
    }
}