using System;
using System.Collections.Generic;
using System.Data;
using System.Text.Json;

public class MainClass
{
    public static void Main(string[] args)
    {
        List<List<int>> grid = ReadInput();

        var result = GetDiagSum(grid);


        Console.WriteLine(result);
    }

    private static int GetDiagSum(List<List<int>> grid)
    {
        if (grid.Count != grid[0].Count)
        {
            return -1; // Размеры списка по высоте и ширине разные
        }

        int sum = 0;
        int n = grid.Count;

        for (int i = 0; i < n; i++)
        {
            sum += grid[i][i]; // Сумма по главной диагонали
            sum += grid[i][n - 1 - i]; // Сумма по побочной диагонали
        }

        return sum;
    }


    public static List<List<int>> ReadInput()
    {
        string input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<List<int>>>(input);
    }
}