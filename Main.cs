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
using BinarySearch;
using InterpolationSearch;
using BubbleSort;
using SelectionSort;
using InsertionSort;

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
        string linearSearch = LinearSearchMain.LinearSearchExample();
        string binarySearch = BinarySearchMain.BinarySearchExample();
        string interpolationSearch = InterpolationSearchMain.InterpolationSearchExample();
        string bubbleSort = BubbleSortMain.BubbleSortExample();
        string selectionSort = SelectionSortMain.SelectionSortExample();
        string insertionSort = InsertionSortMain.InsertionSortMainExample();

        Console.WriteLine(insertionSort);
    }
}
