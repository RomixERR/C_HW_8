using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HW8_List_XML.InputClass;

namespace HW8_List_XML
{   /// <summary>
    /// Задание 3. Проверка повторов
    /// </summary>
    internal class Replays
    {
        /*
         Пользователь вводит число. Число сохраняется в HashSet коллекцию.
        Если такое число уже присутствует в коллекции, то пользователю на экран выводится сообщение,
        что число уже вводилось ранее. Если числа нет, то появляется сообщение о том, что число успешно сохранено. 
         */
        private HashSet<int> collection;

        public Replays()
        {
            collection = new HashSet<int>();
            EnterNumbers();
            PrintNumbers();
        }
        private void EnterNumbers()
        {
            int n;
            while (true)
            {
                n = Input<int>(out bool isEmpty, "Введите число (пустой ввод для завершения)");
                if (isEmpty) return;
                if (collection.Contains(n))
                {
                    Console.WriteLine("Число уже вводилось ранее");
                }
                else
                {
                    collection.Add(n);
                    Console.WriteLine("Число успешно сохранено");
                }
                //collection.Add(n);
            }
        }

        private void PrintNumbers()
        {
            Console.WriteLine("Коллекция содержит следующие числа:");
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }


    }
}
