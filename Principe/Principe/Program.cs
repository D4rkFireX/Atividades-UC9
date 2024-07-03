using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LOBO

            Console.WriteLine("Atividade 1");

            int i_soma = 0;

            for (int i = 0; i < 1000; i++)
            {
                i_soma += i;
            }

            Console.Write(i_soma);

            Console.ReadLine();
            

            Console.WriteLine("Atividade 2");
            

            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("{0} ",i);
                }
            }

            Console.ReadLine();
            #endregion

            #region LEÃO

            Console.WriteLine("Atividade 1");

            i_soma = 0;

            for (int i = 1; i < 100; i++)
            {
                if (i % 3 != 0)
                {
                    i_soma += i;
                }
                Console.Write(i_soma);
            }

            Console.ReadLine();
            

            Console.WriteLine("Atividade 2");

            int i_fat = 1;

            for (int i = 1; i < 10; i++)
            { 
                i_fat *= i;
                Console.Write("O fatorial do numero {0} é {1}",i, i_fat);
            }
            Console.ReadLine();

            #endregion

            #region URSO

            Console.WriteLine("Atividade 1");

            int i_nro = 0;

            Console.Write("Entre com um numero inteiro positivo: ");
            i_nro = int.Parse(Console.ReadLine());

            for (int i = 1; i <= i_nro; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0} ", i);
                }
            }

            string s_palavra = "";

            Console.Write("Entre com uma palavra: ");
            s_palavra = Console.ReadLine();

            for (int i = 0; i < s_palavra.Length; i++)
            {
                Console.WriteLine("{0} ", s_palavra.Substring(i,1));
            }

            Console.ReadLine();
            #endregion

        }
    }
}
