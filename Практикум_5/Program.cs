using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1_к
{
    class Program
    {
        static double f(double x)
        {
            try
            {
                if (Math.Abs(x) == 1) throw new Exception();
                else return 1 / (x*x - 1);
            }
            catch
            {
                throw;
            }
        }
        static void Main(string[] args)
        {
            try
            {
                double a, b, h;
                Console.Write("Начальное значение числа x:");
                a = double.Parse(Console.ReadLine());
                Console.Write("Конечное значение числа x:");
                b = double.Parse(Console.ReadLine());
                if (b < a)
                    throw new Exception("Конечное значение числа x меньше начального значения");
                Console.Write("Шаг h:");
                h = double.Parse(Console.ReadLine());
                if(h <= 0)
                    throw new Exception("Шаг меньше или равен 0");
                for (double i = a; i <= b; i += h)
                    try
                    {
                        Console.WriteLine("y({0})={1}", Math.Round(i,5), Math.Round(f(Math.Round(i, 5)),5));
                    }
                    catch
                    {
                        Console.WriteLine("y({0})=error", i);
                    }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода данных");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: "+ e.Message);
            }
            Console.ReadLine();
        }
    }
}
