using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpojExercises
{
    public class Pesel
    {
        public static void Run()
        {
            int liczonko = 0;

            Console.WriteLine("Podaj liczbę pesli do sprawdzenia: ");
            string sx = Console.ReadLine();
            bool sukces = int.TryParse(sx, out int result);

            if (sukces)
            {
                int x = int.Parse(sx);
                double[] z = new double[x];
                int[] v = new int[11];
                Console.WriteLine("Teraz podaj te pesle: ");

                for (int i = 0; i < x; i++)
                {
                    string k = Console.ReadLine();
                    z[i] = double.Parse(k);
                }

                for (int m = 0; m < x; m++)
                {
                    string y = z[m].ToString();
                    char a = y[0];
                    char b = y[1];
                    char c = y[2];
                    char d = y[3];
                    char e = y[4];
                    char f = y[5];
                    char g = y[6];
                    char h = y[7];
                    char i = y[8];
                    char j = y[9];
                    char k = y[10];

                    v[0] = a * 1;
                    v[1] = b * 3;
                    v[2] = c * 7;
                    v[3] = d * 9;
                    v[4] = e * 1;
                    v[5] = f * 3;
                    v[6] = g * 7;
                    v[7] = h * 9;
                    v[8] = i * 1;
                    v[9] = j * 3;
                    v[10] = k * 1;

                    //int liczonko = v[0] + v[1] + v[2] + v[3] + v[4] + v[5] + v[6] + v[7] + v[8] + v[9] + v[10];

                    for (int ii = 0; ii < v.Length; ii++)
                    {
                        liczonko = liczonko + v[ii];
                    }

                    string sliczonko = liczonko.ToString();
                    var ostatnia = sliczonko.LastOrDefault();
                    if (ostatnia == '0')
                    {
                        Console.WriteLine("Byku, to jest totalnie poprawny pesel");
                    }
                    else
                    {
                        Console.WriteLine("No pesel jest fałszywy");
                    }
                }
            }
            else
            {
                Console.WriteLine("Chyba cos poszło nie tak, może wpisałeś coś źle alboe nie wiem");
                Console.ReadKey();
            }
        }

        }
}
