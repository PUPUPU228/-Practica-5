using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;
namespace PiD5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string Znach1;
            Znach1 = Interaction.InputBox(
                "Введите число",
                "Делитиель на три"
                );

            int res = Convert.ToInt32(Znach1);
            if (res % 3 == 0)
            {
                string txt = Znach1 + " Делится на 3";
                MessageBox.Show(txt);
            }
            else
            {
                string txt = Znach1 + " Не делится на 3";
                MessageBox.Show(txt);
            }
        }


    }
}