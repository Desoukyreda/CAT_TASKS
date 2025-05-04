using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Fetching numbers...");

        List<int> evenNumber = await GetEvenNumbersAsync();

        Console.WriteLine("Even numbers:");
        foreach (int number in evenNumber)
        {
            Console.WriteLine(number);
        }
    }
    static async Task<List<int>> GetEvenNumbersAsync()
    {
        await Task.Delay(2000); // wait 2 seconds
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
         List<int> evenNumber = new List<int>();

        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                evenNumber.Add(number);
            }
        }

        return evenNumber;
    }
}
