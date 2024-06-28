using static System.Console;
namespace _06_Exception
{
public class Card
{
    private string numberCard;
    public string NumberCard
    {
        get { return numberCard; }
        set
        {
            if (value.Length != 8)
            {
                throw new ArgumentException("lenght of card number must be 8");
            }
            else
            {
                numberCard = value;
            }
        }
    }
    private string name;

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name can't be empty");
            }
            else
            {
                name = value;
            }
        }
    }
    private string lastName;

    public string LastName
    {
        get { return lastName; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("LastName cant be empty");
            }
            else
            {
                lastName = value;
            }
        }
    }
    private string secondName;

    public string SecondName
    {
        get { return secondName; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("SecondName cant be empty");
            }
            else
            {
                secondName = value;
            }
        }
    }
    private string cvc;

    public string CVC
    {
        get { return cvc; }
        set
        {
            if (value.Length != 3)
            {
                throw new ArgumentException("lenght of CVC must be 3");
            }
            else
            {
                cvc = value;
            }
        }
    }
    private DateTime data;

    public DateTime Data
    {
        get { return data; }
        set
        {
            if (data <= DateTime.Now)
            {
                data = value; 
            }
            else
            {
                throw new ArgumentException("Data wrong");
            }
        }
    }

    public void Print()
        {
            WriteLine($"Number card {numberCard}");
            WriteLine($"Name {name}, lastname {lastName}, secondname {secondName}");
            WriteLine($"CVC {cvc}");
            WriteLine($"Date {data}");
        }

}
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Zavdanna 1");
            try
            {
                WriteLine("Enter number 0-9");
                int num = int.Parse(ReadLine());
                if(num < 0 || num > 9)
            {
                    throw new ArgumentOutOfRangeException("The number must be between 0 and 9.");
                }

                WriteLine($"Your number is {num}");
            }
            catch (OverflowException)
            {
                WriteLine("OverflowException");
            }
            catch (FormatException )
            {
                Console.WriteLine("FormatException");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception catch!");
                Console.WriteLine(e.Message);
            }

            WriteLine("Zavdanna 2");
            Card card = new Card();
            Write("Enter number card: ");
            card.NumberCard = ReadLine();
            Write("Enter name:");
            card.Name = ReadLine();
            Write("Enter lastname: ");
            card.LastName = ReadLine();
            Write("Enter secondname: ");
            card.SecondName = ReadLine();
            Write("Enter CVC: ");
            card.CVC = ReadLine();
            Write("Enter date: ");
            card.Data = DateTime.Parse(ReadLine());
            card.Print();
        }
    }
}