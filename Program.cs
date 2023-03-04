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
            List<string> people = new List<string>();
            //Добавление в список
            //1.Добавление нового элемента в список
            people.Add("Bob");
            Output(people);//вызов доп. метода для вывода коллекции
            // people = { "Bob" };
            //2.Добавление в список массива
            people.AddRange(new[] { "Tom","Sam", "Alice" });
            Output(people);
            // people = { "Bob", "Tom", "Sam", "Alice" };
            //3. Вставка элемента item в список по индексу index
            people.Insert(0,"Eugene");
            Output(people);
            //4. Вставка коллекции элементов collection в текущий список начиная с индекса index
            //people.InsertRange(1, new[] { "Mike", "Kate" });
            people.InsertRange(1, new string [] { "Mike", "Kate" });
            Output(people);
            Console.Read();
            
        }
    }
}
