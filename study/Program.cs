using System;
using System.Linq;

namespace study
{
    public class Program
    {

       
        static int[] ArrayGenerate(int n,int min,int max)
        {
            int[] arr = new int[n];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(min, max);
            }

           
            return arr;
        }

        private static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Value #{0}: {1}", i + 1, array[i]);
            }
        }

       
            public static int MultipleCounter(int[] array)
            {
                int counter = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 4 == 0 || array[i] % 6 == 0)
                    {
                        counter++;
                    }
                }


                return counter;
            }

        
        public static bool IsPalindrome(string str)
        {
            return str.SequenceEqual(str.Reverse());

        }



        public static void Palindrome()
        {
            

            Console.WriteLine("Please, enter your string: ");
            string palindrome = Console.ReadLine();
            Console.WriteLine(IsPalindrome(palindrome));
        }

        static void Main(string[] args)
        {
            //array generation ant print
            int[] array = ArrayGenerate(20, -20, 20);
            PrintArray(array);

            //task 1
            Console.WriteLine("\n\nTask 1");
           
            int number = MultipleCounter(array);
            Console.WriteLine("The number of values that are multipliers of either 4 or 6 = {0}", number);

            //task 2
            Console.WriteLine("\n\nTask 2");
            Palindrome();



        }
    }
}
