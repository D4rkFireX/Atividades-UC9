using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade.leão
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leão");
            Console.WriteLine("Atividade 1");

            int soma = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 != 0)
                {
                    soma += i;
                }
            }
            Console.WriteLine("A soma dos números não múltiplos de 3 de 1 a 100 é: " + soma);
            Console.ReadLine();

            Console.Clear();


            Console.WriteLine("Atividade 2");

            for (int n = 1; n <= 10; n++)
            {
                long resultado = CalcularFatorial(n);
                Console.WriteLine($"O fatorial de {n} é {resultado}");
            }

            Console.ReadLine();



            static long CalcularFatorial(int i_numero)
            {

                // long é um tipo de dados que representa números inteiros longos. //

                if (i_numero == 0)
                    return 1;

                long fatorial = 1;
                for (int i = 1; i <= i_numero; i++)
                {
                    fatorial *= i;
                }
                return fatorial;
            }
        }
    }
}
