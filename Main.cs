
using System;
using Stacks;
using Queues;
using PriorityQueues;
using LinkedListS;

namespace DSA;

class Program
{
    static void Main(string[] args)

    {
        string Stack = StacksMain.StacksExample();
        string Queue = QueuesMain.QueuesExample();
        string priorityQueue = PriorityQueuesMain.PriorityQueuesExample();
        string LinkedListS = LinkedListSMain.LinkedListExample();
        Console.WriteLine(LinkedListS);
    }
}
