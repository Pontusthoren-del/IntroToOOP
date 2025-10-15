namespace IntroToOOP
{
    internal class Program
    {
        static void ShowCircle()
        {
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);
            Console.WriteLine($"Arean av en cirkel med radian {circle1.Radius} är: " + circle1.GetArea());
            Console.WriteLine();
            Console.WriteLine($"Arean är en cirkel med radian {circle2.Radius} är: " + circle2.GetArea());
        }
        static void PrintSphere()
        {
            Circle c = new Circle(0);
            c.Volume();

        }
        static void PrintTriangle()
        {
            Triangle t = new Triangle();
            t.CalculateTriangle();
        }
        static void Main(string[] args)
        {
            ShowCircle();
            PrintSphere();
            PrintTriangle();
        }
    }
}
