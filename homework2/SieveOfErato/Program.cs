using System;

namespace SieveOfErato
{
    class Program
    {
		public  static int[] number = new int[101];    //默认值为0							   //判断一个数是否为素数
		private static bool isPrime(int n)
		{
			for (int i = 2; i < n; i++)
				if (n % i == 0)
					return false;
			return true;
		}
		//创建一个数组，将数组标号为合数的值置为1，将数组标号为素数的值置为0
		//并从2开始遍历输出数组元素值为0的数组标号
		public static void PrimeJudge()
		{
			for (int i = 2; i <= Math.Sqrt(100); i++)
			{
				//判断是否为素数，并根据是否为素数更改数组元素值
				if (isPrime(i))
				{
					for (int k = 2; k <= 100.0 / i; k++)
					{
						number[i * k] = 1;
					}
				}
			}
		}
		//输出素数
		public static void PrimePrint(int[] number)
		{ 
			for (int i = 2; i <= 100; i++)
			{
				if (number[i] == 0)
				{
					Console.WriteLine(i);
				}
			}
		}

        static void Main(string[] args)
        {
			PrimeJudge();
			PrimePrint(number);
        }
    }
}
