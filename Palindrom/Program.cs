using System;

namespace Palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string rev="", s=Console.ReadLine();
            string original =s= s.ToLower();
           
            
           char[] arr = s.ToLower().ToCharArray();
           /* Console.WriteLine(Arrays.Reverse(arr));*/

            for (int i = s.Length-1 , j=0 ; i >= 0  ; i-- , j++)
            {
                 rev += s[i].ToString();
            }
           
            if (original == rev)
            {
                Console.WriteLine($"{rev} is palindrom" );
            }
            else
            {
                Console.WriteLine($"{s} is not palindrom !" );
            }
        }
    }
}