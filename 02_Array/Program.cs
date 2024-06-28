namespace _0_2Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region One dimention arr
            //int[] arr = new int[5];
            //arr[0] = 10;
            //arr[1] = 20;
            //arr[2] = 30;
            //arr[3] = 40;
            //arr[4] = 50;

            //Console.WriteLine(arr[0]);
            //Console.WriteLine(arr[1]);
            //Console.WriteLine(arr[2]);
            //Console.WriteLine(arr[3]);
            //Console.WriteLine(arr[4]);


            //int[] arr2 = new int[5];
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    arr2[i] = i * 2;
            //}

            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.Write(arr2[i] + " ");
            //}
            //Console.WriteLine();


            //int[] arr3 = new int[5] { 1, 2, 3, 4, 5 };
            //for (int i = 0; i < arr3.Length; i++)
            //{
            //    Console.Write(arr3[i] + " ");
            //}
            //Console.WriteLine();

            //int[] arr4 = new int[] { 1, 2, 3, 4, 5, 32, 43, 53, 54, };
            //for (int i = 0; i < arr4.Length; i++)
            //{
            //    Console.Write(arr4[i] + " ");
            //}
            //Console.WriteLine();

            //int[] arr5 = new int[10];
            //for (int i = 0; i < arr5.Length; i++)
            //{
            //    Console.Write(arr5[i] + " ");
            //}
            //Console.WriteLine();

            //arr5.SetValue(77, 2);
            //arr5.SetValue(22, 3);

            //foreach (var item in arr4)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Two dimention arr
            //int[,] arr = new int[3, 3];
            //arr[0, 0] = 1;
            //arr[0, 1] = 2;
            //arr[0, 2] = 3;

            //arr[1, 0] = 4;
            //arr[1, 1] = 5;
            //arr[1, 2] = 6;

            //arr[2, 0] = 7;
            //arr[2, 1] = 8;
            //arr[2, 2] = 9;
            //Console.Write(arr[0, 0] + " ");
            //Console.Write(arr[0, 1] + " ");
            //Console.Write(arr[0, 2] + " ");
            //Console.WriteLine();
            //Console.Write(arr[1, 0] + " ");
            //Console.Write(arr[1, 1] + " ");
            //Console.Write(arr[1, 2] + " ");
            //Console.WriteLine();
            //Console.Write(arr[2, 0] + " ");
            //Console.Write(arr[2, 1] + " ");
            //Console.Write(arr[2, 2] + " ");
            //Console.WriteLine();
            ////2
            //int[,] arr2 = new int[3, 5];
            //Console.WriteLine(arr2.Length);
            //for (int i = 0; i < arr2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr2.GetLength(1); j++)
            //    {
            //        arr2[i, j] = i * j + 1;
            //    }
            //}
            //for (int i = 0; i <= arr2.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j <= arr2.GetUpperBound(1); j++)
            //    {
            //        Console.Write( arr2[i, j] = i * j + 1);
            //    }
            //    Console.WriteLine();
            //}
            /////4
            //int[,] arr4 =
            //{
            //      { 1,2,3},
            //      {4,5,6 },
            //      {7,8,9 }
            //  };
            //Console.WriteLine(arr4.Length);
            //Console.WriteLine(arr4);
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{arr4[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region DZ
            Console.WriteLine("Zavdanna 1");
            int[] arr = { 2, 3, 5, 3, 7, 5 };
            int evenNumber = 0;
            int oddNumber = 0;
            int uniqueNumber = 0;
            foreach (int item in arr)
            {
                if (item % 2 == 0)
                {
                    evenNumber++;
                }
                else
                {
                    oddNumber++;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] != arr[j])
                    {
                        uniqueNumber++;
                    }
                }
            }
            Console.WriteLine("Even number: " + evenNumber);
            Console.WriteLine("Odd number: " + oddNumber);
            Console.WriteLine("Unique number: " + uniqueNumber);

            Console.WriteLine("Zavdanna 2");












            #endregion
        }
    }
}