using System;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(IsExist(5678, 0));
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
