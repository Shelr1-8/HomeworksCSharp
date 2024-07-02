namespace _04_OOP
{
    public class Freezer
    {
        private string model;
        private int year;
        private int maxTemp;
        private int minTemp;
        private string color;
        private static string production;
        private static int count;

        static Freezer()
        {
            production = "BOSCH";
            count = 70;
        }
        public Freezer()
        {
            this.model = "Standard";
            this.maxTemp = 0;
            this.minTemp = 0;
            this.color = "none";
        }
        public Freezer(string model, int year)
        {
            this.model = model;
            this.year = year;   
        }

        public Freezer(string model, int year, int maxTemp, int minTemp, string color) : this(model, year)
        {
            this.maxTemp = maxTemp;
            this.minTemp = minTemp;
            this.color = color;
        }



        public override string ToString()
        {
            return $"Model: {model}, Year: {year}, Max Temperature: {maxTemp}, Min Temperature: {minTemp}, Color: {color}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Freezer freezer1 = new Freezer("Model: Liebherr IRe 5100 Pure", 2022);
            Freezer freezer2 = new Freezer("Model:  KGN36NL306", 2023, -15, -25, "silver");
            Freezer freezer3 = new Freezer();

            Console.WriteLine(freezer1.ToString());
            Console.WriteLine(freezer2.ToString());
            Console.WriteLine(freezer3.ToString());
        }
    }
}
