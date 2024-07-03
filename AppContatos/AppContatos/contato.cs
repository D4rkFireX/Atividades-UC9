/***********************************************************************
 *       Nome: Contato
 * Observação: Representa a classe de contatos da agenda. Possui atributos privados e
 *             metodos Publicos.
 * Dt Criação: 28/09/2023 
 *   Criada por: Rick
*/
using System;

namespace AppContatos
{
    internal class Contato
    {
        private int i_cod_contato = 0;
        private string s_nm_contato = "";
        private string s_cel_contato = "";
        private string s_mail_contato = "";
        private string s_end_contato = "";
        private string s_bai_contato = "";
        private string s_cid_contato = "";
        private string s_UF_contato = "";
        private string s_CEP_contato = "";
        private DateTime dt_cad_contato = DateTime.MinValue;
        private DateTime dt_nasc_contato = DateTime.MinValue;

        public int Cod_contato 
        { 
            get => i_cod_contato; 
            set => i_cod_contato = value; 
        }

        public string Nm_contato 
        { 
            get => s_nm_contato; 
            set => s_nm_contato = value; 
        }

        public string Cel_contato 
        { 
            get => s_cel_contato; 
            set => s_cel_contato = value; 
        }

        public string Mail_contato 
        { 
            get => s_mail_contato; 
            set => s_mail_contato = value;
        }

        public string End_contato
        { 
            get => s_end_contato; 
            set => s_end_contato = value; 
        }

        public string Bai_contato 
        { 
            get => s_bai_contato; 
            set => s_bai_contato = value; 
        }

        public string Cid_contato 
        { 
            get => s_cid_contato; 
            set => s_cid_contato = value; 
        }

        public string UF_contato 
        { 
            get => s_UF_contato; 
            set => s_UF_contato = value; 
        }

        public string CEP_contato 
        { 
            get => s_CEP_contato; 
            set => s_CEP_contato = value; 
        }

        public DateTime Cad_contato 
        { 
            get => dt_cad_contato; 
            set => dt_cad_contato = value; 
        }

        public DateTime Nasc_contato 
        { 
            get => dt_nasc_contato; 
            set => dt_nasc_contato = value; 
        }
    }
}
