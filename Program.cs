using System;

class Program
{
    static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
 static void Find(Dictionary<string, int> students, string name)
    {
        if (students.ContainsKey(name))
        {
            Console.WriteLine($"{name}'s grade: {students[name]}");
        }
        else
        {
            Console.WriteLine($"Student {name} not found.");
        }
    }

    static void Main(string[] args)
    {
        #region 1
        // int x = 10, y = 20;
        // Console.WriteLine($"Before swap: x = {x}, y = {y}");
        // Swap(ref x, ref y);
        // Console.WriteLine($"After swap: x = {x}, y = {y}");

        // string str1 = "Hello", str2 = "World";
        // Console.WriteLine($"\nBefore swap: str1 = {str1}, str2 = {str2}");
        // Swap(ref str1, ref str2);
        // Console.WriteLine($"After swap: str1 = {str1}, str2 = {str2}");
        // Console.Read();
        #endregion 

        #region 2
        //  Dictionary<string, int> Grades = new Dictionary<string, int>
        // {
        //     {"AHMED", 90},
        //     {"ABAS", 85},
        //     {"WATAN", 78},
        //     {"SA3DOLA", 92},
        //     {"SANTI53", 88}
        // };

        // Console.WriteLine("Enter a student name to find their grade:");
        // string Name = Console.ReadLine();
        // Find(Grades, Name);
        // Console.Read();
        #endregion
   
        #region 3
       Queue<string> customer = new Queue<string>();

        customer.Enqueue("AHMED");
        customer.Enqueue("SANTI");
        customer.Enqueue("SA3DOLA");
        customer.Enqueue("ABSI");
        customer.Enqueue("YASER");

       
        Console.WriteLine("Processing customer service queue:");
        while (customer.Count > 0)
        {
            string details = customer.Dequeue();
            Console.WriteLine($"Served: {details}");
        }
        Console.Read();
        #endregion
    }
}

