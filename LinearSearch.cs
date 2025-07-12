// Linear Search is a simple searching algorithm
// It checks each element in a list or array one by one until it finds the target or reaches the end

// Time Complexity:
// Best Case: O(1) (target found at first position)
// Worst Case: O(n) (target not found or at last position)
// Average Case: O(n)

using LinkedListD;
namespace LinearSearch;

    class LinearSearchMain
    {

        public static string LinearSearchExample()
        {
            string output = Search("Node 1");
          
            return output;
        }

        //linear seach
        public static string Search(string target)
        {
            var LinkedList = LinkedListDMain.stringLinkedList;
            var currentNode = LinkedList.First;

            //search for the target
            for (int i = 0; i <= LinkedList.Count && currentNode != null; i++)
            {
                if (currentNode.Value == target)
                {
                    return $"Found '{target}' at index {i}";
                }
                //move to the next node
                currentNode = currentNode.Next;
            }
            return $"Item '{target}' not found";
        }
    }


