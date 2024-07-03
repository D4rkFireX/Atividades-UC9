using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade.lobo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atividade 1");

            int i_smo = 0;

            for (int i = 1; i <= 1000; i++)
            {
                i_smo += i;
            }

            Console.WriteLine("A soma dos números de 1 até 1000 é: " + i_smo);
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Atividade 2");
            Console.WriteLine("Múltiplos de 3 entre 1 e 100:");

            int i_num2 = 1;
            while (i_num2 <= 100)
            {
                if (i_num2 % 3 == 0)
                {
                    Console.Write("{0} ", i_num2);
                }
                i_num2++;
            }
            Console.ReadLine();
        }
    }
}
