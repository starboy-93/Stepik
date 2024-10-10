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
        var numbers = data.Select(x => x.ToString());
        var arr = string.Join("", numbers).Split('1');
        return $"Количество нулей перед единицей: {arr[0].Count()}, Количество нулей после единицы: {arr[1].Count()}";
    }

    public static List<int> ReadInput()
    {
        string input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<int>>(input.Trim());
    }
}