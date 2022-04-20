using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_List_XML
{   /// <summary>
    /// Задание 1. Работа с листом.
    /// </summary>
    internal class ListClass
    {
        /*
         Создайте лист целых чисел. 
         Заполните лист 100 случайными числами в диапазоне от 0 до 100. 
         Выведите коллекцию чисел на экран. 
         Удалите из листа числа, которые больше 25, но меньше 50. 
         Снова выведите числа на экран. 
        */

        private List<int> list;

        public ListClass()
        {
            list = new List<int>();
            FillList(100);
            PrintList();
            SortingList();
            PrintList();
        }

        private void FillList(int length )
        {
            Console.WriteLine("Fill list");
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                list.Add(rnd.Next(0,101));
            }
        }

        private void PrintList()
        {
            Console.WriteLine($"Total in list now: {list.Count}");
            Console.WriteLine("Print list");
            foreach (var item in list)
            {
                Console.Write($"{item} ,");
            }
            Console.WriteLine();
        }

        private void SortingList()
        {
            Console.WriteLine("Sort list");
            list.RemoveAll(RemovePredicate);
        }

        private bool RemovePredicate(int item)
        {
            if (item > 25 && item < 50) return true; else return false;
        }


    }
}
