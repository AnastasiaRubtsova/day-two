using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[100];

        Console.Write("Enter the first number: ");
        int nums= int.Parse(Console.ReadLine());

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = nums;
            nums -= 3;
        }

        foreach (int value in numbers)
        {
            Console.WriteLine(value);
        }
    }
}