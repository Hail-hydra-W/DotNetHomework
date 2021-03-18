using System;

namespace Shape
{

    public interface Shape
    {
        double getArea();
        bool isLegal();
    }

    public class Rectangle : Shape
    {
        public double width;
        public double height;
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double getArea()
        {
            return width * height;
        }

        public bool isLegal()
        {
            if (width > 0 && height > 0)
                return true;
            else
                return false;
        }
    }

    public class Square : Shape
    {
        public double side;
        public Square(double side)
        {
            this.side = side;
        }

        public double getArea()
        {
            return side * side;
        }

        public bool isLegal()
        {
            if (side > 0)
                return true;
            else
                return false;
        }
    }

    public class Triangle : Shape
    {
        public double a, b, c;
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double getArea()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool isLegal()
        {
            if ((a + b) > c && (a + c > b) && (b + c) > a)
                return true;
            else
                return false;
        }
    }

    class RandomShape
    {
        public static double ShapeSelect()
        {
            Random ran = new Random();
            int shapeTypeNumber = ran.Next(1, 3);
            int randomNumber1 = ran.Next(1, 100);
            int randomNumber2 = ran.Next(1, 100);
            int randomNumber3 = ran.Next(1, 100);

            switch (shapeTypeNumber)
            {
                case 1:
                    return new Rectangle(randomNumber1, randomNumber2).getArea();
                case 2:
                    return new Square(randomNumber1).getArea();
                case 3:
                    return new Triangle(randomNumber1, randomNumber2, randomNumber3).getArea();
                default:
                    return 0;
            }
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            double sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += RandomShape.ShapeSelect();
            }
                Console.WriteLine(sum);
        }
    }
}
