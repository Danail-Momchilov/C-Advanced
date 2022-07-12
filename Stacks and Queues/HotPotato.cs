using System;
using System.Collections.Generic;

class HotPotato
{
    static void Main()
    {
        var children = Console.ReadLine().Split(' ');
        var number = int.Parse(Console.ReadLine());

        Queue<string> game = new Queue<string>(children);
        while (game.Count > 1)
        {
            for (int i = 0; i < number-1; i++)
            {
                game.Enqueue(game.Dequeue());
            }
            Console.WriteLine($"Removed {game.Dequeue()}");
        }
        Console.WriteLine($"Last is {game.Dequeue()}");
    }
}
