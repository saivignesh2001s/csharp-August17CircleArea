namespace Circlearea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float pi, radius;
            pi = 3.14f;
            radius = Convert.ToSingle(Console.ReadLine());
            CircleArea(radius,pi);
            Console.WriteLine("Push to git");
            Console.WriteLine("another push");
            Console.ReadLine();
        }
        static void CircleArea(float radius,float pi)
        {
            double area = pi * radius * radius;
            Console.WriteLine(area);

        }
    }
}