using System;
using System.Collections.Generic;
using System.Globalization;
using AbstractMethod.Entities;
using AbstractMethod.Entities.Enums;
namespace AbstractMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            List<Shape> shapes = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or circle(r/c)? ");
                char response = char.Parse(Console.ReadLine());
                Console.Write("Color(Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if(response == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Circle(radius, color));
                }
            }
            Console.WriteLine("SHAPE AREAS: ");
            foreach(var shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
