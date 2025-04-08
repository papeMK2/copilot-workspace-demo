using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of GUIDs to generate:");
        if (int.TryParse(Console.ReadLine(), out int numberOfGuids))
        {
            if (numberOfGuids > 0)
            {
                for (int i = 0; i < numberOfGuids; i++)
                {
                    Console.WriteLine(Guid.NewGuid());
                }
            }
            else
            {
                Console.WriteLine("Please enter a positive number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
