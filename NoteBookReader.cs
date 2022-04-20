using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace HW8_List_XML
{
    /// <summary>
    /// Дополнительное задание, читалка XMl Person
    /// </summary>
    internal class NoteBookReader
    {
        /*
    Программа читает из файла данные о контакте:

       ФИО
       Улица
       Номер дома
       Номер квартиры
       Мобильный телефон
       Домашний телефон
   

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
        public NoteBookReader(string fileName)
        {
            FileName = fileName;
            FileInfo info = new FileInfo(fileName);
            if (info.Exists)
            {
                ReadData(FileName);
                //PrintRawData();
                PrintData();
            }
            else
            {
                Console.WriteLine($"Файл {fileName} не найден!");
            }
        }

        private void ReadData(string fileName)
        {
            person = XDocument.Load(fileName);
        }
        private void PrintData()
        {
            Console.WriteLine($"ФИО: {person.Root.Attribute("name").Value}");
            XElement Address = person.Root.Element("Address");
            XElement Phones = person.Root.Element("Phones");
            Console.WriteLine($"Название улицы: {Address.Element("Street").Value}");
            Console.WriteLine($"Номер дома: {Address.Element("HouseNumber").Value}");
            Console.WriteLine($"Номер квартиры: {Address.Element("FlatNumber").Value}");
            Console.WriteLine($"Мобильный телефон: {Phones.Element("MobilePhone").Value}");
            Console.WriteLine($"Домашний телефон: {Phones.Element("FlatPhone").Value}");
        }
        private void PrintRawData()
        {
            Console.WriteLine("XML файл содержит следующий текст:");
            Console.WriteLine(person.ToString());
        }

    }
}
