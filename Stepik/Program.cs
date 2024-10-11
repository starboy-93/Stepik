using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;


public class MainClass
{
    public static void Main(string[] args)
    {
        int length = ReadInput();
        List<int> result = GenerateList(length);
        Console.WriteLine(JsonSerializer.Serialize(result));
    }

    public static List<int> GenerateList(int length)
    {
        var list = new List<int>();
        for (int i = length; i >= 1; i--)
            list.Add(i * 3);

        return list;
    }

    public static int ReadInput()
    {
        string input = Console.ReadLine();
        return int.Parse(input.Trim());
    }
}