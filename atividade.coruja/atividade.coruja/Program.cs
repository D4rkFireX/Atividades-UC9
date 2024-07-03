using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade.coruja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercício 1

            int num_at1 = 0;

            Console.WriteLine("Digite um número inteiro para encontrar seu sucessor e seu antecessor");
            num_at1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O sucessor do número {0}, é {1} e o antecessor é {2}", num_at1, num_at1 + 1, num_at1 - 1);
            Console.ReadLine();
            Console.Clear();



            // Exercício 2
            Console.Write("Digite seu nome: ");
            string nm = Console.ReadLine();

            Console.Write("Digite seu endereço: ");
            string address = Console.ReadLine();

            Console.Write("Digite seu telefone: ");
            string ph = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Seu nome é {0}", nm);
            Console.WriteLine("Seu endereço é {0}", address);
            Console.WriteLine("Seu telefone é {0}", ph);
            Console.ReadLine();
            Console.Clear();


            // Exercício 3

            Console.Write("Digite o primeiro número inteiro: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número inteiro: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int soma = num1 + num2;
            int subtracao = num1 - num2;
            int multiplicacao = num1 * num2;

            Console.WriteLine("Soma: " + soma );
            Console.WriteLine("Subtração: " + subtracao);
            Console.WriteLine("Multiplicação: " + multiplicacao);
            Console.ReadLine();
            Console.Clear();


            // Exercício 4

            double al = 0;
            double ps = 0;

            Console.Write("Digite sua altura:");
            al = double.Parse(Console.ReadLine());
            Console.Write("Digite seu peso:");
            ps = double.Parse(Console.ReadLine());


            Console.WriteLine("O seu imc será: {0}", ps / Math.Pow(al, 2));
            Console.ReadLine();
            Console.Clear();



        }
    }
}
