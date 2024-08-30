using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_area_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string shape;
            int rectangleLength;
            int rectangleWidth;
            int rectangleArea;
            double circleRadius;
            double circleArea;
            double pi = 3.142;
            Convert.ToDouble(pi);


            Console.WriteLine("For the area of the shape. Enter r for rectangle and c for circle");
            shape = Console.ReadLine();
            switch (shape)
            {
                case "r":
                Console.WriteLine("Enter the length of the rectangle");
                rectangleLength = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the width of the rectangle");
                rectangleWidth = Convert.ToInt32(Console.ReadLine());

                rectangleArea = rectangleLength * rectangleWidth;
                Console.WriteLine("The area of your rectangle " + rectangleArea);
                    break;

                case "c":
                Console.WriteLine("Enter radius of circle");
                circleRadius = Convert.ToDouble(Console.ReadLine());

                circleArea = circleRadius * circleRadius * pi;
                Console.WriteLine("The area of the circle is " + circleArea);
                    break;
            }
            Console.WriteLine("Thank you for using shape area cal");
            Console.ReadKey();
        }
        
    }
}
