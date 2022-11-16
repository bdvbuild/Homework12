using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, r, result;
            bool ans;
            bool endApp = false;
            do
            {
                Console.WriteLine("1 - Вычислить длину окружности\n2 - Вычислить площадь круга\n3 - Принадлежность точки к кругу");
                try
                {
                    int a = Convert.ToInt32(Console.ReadLine());
                    switch (a)
                    {
                        case 1:
                            Console.Write("Введите радиус: ");
                            r = Math.Abs(Convert.ToDouble(Console.ReadLine()));
                            result = Circle.GetLength(r);
                            Console.WriteLine($"Длина окружнсти = {result}");
                            break;
                        case 2:
                            Console.WriteLine("Введите радиус");
                            r = Math.Abs(Convert.ToDouble(Console.ReadLine()));
                            result = Circle.GetArea(r);
                            Console.WriteLine($"Площадь круга = {result}");
                            break;
                        case 3:
                            Console.Write("Введите радиус: ");
                            r = Math.Abs(Convert.ToDouble(Console.ReadLine()));
                            Console.Write("Введите координату X центра: ");
                            x1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Введите координату Y центра: ");
                            y1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Введите координату X точки: ");
                            x2 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Введите координату Y точки: ");
                            y2 = Convert.ToDouble(Console.ReadLine());

                            ans = Circle.IsInCircle(r, x1, y1, x2, y2);
                            if (ans)
                                Console.WriteLine("Точка принадлежит окружности");
                            else Console.WriteLine("Точка не принадлежит окружности");
                            break;
                        default:
                            Console.WriteLine("Ошибка");
                            break;
                    }
                }
                catch (Exception ex) 
                { Console.WriteLine(ex.Message); }
                Console.Write("\nВведите 0, чтобы завершить, или другую клавишу, чтобы повторить: ");
                if (Console.ReadLine() == "0") endApp = true;
            }while (!endApp);
            Console.ReadLine();
        }
    }
}
