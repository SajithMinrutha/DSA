// Binary Search is an efficient searching algorithm
// It works on sorted arrays or lists by repeatedly dividing the search interval in half
// If the target value is less than the middle element, search the left half
// Otherwise, search the right half, until the target is found or the interval is empty

// Time Complexity:
// Best Case: O(1) (target found at middle position)
// Worst Case: O(log n) (target not found or found after multiple divisions)
// Average Case: O(log n)


using System.Collections.Generic;
using DynamicArray;

namespace BinarySearch;

public class BinarySearchMain
{

    public static string BinarySearchExample()
    {
        var dynamicArray = DynamicArrayMain.intDynamicArray;
        int item = 10;
        string searchResults = Search(item , dynamicArray);
        return searchResults;
    }

    public static string Search(int item, List<int> dynamicArray)
    {
        var array = dynamicArray;
        int length = array.Count;

        int high = length - 1;
        int low = 0;



        while (low <= high)
        {
            int mid = low + (high - low) / 2; //to avoid overflow

            if (array[mid] == item)
            {
                return $"{item} Found at Index {mid}";

            }

            else if (array[mid] < item)
            {
                low = mid + 1; //set the upper part

            }
            else
            {
                high = mid - 1; //set the lower part
            }


        }
         return "Not Found";

        
    }

}