using System;


class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Fetching data...");

        string result = await FetchDataAsync();

        Console.WriteLine("Data fetched: " + result);
    }

    
    static async Task<string> FetchDataAsync()
    {
        
        await Task.Delay(2000); // 2 second delay

        
        return "Hello from the server!";
    }
}
