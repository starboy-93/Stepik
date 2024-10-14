using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;

public class MainClass
{
    public static void Main(string[] args)
    {
        List<int> data = ReadInput();
        int result = FindMostFrequentElement(data);
        Console.WriteLine(result);
    }

    public static int FindMostFrequentElement(List<int> data)
    {
        return data.GroupBy(n => n).OrderByDescending(g => g.Count()).FirstOrDefault().Key;
    }

    public static List<int> ReadInput()
    {
        string input = Console.ReadLine();
        int[] dataArray = JsonSerializer.Deserialize<int[]>(input);
        return dataArray.ToList();
    }
}