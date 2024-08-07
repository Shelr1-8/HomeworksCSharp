﻿using System.Text;

namespace _13_Dictionary
{
    public class PhoneBook
    {
        private Dictionary<string, string> dic;
        public PhoneBook()
        {
            dic = new Dictionary<string, string>();
        }
        public void Add(string key, string value)
        {
            dic.Add(key, value);
        }
        public void RemoveByKey(string key)
        {
            dic.Remove(key);
        }
        public void ChangeByValue(string key, string value)
        {
            dic[key] = value;
        }
        public void Find(string value)
        {
            if (dic.ContainsKey(value))
            {
                Console.WriteLine(dic[value], "Number you find");
            }
            else
            {
                Console.WriteLine($"The entry with the key '{value}' was not found in the phone book.");
            }
        }
        public void Print()
        {
            foreach (var item in dic)
            {
                Console.WriteLine($"Name {item.Value}, number: {item.Key} ");
            }
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneBook ph = new PhoneBook();
            ph.Add("0912345678", "Sasha");
            ph.Add("0987654321", "Sergiy");
            ph.Add("0924446666", "Sophia");
            ph.Print();
            Console.WriteLine();
            ph.ChangeByValue("0987654321", "Sonya");
            ph.Print();
            Console.WriteLine();
            ph.Find("0987654321");
            ph.RemoveByKey("0924446666");
            ph.Print();
            Console.WriteLine();
            Console.WriteLine("Zavdanna 2");
            Console.OutputEncoding = Encoding.UTF8;//щоб виводило українські букви    PS:для вчительки
            string text = "Ось будинок, який збудував Джек. А це пшениця, яка у темній коморі зберігається у будинку, який збудував Джек. А це веселий птах-синиця, який часто краде пшеницю, яка в темній коморі зберігається у будинку, який збудував Джек.";
            string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?', '-', '—', ':', ';', '(', ')' },StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (wordCounts.ContainsKey(word))
                {
                    wordCounts[word]++;
                }
                else
                {
                    wordCounts[word] = 1;
                }
            }
            Console.WriteLine("Слово \t\tКількість");
            Console.WriteLine("-------------------------");
            foreach (var item in wordCounts)
            {
                Console.WriteLine("{0,-15} {1,-5}", item.Key, item.Value);
            }
        }
    }
}
