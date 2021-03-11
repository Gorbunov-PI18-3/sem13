using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Sem13._6
{

    public class Contact
    {
        public Contact(long phoneNumber, String email)
        {
            PhoneNumber = phoneNumber;
            Email = email;
        }
        public long PhoneNumber { get; set; }
        public String Email { get; set; }
    }
    class Program
    {
        public static LinkedList<string> LinkedList = new LinkedList<string>();
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



            LinkedList.AddFirst("Лиса");
            LinkedList.AddFirst("Волк");
            var watchThree = Stopwatch.StartNew();
            LinkedList.AddFirst("Кабан");
            Console.WriteLine($"Вставка в  словарь: {watchThree.Elapsed.TotalMilliseconds}  мс");
            Console.WriteLine("Добавление нового элемента в Linkedlist происходит гораздо быстрее чем в list");
        }

    }
    
}