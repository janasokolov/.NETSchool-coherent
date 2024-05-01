using System;
using System.Runtime.InteropServices;

namespace homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK 1.1
            string[] arr = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B" };

            Console.WriteLine("Enter two numbers: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int[] ints = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                ints[i] = int.Parse(arr[i], System.Globalization.NumberStyles.HexNumber);
            }

            foreach (int i in ints)
            {
                if (i >= a && i <= b)
                {
                    Console.Write(i + " ");
                }
            }

            //TASK 1.2
            Console.WriteLine();
            Console.WriteLine("Enter a 9-digit number: ");
            string number = Console.ReadLine();

            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int digit = int.Parse(number[i].ToString());
                sum += (10 - i) * digit;
            }

            int checkDigit = (11 - (sum % 11)) % 11;
            string isbn = number + (checkDigit == 10 ? "X" : checkDigit.ToString());

            Console.WriteLine($"ISBN is: {isbn}");

            //TASK 1.3
            Console.WriteLine();
            Console.WriteLine("Number of elements in the arr: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr2 = new int[n];
            for(int i=0; i<n; i++)
            {
                Console.WriteLine($"Enter element No{i+1}: ");
                arr2[i] = int.Parse(Console.ReadLine());
            }

            int[] unique = GetUniqueElement(arr2);

            Console.WriteLine("Initial array: ");
            foreach(int i in arr2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("Unique elements: ");
            foreach (int i in unique)
            {
                  Console.Write(i + " ");
            }
              

        }
         
        static int[] GetUniqueElement(int[] arr)
        {
            int[] unique = new int[arr.Length];
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                bool isUnique = true;
                for (int j = i; j < arr.Length; j++)
                {
                    if (i != j && arr[i] == arr[j])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    unique[count] = arr[i];
                    count++;
                }
            }

            int[] result = new int[count];
            for(int i = 0; i < count; i++)
            {
                result[i] = unique[i];
            }
            return result;
        }
    }
}
