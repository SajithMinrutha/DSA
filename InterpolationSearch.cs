// Interpolation Search is an improved searching algorithm for uniformly distributed sorted arrays.
// Instead of always probing the middle element like Binary Search, it estimates the position of the target
// using the formula based on the target's value relative to the range of elements.
// It works best when data is evenly spaced, such as numerical datasets.

// Formula to estimate position:
// pos = low + ((target - array[low]) * (high - low)) / (array[high] - array[low])

// If the target is less than the estimated position value, search the left portion.
// If greater, search the right portion, and repeat until the target is found or range collapses.

// Time Complexity:
// Best Case: O(1)   (target value exactly estimated)
// Average Case: O(log log n) (for uniformly distributed values)
// Worst Case: O(n)  (for skewed or non-uniform distributions)

using DynamicArray;
using System.Collections.Generic;

namespace InterpolationSearch
{
    class InterpolationSearchMain
    {
       
        public static string InterpolationSearchExample()
        {
            var dynamicArray = DynamicArrayMain.intDynamicArray; 
            int target = 20; 
            string search = Search(dynamicArray, target); 
            return search;
        }
        public static string Search(List<int> dynamicArray, int target)
        {
            var array = dynamicArray;
            int high = array.Count - 1; 
            int low = 0;               

            
            while (low <= high && target >= array[low] && target <= array[high])
            {
                // Estimate position using interpolation formula
                int pos = low + (target - array[low]) * (high - low) / (array[high] - array[low]);

               
                if (array[pos] == target)
                    return $"Item Found at Index {pos}";


                else if (array[pos] < target)
                {
                    low = pos + 1; // ignore the left half
                }


                else
                {
                    high = pos - 1; // ignore the right half
                }
            }

           
            return "Item Not Found";
        }
    }
}
