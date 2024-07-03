using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i_num = 0;

            Console.Write("Entre com um número inteiro: ");
            i_num = int.Parse(Console.ReadLine());

            if (i_num > 0)
            {
                Console.Write("O número {0} é POSITIVO.", i_num);
            }
            else 
            {
                if (i_num < 0)
                {
                    Console.Write("O número {0} É NEGATIVO.", i_num);
                }

                else
                {
                    Console.Write("O número {0} é IGUAL a ZERO.", i_num);
                }
            }














            /*
            
            VARIÁVEIS e CONSTANTES

            Numéricos Literais e os Lógicos

            TIPOS
            Numnéricos (int e double)
            Literais   (string)
            Lógicos    (bool)

            SINTAXE PARA CRIAR UMA VARIÁVEL

            1) declare-se o tipo
            2) define-se o nome
            3) atribui-se um valor inicial

            int i_idade = 0;
            double d_altura = 0;
            string s_nome = "";
            bool b_valida = false;  sempre busque o true         errado começar uma booleana com true
            DateTime dt_cadastro = DateTime.MinlValue;

            i_idade = 12;
            d_altura = 1.45;
            s_nome = "Stephany";
            b_valida = true;
            dt_cadastro = DateTime.Now;

            OPERADORES

            Operadores Relacionais, retornam (bool)

            igual --> i_nota == 10;
            maior/igual --> i_nota >= 10;
            menor/igual --> i_nota <= 10;
            maior       --> i_nota > 10;
            menor       --> i_nota < 10;
            não igual   --> i_nota != 10;


            Operadores Matemáticos, retornam (Numerais) 
            
            adição        --> i_nro1 + i_nro2;
            subtração     --> i_nro1 - i_nro2;
            multiplicação --> i_nro1 * i_nro2;
            divisão       --> i_nro1 / i_nro2;
            Mod          --> i_nro1 % 5 ==0;

              obs: se o segundo número é diferente de 0.
            radiciação   --> Math.Sqrt(d_altura);
            potenciação  --> Math.Pow(d_altura, 5);
            


            O operador '+' em uma string, assume o papel de concatenador
            ou seja, ele junta os strings. ("martelo"+"do"+"thor") --> "martelodothor"


            Operadores Lógicos, retornam (bool)
            
            E  (&&) --> if (i_nota <= 122 && i_nota >= 10);
            ...|10, 11,... ...120, 121, 122, |...


            OU (||) -->  if (i_nota >= 15 || i_nota <= 5);
            ... 3, 4, 5,|... ...|15, 16, 17 ...

            negação (!) --> if (!(10 == 10))



            Matemáticos
            Lógicos


            COMANDOS DE ENTRADA DO CONSOLE

            SINTAXE

            Console.Write("Escreve a mensagem"); --> Após a escrita, o cursor permanece na mesma linha.

            Console.WriteLine("Escreve a mensagem"); --> Após a escrita, o cursor pula para a linha de baixo.

            Características peculiares do Write
            \n - marcador de texto para saltar uma linha para baixo
            {x} - placeholder

            SINTAXE \n
            Console.Write("\nEscreve \na mensagem\n");
            Exemplo:
            
            SINTAXE placeholder
            Console.Write("Escreve a mensagem {0}", variável);

            static void Main(string[] args)

            {
            int i_numero = 0;
            Console.Write("O numero é {0}, i_numero")
            }


            COMANDOS DE ENTRADA DO CONSOLE


            SINTAXE

            Console.ReadLine(); --> Recebe o valor digitado pelo usuário através do teclado e após o <enter>, o cursor pula para a próxima linha.

            obs: tudo o que é digitado no teclado é string

            uma variável string recebendo do comando ReadLine não terá problema, pois string recebe string



            s_nome = Console.ReadLine();

            Agora, se a variável for diferente da tipagem string, você terá que converter ou analizar ou tentar analizar.

            Exemplo com int

            converter
            i_idade =Convert.ToInt16(Console.ReadLine());
            --> A Conversão não garante o sucesso e pode crashar o programa, só existe garantia se o usuário digitar o valor do tipo int corretamente.

            Exemplo com int com analizar
            i_idade = int.Parse(Console.ReadLine());
            --> A Análise não garante o sucesso e pode crashar o programa, só existe garantia se o usuário digitar o valor do tipo int corretamente.

            Exemplo com int com o tentar analizar
            = Try.Parse(Console.ReadLine(), out i_idade);
            --> A tentativa de Analise sempre garante o sucesso e nunca irá crashar o programa, independente da digitação correta do usuário.


            CLAUSULA DE CONDIÇÃO

            CLAUSULA DE CONDIÇÃO (SIMPLES)

            if (condição)

            {
               <<bloco se verdadeiro>>
            }

            Exemplo: 
            if (i_nro1 > 0)
            {
                Console.WriteLine("O numero {0} é positivo." i_nro1);
            }




            CLAUSULA DE CONDIÇÃO (COMPOSTA)

            if (COMPOSTA)

            {
               <<bloco se verdadeiro>>
            }
            else
            {
               <<bloco se falso>>
            }

            Exemplo: 
            if (i_nota > 7)
            {
                Console.WriteLine("O aluno foi aprovado com a nota {0}." i_nota);
            }
            else
            {
                Console.WriteLine("O aluno foi reprovado com a nota {0}." i_nota);   
            }



            Clausula de condição (IDENTADA (IF/ELSE/IF))


         if (condição)
        {
          <<bloco se verdadeiro>>
        }
         else
        {
          <<bloco falso>>
        }

 

         if 
        {
          <<bloco se verdadeiro>>
        }

 

        Exemplo: 
         if (i_nota >= 7)
        {
           Console.WriteLine("O aluno foi aprovado com a nota {0}.", i_nota);
        }

 

         else (i_nota >= 4)
        {
           Console.WriteLine("O aluno está de recuperação com a nota {0}.", i_nota);
        }

 

         if (i_nota >4)
        {
           Console.WriteLine("O aluno foi reprovado com a nota {0}.", i_nota);
        }










            */
        }
    }
}
