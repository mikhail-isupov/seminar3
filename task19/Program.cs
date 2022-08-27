using System;
// Проверяем, является ли число палиндромом.
namespace Seminar3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            int number = int.Parse(Console.ReadLine());
            
            if (IsPalindrome(number)) Console.WriteLine("Палиндром");
            else Console.WriteLine("Не палиндром");
        }
    
        static bool IsPalindrome(int number)
        {
            // string inputNumber = number.ToString();
            // string reversedNumber = "";
            
            // for (int i = 1; i <= inputNumber.Length; i++) reversedNumber += inputNumber[ inputNumber.Length - i ];
            
            // return inputNumber == reversedNumber;
            
            int slicedNumber = number;
            int extractedNumber = 0;
            int reversedNumber = 0;
            
            while (slicedNumber != 0)
            {
                extractedNumber = slicedNumber % 10;
                slicedNumber /= 10;
                reversedNumber = reversedNumber*10 + extractedNumber;
            }

            return number == reversedNumber;

        }
    }
}
