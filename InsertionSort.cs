
// Insertion Sort is a simple comparison-based sorting algorithm.
// It builds the sorted list one element at a time.
// It repeatedly takes the next element from the unsorted part
// and inserts it into its correct position in the sorted part
// by shifting larger elements one position to the right.

// Time Complexity:
// Best Case: O(n)    (when the array is already sorted; only 1 comparison per element)
// Worst Case: O(n²)  (when the array is sorted in reverse order; many shifts per element)
// Average Case: O(n²)

using System.Collections.Generic;
namespace InsertionSort;

public class InsertionSortMain
{
    public static string InsertionSortMainExample()
    {
        List<int> array = new List<int> { 10, 20, 3, 5, 34, 22, 15 };

        InsertionSort(array);
        return string.Join(",", array);

    }
    public static void InsertionSort(List<int> array)
    {
        for (int i = 1; i < array.Count; i++)
        {
            int temp = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > temp)
            {
                array[j + 1] = array[j]; //shift elemnt to the right;
                j--;

            }
            array[j + 1] = temp;
        }
    }
}