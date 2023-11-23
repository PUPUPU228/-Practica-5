using Microsoft.VisualBasic;
using System;
using System.Windows;

namespace PiD5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Znach1;
            Znach1 = Interaction.InputBox(
                 "Введите число",
                 " "
                            );
            int res = Convert.ToInt32(Znach1);
            if (res >= 5 && res <= 10)
            {
                string txt = res + " Находится в диапазоне от 5 до 10";
                MessageBox.Show(txt);
            }
            else if (res > 10)
            {
                string txt = res + " Больше 10";
                MessageBox.Show(txt);
            }
            else
            {
                string txt = res + " Меньше 5";
                MessageBox.Show(txt);
            }
        }

    }
}
