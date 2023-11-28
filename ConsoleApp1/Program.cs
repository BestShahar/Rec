using System;
using System.Net;

namespace ConsoleApp1
{
    internal class Program
    {

        public static int Max(int[] arr, int  i)
        {
            if(i==arr.Length-1) 
            {
            return arr[i];
            }
            return Math.Max(arr[i], Max(arr, i + 1));
        }

        public static bool IsExistInArray(int[] arr, int num) 
        {
            return IsExistInArray(arr, num, 0);
        }

        private static bool IsExistInArray(int[] arr, int num, int i)
        {
            if (i == arr.Length) return false;
            if (arr[i] == num) return true;
            return IsExistInArray(arr, num, i + 1);
        }
        public static void Main(string[] args)
        {
            int[] r = {1, 2, 3, 4, 5};
            Console.WriteLine(IsExistInArray(r, 5));
        }

        public static int SumFromEnd(int[] arr, int i)
        {
            if (i == 0)
            {
                return arr[i];
            }
            return arr[i] + SumFromEnd(arr, i - 1);
        }

        public static int DigitCount(int x)
        {
            if (x == 0)
                return 0;
            x /= 10;
            return 1 + DigitCount(x);
        }
        public static int Sum(int x)
        {
            if (x == 0)
                return 0;
            int t = x % 10;
            x /= 10;
            return t + Sum(x);
        }
        public static int fac(int x)
        {
            if(x==0)
                return 1;
            return x * fac(x-1);
        }
        public static bool IsExist(int num, int digit)
        {
            if(num == 0)
                return false;
            if (num%10 == digit)
                return true;
            return IsExist(num/10, digit);

        }
    }
}
