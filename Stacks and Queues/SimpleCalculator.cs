using System;
using System.Collections.Generic;
using System.Linq;

class StackSum
{
    static void Main()
    {
        var input = Console.ReadLine().Split(" ").Reverse().ToArray();
        Stack<string> stack = new Stack<string>(input);
        int sum = 0;

        while (stack.Count > 0)
        {
            string lastItem = stack.Pop();

            if (lastItem == "+")
                sum += int.Parse(stack.Pop());
            else if (lastItem == "-")
                sum -= int.Parse(stack.Pop());
            else
                sum += int.Parse(lastItem);
        }

        Console.WriteLine(sum);

    }
}
