using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HW8_List_XML.InputClass;

namespace HW8_List_XML
{
    /// <summary>
    /// Задание 2. Телефонная книга
    /// </summary>
    internal class PhoneBook
    {
        /*
            Пользователю итеративно предлагается вводить в программу номера телефонов и ФИО их владельцев. 
            В процессе ввода информация размещается в Dictionary, где ключом является номер телефона, а значением — ФИО владельца.
        Таким образом, у одного владельца может быть несколько номеров телефонов. Признаком того, что пользователь закончил вводить номера телефонов,
        является ввод пустой строки. 
            Далее программа предлагает найти владельца по введенному номеру телефона. Пользователь вводит номер телефона и ему выдаётся ФИО владельца.
        Если владельца по такому номеру телефона не зарегистрировано, программа выводит на экран соответствующее сообщение.
         */

        private Dictionary<string, string> phones;

        public PhoneBook()
        {
            phones = new Dictionary<string, string>();
            FillPhones();
            SearchOwner();
        }

        private void FillPhones()
        {
            string phone, fio;
            while (true)
            {
                phone = Input<string>("Введите номер телефона (пустая строка для выхода): ");
                if (phone.Equals("")) break;
                fio = Input<string>("Введите ФИО владельца: ");
                if (fio.Equals("")) break;
                phones.Add(phone, fio);
            }
        }

        private void SearchOwner()
        {
            string phone, fio;
            while (true)
            {
                phone = Input<string>("Введите номер телефона для поиска (пустая строка для выхода): ");
                if (phone.Equals("")) break;

                if (phones.TryGetValue(phone, out fio))
                {
                    Console.WriteLine($"ФИО владельца: {fio}");
                }
                else
                {
                    Console.WriteLine($"Владелец не найден");
                }
                
            }
        }

    }
}
