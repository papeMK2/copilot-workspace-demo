using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of GUIDs to generate:");
        if (int.TryParse(Console.ReadLine(), out int numberOfGuids))
        {
            for (int i = 0; i < numberOfGuids; i++)
            {
                Console.WriteLine(Guid.NewGuid());
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
