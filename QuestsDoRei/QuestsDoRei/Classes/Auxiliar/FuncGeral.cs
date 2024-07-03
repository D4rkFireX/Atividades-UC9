/**************************************************************************
 * Nome da classe: FuncGeral
 *      Descrição: Esta classe é responsável por auxiliar outras partes da
 *                 Aplicação com funções e procedimentos gerais.
 *    Dt. Criação: 09/10/2023
 *    Dt. Alteração: --/--/----
 *    Observação: 
 *    Feita por: D4rk 
 *************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestsDoRei
{
    class FuncGeral
    {
        /**************************************************************************
        *         Método: PegaInt (Público)
        *      Descrição: Este método é responsável por retornar um número inteiro 
        *                 válido
        *    Dt. Criação: 09/10/2023
        *  Dt. Alteração: --/--/----
        *     Observação: 
        *        Família: Função
        *      Parâmetro: Uma mensagem String
        *        Retorno: Uma variável do tipo Inteiro
        *      Feita por: D4rkFire
        *************************************************************************/
        public int PegaInt(string ps_msg)
        {
            bool b_valida = false;
            int i_nro = 0;
            Console.Write(ps_msg);

            do
            {
                b_valida = int.TryParse(Console.ReadLine(), out i_nro);
            }while (!b_valida);//D4rkFire: O valida deve ser negativado para que quando a digitação
                              //for valida ele saia e quando inválida ele faça o looping novamente

            return i_nro;
        }

        /**************************************************************************
        *         Método: PegaDouble (Público)
        *      Descrição: Este método é responsável por retornar um número válido
        *    Dt. Criação: 09/10/2023
        *  Dt. Alteração: --/--/----
        *     Observação: 
        *        Família: Função
        *      Parâmetro: Uma mensagem String
        *        Retorno: Uma variável do tipo double
        *      Feita por: D4rkFire
        *************************************************************************/
        public double PegaDouble(string ps_msg)
        {
            bool b_valida = false;
            double d_nro = 0;
            Console.Write(ps_msg);

            do
            {
                b_valida = double.TryParse(Console.ReadLine(), out d_nro);
            } while (!b_valida);//D4rkFire: O valida deve ser negativado para que quando a digitação
                                //for valida ele saia e quando inválida ele faça o looping novamente

            return d_nro;
        }

        /**************************************************************************
        *         Método: PegaData (Público)
        *      Descrição: Este método é responsável por retornar uma data válida
        *    Dt. Criação: 09/10/2023
        *  Dt. Alteração: --/--/----
        *     Observação: 
        *        Família: Função
        *      Parâmetro: Uma mensagem String
        *        Retorno: Uma variável do tipo DateTime
        *      Feita por: D4rkFire
        *************************************************************************/

        public DateTime PegaData(string ps_msg)
        {
            bool b_valida = false;
            DateTime dt_Data = DateTime.MinValue;
            Console.Write(ps_msg);

            do
            {
                b_valida = DateTime.TryParse(Console.ReadLine(), out dt_Data);
            } while (!b_valida);
            //D4rkFire: O valida deve ser negativado para que quando a digitação      
            //for valida ele saia e quando inválida ele faça o looping novamente

            return dt_Data;
        }


            /**************************************************************************
            *         Método: PegaOpcao (Público)
            *      Descrição: Este método é responsável por retornar uma opção válida
            *    Dt. Criação: 09/10/2023
            *  Dt. Alteração: --/--/----
            *     Observação: 
            *        Família: Função
            *      Parâmetro: Início, Fim e Uma mensagem String
            *        Retorno: Uma variável inteira dentro do Range de opções
            *      Feita por: D4rkFire
            *************************************************************************/

            public int PegaOpcao(int pi_ini, int pi_fim, string ps_msg)
            {
                bool b_valida = false;
                int i_nro = 0;
            Console.Write(ps_msg);

            do
                {
                    b_valida = int.TryParse(Console.ReadLine(), out i_nro) && i_nro >= pi_ini && i_nro <= pi_fim;
                } while (!b_valida);
                //D4rkFire: O valida deve ser negativado para que quando a digitação      
                //for valida ele saia e quando inválida ele faça o looping novamente

            return i_nro;
            }

           /**************************************************************************
            *         Método: PegaSN (Público)
            *      Descrição: Este método é responsável por retornar Sim ou Não (S/N)
            *    Dt. Criação: 09/10/2023
            *  Dt. Alteração: --/--/----
            *     Observação: 
            *        Família: Função
            *      Parâmetro: Uma mensagem String
            *        Retorno: Uma variável contendo S ou S
            *      Feita por: D4rkFire
            *************************************************************************/

        public string PegaSN(string ps_msg)
        {
            bool b_valida = false;
            string s_resp = "";
            Console.Write(ps_msg);

            do
            {
                s_resp = Console.ReadLine().ToUpper();

                // b_valida = s_resp == "S" || s_resp == "N"? true: false;

                if (s_resp == "S" || s_resp == "N")
                {
                    b_valida = true;
                }
                else
                {
                    b_valida &= false;
                }

               
            } while (!b_valida);
            //D4rkFire: O valida deve ser negativado para que quando a digitação      
            //for valida ele saia e quando inválida ele faça o looping novamente

            return s_resp;
        }
    }
}
