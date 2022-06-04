namespace Zadanie_SPOJ_496___dwie_cyfry_silni
{
    public class Mierzewa
    {
        public static double Silnia(double liczba)
        {
            double n = 1;

            for (int i = 1; i <= liczba; i++)
            {
                //n = n * i;
                n *= i;
            }

            return n;
        }
    }
}
