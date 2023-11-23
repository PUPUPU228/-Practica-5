namespace PiD5._2
{
    using System;
    class Program
    {
        static void Main()
        {
            // Ввод числа от пользователя
            Console.Write("Введите число в десятичной системе: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            // Преобразуем число в восьмеричную систему счисления и находим вторую справа цифру
            string num1 = Convert.ToString(num2, 8);
            char num = num1[num1.Length - 2];
            // Выводим результат
            Console.WriteLine($"Вторая цифра справа в восьмеричном представлении числа {num2} равна {num}.");
            Console.ReadLine();
        }
    }
}