using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[100];

        Console.Write("The number by which the arithmetic sequence increases: ");
        int nums= int.Parse(Console.ReadLine());
        if(nums % 2 == 0)
        {
            Console.WriteLine("the code doesn't work: ");
            Environment.Exit(0);
        }

        numbers[0] = 1;
        for (int i = 1; i < numbers.Length; i++)
        {
            numbers[i] = numbers[i - 1] + nums;
        }

        foreach (int value in numbers)
        {
            Console.WriteLine(value);
        }
    }
}