using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

public class MainClass
{
    public static void Main(string[] args)
    {
        List<int> prices = ReadInput();
        int result = CalculateDifference(prices);
        Console.WriteLine(result);
    }

    public static int CalculateDifference(List<int> prices)
    {
        for (int i = 0; i < prices.Count; i++)
            if (i % 2 == 0)
                prices[i] = prices[i] * -1;
        return prices.Sum();
    }

    public static List<int> ReadInput()
    {
        string input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<int>>(input.Trim());
    }
}