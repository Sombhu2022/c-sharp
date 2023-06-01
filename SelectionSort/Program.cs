namespace SelectionSort
{
    internal class Program
    {
   
        static void SelectionSort(int[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                // Find the index of the minimum element in the unsorted part of the array
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Swap the minimum element with the first element of the unsorted part
                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements in the array:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];

            Console.WriteLine("Enter the elements of the array:");

            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Array before sorting:");
            PrintArray(array);

            SelectionSort(array);

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
