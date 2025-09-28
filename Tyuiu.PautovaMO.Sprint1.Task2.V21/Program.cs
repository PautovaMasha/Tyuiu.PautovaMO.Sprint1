using Tyuiu.PautovaMO.Sprint1.Task2.V21.Lib;

namespace Tyuiu.PautovaMO.Sprint1.Task2.V21
{
    class programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил : Паутова М.О. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема:  Арифметические операторы в C#                                    *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Паутова Мария Олеговна | ИБКСб-25-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Известны длины стороны прямоугольника.Вычислить площадь прямоугольника. *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x;
            Console.WriteLine(" Введите значение Х:");
            x= Convert.ToInt32(Console.ReadLine());

            int y;
            Console.WriteLine(" Введите значение Y:");
            y= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Площадь прямоугольника = " + ds.CalculateRectangleSquare(x,y));

            Console.ReadLine();
        }
    }
}