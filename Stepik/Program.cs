using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

public class MainClass
{
    public static void Main(string[] args)
    {
        List<int> data = ReadInput();
        string result = CountZerosBeforeAndAfter(data);
        Console.WriteLine(result);
    }

    public static string CountZerosBeforeAndAfter(List<int> data)
    {
        var index = data.FindIndex(x => x == 1);
        var before = Enumerable.Range(0, data.Count()).Where(x => x < data.IndexOf(1) && data[x] == 0).Count();
        var after = Enumerable.Range(0, data.Count()).Where(x => x > data.IndexOf(1) && data[x] == 0).Count();
        return $"Количество нулей перед единицей: {before}, Количество нулей после единицы: {after}";
    }

    public static List<int> ReadInput()
    {
        string input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<int>>(input.Trim());
    }
}