using System;

namespace OLTest3
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Length : ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Width : ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Height : ");
            double height = Convert.ToDouble(Console.ReadLine());

            double area = Area(length, width);
            double volume = Volume(length, width, height);

            Console.WriteLine($"The area  is: {area}");
            Console.WriteLine($"The volume is: {volume}");
        }

        static double Area(double length, double width)
        {
            return length * width;
        }

        static double Volume(double length, double width, double height)
        {
            return length * width * height;
        }
    }
}
