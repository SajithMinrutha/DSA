// Dynamic Array is a resizable array data structure
// Stores elements in contiguous memory and automatically resizes when capacity is exceeded
// Provides fast random access and flexible sizing

// | Operation      | Description                                      |
// |----------------|-------------------------------------------------|
// | Insert         | Add a new element at the end                      |
// | Delete         | Remove an element by value or index               |
// | Search         | Find an element by value                           |
// | Access         | Get element by index                               |
// | Resize         | Automatically increases capacity when needed      |

// Time Complexity:
// Access (by index): O(1)
// Insert (at end): Amortized O(1)
// Insert (at middle/start): O(n)
// Delete: O(n)
// Search: O(n)
// Resize: O(n) (happens occasionally during insertions)

using System.Collections.Generic;

namespace DynamicArray;

public class DynamicArrayMain
{
    public static List<int> intDynamicArray = new List<int>();
    public static string DynamicArrayExample()
    {


        // Insert elements
        intDynamicArray.Add(10);
        intDynamicArray.Add(20);
        intDynamicArray.Add(30);
        intDynamicArray.Add(40);
        intDynamicArray.Add(50);
        intDynamicArray.Add(60);
        intDynamicArray.Add(70);

        // Insert at specific index
        intDynamicArray.Insert(1, 20); // List: 10, 15, 20, 30

        // Remove element by value
        intDynamicArray.Remove(20);    // List: 10, 15, 30

        // Access by index
        int valueAtIndex2 = intDynamicArray[2]; // 30

        // Search for element
        bool contains15 = intDynamicArray.Contains(15); // true
        
        return $"List contents: {string.Join(", ", intDynamicArray)}\n" +
               $"Element at index 2: {valueAtIndex2}\n" +
               $"Contains 15? {contains15}";
    }
}
