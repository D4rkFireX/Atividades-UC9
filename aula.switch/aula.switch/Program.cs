using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula.@switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}



/*
           if (i_opcao == 1)
           {
               Console.Write("1 - ADIÇÃO");
           }
           else 
           {
               if (i_opcao == 2)
               {
                   Console.Write("2 - SUBTRAÇÃO");
               }
               else
               {
                   if (i_opcao == 3)
                   {
                       Console.Write("3 - MULTIPLICAÇÃO");
                   }

                   else
                   {
                       if (i_opcao == 4)
                       {
                           Console.Write("4 - DIVISÃO");
                       }

                       else
                       {
                           if (i_opcao == 5)
                           {
                               Console.Write("5 - SAIR DO PROGRAMA");
                           }
                       }
                   }
               }
           }
           */


/*
            int i_opcao = 0;

            Console.Write("         MENU DE ESCOLHA");
            Console.Write("         1 - ADIÇÃO");
            Console.Write("         2 - SUBTRAÇÃO");
            Console.Write("         3 - MULTIPLICAÇÃO");
            Console.Write("         4 - DIVISÃO");
            Console.Write("         SAIR DO PROGRAMA");


            Console.Write("Entre com sua opção (1, 2, 3, 4 OU 5): ");
            i_opcao = int.Parse(Console.ReadLine());


            switch (i_opcao)
            {
                case 1:
                   {
                        Console.Write("1 - ADIÇÃO");
                        break;
                   }

                case 2:
                    {
                        Console.Write("2 - SUBTRAÇÃO");
                        break;
                    }
                case 3:
                    {
                        Console.Write("3 - MULTIPLICAÇÃO");
                        break;
                    }
                    case 4:
                    {
                        Console.Write("4 - DIVISÃO");
                        break;
                    }
                    case 5:
                    {
                        Console.Write("5 - SAIR DO PROGRAMA");
                        break;
                    }
            }
            Console.ReadLine();
            */

            /*
            Int64 i_soma = 0;

            //somar todos os numeros de 1 até 100000 => 5000050000
            for (int i = 0; i <= 100000; i++)
            {
                i_soma += i;
            }
            Console.WriteLine(i_soma);
            Console.ReadLine();
            */