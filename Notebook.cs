using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static HW8_List_XML.InputClass;

namespace HW8_List_XML
{
    /// <summary>
    /// Задание 4. Записная книжка
    /// </summary>
    internal class Notebook
    {
        /*
         Программа спрашивает у пользователя данные о контакте:

            ФИО
            Улица
            Номер дома
            Номер квартиры
            Мобильный телефон
            Домашний телефон
        Заполняйте XElement в ходе заполнения данных. Изучите возможности XElement в документации Microsoft.
        С помощью XElement создайте xml файл, в котором есть введенная информация. XML файл должен содержать следующую структуру:

        <Person name=”ФИО человека” >
            <Address>
                <Street>Название улицы</Street>
                <HouseNumber>Номер дома</HouseNumber>
                <FlatNumber>Номер квартиры</FlatNumber>
            </Address>
            <Phones>
                <MobilePhone>89999999999999</MobilePhone>
                <FlatPhone>123-45-67<FlatPhone>
            </Phones>
        </Person>
         */

        private XDocument person;
        private string FileName;
        public Notebook(string fileName)
        {
            FileName = fileName;
            person = new XDocument();
            FillingData();
            SaveDataFile(FileName);
            ShowData();
        }

        private void FillingData()
        {
            Console.WriteLine("Данные о контакте:");
            XAttribute name = new XAttribute("name", Input<string>("Введите ФИО"));
            XElement Street = new XElement("Street", Input<string>("Улица"));
            XElement HouseNumber = new XElement("HouseNumber", Input<string>("Номер дома"));
            XElement FlatNumber = new XElement("FlatNumber", Input<string>("Номер квартиры"));
            XElement MobilePhone = new XElement("MobilePhone", Input<string>("Мобильный телефон"));
            XElement FlatPhone = new XElement("FlatPhone", Input<string>("Домашний телефон"));

            XElement Person = new XElement("Person");
            XElement Address = new XElement("Address");
            XElement Phones = new XElement("Phones");

            Address.Add(Street, HouseNumber, FlatNumber);
            Phones.Add(MobilePhone, FlatPhone);
            Person.Add(name, Address, Phones);
            person.Add(Person);
        }
        private void SaveDataFile(string fileName)
        {
            person.Save(fileName);
            Console.WriteLine($"Файл сохранён под именем: {fileName}");
        }
        private void ShowData()
        {
            Console.WriteLine( $"Вы создали следующий XML:\n{person.ToString()}");
        }

    }
}
