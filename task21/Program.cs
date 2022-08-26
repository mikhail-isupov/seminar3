using System;
// вычисляем расстояние между 2 точками;
namespace Seminar3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] point1 = {1, 2, 3};
            double[] point2 = {4, 5, 6}; 
            double distance = Distance(point1, point2);

            Console.WriteLine($"Расстояние между точками = {distance}");
        }
    
        static double Distance(double[] point1, double[] point2) 
        // Возвращает расстояние между точками либо -1 если число координат точек не совпадает
        {
            if (point1.Length != point2.Length) return -1;

            double distance = 0;

            for (int i = 0; i < point1.Length; i++) distance += (point1[i] - point2[i]) * (point1[i] - point2[i]); 
            // суммируем квадраты разности по всем координатам

            distance = Math.Sqrt(distance);
            //берем корень

            return distance;
        }
    }

}
