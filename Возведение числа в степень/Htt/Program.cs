using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Возведение_числа_в_степень
{
    public class Program
    {
        private static double a { get; set; }
        private static double b { get; set; }
        private static double c { get; set; }
        static void Main()
        {
            Console.WriteLine("Введите число, которое нужно возвести в степень:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите степень, в которую нужно возвести число " + a + ":");
            b = Convert.ToDouble(Console.ReadLine());
            c = Math.Pow(a, b);
            Console.WriteLine(+a + " в степени " + b + " = " + c + "");
            Console.ReadLine();
        }
    }
}
