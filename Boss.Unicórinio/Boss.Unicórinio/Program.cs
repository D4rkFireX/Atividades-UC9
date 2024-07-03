using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss.Unicórinio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boss Unicórnio");
            Console.ReadLine();
            Console.Clear();

            string s_nm = "";
            Console.Write("Digite seu nome completo: ");
            s_nm = Console.ReadLine();

            Console.WriteLine("Todo o nome: {0}", s_nm);
            Console.WriteLine("Primeiro Caractere: {0}", s_nm.Substring(0, 1));
            Console.WriteLine("Último Caractere: {0}", s_nm.Substring(s_nm.Length - 1,1));
            Console.WriteLine("Do primeiro até o Terceiro: {0}", s_nm.Substring(0, 3));
            Console.WriteLine("Quarto Caractere: {0}", s_nm.Substring(3, 1));
            Console.WriteLine("Todos menos o primeiro: {0}", s_nm.Substring(1));
            Console.WriteLine("Os Dois Últimos: {0}", s_nm.Substring(s_nm.Length - 2));
            Console.ReadLine();
        }
    }
}
