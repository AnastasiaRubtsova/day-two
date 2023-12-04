using System;
using System.Collections.Generic;

class Program
{
    static void BubbleSort(Dictionary<string, int> dict)
    {
        int n = dict.Count;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (dict[GetKeyByIndex(dict, j)] > dict[GetKeyByIndex(dict, j + 1)])
                {
                    SwapEntries(dict, j, j + 1);
                }
            }
        }
    }

    static string GetKeyByIndex(Dictionary<string, int> dict, int index)
    {
        int i = 0;
        foreach (string key in dict.Keys)
        {
            if (i == index)
            {
                return key;
            }
            i++;
        }
        return null;
    }

    static void SwapEntries(Dictionary<string, int> dict, int index1, int index2)
    {
        string key1 = GetKeyByIndex(dict, index1);
        string key2 = GetKeyByIndex(dict, index2);

        int temp = dict[key1];
        dict[key1] = dict[key2];
        dict[key2] = temp;
    }

    static void Main()
    {
        int[,] temperature = new int[12, 30];
        Random rnd = new Random();
        string[] months = { "january", "february", "march", "april", "may", "june", "july", "august", "september", "october", "november", "december" };
        Console.Write("months/days");
        for (int day = 1; day <= 30; day++)
        {
            Console.Write($"{day,4}");
        }
        Console.WriteLine();
        for (int i = 0; i < 12; i++)
        {
            Console.Write($"{months[i],-10}");
            for (int j = 0; j < 30; j++)
            {
                if (i >= 0 && i <= 1 || i == 11) // зима
                {
                    temperature[i, j] = rnd.Next(-30, -9);
                }
                else if (i >= 2 && i <= 4) // весна
                {
                    temperature[i, j] = rnd.Next(-10, 16);
                }
                else if (i >= 5 && i <= 7) // лето
                {
                    temperature[i, j] = rnd.Next(10, 31);
                }
                else if (i >= 8 && i <= 10) // осень
                {
                    temperature[i, j] = rnd.Next(-12, 16);
                }
                Console.Write($"{temperature[i, j],4}");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\naverage temperature (unsorted):");
        Dictionary<string, int> averageTemperatures = new Dictionary<string, int>();
        for (int i = 0; i < 12; i++)
        {
            int sum = 0;
            for (int j = 0; j < 30; j++)
            {
                sum += temperature[i, j];
            }
            averageTemperatures.Add(months[i], sum / 30);
        }
        foreach (KeyValuePair<string, int> entry in averageTemperatures)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
        BubbleSort(averageTemperatures);
        Console.WriteLine("\nsorted average temperatures in ascending order:");
        foreach (KeyValuePair<string, int> entry in averageTemperatures)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }
}