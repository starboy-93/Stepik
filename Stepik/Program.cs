using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

public class MainClass
{
    public static void Main(string[] args)
    {
        (List<string> classifications, List<int> prices) = ReadInput();

        List<int> result = Prices(classifications, prices);

        Console.WriteLine(JsonSerializer.Serialize(result));
    }

    public static List<int> Prices(List<string> classifications, List<int> prices)
    {
        var s1 = 0;
        var s2 = 0;


        for (int i = 0; i < classifications.Count; i++)
        {
            if (classifications[i] == "S")
                s1 += prices[i];
            else
            {
                s1 += prices[i] / 2;
                s2 += prices[i] / 2;
            }
        }

        return new List<int> { s1, s2 };
    }

    public static (List<string>, List<int>) ReadInput()
    {
        string input = Console.ReadLine();

        string[] values = input.Split(" | ");

        List<string> classifications = JsonSerializer.Deserialize<List<string>>(values[0]);
        List<int> prices = JsonSerializer.Deserialize<List<int>>(values[1]);

        return (classifications, prices);
    }
}