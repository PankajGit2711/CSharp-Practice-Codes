// Third C# Program

// There are two ways to write to the console.
// 1. Concatenation
// 2. Place holder syntax (Most Preferred)

// C# is a case sensitive Language.

using System;

class ReadWrite
{
    static void Main()
    {
        Console.WriteLine("Please Enter your First Name:");
        string FirstName = Console.ReadLine();
        
        Console.WriteLine("Please Enter your Last Name:");
        string LastName = Console.ReadLine(); // Reads an Input and Returns a String
        
        Console.WriteLine("Hello " + FirstName + " " + LastName); // 1. Concatenation Method
        Console.WriteLine("Hello {0} {1}", FirstName, LastName); // 2. Place Holder Method
    }
}
