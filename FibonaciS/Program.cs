namespace FibonaciS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci Series..");
            Console.WriteLine("enter the range of the fibonacci series:");
           int n=Convert.ToInt32( Console.ReadLine());
            int a=0; int b=1; int sum , i=0;

            Console.WriteLine($"fibonacci serise are :{a} \n {b}");
            while (i <n )
            {
                sum = a + b;
                a = b;
                b = sum;
                Console.WriteLine(sum);
                i++;

            }

        }
    }
}