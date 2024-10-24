using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;

public class MainClass
{
    public static void Main(string[] args)
    {
        (List<string> data, string order) = ReadInput();
        List<string> result = CustomSort(data, order);

        JsonSerializerOptions options = new JsonSerializerOptions
        {
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            WriteIndented = false
        };

        Console.WriteLine(JsonSerializer.Serialize(result, options));
    }

    public static List<string> CustomSort(List<string> data, string order)
    {
        var result = new List<string>();
        var temp = new List<char>();
        if (order == "ASC")
            foreach (string item in data)
            {
                temp = item.ToList();
                temp.Sort();
                result.Add(string.Join("", temp));
            }
        else
            foreach (string item in data)
            {
                temp = item.ToList();
                temp.Sort();
                temp.Reverse();
                result.Add(string.Join("", temp));
            }
        return result;
    }

    public static (List<string>, string) ReadInput()
    {
        string input = Console.ReadLine();
        string[] parts = input.Split(" | ");
        List<string> data = JsonSerializer.Deserialize<List<string>>(parts[0]);
        string order = parts[1].Trim();
        return (data, order);
    }
}