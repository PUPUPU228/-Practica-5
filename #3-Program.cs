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
            if (res % 5 == 2)
            {
                string txt = Znach1 + " Делится на 5 с остатком 2";
                MessageBox.Show(txt);
            }
            else if (res % 7 == 1)
            {
                string txt = Znach1 + " Делится на 7 с остатком 1";
                MessageBox.Show(txt);
            }
            else
            {
                string txt = Znach1 + " Не делится на 5 с остатком 2 и не делится на 7 с остатком 1";
            }
        }
    }
}
