/*****************************************************************************
*           Nome: FamiliaBD
*      Descrição: Representa a classe que negocia com a Base de dados da 
*                 Entidade Familia. A classe BD possui os metodos: Incluir,
*                 Alterar, Excluir, FindByCod e FindAll (Publicas)
*    Dt. Criação: 08/02/2024
*  Dt. Alteração: --/--/----
* Obs. Alteração: -------------------
*     Criada por: mFacine
******************************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppToDo
{
    class FamiliaBD
    {
        //Destruidor da Classe
        ~FamiliaBD()
        {
        }

        /**********************************************************************
        *  Nome: Incluir
        *  Descrição: Responsável por incluir a TUPLA do Objeto Familia na
        *             Tabela TB_FAMILIA
        *  Parametro: Familia (Objeto da Classe)
        *  Retorna: Código da TUPLA incluída.
        *  Dt. Criação:
        *  DT. Alteração:
        *  Obs. Alteração: -------------------
        *  Criada por: mFacine
        *  Observação: Este método utiliza a classe auxiliar de conexão.
        ***********************************************************************/
        public int Incluir(Familia pobj_Familia)
        {
            string s_varSql = "";
            int i_Cod = pobj_Familia.Cod_Familia;

            //Conexão

            SqlConnection obj_Conn = new SqlConnection(Connection.PathConnection());

            s_varSql = " INSERT INTO TB_FAMILIA " +
                       " ( " +
                       " S_NM_FAMILIA " +
                       " ) " +
                       " VALUES " +
                       " ( " +
                       " @S_NM_FAMILIA " +
                       " ); " +
                       " SELECT IDENT_CURRENT ('TB_FAMILIA') AS 'COD' ";

            SqlCommand obj_Cmd = new SqlCommand(s_varSql, obj_Conn);
            obj_Cmd.Parameters.AddWithValue("@S_NM_FAMILIA", pobj_Familia.Nm_Familia);

            try
            {
                obj_Conn.Open();
                i_Cod = Convert.ToInt16(obj_Cmd.ExecuteScalar());
                obj_Conn.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return i_Cod;
        }

        /**********************************************************************
        *  Nome: Alterar
        *  Descrição: Responsável por Alterar a TUPLA do Objeto Familia na
        *             Tabela TB_FAMILIA
        *  Parametro: Familia (Objeto da Classe)
        *  Retorna: Boleano (bool)
        *  Dt. Criação:
        *  DT. Alteração:
        *  Obs. Alteração: -------------------
        *  Criada por: mFacine
        *  Observação: Este método utiliza a classe auxiliar de conexão.
        ***********************************************************************/
        public bool Alterar(Familia pobj_Familia)
        {
            string s_varSql = "";
            bool b_valida = false;

            //Conexão
            SqlConnection obj_Conn = new SqlConnection(Connection.PathConnection());

            s_varSql = " UPDATE TB_FAMILIA SET " +
                       " S_NM_FAMILIA = @S_NM_FAMILIA " +
                       " WHERE I_COD_FAMILIA = @I_COD_FAMILIA ";

            SqlCommand obj_Cmd = new SqlCommand(s_varSql, obj_Conn);
            obj_Cmd.Parameters.AddWithValue("@S_NM_FAMILIA", pobj_Familia.Nm_Familia);
            obj_Cmd.Parameters.AddWithValue("@I_COD_FAMILIA", pobj_Familia.Cod_Familia);

            try
            {
                obj_Conn.Open();
                obj_Cmd.ExecuteNonQuery();
                obj_Conn.Close();
                b_valida = true;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return b_valida;
        }


        /**********************************************************************
        *  Nome: Excluir
        *  Descrição: Responsável por Excluir a TUPLA do Objeto Familia na
        *             Tabela TB_FAMILIA
        *  Parametro: Familia (Objeto da Classe)
        *  Retorna: Boleano (bool)
        *  Dt. Criação:
        *  DT. Alteração:
        *  Obs. Alteração: -------------------
        *  Criada por: mFacine
        *  Observação: Este método utiliza a classe auxiliar de conexão.
        ***********************************************************************/
        public bool Excluir(Familia pobj_Familia)
        {
            string s_varSql = "";
            bool b_valida = false;

            //Conexão
            SqlConnection obj_Conn = new SqlConnection(Connection.PathConnection());

            s_varSql = " DELETE FROM TB_FAMILIA " +
                       " WHERE I_COD_FAMILIA = @I_COD_FAMILIA ";

            SqlCommand obj_Cmd = new SqlCommand(s_varSql, obj_Conn);
            obj_Cmd.Parameters.AddWithValue("@I_COD_FAMILIA", pobj_Familia.Cod_Familia);

            try
            {
                obj_Conn.Open();
                obj_Cmd.ExecuteNonQuery();
                obj_Conn.Close();
                b_valida = true;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return b_valida;
        }

        /**********************************************************************
        *  Nome: FindByCod
        *  Descrição: Responsável por Selecionar a TUPLA do Objeto Familia na
        *             Tabela TB_FAMILIA
        *  Parametro: Familia (Objeto da Classe)
        *  Retorna: Familia (Objeto da Classe) 
        *  Dt. Criação: 09/02/2024
        *  DT. Alteração: --/--/----
        *  Obs. Alteração: -------------------
        *  Criada por: mFacine
        *  Observação: Este método utiliza a classe auxiliar de conexão.
        ***********************************************************************/
        public Familia FindByCod(Familia pobj_Familia)
        {
            string s_varSql = "";

            //Conexão
            SqlConnection obj_Conn = new SqlConnection(Connection.PathConnection());

            s_varSql = " SELECT * FROM TB_FAMILIA " +
                       " WHERE I_COD_FAMILIA = @I_COD_FAMILIA ";

            SqlCommand obj_Cmd = new SqlCommand(s_varSql, obj_Conn);
            obj_Cmd.Parameters.AddWithValue("@I_COD_FAMILIA", pobj_Familia.Cod_Familia);

            try
            {
                obj_Conn.Open();
                SqlDataReader obj_Dtr = obj_Cmd.ExecuteReader();

                if (obj_Dtr.HasRows)
                {
                    obj_Dtr.Read();
                    pobj_Familia.Nm_Familia = obj_Dtr["S_NM_FAMILIA"].ToString();

                }
                else
                {
                    pobj_Familia = new Familia();
                }

                obj_Conn.Close();
                obj_Dtr.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return pobj_Familia;
        }

        /**********************************************************************
        *  Nome: FindAll
        *  Descrição: Responsável por Selecionar todas as TUPLAS dos Objetos Familia na
        *             Tabela TB_FAMILIA
        *  Retorna: Uma Lista de objetos Familia (List) 
        *  Dt. Criação: 09/02/2024
        *  DT. Alteração: --/--/----
        *  Obs. Alteração: -------------------
        *  Criada por: mFacine
        *  Observação: Este método utiliza a classe auxiliar de conexão.
        ***********************************************************************/
        public List<Familia> FindAll()
        {
            string s_varSql = "";

            //Conexão
            SqlConnection obj_Conn = new SqlConnection(Connection.PathConnection());

            s_varSql = " SELECT * FROM TB_FAMILIA ";

            SqlCommand obj_Cmd = new SqlCommand(s_varSql, obj_Conn);

            List<Familia> Lista = new List<Familia>();

            try
            {
                obj_Conn.Open();
                SqlDataReader obj_Dtr = obj_Cmd.ExecuteReader();

                if (obj_Dtr.HasRows)
                {

                    while (obj_Dtr.Read())
                    {
                        Familia obj_Familia = new Familia();
                        obj_Familia.Cod_Familia = Convert.ToInt16(obj_Dtr["I_COD_FAMILIA"].ToString());
                        obj_Familia.Nm_Familia = obj_Dtr["S_NM_FAMILIA"].ToString();

                        Lista.Add(obj_Familia);
                    }

                }
                obj_Conn.Close();
                obj_Dtr.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Lista;
        }


    }
}
