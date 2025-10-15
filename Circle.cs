using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    internal class Circle
    {
        static float _pi = 3.141f;
        public int Radius;

        public Circle(int radius) 
        {
            Radius = radius;
        }

        public float GetArea()
        {
            return _pi * Radius * Radius;
        }

        public void Volume()
        {
            float r;
            Console.Write("Radius: ");
            r = Convert.ToSingle(Console.ReadLine());

            float area = 4 * MathF.PI * (r * r);
            float volume = (4f / 3f) * MathF.PI * (r * r * r);
            Console.WriteLine();
            Console.WriteLine("Sfärens ytarea: " + area);
            Console.WriteLine();
            Console.WriteLine("Sfärens volym: "+ volume);
            Console.WriteLine();
        }
    }
}
