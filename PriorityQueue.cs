// Priority Queue processes elements based on priority
// Used in task schedulers, pathfinding, CPU job queues

// | Operation  | Description                                         |
// |------------|-----------------------------------------------------|
// | Enqueue    | Add an element with a specific priority             |
// | Dequeue    | Remove and return the element with highest priority |
// | Peek       | View the highest priority element without removing  |
// | Count      | Number of elements in the queue                     |

// Insertion and removal: O(log n) (uses a heap internally)
// Searching: O(n)

using System.Collections.Generic;

namespace PriorityQueues;

public class PriorityQueuesMain
{
    public static string PriorityQueuesExample()
    {
        
        PriorityQueue<string, int> stringPriorityQueue = new PriorityQueue<string, int>();
        stringPriorityQueue.Enqueue("Porsche", 2);//dequeued second 
        stringPriorityQueue.Enqueue("Lamborghini", 1);//dequeued first
        stringPriorityQueue.Enqueue("Ferrari", 3);//dequeued third
        string output = "PriorityQueue is NOT EMPTY";


        output += $"\n Number Of Items: {stringPriorityQueue.Count}";
        output += $"\n Items: {string.Join(",",stringPriorityQueue.ToString())}";
        output += $"\n {stringPriorityQueue.Dequeue()}";// removes the highest priority item from the queue
        output += $"\n {stringPriorityQueue.Peek()}";//look at the next item


        if (stringPriorityQueue.Count == 0)
        {
            return "PriorityQueue is Empty";
        }
        return output;
    }
}