using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

public class MainClass
{
    public static void Main(string[] args)
    {
        List<int> data = ReadInput();
        int result = FindLongestSeries(data);
        Console.WriteLine(result);
    }

    public static int FindLongestSeries(List<int> data)
    {
        int counter = 1;
        var l = new List<int>();
        for (int i = 0; i < data.Count - 1; i++)
        {
            if (data[i] < data[i+1])
                counter++;
            else
            {
                l.Add(counter);
                counter = 1;
            }
            l.Add(counter);
        }
        return l.Max();
    }

    public static List<int> ReadInput()
    {
        string input = Console.ReadLine();
        int[] dataArray = JsonSerializer.Deserialize<int[]>(input);
        return dataArray.ToList();
    }
}