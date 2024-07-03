using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade.alce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool b_brasileira = true;
            int i_idade = 0;

            Console.WriteLine("Atividade 1");

            Console.Write("Digite sua idade: ");
            i_idade = int.Parse(Console.ReadLine());

            Console.Write("Você é brasileiro (SIM/NÃO)?: ");
            b_brasileira = Console.ReadLine().ToUpper() == "SIM";


            if (i_idade >= 16 && b_brasileira)
            {
                Console.WriteLine("Você está apto a votar!");
            }
            else
            {
                Console.WriteLine("Você não está apto a votar!");
            }

            Console.ReadLine();
            Console.Clear();


            Console.WriteLine("Atividade 2");

            double d_nfiscal = 0;
            double d_imposto = 0.0;

            Console.Write("Valor da nota fiscal: ");
            d_nfiscal = double.Parse(Console.ReadLine());

            if (d_nfiscal < 999)
            {
                d_imposto = 0.02; // 2%
            }
            else
            {
                if (d_nfiscal >= 1000 && d_nfiscal <= 2999)
                {
                    d_imposto = 0.025; // 2.5%
                }
                else
                {

                }
                if (d_nfiscal >= 3000 && d_nfiscal <= 6999)
                {
                    d_imposto = 0.028; // 2.8%
                }
                else
                {

                }
                if (d_nfiscal >= 7000)
                {
                    d_imposto = 0.03; // 3%
                }
            }

            double d_vdi = d_nfiscal * d_imposto;

            Console.WriteLine($"O valor do imposto a ser pago é: R$ {d_vdi:N2}");
            Console.ReadLine();
        }
    }
}
