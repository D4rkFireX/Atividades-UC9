using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade.bisão
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atividade 1");
            Console.Clear();

            double d_nota = 0;

            Console.Write("Digite sua nota: ");
            d_nota = double.Parse(Console.ReadLine());


            if (d_nota >= 7 && d_nota <= 10)
            {
                Console.Write("Aluno aprovado");
            }
            else
            {
                if (d_nota >= 4 && d_nota < 7)
                {
                    Console.WriteLine("Aluno em exame");
                }
                else
                    if (d_nota >= 0 && d_nota < 4)
                {
                    Console.WriteLine("Aluno reprovado");
                }
            }

            Console.ReadLine();
            Console.Clear();





            int i_opcao = 0;
            double d_num1 = 0;
            double d_num2 = 0;


            Console.WriteLine("Calculadora Simples");
            Console.WriteLine("Selecione uma operação:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair da Calculadora");

            Console.Write("Escolha uma opção dentre (1),(2),(3),(4),(5):  ");
            i_opcao = int.Parse(Console.ReadLine());


            if (i_opcao == 5)
            {
                Environment.Exit(0);
            }

            Console.Write("Digite o primeiro número: ");
            d_num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            d_num2 = Convert.ToDouble(Console.ReadLine());


            switch (i_opcao)
            {
                case 1:
                    {
                        double d_rsl = d_num1 + d_num2;



                        Console.WriteLine("Resultado da Adição: " + d_rsl);
                        break;
                    }

                case 2:
                    {
                        double d_rsl = d_num1 - d_num2;



                        Console.WriteLine("Resultado da Subtração : " + d_rsl);
                        break;
                    }

                case 3:
                    {
                        double d_rsl = d_num1 * d_num2;



                        Console.WriteLine("Resultado da Multiplicação:  " + d_rsl);
                        break;
                    }

                case 4:
                    {
                        if (d_num2 != 0)
                        {
                            double d_rsl = d_num1 / d_num2;



                            Console.WriteLine("Resultado da Divisão: " + d_rsl);
                            break;



                        }
                        else
                        {
                            Console.WriteLine("Erro: Divisão por zero!");
                            break;
                        }
                    }

                default:
                    {
                        Console.WriteLine("Opção inválida!");
                        break;
                    }
            }
            Console.ReadLine();
        }
    }
}



/*
Console.WriteLine("Calculadora      ");
Console.WriteLine("1 - ADIÇÃO       ");
Console.WriteLine("2 - SUBTRAÇÃO    ");
Console.WriteLine("3 - MULTIPLICAÇÃO");
Console.WriteLine("4 - DIVISÃO      ");
Console.WriteLine("                 ");
Console.WriteLine("5 - SAIR         ");

Console.WriteLine("   ═╬╠╦╩╔╚z    ");


    int Pega_Opcao(int i_ini, int i_fim, string ps_msg)

int i_op = 0;
double d_num1 = 0;
double d_num2 = 0;



int i_op = Pega_Opcao(1 , 5, "Entre com sua opção (1, 2, 3, 4, 5): ")

if(i_op != 5)
{
d_num1 = PegaDouble("Entre com o Primeiro Numero: ")
d_num2 = PegaDouble("Entre com o Segundo Numero: ")
}

switch (i_op)
{
  case 1;
 {

  break;
 }
  case 2;
 {

  break;
 }
 case 3;
 {

  break;
 }
 case 4
 {

  break;
 }
 case 5
 {
  Environment.Exit(0);
  break;
 }
}

Console.WriteLine("A resposta do cálculo é: {0}, d_res");


 */
