using System;
using System.Collections.Generic;

namespace SortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] {23,97,46,153,248,5,129};
            Array.Sort(numbers);
            Console.WriteLine("数组元素的最大值为：{0}" , numbers[numbers.Length - 1]);
            Console.WriteLine("数组元素的最小值为：{0}" , numbers[0]);
            float sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            float average = sum / numbers.Length;
            Console.WriteLine("数组元素的平均值为：{0}", average);
            Console.WriteLine("数组元素的和为：{0}", sum);
        }
    }
}
