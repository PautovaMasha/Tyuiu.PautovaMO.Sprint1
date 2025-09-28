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

            double y = 20;
            double z = 30;
            Console.WriteLine(" Процентная ставка = " + y);
            Console.WriteLine(" Время хранения = " + z);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Сумма по окончании срока вклада = " + Math.Round(ds.IncomeAmount(x, y, z), 3));

            Console.ReadLine();
        }
    }
}

