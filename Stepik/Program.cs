using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

public class MainClass
{
    public static void Main(string[] args)
    {
        (List<List<int>> intervals, int point) = ReadInput();
        int result = 0;

        foreach (var arr in intervals)
        { 
            var start = arr[0];
            var finish = arr[arr.Count - 1];
            for (int i = start; i <= finish; i++)
                if (i == point)
                    result++;
        }
        Console.WriteLine(result);
    }

    public static (List<List<int>> intervals, int point) ReadInput()
    {
        string input = Console.ReadLine();

        string[] values = input.Split(" | ");

        List<List<int>> intervals = JsonSerializer.Deserialize<List<List<int>>>(values[0]);
        int point = int.Parse(values[1]);

        return (intervals, point);
    }
}