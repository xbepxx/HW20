using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW20
{
    class Program
    {

        delegate double Geometry(double R);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение радиуса окружности R");
            double R;
            bool result = double.TryParse(Console.ReadLine(), out R);
            if (result)
            {
                Console.WriteLine($"Значение радиуса {R}");
            }
            else
            {
                Console.WriteLine("Ошибка ввода. Введите число");
            }
            if (result == true)
            {
                Geometry geometry1 = Lenght;
                double L = geometry1(R);
                Geometry geometry2 = Sqr;
                double S = geometry2(R);
                Geometry geometry3 = Vol;
                double V = geometry3(R);
                Console.WriteLine($"Длина окружности равна {L}, площадь круга равна {S}, объём шара равен {V}");
            }
            else
            {
                Console.WriteLine("Подсчёт невозможен");
            }
            Console.ReadLine();
        }
        static double Lenght(double R)
        {
            double lenght = Math.Round((2 * R * Math.PI), 2);
            return lenght;
        }
        static double Sqr(double R)
        {
            double sqr = Math.Round((Math.Sqrt(R) * Math.PI), 2);
            return sqr;
        }
        static double Vol(double R)
        {
            double vol = Math.Round((4 / 3 * Math.Pow(R, 3) * Math.PI), 2);
            return vol;
        }

    }
}
