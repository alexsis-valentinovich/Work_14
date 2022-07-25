using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Разработать абстрактный класс Animal, который описывает животное. Класс содержит следующие элементы:

//абстрактное свойство - название животного.
//В классе Animal нужно определить следующие методы:

//конструктор, устанавливающий значение по умолчанию для названия;
//абстрактный метод Say(), который выводит звук, который издает животное;
//неабстрактный метод ShowInfo(), который выводит на консоль последовательно название, а затем звук (вызывая метод Say()).
//Разработать классы Cat и Dog, которые реализуют абстрактный класс Animal. В классах реализовать следующие элементы:

//свойство – название животного;
//метод Say(), выводящий на экран «Мяу» либо «Гав» соответственно.
//Создайте экземпляры классов Cat и Dog и проверьте их работоспособность.
namespace Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "животного";
            string sound = "и его звуки для общения";
            Console.Write("Выводим имя {0}, {1}", name, sound);
            Console.WriteLine();
            Animals cat = new Cat(name, sound);
            Console.WriteLine();
            cat.ShowInfo();
            Animals dog = new Dog(name, sound);
            Console.WriteLine();
            dog.ShowInfo();
            Console.ReadKey();
        }
    }
}
