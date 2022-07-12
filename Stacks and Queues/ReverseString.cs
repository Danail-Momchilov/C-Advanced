using System;
using System.Collections.Generic;
class StringReversal
{
    static void Main()
    {
        string input = Console.ReadLine();
        Stack<char> stack = new Stack<char>();

        foreach (char ch in input)
        {
            stack.Push(ch);
        }

        while (stack.Count > 0)
        {
            Console.Write(stack.Pop());
        }
    }
}
