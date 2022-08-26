using System;
// вычисляем таблицу кубов от 1 до N
namespace Seminar3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) Console.WriteLine(i * i * i);
        }
    }

}

