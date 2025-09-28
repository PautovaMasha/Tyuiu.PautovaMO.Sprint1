using Tyuiu.PautovaMO.Sprint1.Task3.V8.Lib;

namespace Tyuiu.PautovaMO.Sprint1.Task3.V8
{
    class programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил : Паутова М.О. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Паутова Мария Олеговна | ИБКСб-25-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу вычисления величины дохода по вкладу.                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x;
            Console.WriteLine(" Введите величину вклада ");
            x = Convert.ToInt32(Console.ReadLine());

            double y;
            Console.WriteLine(" Введите Процентную ставку ");
            y = Convert.ToInt32(Console.ReadLine());

            double z;
            Console.WriteLine(" Введите Время хранения ");
            z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Доход = " + Math.Round(ds.IncomeAmount(x, y, z), 3));

            Console.ReadLine();
        }
    }
}

