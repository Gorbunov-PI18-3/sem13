using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Sem13._3
{
    class Program
    {

        
        private static Dictionary<string, Contact> PhoneBook = new Dictionary<String, Contact>()
        {
            ["Игорь"] = new Contact(79990000000, "igor@example.com"),
            ["Андрей"] = new Contact(79990000001, "andrew@example.com"),
        };
        
        static void Main(string[] args)
        {

            var watchTwo = Stopwatch.StartNew();
            PhoneBook.TryAdd("Диана", new Contact(79160000002, "diana@example.com"));
            Console.WriteLine($"Вставка в  словарь: {watchTwo.Elapsed.TotalMilliseconds}  мс");

            Console.WriteLine("Текущий список контактов: ");
            WriteAllContacts();
            PhoneBook.TryAdd("Диана", new Contact(79160000002, "diana@example.com"));
            Console.WriteLine("Обновленный список контактов: ");
            WriteAllContacts();

            if (PhoneBook.TryGetValue("Диана", out Contact contact))
                contact.PhoneNumber = 79990000001;
            Console.WriteLine("Список после изменения: ");
            WriteAllContacts();
        }

        public static void WriteAllContacts()
        {
            foreach (var contact in PhoneBook)
                Console.WriteLine(contact.Key + ": " + contact.Value.PhoneNumber);
            Console.WriteLine();
        }

        public class Contact 
        {
            public Contact(long phoneNumber, String email) 
            {
                PhoneNumber = phoneNumber;
                Email = email;
            }
            public long PhoneNumber { get; set; }
            public String Email { get; set; }

            

            /*
            SortedDictionary<string, int> sortedDictionary = new SortedDictionary<string, int>();
            // Добавим несколько элементов в случайном порядке
            sortedDictionary.Add("zebra", 5);
            sortedDictionary.Add("cat", 2);
            sortedDictionary.Add("dog", 9);
            sortedDictionary.Add("mouse", 4);
            sortedDictionary.Add("programmer", 100);
            // Ищем собаку
            if (sortedDictionary.ContainsKey("dog"))
                Console.WriteLine("Нашли собаку");
            // Ищем зебру
            if (sortedDictionary.ContainsKey("zebra"))
                Console.WriteLine("Нашли зебру");
            // Ищем обезьяну
            if (sortedDictionary.ContainsKey("ape"))
                Console.WriteLine("Нашли обезьяну");

            Console.WriteLine();

            // Теперь посмотрим, кто у нас живёт и в каком порядке
            Console.WriteLine("Посмотрим всех:");

            foreach (KeyValuePair<string, int> p in sortedDictionary)
                Console.WriteLine($"{p.Key} = {p.Value}");

            */
        }
    }
}
