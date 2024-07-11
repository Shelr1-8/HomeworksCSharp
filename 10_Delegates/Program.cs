namespace _10_Delegates
{
class ArrayOperations
{
	delegate int CalculationDelegate(int[] array);
	delegate void ModificationDelegate(int[] array);

	static int NegativeNumbers(int[] array)
	{
		int count = 0;
		foreach (int num in array)
		{
			if (num < 0)
			{
				count++;
			}
		}
		return count;
	}

	static int Sum(int[] array)
	{
		int sum = 0;
		foreach (int num in array)
		{
			sum += num;
		}
		return sum;
	}

	static int PrimeNumbers(int[] array)
	{
		int count = 0;
		foreach (int num in array)
		{
			if (IsPrime(num))
			{
				count++;
			}
		}
		return count;
	}

	static void ReplaceNegativesWithZero(int[] array)
	{
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] < 0)
			{
				array[i] = 0;
			}
		}
	}

	static void ArraySort(int[] array)
	{
		Array.Sort(array);
	}
	static int CompareByParity(int a, int b)
	{
		return (a % 2).CompareTo(b % 2);
	}

	static bool IsPrime(int number)
	{
		if (number <= 1) return false;
		for (int i = 2; i * i <= number; i++)
		{
			if (number % i == 0) return false;
		}
		return true;
	}

	static void MoveEvensToFront(int[] array)
	{
		Array.Sort(array, CompareByParity);
	}
	class Program
	{
		static void Main()
		{
				int[] numbers = { 1, -2, 3, -4, 5, -6, 7, -8, 9 };

			CalculationDelegate[] calculations = new CalculationDelegate[]
			{
				NegativeNumbers,
				Sum,
				PrimeNumbers
			};

			ModificationDelegate[] modifications = new ModificationDelegate[]
			{
				ReplaceNegativesWithZero,
				ArraySort,
				MoveEvensToFront
			};

			while (true)
			{
				Console.WriteLine("Choose the type of operation:");
				Console.WriteLine("1. Calculation");
				Console.WriteLine("2. Array modification");
				Console.WriteLine("3. Exit");
				int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Choose a calculation operation:");
                    Console.WriteLine("1. Number of negative elements");
                    Console.WriteLine("2. Sum of all elements");
                    Console.WriteLine("3. Number of prime numbers");

                    int calculationChoice = int.Parse(Console.ReadLine());
                    int result = 0;
                    switch (calculationChoice)
                    {
                        case 1:
                            result = NegativeNumbers(numbers);
                            break;
                        case 2:
                            result = Sum(numbers);
                            break;
                        case 3:
                            result = PrimeNumbers(numbers);
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            continue;
                    }
                    Console.WriteLine($"Result: {result}");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Choose an array modification operation:");
                    Console.WriteLine("1. Replace negatives with 0");
                    Console.WriteLine("2. Sort the array");
                    Console.WriteLine("3. Move evens to the front");

                    int modificationChoice = int.Parse(Console.ReadLine());
                    switch (modificationChoice)
                    {
                        case 1:
                            ReplaceNegativesWithZero(numbers);
                            break;
                        case 2:
                            ArraySort(numbers);
                            break;
                        case 3:
                            MoveEvensToFront(numbers);
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            continue;
                    }
                    Console.WriteLine("Array modified:");
                    Console.WriteLine(string.Join(", ", numbers));
                }

                if (choice == 3)
				{
					Console.WriteLine("Exit...");
					break;
				}
			}
		}
	}
}
}
