using System;
using System.Collections.Generic;
using System.Text.Json;

public class MainClass
{
    public static void Main(string[] args)
    {
        int n = ReadInput();
        List<string> result = GenerateList(n);
        Console.WriteLine(JsonSerializer.Serialize(result));
    }

    public static List<string> GenerateList(int n)
    {
        var result = new List<string>();
        if (n == 1)
            result.Add(new string('#', n));
        else if (n == 2)
        {
            result.Add(new string('#', n));
            result.Add(new string('#', n));
        }
        else
        {
            result.Add(new string('#', n));
            for (int i = 0; i < n - 2; i++)
                result.Add('#' + new string(' ', n - 2) + '#');
            result.Add(new string('#', n));
        } 
        return result;
    }

    public static int ReadInput()
    {
        string input = Console.ReadLine();
        return int.Parse(input.Trim());
    }
}