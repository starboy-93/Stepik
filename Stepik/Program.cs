using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

public class MainClass
{
    public static void Main(string[] args)
    {
        List<string> data = ReadInput();
        var result = data.Where(x => x.EndsWith(".png"));

        Console.WriteLine(JsonSerializer.Serialize(result));
    }


    public static List<string> ReadInput()
    {
        string input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<string>>(input.Trim());
    }
}