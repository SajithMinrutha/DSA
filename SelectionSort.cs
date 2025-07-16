// Selection Sort is a simple comparison-based sorting algorithm.
// It divides the list into a sorted and an unsorted part.
// It repeatedly selects the smallest (or largest) element from the unsorted part
// and moves it to the end of the sorted part by swapping.

// Time Complexity:
// Best Case: O(n²)   (no optimization like bubble sort; still checks every element)
// Worst Case: O(n²)  (always makes full comparisons)
// Average Case: O(n²)
using System.Collections.Generic;
namespace SelectionSort;

public class SelectionSortMain
{

    public static string SelectionSortExample()
    {
        List<int> array = new List<int> { 10, 20, 3, 5, 34, 22, 15 };

        SelectionSort(array);
        return string.Join(",",array);
    }

    public static void SelectionSort(List<int> array)
    {
        for (int i = 0; i < array.Count - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < array.Count; j++)
            {
                if (array[min] > array[j])
                {
                    min = j;
                }

            }
            int temp = array[i];
            array[i] = array[min];
            array[min] = temp;
        }
        
    }
}