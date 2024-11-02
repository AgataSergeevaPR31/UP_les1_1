using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP_les1_1
{
    class Cat
    {
        //создаём поля класса
        private string name;
        private  double weight;
        public string Name // свойство, реализуем инкапсуляцию!
        {
            // получение значения - просто возврат name
            get
            {
                return name;
            }
            // установка значения - используем проверку
            set
            {
                bool OnlyLetters = true;
                // ключ. слово value - это то, что хотят свойству присвоить
                foreach (var ch in value)
                {
                    if (!char.IsLetter(ch))
                    {
                        OnlyLetters = false;
                    }
                }

                if (OnlyLetters)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine($"{value} - неправильное имя!!!");
                    name = "Неизвестный";
                }
            }
        }

        public double Weight // свойство, реализуем инкапсуляцию!
        {
            // получение значения - просто возврат weight
            get
            {
                return weight;
            }
            // установка значения - используем проверку
            set
            {
                bool CorrectNumber = true;
                // ключ. слово value - это то, что хотят свойству присвоить
                //проверка на то, что ввёденное пользователем значение double и больше 0
                if (value <= 0) CorrectNumber = false;

                if (CorrectNumber)
                {
                    weight = value;
                }
                else
                {
                    Console.WriteLine($"{value} - такого веса не может быть!!! Мы заменили его на средний - 4\n");
                    weight = 4;
                }
            }
        }

        //конструктор для создания нового экземпляра
        public Cat(string CatName, double CatWeight)
        {
            Name = CatName;
            Weight = CatWeight;
        }

        //метод, который бы позволял опознать отдельно взятого кота
        public void Meow()
        {
            Console.WriteLine($"{name}: МЯЯЯЯУ!!!!\nВЕС: {weight}\n");
        }
    }
}
