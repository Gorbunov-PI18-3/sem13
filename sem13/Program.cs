using System;
using System.IO;
using System.Collections.Generic;


namespace sem13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] names =  {
               "Игорь",
               "Андрей",
               "Васиий",
               "София",
               "Елена",
               "Анна",
               "Игорь"
           };

            Console.WriteLine("Длина массива " + names.Length);
            Console.WriteLine();
            Console.WriteLine("Данные в массиве");
            foreach (var n in names)
                Console.WriteLine(n);
            Console.WriteLine();

            HashSet<string> hSet = new HashSet<string>(names);
            Console.WriteLine("Длина хэш-сета " + hSet.Count);
            Console.WriteLine();

            Console.WriteLine("Элементы в хэшсете:");
            foreach (var n in hSet)
                Console.WriteLine(n);

            */

            /*var sentence =
               "Подсчитайте, сколько уникальных символов в этом предложении, используя HashSet<T>," +
               " учитывая знаки препинания," +
               " но не учитывая пробелы в начале и в конце предложения.";

            var characters = sentence.ToCharArray();
            var symbols = new HashSet<char>();
            foreach(var symbol in characters)
               symbols.Add(symbol);

            var signs = new[] { ',', ' ', '.' };
            var numbers = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            bool containsNumbers = symbols.Overlaps(numbers);
            symbols.ExceptWith(signs);


            Console.WriteLine(symbols.Count);
            Console.WriteLine($"Коллекция содержит цифры: {containsNumbers}");
            Console.WriteLine($"Символов без знаков препинания:: {symbols.Count}");
            */


            /*
            while (true)
            {
                Console.WriteLine("Введите текст:");
                var sentence = Console.ReadLine();
                var characters = sentence.ToCharArray();
                var symbols = new HashSet<char>();

                foreach (var symbol in characters)
                    symbols.Add(symbol);
                Console.WriteLine($"Всего {symbols.Count} уникальных символов");
                var signs = new[] { ',', ' ', '.' };
                var numbers = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

                bool containsNumbers = symbols.Overlaps(numbers);
                Console.WriteLine($"Коллекция содержит цифры: {containsNumbers}");

                symbols.ExceptWith(signs);
                Console.WriteLine($"Символов без знаков препинания:: {symbols.Count}");
                Console.WriteLine();
                Console.WriteLine();
            }
            */


            var cities = new Dictionary<string, string[]>(3);
            cities.Add("Россия", new[] { "Москва", "Санкт-Петербург", "Волгоград" });
            cities.Add("Украина", new[] { "Киев", "Львов", "Николаев", "Одесса" });
            cities.Add("Беларусь", new[] { "Минск", "Витебск", "Гродно" });
            foreach (var citiesByCountry in cities)
            {
                Console.Write(citiesByCountry.Key + ": ");
                foreach (var city in citiesByCountry.Value)
                    Console.Write(city + " ");

                Console.WriteLine();
            }

            Console.WriteLine();
            var russianCities = cities["Россия"];
            Console.WriteLine("Города России:");
            foreach (var city in russianCities)
                Console.WriteLine(city);
        }
    }
} 
