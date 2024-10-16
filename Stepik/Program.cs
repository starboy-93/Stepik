using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

public class MainClass
{
    public static void Main(string[] args)
    {
        List<int> data = ReadInput();
        int result = FindSeriesCount(data);
        Console.WriteLine(result);
    }

    public static int FindSeriesCount(List<int> data)
    {
        return Enumerable.Range(1, data.Count - 1).Where(x => data[x] == data[x - 1]).Count(); 
    }

    public static List<int> ReadInput()
    {
        string input = Console.ReadLine();
        int[] dataArray = JsonSerializer.Deserialize<int[]>(input);
        return dataArray.ToList();
    }
}