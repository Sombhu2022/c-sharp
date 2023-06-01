namespace BinarySearch
{
    internal class Program
    {
      
        static int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                // Check if the target is present at the middle index
                if (array[mid] == target)
                    return mid;

                // If the target is greater, ignore the left half
                if (array[mid] < target)
                    left = mid + 1;

                // If the target is smaller, ignore the right half
                else
                    right = mid - 1;
            }

            // Target element not found in the array
            return -1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter the range of array:");
            int n =Convert.ToInt32( Console.ReadLine());

            int[] array = new int[n];
            Console.WriteLine("enter the array value:");
            for(int i=0; i<n; i++)
            {
                array[i] = Convert.ToInt32( Console.ReadLine());
            }
            Console.WriteLine("enter the searching value: ");
            int target = Convert.ToInt32( Console.ReadLine());

            int result = BinarySearch(array, target);

            if (result == -1)
                Console.WriteLine("Element not found in the array");
            else
                Console.WriteLine("Element found at index: " + result);
        }
    }
}