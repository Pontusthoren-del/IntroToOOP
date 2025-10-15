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

        public void CalculateTriangle()
        {
            double side1;
            double side2;
            //double angle;

            Console.WriteLine();
            Console.Write("Skriv in triangels bas: ");
            side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Skriv in triangelns höjd: ");
            side2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Skriv in trianglens vinkel: ");
            //angle = Convert.ToDouble(Console.ReadLine());

            //double angleRadians = angle * Math.PI / 180;

            double area = side1 * side2 / 2;
            Console.WriteLine();
            Console.WriteLine($"Triangelns area är: {area}");
        }
    }
}
