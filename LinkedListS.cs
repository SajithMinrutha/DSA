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
        // Head of the linked list
        private LinkedListNode? head = null;

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

        // Insert new node at the front (head)
        public void InsertAtHead(int value)
        {
            LinkedListNode newNode = new LinkedListNode(value);
            newNode.next = head;  // Point new node's next to current head
            head = newNode;       // Update head to new node
        }

        // Traverse list and build string representation
        public string Traverse()
        {
            LinkedListNode? current = head;
            string output = "";
            while (current != null)
            {
                output += current.data + " -> ";
                current = current.next;
            }
            output += "null";
            return output;
        }

        // Example usage
        public static string LinkedListExample()
        {
            LinkedListSMain list = new LinkedListSMain();

            list.InsertAtHead(10);  // List: 10 -> null
            list.InsertAtHead(20);  // List: 20 -> 10 -> null
            list.InsertAtHead(30);  // List: 30 -> 20 -> 10 -> null

            return list.Traverse();
        }
    }
}
