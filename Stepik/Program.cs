using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
public class MainClass
{
    public static void Main(string[] args)
    {
        List<List<int>> data = ReadInput();
        var result = ColumnSum(data);
        Console.WriteLine(JsonSerializer.Serialize(result));
    }

    public static List<int> ColumnSum(List<List<int>> data)
    {
        var res = new List<int>();
        int counter = 0;

        foreach (var list in data)
            if (list.Count > counter)
                counter = list.Count;

        for (var i = 0; i < counter; i++)
            res.Add(0);
        
        foreach (var list in data)
            for (var i = 0; i < list.Count; i++)
                res[i] += list[i];

        return res;
    }
    public static List<List<int>> ReadInput()
    {
        string input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<List<int>>>(input.Trim());
    }
}