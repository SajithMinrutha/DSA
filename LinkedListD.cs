
// a linear data structure
// Each node contains data and references to both the next and previous nodes
// dynamic memory allocation is needed and fast insertions/deletions at both ends

// | Operation      | Description                                     |
// |----------------|-------------------------------------------------|
// | Insert at Head | Add a new node at the beginning                   |
// | Insert at Tail | Add a new node at the end                          |
// | Delete         | Remove a node by value or position                 |
// | Search         | Find a node by value                                 |
// | Traverse Forward  | Visit all nodes from head to tail                  |
// | Traverse Backward | Visit all nodes from tail to head                  |

// Time Complexity:
// Insert at Head: O(1)
// Insert at Tail: O(1) (if tail pointer maintained)
// Delete: O(n)
// Search: O(n)
// Traverse: O(n)


using System.Collections.Generic;

namespace LinkedListD;

public class LinkedListDMain
{
    public static string LinkedListDExample()
    {
        LinkedList<string> stringLinkedList = new LinkedList<string>();

        // Insert at head (AddFirst)
        stringLinkedList.AddFirst("Node 1");
        stringLinkedList.AddFirst("Node 2");
        stringLinkedList.AddFirst("Node 3"); // List: Node 3 -> Node 2 -> Node 1

        // Insert at tail (AddLast)
        stringLinkedList.AddLast("Node 4");

        // Traverse forward
        string output = "";
        foreach (var item in stringLinkedList)
        {
            output += item + " <-> ";
        }
        output += "null";

        return output;
    }
}
