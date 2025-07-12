// Singly Linked List is a linear data structure
// Each node contains data and a reference to the next node
// dynamic memory allocation is needed and fast insertions/deletions

// | Operation      | Description                               |
// |----------------|-------------------------------------------|
// | Insert at Head | Add a new node at the beginning           |
// | Insert at Tail | Add a new node at the end                  |
// | Delete         | Remove a node by value or position         |
// | Search         | Find a node by value                         |
// | Traverse       | Visit all nodes from head to tail            |

// Time Complexity:
// Insert at Head: O(1)
// Insert at Tail: O(n) (unless tail pointer maintained)
// Delete: O(n) 
// Search: O(n)
// Traverse: O(n)


namespace LinkedListS
{
    public class LinkedListSMain
    {
        public class LinkedListNode
        {
            public int data;
            public LinkedListNode? next;

            public LinkedListNode(int x)
            {
                data = x;
                next = null;
            }
        }

        public static string LinkedListExample()
        {
            // Create nodes
            LinkedListNode node1 = new LinkedListNode(10);
            LinkedListNode node2 = new LinkedListNode(20);
            LinkedListNode node3 = new LinkedListNode(30);

            // Link nodes
            node1.next = node2;
            node2.next = node3;
            node3.next = null;  // last node

            // Traverse list to build output string
            LinkedListNode? current = node1;
            string output = "";
            while (current != null)
            {
                output += current.data + " -> ";
                current = current.next;
            }
            output += "null";

            return output;
        }
    }
}
