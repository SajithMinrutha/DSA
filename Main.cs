//Data Structures
using System;
using Stacks;
using Queues;
using PriorityQueues;
using LinkedListS;
using LinkedListD;
using DynamicArray;
using Array;

//Algorithms
using LinearSearch;

namespace DSA;

class Program
{
    static void Main(string[] args)

    {
        //DSA

        //Data Structures
        string stack = StacksMain.StacksExample();
        string queue = QueuesMain.QueuesExample();
        string priorityQueue = PriorityQueuesMain.PriorityQueuesExample();
        string linkedListS = LinkedListSMain.LinkedListExample();
        string linkedListD = LinkedListDMain.LinkedListDExample();
        string array = ArrayMain.ArrayExample();
        string dynamicArray = DynamicArrayMain.DynamicArrayExample();

        //Algorithms
        string LinearSearch = LinearSearchMain.LinearSearchExample();

        Console.WriteLine(LinearSearch);
    }
}
