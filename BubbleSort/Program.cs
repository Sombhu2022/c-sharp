namespace BubbleSort
{
    internal class Program
    {
 
        static void BubbleSort(int[] array)
        {
            int n = array.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    // Swap elements if the current element is greater than the next element
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapped = true;
                    }
                }

                // If no elements were swapped in the inner loop, the array is already sorted
                if (!swapped)
                    break;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the range of the array:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];

            Console.WriteLine("Enter the elements of the array:");

            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Array before sorting:");
            PrintArray(array);

            BubbleSort(array);

            Console.WriteLine("Array after sorting:");
            PrintArray(array);
        }

        static void PrintArray(int[] array)
        {
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }

}
