using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

public class MainClass
{
    public static void Main(string[] args)
    {
        List<double> data = ReadInput();
        string result = CountNumbers(data);
        Console.WriteLine(result);
    }

    public static string CountNumbers(List<double> data)
    {
        int uniqueCount = data.GroupBy(n => n)
                                  .Where(g => g.Count() == 1)
                                  .Select(g => new { Value = g.Key }).Count(); ;
        int duplicateCount = data.GroupBy(n => n)
                                  .Where(g => g.Count() > 1)
                                  .Select(g => new { Value = g.Key }).Count();
        int zeroCount = data.Count(x => x == 0);
        int evenCount = data.Count(x => x % 2 == 0 && x != 0);
        int oddCount = data.Count(x => x % 2 != 0);
        return string.Join(", ", uniqueCount, duplicateCount, zeroCount, evenCount, oddCount);
    }

    public static List<double> ReadInput()
    {
        string input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<double>>(input);
    }
}