using System;
using System.Collections.Generic;

class TrafficJam
{
    static void Main()
    {
        var number = int.Parse(Console.ReadLine());

        Queue<string> carqueue = new Queue<string>();
        int count = 0;

        string command = Console.ReadLine();

        while (command != "end")
        {

            if (command == "green")
            {
                for (int i = 0; i < number; i++)
                {
                    if(carqueue.Count > 0)
                    {
                        Console.WriteLine($"{carqueue.Dequeue()} car passed!");
                        count++;
                    }
                }
            }
            else
                carqueue.Enqueue(command);

            command = Console.ReadLine();
        }

        Console.WriteLine($"{count} cars passed the crossroads.");
    }
}
