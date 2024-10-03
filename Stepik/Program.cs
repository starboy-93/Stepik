using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

public class MainClass
{
    public static void Main(string[] args)
    {
        List<int> data = ReadInput();
        List<int> result = data.Select(x => x * -1).ToList();
        Console.WriteLine(JsonSerializer.Serialize(result));
    }

    public static List<int> ReadInput()
    {
        string input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<int>>(input.Trim());
    }
}