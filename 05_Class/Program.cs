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

    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
