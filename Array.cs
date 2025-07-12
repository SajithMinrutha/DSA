// an Array is a fixed-size data structure
// Stores elements in contiguous memory with fast random access
// Size must be defined at creation time and cannot change

// | Operation      | Description                                |
// |----------------|--------------------------------------------|
// | Insert         | Assign value to an index                    |
// | Delete         | Not directly supported (overwrite manually) |
// | Search         | Find an element by value                    |
// | Access         | Get or set element by index                 |

// Time Complexity:
// Access (by index): O(1)
// Insert (by index): O(1)
// Delete (overwrite): O(1)
// Search: O(n)

namespace Array;

public class ArrayMain
{
    public static string ArrayExample()
    {
        int[] intArray = new int[5]; // Fixed size array with 5 elements

        // Insert elements
        intArray[0] = 10;
        intArray[1] = 20;
        intArray[2] = 30;

        // Overwrite/delete (manual)
        intArray[1] = 0; // Simulates deleting the value at index 1

        // Access by index
        int valueAtIndex2 = intArray[2]; // 30

        // Search for element (e.g., 10)
        bool contains10 = false;
        foreach (int value in intArray)
        {
            if (value == 10)
            {
                contains10 = true;
                break;
            }
        }

    
        string arrayContents = string.Join(", ", intArray);

        return $"Array contents: {arrayContents}\n" +
               $"Element at index 2: {valueAtIndex2}\n" +
               $"Contains 10? {contains10}";
    }
}
