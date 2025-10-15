using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace IntroToOOP
{
    internal class Triangle
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(double baseLenght, double height)
        {
            Base = baseLenght;
            Height = height;
        }
        public Triangle()
        {

        }
        public double GetTriangleArea()
        {
            return (Base * Height) / 2;
        }
        public void CalculateTriangle()
        {
            Console.WriteLine();
            Console.Write("Skriv in triangels bas: ");
            Base = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Skriv in triangelns höjd: ");
            Height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Triangelns area är: {GetTriangleArea()}");
        }
    }
}

//double angle;
//Console.Write("Skriv in trianglens vinkel: ");
//angle = Convert.ToDouble(Console.ReadLine());

//double angleRadians = angle * Math.PI / 180;