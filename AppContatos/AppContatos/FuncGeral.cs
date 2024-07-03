using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppContatos
{
    internal class FuncGeral
    {
        public string PegaString(string s_msg)
        {
            Console.Write(s_msg);
            return Console.ReadLine().ToUpper();
        }
        public int PegaInt(string s_msg)
        {
            bool b_valida = false;
            int i_nro = 0;

            Console.Write(s_msg);
            while (!b_valida)
            {
                b_valida = int.TryParse(Console.ReadLine(), out i_nro);
            }

            return i_nro;
        }
        public DateTime PegaData(string s_msg)
        {
                bool b_valida = false;
                DateTime dt_retorno = DateTime.MinValue;



                Console.Write(s_msg);
                while (!b_valida)
                {
                    b_valida = DateTime.TryParse(Console.ReadLine(), out dt_retorno);
                }
                return dt_retorno;
        }
    }
}

