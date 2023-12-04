using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[,] temperature = new int[12, 30];
        Random rnd = new Random();
        string[] months = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};

        Console.WriteLine("Months/Days");

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
                if (i >= 0 && i <= 1 || i == 11) // Winter
                {
                    temperature[i, j] = rnd.Next(-30, -9);
                }
                else if (i >= 2 && i <= 4) // Spring
                {
                    temperature[i, j] = rnd.Next(-10, 16);
                }
                else if (i >= 5 && i <= 7) // Summer
                {
                    temperature[i, j] = rnd.Next(10, 31);
                }
                else if (i >= 8 && i <= 10) // Autumn
                {
                    temperature[i, j] = rnd.Next(-12, 16);
                }

                Console.Write($"{temperature[i, j],4}");
            }

            Console.WriteLine();
        }

        Console.WriteLine("\nAverage temperature (unsorted):\n");

        int[] averageTemperatures = new int[12];
        for (int i = 0; i < 12; i++)
        {
            int sum = 0;

            for (int j = 0; j < 30; j++)
            {
                sum += temperature[i, j];
            }

            averageTemperatures[i] = sum / 30;
        }

        for (int i = 0; i < 12; i++)
        {
            Console.WriteLine($"{months[i]}: {averageTemperatures[i]}");
        }

        BubbleSort(averageTemperatures, months);

        Console.WriteLine("\nSorted average temperatures in ascending order:\n");
        for (int i = 0; i < 12; i++)
        {
            Console.WriteLine($"{months[i]}: {averageTemperatures[i]}");
        }
    }

    static void BubbleSort(int[] arr, string[] months)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;

                    string tmpMonth = months[j];
                    months[j] = months[j + 1];
                    months[j + 1] = tmpMonth;
                }
            }
        }
    }
}

    
