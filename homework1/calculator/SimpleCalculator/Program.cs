using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" 请输入数字1：");
            string Number1 = Console.ReadLine();
            Console.Write(" 请选择运算符号(+、-、*、/)：");
            string B = Console.ReadLine();
            Console.Write(" 请输入数字2：");
            string Number2 = Console.ReadLine();
            double a, b;
            a = Convert.ToDouble(Number1);
            b = Convert.ToDouble(Number2);
            double Result = 0;
            switch (B)
            {
                case "+":
                    Result = a + b;
                    break;
                case "-":
                    Result = a - b;
                    break;
                case "*":
                    Result = a * b;
                    break;
                case "/":
                    //异常处理
                    if (b == 0)
                    {
                        break;
                    }
                    else
                    {
                        Result = a / b;
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine(" 计算结果为：" + Result);
        }
    }
}
