// Sixth C# Program

// Operators in C#
// 1. Assignment Operators: =
// 2. Arithematic Operators: +, - , *, /, %
// 3. Comparison Operators: ==, !=, >, >=, <, <=
// 4. Conditional Operators: &&, || 
// 5. Ternary Operator: ?:
// 6. Null Coalescing Operator: ??

using System;

class DataType
{
    static void Main()
    {
        // Assignment Operator.
        int i = 10; 
        bool b = true; 
        
        // Arithematic Operator.
        int numerator = 10;
        int denominator = 2;
        int result = numerator / denominator;
        Console.WriteLine("Result is: {0}", result);
        
        // Comparison Operator.
        int num = 10;
        if(num == 10)
            Console.WriteLine("Numbers are Equal");
            
        // Conditional Operator.
        int num1 = 10;
        int num2 = 20;
        if(num1 == 10 && num2 == 20)
            Console.WriteLine("Condition Meets");
            
        if(num1 == 10 || num2 == 21)
            Console.WriteLine("Condition Meets");
            
            
        // Without Ternary Operator.
        int number = 10;
        bool isNumberValid;
        
        if(number == 10)
            isNumberValid = true;
        else
            isNumberValid = false;
        Console.WriteLine("Number == 10 is {0}", isNumberValid);
        
        // With Ternary Operator
        bool isNumberValidTernary = number == 10 ? true : false;
        Console.WriteLine("Number == 10 is {0}", isNumberValidTernary);
    }
}
