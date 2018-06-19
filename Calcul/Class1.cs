using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcu
{
    public class Class1
    {

        public static string tex_1;
        public static double b;
        public static string calculate(string per, double a, int znach)
        {
            switch (znach)
            {
                case 1:
                    b = a + double.Parse(per);
                    tex_1 = b.ToString("0.#");
                    break;
                case 2:
                    b = a - double.Parse(per);
                    tex_1 = b.ToString("0.#");
                    break;
                case 3:
                    b = a * double.Parse(per);
                    tex_1 = b.ToString("0.#");
                    break;
                case 4:
                    b = a / double.Parse(per);
                    tex_1 = b.ToString("0.#");
                    break;
                case 5:
                    b = Math.Sqrt(a);
                    tex_1 = b.ToString("0.#");
                    break;
                case 6:
                    b = Math.Sin(a);
                    tex_1 = b.ToString("0.#");
                    break;
                case 7:
                    b = 1;
                    for (double i = 1; i <= a; i++)
                    {
                        b *= i;
                    }
                    tex_1 = b.ToString("0.#");
                    break;

                default:
                    break;
            }
            return tex_1;
        }
    }
}

