using System;
using System.Collections.Generic;

class MatchingBrackets
{
    static void Main()
    {
        string input = Console.ReadLine();
        Stack<int> stack = new Stack<int>();
        var expressions = new List<string>();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
                stack.Push(i);
            
            else if (input[i] == ')')
            {
                int startindex = stack.Pop();
                Console.WriteLine(input.Substring(startindex, i - startindex + 1));
            }

        }

    }
}
