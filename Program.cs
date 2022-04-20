using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HW8_List_XML.InputClass;

namespace HW8_List_XML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic _;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Домашняя работа 8. Выберете номер задания:");
                Console.WriteLine(" Задание 1. Работа с листом");
                Console.WriteLine(" Задание 2. Телефонная книга");
                Console.WriteLine(" Задание 3. Проверка повторов");
                Console.WriteLine(" Задание 4. Записная книжка");
                Console.WriteLine(" Задание 5. Дополнительное задание, читалка XMl Person");
                Console.WriteLine(" 0. Выход");
                switch (Input<int>())
                {
                    case 0: return;
                    case 1:
                        _ = new ListClass();                    // Задание 1.Работа с листом.
                        Console.ReadKey();
                        break;
                    case 2:
                        _ = new PhoneBook();                    // Задание 2. Телефонная книга.
                        Console.ReadKey();
                        break;
                    case 3:
                        _ = new Replays();                      // Задание 3. Проверка повторов
                        Console.ReadKey();
                        break;
                    case 4:
                        _ = new Notebook("xml_Person_file.xml");// Задание 4. Записная книжка
                        Console.ReadKey();
                        break;
                    case 5:
                        _ = new NoteBookReader("xml_Person_file.xml");// Задание 5. Дополнительное задание, читалка XMl Person
                        Console.ReadKey();
                        break;
                    default :
                        Console.Clear();
                        Console.WriteLine("Такого задания нет, выберете из предложенных!");
                        Console.ReadKey();
                        continue;
                }
                
            }
        }
    }
}
