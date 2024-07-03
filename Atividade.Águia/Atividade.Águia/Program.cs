using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade.Águia
{
    internal class Program
    {
        static void Main(string[] args)

            // Exercício 1

        {
            int i_nro_tabu = 0;


            Console.Write("Digite o Número que deseja fazer a tabuada: ");
            i_nro_tabu = int.Parse(Console.ReadLine());


            Console.WriteLine("Tabuada do {0}", i_nro_tabu);
            Console.WriteLine("1 x {0} = {1}", i_nro_tabu, i_nro_tabu * 1);
            Console.WriteLine("2 x {0} = {1}", i_nro_tabu, i_nro_tabu * 2);
            Console.WriteLine("3 x {0} = {1}", i_nro_tabu, i_nro_tabu * 3);
            Console.WriteLine("4 x {0} = {1}", i_nro_tabu, i_nro_tabu * 4);
            Console.WriteLine("5 x {0} = {1}", i_nro_tabu, i_nro_tabu * 5);
            Console.WriteLine("6 x {0} = {1}", i_nro_tabu, i_nro_tabu * 6);
            Console.WriteLine("7 x {0} = {1}", i_nro_tabu, i_nro_tabu * 7);
            Console.WriteLine("8 x {0} = {1}", i_nro_tabu, i_nro_tabu * 8);
            Console.WriteLine("9 x {0} = {1}", i_nro_tabu, i_nro_tabu * 9);
            Console.WriteLine("10 x {0} = {1}", i_nro_tabu, i_nro_tabu * 10);
            Console.ReadLine();
            Console.Clear();


            //Exercício 2

            double d_laud = 0;

            Console.WriteLine("Insira sua quantidade de laudas:");
            d_laud = double.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Sua quantidade de laudas original é {0}", d_laud);
            Console.WriteLine("O preço total é {0:c}", d_laud * 50);
            Console.WriteLine("A quantidade de parcelas iguais de 3 partes será {0:c}", (d_laud * 50) / 3);

            Console.ReadLine();
            Console.Clear();



            //Exercício 3

            string s_nm = "";
            string s_msg = "Bem Vindo!!";

            Console.Write("Digite seu nome: ");
            s_nm = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Olá {0}\n{1}", s_nm, s_msg);
            Console.WriteLine("Tecle ENTER para finalizar");
            Console.ReadLine();
            Console.Clear();



        }
    }
}
