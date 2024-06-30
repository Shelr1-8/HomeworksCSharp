namespace _09_Interfaces
{
    interface IOutput
    {
        void Show();
        void Show(string info);
    }
    interface IMath
    {
        int Max();
        int Min();
        double Avg();
        bool Search(int valueToSearch);
    }
    interface ISort
    {
        void SortAsc();
        void SortDesc();
        void SortByParam(bool isAsc);
    }

    public class myArray : IOutput, IMath, ISort
    {
        private int[] arr;
        public myArray(int[] arr)
        {
            this.arr = arr;
        }

        public double Avg()
        {
            return arr.Average();
        }

        public int Max()
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public int Min()
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        public bool Search(int valueToSearch)
        {
            foreach (int item in arr)
            {
                if (item == valueToSearch)
                {
                    return true;
                }
            }
            return false;
        }

        public void Show()
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }

        public void Show(string info)
        {
            Console.WriteLine(info);
            foreach (int i in arr)
            {
                Console.WriteLine(i + " ");
            }
        }

        public void SortAsc()
        {
            Array.Sort(arr);
        }

        public void SortDesc()
        {
            SortAsc();
            Array.Reverse(arr);
        }
        public void SortByParam(bool isAsc)
        {
            if (isAsc)
            {
                SortAsc();
            }
            else
            {
                SortDesc();
            }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zavdanna 1");
            int[] arr = { 1, 2, 3, 4, 5 };
            myArray arr1 = new myArray(arr);
            Console.WriteLine($"My Array:");
            arr1.Show();
            arr1.Show("Xuxu");
            Console.WriteLine("Zavdanna 2");
            Console.WriteLine($"Max: {arr1.Max()}");
            Console.WriteLine($"Min: {arr1.Min()}");
            Console.WriteLine($"Average: {arr1.Avg()}");
            Console.WriteLine($"Sort 5: {arr1.Search(5)}");
            Console.WriteLine($"Sort 6: {arr1.Search(6)}");
            Console.WriteLine("Zavdanna 3");
            arr1.Show();
            Console.WriteLine();
            arr1.SortAsc();
            arr1.Show();
            Console.WriteLine();
            arr1.SortDesc();
            arr1.Show();
            Console.WriteLine();
            arr1.SortByParam(false);
            arr1.Show();
            Console.WriteLine();
        }
    }
}