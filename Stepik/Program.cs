using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

public class MainClass
{
    public static void Main(string[] args)
    {
        List<List<int>> data = ReadInput();
        List<int> result = RowSum(data);
        Console.WriteLine(JsonSerializer.Serialize(result));
    }

    public static List<int> RowSum(List<List<int>> data)
    {
        var res = new List<int>();

        foreach (var list in data)
            res.Add(list.Sum());
        return res;
    }

    public static List<List<int>> ReadInput()
    {
        string input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<List<int>>>(input.Trim());
    }
}