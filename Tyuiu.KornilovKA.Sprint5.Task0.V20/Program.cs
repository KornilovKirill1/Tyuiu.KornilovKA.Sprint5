using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Tyuiu.KornilovKA.Sprint5.Task0.V20.Lib;

namespace Tyuiu.KornilovKA.Sprint5.Task0.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Корнилов К. А. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Корнилов Кирилл Андреевич | ИИПб-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение f(x) = 2.12 * x^3 + 1.05 * x^2 + 4.1 * x * 2, вычислить  *");
            Console.WriteLine("* его значение при x = 2, результат сохранить в текстовый файл            *");
            Console.WriteLine("* OutPutFileTask0.txt и вывести на консоль. Округлить до трёх знаков      *");
            Console.WriteLine("* после запятой.                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 2;

            Console.WriteLine("X = " + x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");

            Console.ReadLine();
        }
    }
}
