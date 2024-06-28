using System.Text;

namespace _03_str
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zavdanna 1");
            string OrText = "I love C++, and  love C#";
            Console.WriteLine(OrText);
            string Word = "dont";
            Console.WriteLine("Enter position preferably 16 : ");
            int Position = int.Parse(Console.ReadLine());
            string resText = OrText.Insert(Position, Word);
            Console.WriteLine(resText);

            Console.WriteLine("Zavdanna 2");
            Console.Write("Enter word : ");
            string word = Console.ReadLine();
            char[] stringArray = word.ToCharArray();
            Array.Reverse(stringArray);
            string reversedStr = new string(stringArray);
            Console.WriteLine(reversedStr);
            if (word == reversedStr)
            {
                Console.WriteLine("Word is palindrom");
            }
            else
            {
                Console.WriteLine("Word is not palindrom");

            }

            Console.WriteLine("Zavdanna 3");
            string Text = "The text is given. " +
                "Determine the percentage ratio of lowercase and uppercase " +
                "letters to the total number of characters in it.";
            Console.WriteLine(Text);
            int CountLower = 0;
            int CountUpper = 0;
            foreach (char i in Text)
            {
                if (char.IsLower(i))
                    CountLower++;
                else if (char.IsUpper(i))
                    CountUpper++;
            }
            double lowerCountPercentage = (double)CountLower / Text.Length * 100;
            double upperCountPercentage = (double)CountUpper / Text.Length * 100;
            Console.WriteLine($"Lowercase letters: {lowerCountPercentage} %");
            Console.WriteLine($"Uppercase letters: {upperCountPercentage} %");

            Console.WriteLine("Zavdanna 4");
            string[] array = { "Rivne", "Step", "School", "House", "Cat" };
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length >= 5)
                {
                    array[i] = array[i].Substring(0, array[i].Length - 3) + "$$$";
                }
            }
            foreach (string w in array)
            {
                Console.WriteLine(w);
            }
            Console.WriteLine();

            Console.WriteLine("Zavdanna 5");
            string text = "Find the word that is in the text under a certain number, and display its first letter.";
            Console.WriteLine(text);
            Console.Write("Enter word which you want to found first number: ");
            string words = Console.ReadLine();
            int wordIndex = Array.IndexOf(text.Split(), words);
            char firstLetter = text.Split()[wordIndex][0];
            Console.WriteLine($"The first letter of the word '{words}' in the text: {firstLetter}");

            Console.WriteLine("Zavdanna 6");
            string text1 = "Given a string of words separated by spaces. There can be several spaces between words, and there can also be spaces at the beginning and end of a line.";
            string[] word1 = text1.Split(new char[] { ' ',',','.' });
            string result = string.Join("*", word1);
            Console.WriteLine(result);

            Console.WriteLine("Zavdanna 7");
            StringBuilder sb = new StringBuilder();
            string word2;
            Console.WriteLine("Enter words to stop enter a word with a period at the end:\r\n");
            while (true)
            {
                word2 = Console.ReadLine();
                sb.Append(word2);

                if (word2.EndsWith("."))
                {
                    break;
                }
                sb.Append(" ");
            }
            Console.WriteLine( sb.ToString());
        }
    }
}
