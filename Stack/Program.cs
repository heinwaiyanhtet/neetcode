// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//  Valid Parentheses

using System.Collections;

public class Solution
{
    public bool isValid(string words)
    {

        Stack myStack = new Stack(); 

        foreach (var item in words)
        {
            Console.WriteLine(item);
        }
        
        return true;

    }
}


public class Program{


    public static void Main(string[] args)
    {

        Solution solution = new Solution();

        Console.WriteLine(solution.isValid("()"));
        Console.WriteLine(solution.isValid("()[]{}"));
        Console.WriteLine(solution.isValid("(]"));

    }
}