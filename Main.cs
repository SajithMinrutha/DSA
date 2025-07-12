
using System;
using Stacks;
using Queues;
using PriorityQueues;

namespace DSA;

class Program
{
    static void Main(string[] args)

    {
        string Stack = StacksMain.StacksExample();
        string Queue = QueuesMain.QueuesExample();
        string priorityQueue = PriorityQueuesMain.PriorityQueuesExample();
        Console.WriteLine(priorityQueue);
    }
}
