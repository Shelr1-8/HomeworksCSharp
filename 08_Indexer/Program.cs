namespace _08_Indexer
{
    public abstract class GeometriFigur
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
        public abstract void Print();
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
        public override void Print()
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
            return A1 * 4;
        }
        public override void Print()
        {
            Console.WriteLine($"Area: {GetArea()}. Perimeter: {GetPerimeter()}.");
        }
    }

    public class Romb : GeometriFigur
    {
        public double D1 { get; set; }
        public double D2 { get; set; }
        public double A2 { get; set; }
        public Romb(double d1, double d2, double a2)
        {
            D1 = d1;
            D2 = d2;
            A2 = a2;
        }
        public override double GetArea()
        {
            return (D1 * D2)/2;
        }
        public override double GetPerimeter()
        {
            return A2 * 4;
        }
        public override void Print()
        {
            Console.WriteLine($"Area: {GetArea()}. Perimeter: {GetPerimeter()}.");
        }
    }

    public class Rectangle : GeometriFigur
    {
        public double A3 { get; set; }
        public double B3 { get; set; }

        public Rectangle(double a3, double b3)
        {
            A3 = a3;
            B3 = b3;
        }
        public override double GetArea()
        {
            return A3 * B3;
        }
        public override double GetPerimeter()
        {
            return (A3 + B3)*2;
        }
        public override void Print()
        {
            Console.WriteLine($"Area: {GetArea()}. Perimeter: {GetPerimeter()}.");
        }
    }

    public class Parallelogram : GeometriFigur
    {
        public double A4 { get; set; }
        public double B4 { get; set; }
        public double H4 { get; set; }
        public Parallelogram(double a4, double b4, double h4)
        {
            A4 = a4;
            B4 = b4;
            H4 = h4;
        }
        public override double GetArea()
        {
            return A4 * H4;
        }
        public override double GetPerimeter()
        {
            return (A4 + B4) * 2;
        }
        public override void Print()
        {
            Console.WriteLine($"Area: {GetArea()}. Perimeter: {GetPerimeter()}.");
        }
    }

    public class Trapeze : GeometriFigur
    {
        public double A5 { get; set; }
        public double B5 { get; set; }
        public double C5 { get; set; }
        public double D5 { get; set; }
        public double H5 { get; set; }
        public Trapeze(double a5, double b5,double c5, double d5 ,double h5)
        {
            A5 = a5;
            B5 = b5;
            C5 = c5;
            D5 = d5;
            H5 = h5;
        }
        public override double GetArea()
        {
            return ((A5 + B5)/2)*H5;
        }
        public override double GetPerimeter()
        {
            return A5 + B5 + C5 + D5;
        }
        public override void Print()
        {
            Console.WriteLine($"Area: {GetArea()}. Perimeter: {GetPerimeter()}.");
        }
    }

    public class Circle : GeometriFigur
    {
        public double Radius { get; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public override void Print()
        {
            Console.WriteLine($"Area: {GetArea()}. Perimeter: {GetPerimeter()}.");
        }
    }

    public class Ellipse : GeometriFigur
    {
        public double A6 { get; set; }
        public double B6 { get; set; }

        public Ellipse(double a6, double b6)
        {
            A6 = a6;
            B6 = b6;
        }
        public override double GetArea()
        {
            return Math.PI * A6 * B6;
        }
        public override double GetPerimeter()
        {
            return 666;
        }
        public override void Print()
        {
            Console.WriteLine($"Area: {GetArea()}. Perimeter: {GetPerimeter()}.");
        }
    }

    public class CompositeFigure
    {
        private GeometriFigur[] figures;

        public CompositeFigure(params GeometriFigur[] figures)
        {
            this.figures = figures;
        }
    }

        internal class Program
    {
        static void Main(string[] args)
        {
            Triangle tri = new Triangle(3, 4, 5, 6);
            Square squ = new Square(3);
            Romb rom = new Romb(4, 5, 6);          
            Rectangle rec = new Rectangle(4, 5);
            Parallelogram par = new Parallelogram(5, 6, 4);
            Trapeze tra = new Trapeze(3, 4, 5, 6, 7);
            Circle cir = new Circle(3);
            Ellipse ell = new Ellipse(5, 3);
            Console.WriteLine("-------------Triangle-----------");
            tri.Print();
            Console.WriteLine("-------------Square-----------");
            squ.Print();
            Console.WriteLine("-------------Romb-----------");
            rom.Print();
            Console.WriteLine("-------------Rectangle-----------");
            rec.Print();
            Console.WriteLine("-------------Parallelogram-----------");
            par.Print();
            Console.WriteLine("-------------Trapeze-----------");
            tra.Print();
            Console.WriteLine("-------------Circle-----------");
            cir.Print();
            Console.WriteLine("-------------Ellipse-----------");
            ell.Print();
        }
    }
}