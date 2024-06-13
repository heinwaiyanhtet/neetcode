// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");



//  Valid Parentheses

using System.Collections;

public class Solution
{
    public bool isValid(string words)
    {

        // ([{   }])

        Stack myStack = new Stack(); 

        foreach (char word in words)
        {
            if(word == '(' || word == '[' || word == '{')
            {
                myStack.Push(word);
            }

            else
            {
                if(myStack.Count == 0)
                {
                    return false;
                }    

                char top = (char)myStack.Pop();

                if(
                    word == ')' && top != '(' ||
                    word == ']' && top != '[' ||
                    word == '}' && top != '{' 
                )
                {
                    return false;
                }

                return true;
            }
        }



        Console.WriteLine(myStack.Count); 

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