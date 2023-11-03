using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanovJD.Sprint3.Task3.V23.Lib;

namespace Tyuiu.IvanovJD.Sprint3.Task3.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Иванов  Я.Д. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнила: Иванов  Я.Д.    | ПКТб-23-2                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach заменить буквы s на цифру 8 в строке:            *");
            Console.WriteLine("* fdsst siu vsrs                                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            string value = "fdsst siu vsrs";
            char replaceable = 's';
            char replacement = '8';


            Console.WriteLine("Строка = " + value);
            Console.WriteLine("Искомый символ = " + replaceable);
            Console.WriteLine("Символ для замены = " + replacement);

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string value1 = ds.ReplaceCharOnNum(value, replaceable, replacement);
            Console.WriteLine("Результат: " + value1);

            Console.ReadKey();
        }
    }
}
