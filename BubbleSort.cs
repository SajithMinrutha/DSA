// Bubble Sort is a simple comparison-based sorting algorithm.
// It repeatedly steps through the list, compares adjacent elements,
// and swaps them if they are in the wrong order.
// This process is repeated until the list is sorted.

// Time Complexity:
// Best Case: O(n)    (when the list is already sorted, with a slight optimization)
// Worst Case: O(n²)  (when the list is sorted in reverse order)
using System.Collections.Generic;

namespace BubbleSort
{
    public class BubbleSortMain
    {
        public static string BubbleSortExample()
        {
            List<int> array = new List<int> { 10, 20, 3, 5, 34, 22, 15 };
            string beforeSorted = string.Join(",", array);
            for (int i = 0; i < array.Count - 1; i++)
            {
                for (int j = 0; j < array.Count - i - 1; j++)
                {
                    if (array[j] > array[j + 1])  // For ascending order
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            // Return the sorted array 
            return $"Before Sorted:{beforeSorted} \n After Sorted:{string.Join(", ", array)}";
        }
    }
}
