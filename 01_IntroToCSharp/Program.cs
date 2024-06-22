class Program
{
    static void Main(string[] args)
    {
        {
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
            Console.WriteLine("Return me to C++ ");
        }
        Console.WriteLine("Zavdanna 1");
        Console.WriteLine("It's easy to win forgiveness for being wrong;\nbeing right is what gets you into real trouble.\nBjarne Stroustrup");
        Console.WriteLine("Zavdanna 2");
        Console.WriteLine("Enter firstnumber : ");
        string num1 = Console.ReadLine();
        int number = int.Parse(num1);

        Console.WriteLine("Enter second number : ");
        string num2 = Console.ReadLine();
        int number2 = int.Parse(num2);

        Console.WriteLine("Enter third number : ");
        string num3 = Console.ReadLine();
        int number3 = int.Parse(num3);

        Console.WriteLine("Enter fourth number : ");
        string num4 = Console.ReadLine();
        int number4 = int.Parse(num4);

        Console.WriteLine("Enter fifth number : ");
        string num5 = Console.ReadLine();
        int number5 = int.Parse(num5);

        int sum = number + number2 + number3 + number4 + number5;
        Console.WriteLine("Summa = " + sum);

        if (number > number2 && number > number3 && number > number4 && number > number5)
        {
            Console.WriteLine("The most bigger number is: " + number);
        }
        else if (number2 > number && number2 > number3 && number2 > number4 && number2 > number5)
        {
            Console.WriteLine("The most bigger number is: " + number2);
        }
        else if (number3 > number && number3 > number2 && number3 > number4 && number3 > number5)
        {
            Console.WriteLine("The most bigger number is: " + number3);
        }
        else if (number4 > number && number4 > number2 && number4 > number3 && number4 > number5)
        {
            Console.WriteLine("The most bigger number is: " + number4);
        }
        else if (number5 > number && number5 > number2 && number5 > number3 && number5 > number4)
        {
            Console.WriteLine("The most bigger number is: " + number5);
        }

        if (number < number2 && number < number3 && number < number4 && number < number5)
        {
            Console.WriteLine("The most least number is: " + number);
        }
        else if (number2 < number && number2 < number3 && number2 < number4 && number2 < number5)
        {
            Console.WriteLine("The most least number is: " + number2);
        }
        else if (number3 < number && number3 < number2 && number3 < number4 && number3 < number5)
        {
            Console.WriteLine("The most least number is: " + number3);
        }
        else if (number4 < number && number4 < number2 && number4 < number3 && number4 < number5)
        {
            Console.WriteLine("The most least number is: " + number4);
        }
        else if (number5 < number && number5 < number2 && number5 < number3 && number5 < number4)
        {
            Console.WriteLine("The most least number is: " + number5);
        }

        int dob = number * number2 * number3 * number4 * number5;
        Console.WriteLine("Dobutock = " + dob);

        Console.WriteLine("Zavdanna 3");
        Console.WriteLine("Enter number : ");
        string num6 = Console.ReadLine();
        int number6 = int.Parse(num6);
        int firstn = number6 / 100000;
        int secondn = number6 / 10000 % 10;
        int thirdn = number6 / 1000 % 10;
        int firthn = number6 / 100 % 10;
        int fifthn = number6 / 10 % 10;
        int sixth = number6 % 10;
        Console.WriteLine(firstn);
        Console.WriteLine(secondn);
        Console.WriteLine(thirdn);
        Console.WriteLine(firthn);
        Console.WriteLine(fifthn);
        Console.WriteLine(sixth);
        Console.WriteLine(sixth.ToString() + fifthn.ToString() + firthn.ToString() + thirdn.ToString() + secondn.ToString() + firstn.ToString());


        Console.WriteLine("Zavdanna 4");
        Console.Write("Enter begin  : ");
        string num7 = Console.ReadLine();
        int number7 = int.Parse(num7);
        Console.Write("Enter end : ");
        string num8 = Console.ReadLine();
        int number8 = int.Parse(num8);
        int i = 0;
        int j = 1;
        while (i <= number8)
        {
            if (i >= number7)
            {
                Console.WriteLine(i);
            }

            int temp = i + j;
            i = j;
            j = temp;
        }


        Console.WriteLine("Zavdanna 5");
        Console.Write("Enter first number: ");
        int FN = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int SN = int.Parse(Console.ReadLine());
        for (int i1 = FN; i1 <= SN; i1++)
        {
            for (int j1 = 0; j1 < i1; j1++)
            {
                Console.Write(i1 + " ");
            }
            Console.WriteLine();
        }


        Console.WriteLine("Zavdanna 6");
        Console.Write("Enter length:");
        int length = int.Parse(Console.ReadLine());
        Console.Write("Symbol: ");
        char symbol = char.Parse(Console.ReadLine());
        Console.Write("Enter the direction of the line (v - vertically, h - horizontally):");
        string direction = Console.ReadLine();
        if (direction == "v")
        {
            for (int i2 = 0; i < length; i2++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }
        else if (direction == "h")
        {
            for (int i2 = 0; i2 < length; i2++)
            {
                Console.WriteLine(symbol);
            }
        }
    }
}