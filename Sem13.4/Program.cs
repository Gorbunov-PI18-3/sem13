using System;
using System.Collections.Generic;


namespace Sem13._4
{
    class Program
    {
        public static Stack<string> words = new Stack<string>();
        static void Main(string[] args)
        {

            Console.WriteLine("Введите слово и нажмите Enter, чтобы добавить его в стек.");
            Console.WriteLine();

            while (true)
            {
                var input = Console.ReadLine();

                words.Push(input); // Изменить здесь


                Console.WriteLine();
                Console.WriteLine("В стеке:");

                foreach (var word in words)
                {
                    Console.WriteLine(" " + word);
                }

                switch (input)
                {
                    case "pop":
                        words.TryPop(out string popResult);
                        break;

                    case "peek":
                        words.TryPeek(out string peekResult);
                        break;
                    default:
                        
                        words.Push(input);
                        break;
                }

            }
            /*Stack<int> numbers = new Stack<int>();

            numbers.Push(3); 
            numbers.Push(5); 
            numbers.Push(8); 

            Console.WriteLine("Элементы числового стека: ");
            foreach (var number in numbers)
                Console.WriteLine(number);

            Console.WriteLine($"Извлекаем верхний элемент из стека: {numbers.Pop()}");


            Console.WriteLine();

            Stack<Person> persons = new Stack<Person>();
            persons.Push(new Person() { Name = "Иван" });
            persons.Push(new Person() { Name = "Сергей" });
            persons.Push(new Person() { Name = "Анна" });

            Console.WriteLine("Элементы стека объектов: ");
            foreach (Person p in persons)
                Console.WriteLine(p.Name);

            Console.WriteLine($"Извлекаем верхний элемент из стека объектов: {persons.Pop().Name}");
            */
        }
    }

    class Person
    {
        public string Name { get; set; }
    }
}
