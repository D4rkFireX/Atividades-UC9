using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Cisne
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // O comando write serve´para escrever na tela do monitor 
            // Porém o comando Write é diferente do comando WriteLine
            // O comando Write escreve e o cursor permanece na mesma linha 
            // Logo em seguida do que foi escrito.
            // O comando WriteLine Escreve e o cursor vai para a próxima linha
            // Logo abaixo.

            /*
             * Operadores
             * Relacionais( ==, >=, <=, >, <, e != )
             * Matemáticos (unários, {[()]}, rais e exp, *, /, +, -)
             * Lógicos ( || <OR>, &&, <AND>, ! <NOT> )
             */

            /*Variáveis
            * Numéricas, Literais e Lógicas
            * As numéricas se dividem em dois tipos
            * Inteiros (int) -->10   14   9   -100
            * Decimais (double) -->10,  14,1  9,5  -100,12
            * As literais possuem vários tipos. (Char, String, Varchar...)
            * Literais (string) --> "São Paulo" "RPM" "243"
            * As Booleanas é do tipo (bool) --> true false
            */


            
             // Exercício 1

            Console.Write("Digite o primeiro número inteiro: ");
            int i_nm1 = 
                Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número inteiro: ");
            int i_nm2 =
                Convert.ToInt32(Console.ReadLine());

            int soma = i_nm1 + i_nm2;
            Console.WriteLine("soma:" + soma);
            Console.ReadLine();
            Console.Clear();


            // Exercício 2

            Console.Write("Digite um número real: ");
            string input = Console.ReadLine();
            double numeroReal = double.Parse(input);

           double tercaParte = numeroReal / 3;

            Console.WriteLine(tercaParte);
            Console.ReadLine();
            Console.Clear();

            // Exercício 3

            Console.Write("Digite o primeiro número real: ");
            string input1 = Console.ReadLine();
            double numeroReal1 = double.Parse(input1);

            Console.Write("Digite o segundo número real: ");
            string input2 = Console.ReadLine();
            double numeroReal2 = double.Parse(input2);

            double media = (numeroReal1 + numeroReal2) / 2;
            Console.WriteLine("Média:"+ media);
            Console.ReadLine();
            Console.Clear();

            // Exercício 4

            double d_sld = 0;

            Console.Write("Digite um saldo: R$ ");
            d_sld = double.Parse(Console.ReadLine());

            Console.WriteLine("PO saldo é {0:c}", d_sld * 1.01);
            Console.ReadLine();
            Console.Clear();


            //Exercício 5

            double NOTA_PROVA1 = 0;
            double NOTA_PROVA2 = 0;
            double NOTA_PROVA3 = 0;
            double NOTA_PROVA4 = 0;



            Console.Write("NOTA_PROVA1: ");
            NOTA_PROVA1 = double.Parse(Console.ReadLine());



            Console.Write("NOTA_PROVA2: ");
            NOTA_PROVA2 = double.Parse(Console.ReadLine());



            Console.Write("NOTA_PROVA3: ");
            NOTA_PROVA3 = double.Parse(Console.ReadLine());



            Console.Write("NOTA_PROVA4: ");
            NOTA_PROVA4 = double.Parse(Console.ReadLine());



            Console.WriteLine("A média final é: {0}", (NOTA_PROVA1 + NOTA_PROVA2 + NOTA_PROVA3 + NOTA_PROVA4) / 4);
            Console.ReadLine();
            Console.Clear();

        }
    }
}
