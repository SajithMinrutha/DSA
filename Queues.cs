// Queue is FIFO (First-In-First-Out)
// Used for task scheduling, buffering,

// | Operation | Description                                 |
// | --------- | -------------------------------------------|
// | Enqueue   | Add an element to the back of the queue     |
// | Dequeue   | Remove and return the front element          |
// | Peek      | View the front element without removing it  |
// | Count     | Get the number of elements in the queue      |

// Most operations run in O(1) time
// Searching is O(n) 


using System.Collections.Generic;
namespace Queues;

public class QueuesMain
{
    public static string QueuesExample()
    {
        //initializing a new Queue (First In First Out)
        Queue<string> stringQueue = new Queue<string>();
        stringQueue.Enqueue("Porsche"); //first in the queue (first out)
        stringQueue.Enqueue("Lamborghini");
        stringQueue.Enqueue("Ferrari"); //last in the queue (last out)
        string output = "Queue is NOT EMPTY";

        output += $"\n Number Of Items: {stringQueue.Count}";
        output += $"\n Items: {string.Join(",",stringQueue)}";
        output += $"\n {stringQueue.Dequeue()}";// removes the first in the queue
        output += $"\n {stringQueue.Peek()}";//look at the first in the queue


        if (stringQueue.Count == 0)
        {
            return "Queue is EMPTY";
        }

        return output;
    }
    
}