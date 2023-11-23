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
            res = (res / 1000) % 10;
            string txt = res + " тысяч";
            MessageBox.Show(txt);
        }

    }
}