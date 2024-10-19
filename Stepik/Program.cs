using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

public class MainClass
{
    public static void Main(string[] args)
    {
        List<List<int>> data = ReadInput();
        bool result = IsValidPool(data);
        Console.WriteLine(result.ToString().ToLower());
    }

    public static bool IsValidPool(List<List<int>> data)
    {
        foreach (var row in data)
            if (row[0] == 1 || row[row.Count - 1] == 1)
                return false;

        if (data.ElementAt(0).Contains(1) || data.ElementAt(data.Count - 1).Contains(1))
            return false;
        return true;
    }

    public static List<List<int>> ReadInput()
    {
        string input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<List<int>>>(input);
    }
}