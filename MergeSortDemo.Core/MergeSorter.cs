namespace MergeSortDemo.Core
{
   public class MergeSorter
    {
        // Entry point — recursively splits the array
        public int[] Sort(int[] array)
        {
            // Base case: a single element or empty array is already sorted
            if (array.Length <= 1)
                return array;

            // Find the middle point
            int mid = array.Length / 2;

            // Recursively sort the left half
            int[] left = Sort(array[0..mid]);

            // Recursively sort the right half
            int[] right = Sort(array[mid..]);

            // Merge the two sorted halves
            return Merge(left, right);
        }

        // Merges two sorted arrays into one sorted array
        private int[] Merge(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];
            int i = 0; // pointer for left
            int j = 0; // pointer for right
            int k = 0; // pointer for result

            // Compare elements from both halves and place smaller one first
            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                    result[k++] = left[i++];
                else
                    result[k++] = right[j++];
            }

            // Dump any remaining left elements
            while (i < left.Length)
                result[k++] = left[i++];

            // Dump any remaining right elements
            while (j < right.Length)
                result[k++] = right[j++];

            return result;
        }
    }
}