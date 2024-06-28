namespace _07_Operators
{
    class Square
    {
        public int A { get; set; }
        public Square() : this(0) { }
        public Square(int a)
        {
            A = a;
        }
        public override string ToString()
        {
            return $"Side : {A}.";
        }
        public override bool Equals(object? obj)
        {
            return obj is Square square &&
                   A == square.A;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(A);
        }
        public static Square operator ++(Square s)
        {
            s.A++;
            return s;
        }
        public static Square operator --(Square s)
        {
            s.A++;
            return s;
        }
        public static Square operator +(Square s1, Square s2)
        {
            Square res = new Square
            {
                A = s1.A + s2.A
            };
            return res;
        }
        public static Square operator -(Square s1, Square s2)
        {
            Square res = new Square
            {
                A = s1.A - s2.A
            };
            return res;
        }
        public static Square operator *(Square s1, Square s2)
        {
            Square res = new Square
            {
                A = s1.A * s2.A
            };
            return res;
        }
        public static Square operator /(Square s1, Square s2)
        {
            Square res = new Square
            {
                A = s1.A / s2.A
            };
            return res;
        }
        public static bool operator <(Square s1, Square s2)
        {
            return s1.A < s2.A;
        }
        public static bool operator >(Square s1, Square s2)
        {
            return s1.A > s2.A;
        }
        public static bool operator <=(Square s1, Square s2)
        {
            return s1.A <= s2.A;
        }
        public static bool operator >=(Square s1, Square s2)
        {
            return s1.A >= s2.A;
        }
        public static bool operator ==(Square s1, Square s2)
        {
            return s1.Equals(s2);
        }
        public static bool operator !=(Square s1, Square s2)
        {
            return !(s1 == s2);
        }
        public static bool operator true(Square s)
        {
            return s.A >= 0;
        }
        public static bool operator false(Square s)
        {
            return s.A < 0;
        }
        public static implicit operator Rectangle(Square s)
        {
            return new Rectangle(s.A, s.A);
        }
        public static implicit operator int(Square s)
        {
            return s.A;
        }
    }
    class Rectangle
    {
        public int A1 { get; set; }
        public int B1 { get; set; }
        public Rectangle() { }
        public Rectangle(int a1, int b1)
        {
            A1 = a1;
            B1 = b1;
        }
        public override string ToString()
        {
            return $"Rectangle with sides {A1} and {B1}";
        }
        public static Rectangle operator +(Rectangle r1, Rectangle r2)
        {
            Rectangle res = new Rectangle
            {
                A1 = r1.A1 + r2.A1,
                B1 = r2.B1 + r2.B1
            };
            return res;
        }
        public static Rectangle operator -(Rectangle r1, Rectangle r2)
        {
            Rectangle res = new Rectangle
            {
                A1 = r1.A1 - r2.A1,
                B1 = r2.B1 - r2.B1
            };
            return res;
        }
        public static Rectangle operator *(Rectangle r1, Rectangle r2)
        {
            Rectangle res = new Rectangle
            {
                A1 = r1.A1 * r2.A1,
                B1 = r2.B1 * r2.B1
            };
            return res;
        }
        public static Rectangle operator /(Rectangle r1, Rectangle r2)
        {
            Rectangle res = new Rectangle
            {
                A1 = r1.A1 / r2.A1,
                B1 = r2.B1 / r2.B1
            };
            return res;
        }
        public static Rectangle operator ++(Rectangle r)
        {
            r.A1++;
            r.B1++;
            return r;
        }
        public static Rectangle operator --(Rectangle r)
        {
            r.A1--;
            r.B1--;
            return r;
        }
        public static bool operator <(Rectangle r1, Rectangle r2)
        {
            return r1.A1 + r2.A1 < r1.B1 + r2.B1;
        }
        public static bool operator >(Rectangle r1, Rectangle r2)
        {
            return !(r1 > r2);
        }
        public static bool operator <=(Rectangle r1, Rectangle r2)
        {
            return r1.A1 + r2.A1 <= r1.B1 + r2.B1;
        }
        public static bool operator >=(Rectangle r1, Rectangle r2)
        {
            return r1.A1 + r2.A1 >= r1.B1 + r2.B1;
        }
        public static bool operator true(Rectangle r1)
        {
            return r1.A1 >= 0 && r1.B1 >= 0;
        }
        public static bool operator false(Rectangle r1)
        {
            return r1.A1 < 0 || r1.B1 < 0;
        }
        public override bool Equals(object? obj)
        {
            return obj is Rectangle rectangle &&
                   A1 == rectangle.A1 &&
                   B1 == rectangle.B1;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(A1, B1);
        }
        public static explicit operator int(Rectangle r)
        {
            return r.A1 + r.B1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square(5);
            Square s1 = new Square(8);
            Square squareSum = s + s1;
            Square squareDif = s - s1;
            Square squarePro = s * s1;
            Square squareDiv = s / s1;
            Console.WriteLine($"Square 1: {s}");
            Console.WriteLine($"Square 2: {s1}");
            Console.WriteLine($"Summa: {squareSum}");
            Console.WriteLine($"Difference: {squareDif}");
            Console.WriteLine($"Product: {squarePro}");
            Console.WriteLine($"Division: {squareDiv}");

            Rectangle r = new Rectangle(1, 2);
            Rectangle r1 = new Rectangle(3, 4);
            Rectangle rectSum = r + r1;
            Rectangle rectDif = r - r1;
            Rectangle rectPro = r * r1;
            Rectangle rectDiv = r / r1;
            Console.WriteLine($"Rectangle 1: {r}");
            Console.WriteLine($"Rectangle 2: {r1}");
            Console.WriteLine($"Summa: {rectSum}");
            Console.WriteLine($"Difference: {rectDif}");
            Console.WriteLine($"Product: {rectPro}");
            Console.WriteLine($"Division: {rectDiv}");
        }
    }

}
