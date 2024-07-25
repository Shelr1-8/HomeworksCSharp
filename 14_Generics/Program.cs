namespace _14_Generics
{
    internal class Program
    {
        public class MyStack<T>
        {
            private T[] items;
            private int count;
            const int n = 10;
            public MyStack()
            {
                items = new T[n];
            }
            public bool IsEmpty
            {
                get { return count == 0; }
            }
            public int Count
            {
                get { return count; }
            }
            public void Push(T item)
            {
                if (count == items.Length)
                    throw new InvalidOperationException("Stack is full");
                items[count++] = item;
            }
            public T Pop()
            {
                if (IsEmpty)
                    throw new InvalidOperationException("Stack is empty");
                T item = items[--count];
                items[count] = default(T);
                return item;
            }
            public T Peek()
            {
                if (IsEmpty)
                    throw new InvalidOperationException("Stack is empty ");
                return items[count - 1];
            }
            public void Show()
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(items[i]);
                }

                Console.WriteLine();
            }
        }
        public class Queue<T>
        {
            private List<T> elements = new List<T>();

            public void Enqueue(T item)
            {
                elements.Add(item);
            }

            public T Dequeue()
            {
                if (elements.Count == 0)
                    throw new InvalidOperationException("Queue is empty");

                T item = elements[0];
                elements.RemoveAt(0);
                return item;
            }

            public T Peek()
            {
                if (elements.Count == 0)
                    throw new InvalidOperationException("Queue is empty");

                return elements[0];
            }

            public int Count
            {
                get { return elements.Count; }
            }

            public void Show()
            {
                if (elements.Count == 0)
                {
                    Console.WriteLine("Queue is empty");
                }
                else
                {
                    Console.WriteLine("Elements in queue:");
                    foreach (T item in elements)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }

        public static T Max<T>(T a, T b, T c) where T : IComparable<T>
        {
            T max = a;
            if (b.CompareTo(max) > 0)
            {
                max = b;
            }
            if (c.CompareTo(max) > 0)
            {
                max = a;
            }
            return max;
        }
        public static T Min<T>(T a, T b, T c) where T : IComparable<T>
        {
            T min = a;
            if (b.CompareTo(min) < 0)
            {
                min = b;
            }
            if (c.CompareTo(min) < 0)
            {
                min = a;
            }
            return min;
        }
        public static T Sum<T>(T[] array)
        {
            dynamic sum = default(T);
            foreach (T item in array)
            {
                sum += (dynamic)item;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Zavdanna 1");
            int A = Program.Max(1, 2, 3);
            Console.WriteLine($"Max of 1, 2, 3 is: {A}");
            double B = Program.Max(1.1, 2.2, 3.3);
            Console.WriteLine($"Max of 1.1, 2.2, 3.3 is: {B}");

            Console.WriteLine();

            Console.WriteLine("Zavdanna 2");
            int C = Program.Min(1, 2, 3);
            Console.WriteLine($"Min of 1, 2, 3 is: {C}");
            double D = Program.Min(1.1, 2.2, 3.3);
            Console.WriteLine($"Min of 1.1, 2.2, 3.3 is: {D}");

            Console.WriteLine();

            Console.WriteLine("Zavdanna 3");
            int[] intArray = { 1, 2, 3, 4, 5 };
            int sumInt = Program.Sum(intArray);
            Console.WriteLine($"Sum intArray: {sumInt}");

            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            double sumDouble = Program.Sum(doubleArray);
            Console.WriteLine($"Sum doubleArray: {sumDouble}");

            Console.WriteLine();

            Console.WriteLine("Zavdanna 4");
            MyStack<int> myStack = new MyStack<int>();
            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Show();
            Console.WriteLine($"Count: {myStack.Count}");
            int topElement = myStack.Peek();
            Console.WriteLine($"Top element: {topElement}");
            myStack.Pop();
            myStack.Show();

            Console.WriteLine("Zavdanna 5");
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Show();
            Console.WriteLine("Peek: " + queue.Peek());
            Console.WriteLine("Dequeue: " + queue.Dequeue());
            queue.Show();
            queue.Enqueue(4);
            queue.Show();

        }
    }
}
