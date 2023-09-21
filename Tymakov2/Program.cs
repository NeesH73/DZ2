using System;

namespace Tymakov2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упр. 2.1: Запросить имя и поздароваться с пользователем");
                Console.Write("Введите имя: ");
                string name=Console.ReadLine();
                Console.WriteLine("Здравствуйте, " + name);
            Console.WriteLine("Упр. 2.2: Получить 2 числа и поделить их");
                Console.Write("Введите 1-ое число(делимое): ");
                int ch1 = int.Parse(Console.ReadLine());
                Console.Write("Введите 2-ое число(делитель): ");
                int ch2 = int.Parse(Console.ReadLine());
                double res;
                if (ch2 == 0)
                {
                    Console.WriteLine("на ноль делить нельзя");

                }
                else
                {
                    res = (double)ch1 / ch2;
                    Console.WriteLine("Результат деления: " + res);
                }
            Console.WriteLine("Д/З 2.1: Вывести след. букву");
                Console.Write("Введите букву англ. алфавита: ");
                char bykva = char.Parse(Console.ReadLine());
                if (bykva=='z')
                {
                    Console.WriteLine(bykva + " последняя буква,введите другую");
                }
                else
                {
                    bykva++;
                    Console.WriteLine("Следующая буква: " + bykva);

                }
            Console.WriteLine("Д/З 2.2:Найти корни кв. ур-ия  ");
                Console.Write("Введите значение а: ");
                double a = int.Parse(Console.ReadLine());
                Console.Write("Введите значение b: ");
                double b = int.Parse(Console.ReadLine());
                Console.Write("Введите значение c: ");
                double c = int.Parse(Console.ReadLine());
                double D = b * b - 4 * a * c; // нахождение дискриминанта
                if (D < 0)
                {
                    Console.WriteLine("Нет корней");
                }
                else
                {
                    double x1 = (-1 * b + Math.Sqrt(D)) / 2 * a;
                    double x2 = (-1 * b - Math.Sqrt(D)) / 2 * a;
                    Console.WriteLine("Корни:" + $"{x1} {x2}");
                }





            }
    }
}
