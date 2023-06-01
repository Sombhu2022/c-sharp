namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***....palindrom number from an array in intiger ....****");
            Console.WriteLine("Enter the range of array");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the array values");
            int[] arr= new int[n];int k = 0; int range=0; int[] pra = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i]= Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < n;i++)
            {
                int count = 0;

                for (int j = 2; j <= arr[i]/2; j++)
                {
                    if (arr[i] %j == 0)
                    { 
                        count= 1;
                       
                        break;
                    }
                    
                    
                }
                if(count == 0) {
                    
                    pra[k] = arr[i];
                    k++;
                    range++;

                }

                
            }


            Console.WriteLine("praime Number are in array:");
           for(int i=0; i < range; i++) {

                Console.WriteLine(pra[i]);
            }
        }
    }
}