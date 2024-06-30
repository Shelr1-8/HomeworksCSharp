namespace _05_Class
{
    class Worker
    {
        private string name;
        public string Name
        {
            get { return name; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;
                else
                    throw new Exception("Name cant be empty");
            }
        }
        private string surName;
        public string SurName
        {
            get { return surName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    surName = value;
                else
                    throw new Exception("Surname cant be empty");
            }
        }
        private int salary;
        public int Salary
        {
            get { return salary; }
            set
            {
                if (value > 0)
                    salary = value;
                else
                    throw new Exception("Salary cant be smaller than zero");
            }
        }
        private DateTime data;
        public DateTime Data
        {
            get { return data; }
            set
            {
                if (value <= DateTime.Now)
                    data = value;
                else
                    throw new Exception("Data cant be future");
            }
        }
        public void Print()
        {
            Console.WriteLine($"Name: {Name} ");
            Console.WriteLine($"Surname: {SurName} ");
            Console.WriteLine($"Salary: {Salary} ");
            Console.WriteLine($"Date: {Data} ");
        }
    }

    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Sub(double a, double b)
        {
            return a - b;
        }

        public double Mul(double a, double b)
        {
            return a * b;
        }

        public double Div(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Divide by zero unreal.");
            }
            return a / b;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zavdanna 1");
            try
            {
                Worker[] worker = new Worker[2];
                for (int i = 0; i < worker.Length; i++) 
                {
                    Console.WriteLine();
                    worker[i] = new Worker();
                    Console.Write("Enter name:");
                    worker[i].Name = Console.ReadLine();
                    Console.Write("Enter surname:");
                    worker[i].SurName = Console.ReadLine();
                    Console.Write("Enter salary:");
                    worker[i].Salary = int.Parse(Console.ReadLine());
                    Console.Write("Enter date:");
                    worker[i].Data = DateTime.Parse(Console.ReadLine());
                }
                foreach (var item in worker)
                {
                    item.Print();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            Console.WriteLine();

            Console.WriteLine("Zavdanna 2");
            Calculator calculator = new Calculator();
            double num1 = 10;
            double num2 = 5;

            Console.WriteLine($"Addition: {calculator.Add(num1, num2)}");  
            Console.WriteLine($"Subtraction: {calculator.Sub(num1, num2)}"); 
            Console.WriteLine($"Multiplication: {calculator.Mul(num1, num2)}");  

            try
            {
                Console.WriteLine($"Division: {calculator.Div(num1, num2)}"); 
                Console.WriteLine($"Division: {calculator.Div(num1, 0)}");    
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
