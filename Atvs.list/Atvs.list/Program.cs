using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atvs.list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double d_maca = 0;

            Console.WriteLine("Atividade das maçãs");


            Console.Write("Entre com a quantidade de maçãs compradas: ");
            d_maca = double.Parse(Console.ReadLine());


            if (d_maca <= 11)
            {
                Console.WriteLine("O valor a ser pago é de {0:C}" + d_maca * 1, 30);
            }
            else
            {
                Console.WriteLine("O valor a ser pago é {0:C}" + d_maca * 1, 00);
            }

            Console.ReadLine();
            Console.Clear();




            Console.WriteLine("Programa");


            int i_produto = 0;
            double d_kg = 0;
            double d_resul = 0;

            do
            {
                Console.Clear();

                Console.WriteLine("[1] Arroz - R$8,00");
                Console.WriteLine("[2] Feijão - R$5,00");
                Console.WriteLine("[3] Toddy - R$4,50");
                Console.WriteLine("[4] Macarrão - R$3,80");
                Console.WriteLine("[5] Sair");


                Console.Write("Escolha um produto: ");
                i_produto = int.Parse(Console.ReadLine());

                Console.Write("Digite a quantidade de Kg do produto: ");
                d_kg = double.Parse(Console.ReadLine());


                switch (i_produto)
                {
                    case 1:
                        {
                            d_resul = d_kg * 8.00;

                            break;
                        }
                    case 2:
                        {
                            d_resul = d_kg * 5.00;

                            break;
                        }
                    case 3:
                        {
                            d_resul = d_kg * 4.50;

                            break;
                        }
                    case 4:
                        {
                            d_resul = d_kg * 3.80;

                            break;
                        }
                }

                Console.Write("O resultado da compra da {0}", d_resul);
                Console.ReadLine();

                Console.WriteLine("Deseja comprar mais alguma coisa? (S/N)");
            } while (Console.ReadLine().ToUpper() == "S");
        }
    }
}
