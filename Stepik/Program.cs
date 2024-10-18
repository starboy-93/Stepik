using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

public class MainClass
{
    public static void Main(string[] args)
    {
        List<int> data = ReadInput();
        for (int i = 0; i < data.Count; i++)
            if (data[i] < 0)
                data[i] *= -1;

        int result = data.Sum();
        if (result > 5)
            if (result % 5 == 0)
                result += (result / 5) - 1;
            else
                result += (result / 5);

        Console.WriteLine(result);
    }


    public static List<int> ReadInput()
    {
        string input = Console.ReadLine();
        int[] dataArray = JsonSerializer.Deserialize<int[]>(input);
        return dataArray.ToList();
    }
}