// Seventh C# Program

// Nullable types and Null Coalescing Operator.

// In C# types are divided into 2 broad categories
// 1. Value Types - int, float, double, struct, enums, etc.
// 2. Reference Types - Interface, Class, delegates, arrays, etc.

// By Default value types are non nullable and to make them nullable we use ?.
// int i = 0 (i is non nullable, so we cannot i to null, i = null will generate compiler error).
// int? j = 0 (j is nullable int, so j = null is legal)

// Nullable types bridges the difference between C# types and database types.

using System;

class DataType
{
    static void Main()
    {
        string name = null; // Will not give error.
        // int i = null // Will give error.
        
        int? i = null; // Will not give error because of Null Coalescing Operator.
        
        bool? areYouMajor = null; // If user does not want to answer this question then this variable should be capable of storing null values as well.
        
        if(areYouMajor == true)
            Console.WriteLine("User is Major");
        else if(areYouMajor == false)
            Console.WriteLine("User is not major");
        else
            Console.WriteLine("User did not answer the question");
            
            
        // Null Coalescing Operator.
        int? TicketsOnSale = 100;
        int AvailableTickets;
        
        if(TicketsOnSale == null)
            AvailableTickets = 0;
        else
            AvailableTickets = (int)TicketsOnSale; // Here we're forcing nullable datatype to be converted into non-nullable datatype.
            
        Console.WriteLine("AvailableTickets = {0}", AvailableTickets);
        
        //But Do we really need all these lines to do this? No, we can use Null Coalescing Operator.
        // Below line says if TicketsOnSale is availble use it's value otherwise use 0.
        int? TicketsOnSaleNCO = null;
        int AvailableTicketsNCO = TicketsOnSaleNCO ?? 0; 
        Console.WriteLine("AvailableTickets = {0}", AvailableTicketsNCO);
    }
}
