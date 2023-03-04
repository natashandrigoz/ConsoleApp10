using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        /// <summary>
        /// Дополнительный метод для вывода коллекции
        /// </summary>
        /// <param name="list">элемент списка</param>
        //static void Output(List<string> list)//параметр-ссылка
        //{
        //    foreach (string element in list)
        //    {
        //        Console.WriteLine(element);
        //    }
        //    Console.WriteLine();
        //}

        static void Output(List<string> list)//параметр-ссылка
        {
            foreach (string element in list)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
        }


        /// <summary>
        /// Методы списка
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Создание пустого списка
            //List<string> people = new List<string>();
            //Добавление в список
            //1.Добавление нового элемента в список
            //people.Add("Bob");
            //Output(people);//вызов доп. метода для вывода коллекции
            //people = { "Bob" };
            //2.Добавление в список массива
            //people.AddRange(new[] { "Tom","Sam", "Alice" });
            //Output(people);
            // people = { "Bob", "Tom", "Sam", "Alice" };
            //3. Вставка элемента item в список по индексу index
            //people.Insert(0,"Eugene");
            //Output(people);
            //people = { "Eugene", "Tom", "Bob", "Sam", "Alice" };
            //4. Вставка коллекции элементов collection в текущий список начиная с индекса index
            //people.InsertRange(1, new[] { "Mike", "Kate" });
            //people.InsertRange(1, new string [] { "Mike", "Kate" });
            //Output(people);
            // people = { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam", "Alice" };

            //Удаление из списка
            //Создание списка
            //var people = new List<string> { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam", "Tom", "Alice" };
            //1. Удаление элемента по указанному индексу index (второй элемент)
            //people.RemoveAt(1);
            //Output(people);
            // people = { "Eugene", "Kate", "Tom", "Bob", "Sam", "Tom", "Alice" };
            //2. Удаление элемента item ("Tom") из списка
            //people.Remove("Tom");
            //Output(people);
            // people = { "Eugene", "Kate", "Bob", "Sam", "Tom", "Alice" };
            //3. Удаление из списка 2 элемента начиная с индекса 1
            //people.RemoveRange(1, 2);
            //Output(people);
            //people = { "Eugene", "Sam", "Tom", "Alice" };
            //4. Удаление из списка всех элементов
            //people.Clear();
            //people = {  };

            //Расположение элементов в обратном порядке
            //Создание списка
            //var people = new List<string> { "Eugene", "Tom", "Mike", "Sam", "Bob" };
            //Output(people);
            //people.Reverse();
            //Output(people);
            //people = { "Bob","Sam", "Mike", "Tom", "Eugene"};
            //List<string> people2 = new List<string>() { "Eugene", "Tom", "Mike", "Sam", "Bob" };
            // переворачиваем часть только 3 элемента с индекса 1
            //people2.Reverse(1, 3);
            //Output(people);
            //people2 = { "Eugene","Sam", "Mike", "Tom", "Bob" };

            //Список из женских имен
            var name = new List<string>() { "Анна", "Ольга", "Ева", "Ирина", "Марина", "Светлана" };
            Output(name);
            //1. Добавьте в список элементы строчными буквами
            foreach(string element in name)
            {
                Console.WriteLine($"{element.ToUpper()}");
            }
            Console.Read();
            
        }
    }
}
