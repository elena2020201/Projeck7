using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace двойной_факториал_перед_арг_методу_без_рек
{
    class Program
    {
        static void show(string txt)
        {
            Console.WriteLine(txt);
        }
        static int factorial(int n)
        {
            int s = 1;
            for (int k=1; k<=n; k+=2)
            {
                s *= k;
            }
            return s;
        }
        static void Main()
        {
            show("Вычисление двойного факториала: ");
            int m = 5;
            show(m + "!!=" + factorial(m));
            Console.ReadLine();
        }
    }
}
