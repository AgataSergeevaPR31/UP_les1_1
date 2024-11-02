using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP_les1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            double weight = 0;

            while (true)
            {
                Console.Write("Введите имя коту: ");
                name = Convert.ToString(Console.ReadLine());
                //проверка на выход заполнения котов
                if (name == "exit")
                {
                    break;
                }

                while (true)
                {
                    Console.Write("Введите вес кота: ");
                    string weig = Convert.ToString(Console.ReadLine());

                    if (double.TryParse(weig, out weight))
                    {
                        break;
                    }
                }

                if (weight == -100)
                {
                    break;
                }

                //создаём объект, вызывая конструктор класса
                Cat murzik = new Cat(name, weight);
                //вызываем метод класса
                murzik.Meow();
            }
            Console.Write("Заполнение закончено!");

            Console.ReadKey();
        }
    }
}
