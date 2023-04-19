using System;

namespace Lab_2._1
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double DistanceTo(Point other)
        {
            double dx = X - other.X;
            double dy = Y - other.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }

    class Rectangle
    {
        private Point topLeft;
        private Point botRight;

        public Rectangle(Point topLeft, Point bottRight)
        {
            if (topLeft.X >= botRight.X || topLeft.Y <= bottRight.Y)
            {
                throw new ArgumentException("Invalid rectangle coordinates.");
            }

            this.topLeft = topLeft;
            this.botRight = bottRight;
        }

        public double GetArea()
        {
            return GetWidth() * GetHeight();
        }

        public double GetPerimeter()
        {
            return 2 * (GetWidth() + GetHeight());
        }

        public double GetWidth()
        {
            return botRight.X - topLeft.X;
        }

        public double GetHeight()
        {
            return topLeft.Y - botRight.Y;
        }

        public void PrintData()
        {
            Console.WriteLine($"Top-left: ({topLeft.X}, {topLeft.Y})");
            Console.WriteLine($"Bottom-right: ({botRight.X}, {botRight.Y})");
            Console.WriteLine($"Area: {GetArea():F3}");
            Console.WriteLine($"Perimeter: {GetPerimeter():F3}");
            Console.WriteLine($"Width: {GetWidth():F3}");
            Console.WriteLine($"Height: {GetHeight():F3}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int Repline;
            do
            {
                Console.WriteLine("Enter the coordinates of the top-left and bottom-right corners of the rectangle:");
                Console.Write("Top-left X: ");
                double topLeftX = double.Parse(Console.ReadLine());
                Console.Write("Top-left Y: ");
                double topLeftY = double.Parse(Console.ReadLine());
                Console.Write("Bottom-right X: ");
                double botRightX = double.Parse(Console.ReadLine());
                Console.Write("Bottom-right Y: ");
                double botRightY = double.Parse(Console.ReadLine());

                Point topLeft = new Point(topLeftX, topLeftY);
                Point bottomRight = new Point(botRightX, botRightY);

                Rectangle rect = new Rectangle(topLeft, bottomRight);

                rect.PrintData();
                Console.WriteLine("repeat?(1 = yes,0 = no)");
                Repline = int.Parse(Console.ReadLine());
            } while (Repline == 1 & Repline != 0);
            Console.ReadKey();
        }
    }
}