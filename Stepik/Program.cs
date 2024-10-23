using System;
using System.Collections.Generic;
using System.Text.Json;

public class MainClass
{
    public static void Main(string[] args)
    {
        List<int> numbers = ReadInput();
        int result = 0;
        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        for (int i = 1; i < numbers.Count; i++)
            if (!numbers.Contains(i))
            {
                result = i;
                break;
            }
        Console.WriteLine(alphabet[result - 1]);
    }

    public static List<int> ReadInput()
    {
        List<int> numbers = null;

        string input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input))
        {
            numbers = JsonSerializer.Deserialize<List<int>>(input);
        }

        return numbers ?? new List<int>();
    }
}