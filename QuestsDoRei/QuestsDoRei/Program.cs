using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestsDoRei
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FuncGeral obj_FuncGeral = new FuncGeral();

            #region HipoCampus
            /*
            * Crie um programa utilizando o comando switch que leia dois valores reais.
            * Após a captura dos valores, o programa deverá perguntar qual operação executar 
            * (Operações: soma, subtração, divisão, multiplicação, exponenciação e raiz quadrada). 
            * Execute a operação desejada e imprima na tela o resultado.
            * Lembrando que não existe divisão por 0 (zero) e nem raiz quadrada de numero negativo. OK.
            */

            int i_op = 0;
            double d_nro1 = 0, d_nro2 = 0, d_resp = 0;

          do
          { 
                Console.Clear();

            Console.WriteLine("         0 - Sair do Programa");
            Console.WriteLine("         1 - Adição");
            Console.WriteLine("         2 - Subtração");
            Console.WriteLine("         3 - Divisão");
            Console.WriteLine("         4 - Multiplicação");
            Console.WriteLine("         5 - Exponenciação");
            Console.WriteLine("         6 - Radiciação");

            i_op = obj_FuncGeral.PegaOpcao(0, 6, "Entre com cua opção: ");

            switch (i_op)
            {
                case 0:
                    {
                        Environment.Exit(0);
                        break;
                    }
                case 1: // Soma
                    {
                        d_nro1 = obj_FuncGeral.PegaDouble("Digite o primeiro número: ");
                        d_nro2 = obj_FuncGeral.PegaDouble("Digite o segundo número: ");

                        d_resp = d_nro1 + d_nro2;
                        break;
                    }
                case 2: // Subtração
                    {
                        d_nro1 = obj_FuncGeral.PegaDouble("Digite o primeiro número: ");
                        d_nro2 = obj_FuncGeral.PegaDouble("Digite o segundo número: ");

                        d_resp = d_nro1 - d_nro2;
                        break;
                    }
                case 3: // Divisão
                    {
                        d_nro1 = obj_FuncGeral.PegaDouble("Digite o primeiro número: ");
                        d_nro2 = obj_FuncGeral.PegaDouble("Digite o segundo número: ");

                        if (d_nro2 < 0)
                        {
                            d_resp = d_nro1 / d_nro2;
                        }
                        else
                        {
                            Console.WriteLine("Não existe divisão por Zero no campo dos números reais");
                        }
                        break;
                    }
                case 4: // Multiplicação
                    {
                        d_nro1 = obj_FuncGeral.PegaDouble("Digite o primeiro número: ");
                        d_nro2 = obj_FuncGeral.PegaDouble("Digite o segundo número: ");

                        d_resp = d_nro1 * d_nro2;
                        break;
                    }
                case 5: // Exponenciação
                    {
                        d_nro1 = obj_FuncGeral.PegaDouble("Digite o primeiro número: ");
                        d_nro2 = obj_FuncGeral.PegaDouble("Digite o segundo número: ");

                        d_resp = Math.Pow(d_nro1, d_nro2);
                        break;
                    }
                case 6: // Radiciação
                    {
                        d_nro1 = obj_FuncGeral.PegaDouble("Digite o número: ");

                            if (d_nro1 >= 0)
                            {
                                d_resp = Math.Sqrt(d_nro1);
                            }
                            else
                            {
                                d_resp = 0;
                            }
                       
                        break;
                    }
            }

                if (i_op == 3)
                {
                    if (d_nro2 > 0)
                    {
                        Console.WriteLine("A resposta é {0}\n\n", d_resp);
                    }
                    else
                    {
                            Console.WriteLine("Não existe divisão do numero negativo no campo dos numeros Reais.");
                    }
                }
                else
                {
                    if (i_op == 6)
                    {
                        if (d_nro1 >= 0)
                        {
                            Console.WriteLine("A resposta é {0}\n\n", d_resp);
                        }
                        else
                        {
                            Console.WriteLine("Não existe rais de numero negativo no campo dos numeros Reais.");
                        }
                    }
                    if (d_nro1 > 0)
                    {
                        Console.WriteLine("A resposta é {0}\n\n", d_resp);
                    }
                }
            
          }while(obj_FuncGeral.PegaSN("Deseja outro calculo (S/N): ") == "S");




            string[] s_meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"};
            int i_mes = 0;
            do
            {
                Console.Clear();

                i_mes = obj_FuncGeral.PegaInt("Digite o numero do mês desejado: ");

                Console.WriteLine("O mês correspondente ao numero {0} é o {1}", i_mes, s_meses[i_mes - 1]);
            } while (obj_FuncGeral.PegaSN("Deseja outra pesquisa? (S/N)") == "S");













                #endregion

                #region 1
                #endregion

                #region 1
                #endregion

                #region 1
                #endregion

                #region 1
                #endregion

                #region 1
                #endregion





            }
    }
}
