using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance3.Entities;
using Inheritance3.Entities.Enums;

namespace Inheritance3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();


            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i<=n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("(R) Rectangle or (C) Circle? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = (Color)Enum.Parse(typeof(Color), Console.ReadLine());
                if (ch == 'r' || ch == 'R')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());
                    list.Add(new Rectangle(width, height, color));
                }
                else if (ch == 'c' || ch == 'C')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    list.Add(new Circle(radius, color));
                }
                else
                {
                    Console.WriteLine("Not an shape, restart.");
                    return;
                }
                
            }

            Console.WriteLine();

            Console.WriteLine("SHAPE AREAS: ");
            foreach(Shape shp in list)
            {
                Console.WriteLine(shp.Area().ToString("F2"));
            }


        }
    }
}
