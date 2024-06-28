using System.Drawing;

namespace _08_Indexer
{
    public abstract class GeometriFigur
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }
    public class Triangle : GeometriFigur
    {
        private int A { get; set; }
        private int B { get; set; }
        private int C { get; set; }
        private int H { get; set; }
        public Triangle(int a, int b, int c, int h)
        {
            A = a;
            B = b;
            C = c;
            H = h;
        }
        public override double GetArea()
        {
            return (A * H) / 2;
        }
        public override double GetPerimeter()
        {
            return A + B + C;
        }
        public void Print()
        {
            Console.WriteLine($"Area: {GetArea()}. Perimeter: {GetPerimeter()}.");
        }
    }
    public class Square : GeometriFigur
    {
        private int A1 { get; set; }
        public Square(int a1)
        {
            A1 = a1;
        }
        public override double GetArea()
        {
            return A1 * A1;
        }
        public override double GetPerimeter()
        {
            return A1 * 2;
        }
        public void Print1()
        {
            Console.WriteLine($"Area: {GetArea()}. Perimeter: {GetPerimeter()}.");
        }
    }

    public class Romb : GeometriFigur
    {
        public double D1 { get; set; }
        public double D2 { get; set; }
        public Romb(double d1, double d2)
        {
            D1 = d1;
            D2 = d2;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle tr = new Triangle(3, 4, 5, 6);
            tr.Print();
            Square sq = new Square(3);
            sq.Print1();
        }
    }
}