using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade.cabra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atividade 1 ");

            int i_nro1 = 0;

            Console.Write("Digite um número inteiro: ");
            i_nro1 = int.Parse(Console.ReadLine());

            if (i_nro1 % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");
            }

            Console.ReadLine();
            Console.Clear();



            Console.WriteLine("Atividade 2");

            int i_vlr1 = 0;
            int i_vlr2 = 0;

            Console.Write("Digite o primeiro número inteiro: ");
            i_vlr1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número inteiro: ");
            i_vlr2 = int.Parse(Console.ReadLine());

            if (i_vlr1 == i_vlr2)
            {
                Console.WriteLine("Os números são iguais");
            }
            else
            {
                if (i_vlr1 > i_vlr2)
                {
                    Console.WriteLine("O número {0} é maior que o número {1}", i_vlr1, i_vlr2);
                }

                else
                {
                    Console.WriteLine("O número {1} é maior que o número {0}", i_vlr1, i_vlr2);
                }
            }

            Console.ReadLine();


            /*
             i = 0;

             i = i + 10; i = i - 10; i = i / 10; i = i * 10;
            
             i += 10; i -=10
            


            #region Cabra
            Console.WriteLine("Quest 1 da Cabra.")
            int i_num = PegaInt("Entre com um número inteiro: ")

            if (i_num % 2 == 0)
            {
              Console.WriteLine("O numero digitado é PAR.")
            }
            else
            {
              Console.WriteLine("O numero é IMPAR.")
            }


            #endregion

            static int PegaInt(string ps_msg)

            {
            bool b_valida = false;
            int i_num = 0;

            Console.WriteLine(ps_msg);
            while (!b_valida)
             {
               Console.Clear();
               Console.Write(ps_msg);
            b_valida = int.TryParse(Console.ReadLine(), out i_num);
             }
            return i_num;

            }

            */
        }
    }
}
