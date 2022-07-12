using System;
using System.Collections.Generic;
using System.Linq;

class StackSum
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Stack<int> stack = new Stack<int>(input);

        string command = Console.ReadLine().ToLower();
        var com = command.Split(' ').ToArray();

        while (com[0] != "end")
        {
            if (com[0] == "add")
            {
                stack.Push(int.Parse(com[1]));
                stack.Push(int.Parse(com[2]));
            }
            else if (com[0] == "remove")
            {
                int numbItems = int.Parse(com[1]);

                if (stack.Count >= numbItems)
                {
                    for (int i = 0; i < numbItems; i++)
                    {
                        stack.Pop();
                    }
                }
            }
            command = Console.ReadLine().ToLower();
            com = command.Split(' ').ToArray();
        }

        Console.WriteLine($"Sum: {stack.ToArray().Sum()}");

    }
}
