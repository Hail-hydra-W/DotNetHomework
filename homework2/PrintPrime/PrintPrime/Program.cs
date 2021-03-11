using System;

namespace PrintPrime
{
    class Program
    {
        public static bool JudgePrimeDivisor(int k,int i)
        {
            bool isPrime = false;
            if(k % i == 0)
            {
                for(int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    isPrime = true;
                }
            }
            return isPrime;
        }
        public static void PrintPrime()
        {
            Console.WriteLine("请输入一个整数：");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("该数的所有素数因子为：");
            if(k % 2 == 0)
            {
                Console.WriteLine(2);
            }
            if (k % 3 == 0)
            {
                Console.WriteLine(3);
            }
            for (int i = 2; i <= k ; i++)
            {
                bool isPrime = JudgePrimeDivisor(k, i);
                if(isPrime)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Main(string[] args)
        {
            PrintPrime();
        }
    }
}
