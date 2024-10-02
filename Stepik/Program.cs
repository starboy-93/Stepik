using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

public class MainClass
{
    public static void Main(string[] args)
    {
        List<int> data = ReadInput();
        var result = data.FirstOrDefault(x => x < 0);

        Console.WriteLine(JsonSerializer.Serialize(result));
    }

    public static List<int> ReadInput()
    {
        string input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<int>>(input.Trim());
    }
}