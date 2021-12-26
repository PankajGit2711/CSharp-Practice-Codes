// Fifth C# Program

// Strings, Escape Sequences and Verbatium Literals

// Verbatium Literal - It is a string with an @ symbol prefix, as in @"Hello". Verbatium Literals makes Escape Sequences translate as normal printable characters to enhance readability.

using System;

class DataType
{
    static void Main()
    {
        string strWithNoQuotes = "Pankaj";
        Console.WriteLine(strWithNoQuotes);
        
        string strWithQuotes = "\"Pankaj\""; // Escape Sequence \"
        Console.WriteLine(strWithQuotes);
        
        string strNewLine = "One\nTwo\nThree"; // Escape Sequence \n
        Console.WriteLine(strNewLine);
        
        string strPath = "D:\\KT Sessions\\How to take Latest parameterset"; // Escape Sequence \\
        Console.WriteLine(strPath);
        
        //Verbatium Literal
        string strPathVL = @"D:\KT Sessions\How to take Latest parameterset"; 
        Console.WriteLine(strPathVL);
    }
}
