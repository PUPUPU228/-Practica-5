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
            if (res > 10 && res % 4 == 0)
            {
                string txt = Znach1 + " Делится на 4 и при этом больше 10";
                MessageBox.Show(txt);
            }
            else if (res < 10)
            {
                string txt = Znach1 + " не больше 10";
                MessageBox.Show(txt);
            }
            else if ((res % 4) == 0)
            {
                string txt = Znach1 + " не делится на 4";
                MessageBox.Show(txt);
            }

        }

    }
}
