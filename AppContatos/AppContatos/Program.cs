/*
  *****************************************************************************************************
  * Nome do projeto: Agenda                                                                           *
  *     Dt. Criação: 28/09/2023                                                                       *
  *   Dt. Alteração: --/--/----                                                                       *
  *       Histórico:                                                                                  *
  *       Descrição: Aplicativo que recebe informações de                                             *
  *                  contatos e os grava em um arquivo TXT.                                           *
  *                  Permite a consulta de todos ou individual.                                       *
  *     Responsável: Rick                                                                             *
  *****************************************************************************************************
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppContatos
{
    internal class Program
    {
   
        static void Main(string[] args)
        {
            Contato obj_Contato = new Contato();
            FuncGeral obj_FuncGeral = new FuncGeral();
            string s_opcao = "";
            string s_path = @"C:\Users\victor.grferreira\source\repos\AppContatos\AppContato.TXT";

            do
            {
                Console.Clear();  //clear para limpar o console
                Console.WriteLine("*****************************************");
                Console.WriteLine("*        A P P  C O N T A T O S *       *");
                Console.WriteLine("*****************************************");
                Console.WriteLine("*         G - Gravar um contato         *");
                Console.WriteLine("*       T - Ler todos os contatos       *");
                Console.WriteLine("*    P - pesquisar contado p/ codigo    *");
                Console.WriteLine("          S - SAIR DA APLICAÇÃO         *");
                Console.WriteLine("*****************************************");

                s_opcao = obj_FuncGeral.PegaString("Entre com sua opção (G, T, P ou S)  ");

                if (s_opcao != "S")

                switch (s_opcao)
                {
                    case "G":
                        {
                            do
                            {

                                obj_Contato.Cod_contato = obj_FuncGeral.PegaInt("Entre com o codigo do contado: ");
                                obj_Contato.Nm_contato = obj_FuncGeral.PegaString("enre com o nome do contato: ");
                                obj_Contato.Cel_contato = obj_FuncGeral.PegaString("enre com o numero do celular do contato: ");
                                obj_Contato.Mail_contato = obj_FuncGeral.PegaString("enre com o email do contato: ");
                                obj_Contato.End_contato = obj_FuncGeral.PegaString("enre com o endereço do contato: ");
                                obj_Contato.Bai_contato = obj_FuncGeral.PegaString("enre com o endereço do contato: ");
                                obj_Contato.Cid_contato = obj_FuncGeral.PegaString("enre com a cidade do contato: ");
                                obj_Contato.UF_contato = obj_FuncGeral.PegaString("enre com a UF do contato: ");
                                obj_Contato.CEP_contato = obj_FuncGeral.PegaString("enre com o CEP do contato: ");
                                obj_Contato.Cad_contato = DateTime.Today;
                                obj_Contato.Nasc_contato = obj_FuncGeral.PegaData("Entre com a data de nacimento do Contato: ");

                                StreamWriter sw = new StreamWriter("AppConsole");
                                sw.WriteLine("{0}", obj_Contato.Cod_contato);
                                sw.WriteLine("          Nome: {0}", obj_Contato.Nm_contato);
                                sw.WriteLine("       Celular: {0}", obj_Contato.Cel_contato);
                                sw.WriteLine("        E-mail: {0}", obj_Contato.Mail_contato);
                                sw.WriteLine("      Endereço: {0}", obj_Contato.End_contato);
                                sw.WriteLine("        Bairro: {0}", obj_Contato.Bai_contato);
                                sw.WriteLine("            UF: {0}", obj_Contato.UF_contato);
                                sw.WriteLine("           CEP: {0}", obj_Contato.CEP_contato);
                                sw.WriteLine("  Dt. Cadastro: {0}", obj_Contato.Cad_contato);
                                sw.WriteLine(" Dt Nascimento: {0}", obj_Contato.Nasc_contato);
                                sw.WriteLine("-------------------------------------------------");
                                sw.Close();

                                Console.Write("Deseja gravar outro contato?");
                            } while (Console.ReadLine().ToUpper() == "S");

                            break;
                        }
                    case "T":
                        {
                            StreamReader sr = new StreamReader(s_path);

                            while(!sr.EndOfStream)
                            {
                                Console.WriteLine(sr.ReadLine());
                            }
                            sr.Close();

                            Console.WriteLine("Pressione <enter> para continuar...");
                            Console.ReadLine(); //pode ser usado ReadKey para ler qualquer tecla 

                            break;
                        }
                    case "P":
                        {
                            bool b_encontrou = false;
                            int i_codigo = 0;

                            i_codigo = obj_FuncGeral.PegaInt("Entre com o código do contato: ");

                            StreamReader sr = new StreamReader(s_path);

                            while (!sr.EndOfStream)
                            {
                                if (i_codigo.ToString() == sr.ReadLine())
                                {
                                    b_encontrou = true;
                                    Console.WriteLine("{0}", i_codigo.ToString());
                                    for (int i = 1; i <= 10; i++)
                                    {
                                        Console.WriteLine(sr.ReadLine());
                                    }
                                }
                                sr.ReadLine();
                            }
                            sr.Close();

                            Console.WriteLine("Pressione <enter> para continuar...");
                            Console.ReadLine();

                            break;
                        }


                        case "S":
                            {
                                Environment.Exit(0);
                                break;
                            }

                }

            } while (s_opcao != "S");
        }
    }
}
