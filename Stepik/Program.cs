using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Linq;

public class MainClass
{
    public static void Main(string[] args)
    {
        List<int> data = ReadInput();
        string result = Balance(data);
        Console.WriteLine(result);
    }

    public static string Balance(List<int> data)
    {
        int center = data.Count / 2;
        int left = 0;
        int right = 0;
        string result = "";

        for (int i = 0; i < center; i++)
            left += data[i];

        for (int i = center; i < data.Count; i++)
            right += data[i];

        if (left > right)
            result = "Левая сторона тяжелее";
        else if (right > left)
            result = "Правая сторона тяжелее";
        else
            result = "Обе стороны сбалансированы";

        return result;
    }

    public static List<int> ReadInput()
    {
        string input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<int>>(input.Trim());
    }
}