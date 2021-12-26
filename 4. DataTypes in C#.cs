// Fourth C# Program

// Builtin Data types in C# are:-
// 1. Boolean type - Only true or false. 0 and 1 are also not valid.
// 2. Integer type - sbyte, byte, short, ushort, int, uint, long, ulong, char
// 3. Floating types - float and double
// 4. Decimal types
// 5. String types


using System;

class DataType
{
    static void Main()
    {
        bool b = true;
        // b = 0/1; Will produce error
        int i = 0;
        
        // Gives Minimum value of any DataType.
        Console.WriteLine("Minimum Value of Int: {0}", int.MinValue);
        // Gives Maximum Value of any DataType.
        Console.WriteLine("Maximum Value of Int: {0}", int.MaxValue);
        
        double d = 123.22242433;
        //int d = 123.22242433; Will produce error 
        Console.WriteLine(d);
    }
}
