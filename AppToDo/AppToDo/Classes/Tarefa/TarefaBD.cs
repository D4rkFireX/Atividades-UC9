/*****************************************************************************
*           Nome: TarefaBD
*      Descrição: Representa a classe que negocia com a Base de dados da 
*                 Entidade Tarefa. A classe BD possui os metodos: Incluir,
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
    class TarefaBD
    {
        //Destruidor da Classe
        ~TarefaBD()
        {
        }

        /**********************************************************************
        *  Nome: Incluir
        *  Descrição: Responsável por incluir a TUPLA do Objeto Tarefa na
        *             Tabela TB_TAREFA
        *  Parametro: Tarefa (Objeto da Classe)
        *  Retorna: Código da TUPLA incluída.
        *  Dt. Criação:
        *  DT. Alteração:
        *  Obs. Alteração: -------------------
        *  Criada por: mFacine
        *  Observação: Este método utiliza a classe auxiliar de conexão.
        ***********************************************************************/
        public int Incluir(Tarefa pobj_Tarefa)
        {
            string s_varSql = "";
            int i_Cod = pobj_Tarefa.Cod_Tarefa;

            //Conexão

            SqlConnection obj_Conn = new SqlConnection(Connection.PathConnection());

            s_varSql = " INSERT INTO TB_TAREFA " +
                       " ( " +
                       " I_COD_USUARIO, " +
                       " I_COD_CATEGORIA, " +
                       " S_TIT_TAREFA, " + 
                       " S_DESC_TAREFA, " + 
                       " DT_TERM_TAREFA, " + 
                       " I_STAT_TAREFA, " + 
                       " I_PRIOR_TAREFA " + 
                       " ) " +
                       " VALUES " +
                       " ( " +
                       " @I_COD_USUARIO, " +
                       " @I_COD_CATEGORIA, " +
                       " @S_TIT_TAREFA, " +
                       " @S_DESC_TAREFA, " +
                       " @DT_TERM_TAREFA, " +
                       " @I_STAT_TAREFA, " +
                       " @I_PRIOR_TAREFA " +
                       " ); " +
                       " SELECT IDENT_CURRENT ('TB_TAREFA') AS 'COD' ";

            SqlCommand obj_Cmd = new SqlCommand(s_varSql, obj_Conn);
            obj_Cmd.Parameters.AddWithValue("I_COD_USUARIO", pobj_Tarefa.Cod_Usuario);
            obj_Cmd.Parameters.AddWithValue("I_COD_CATEGORIA", pobj_Tarefa.Cod_Categoria);
            obj_Cmd.Parameters.AddWithValue("S_TIT_TAREFA", pobj_Tarefa.Tit_Tarefa);
            obj_Cmd.Parameters.AddWithValue("S_DESC_TAREFA", pobj_Tarefa.Desc_Tarefa);
            obj_Cmd.Parameters.AddWithValue("DT_TERM_TAREFA", pobj_Tarefa.Term_Tarefa);
            obj_Cmd.Parameters.AddWithValue("I_STAT_TAREFA", pobj_Tarefa.Stat_Tarefa);
            obj_Cmd.Parameters.AddWithValue("I_PRIOR_TAREFA", pobj_Tarefa.Prior_Tarefa);

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
        *  Descrição: Responsável por Alterar a TUPLA do Objeto Tarefa na
        *             Tabela TB_TAREFA
        *  Parametro: Tarefa (Objeto da Classe)
        *  Retorna: Boleano (bool)
        *  Dt. Criação:
        *  DT. Alteração:
        *  Obs. Alteração: -------------------
        *  Criada por: mFacine
        *  Observação: Este método utiliza a classe auxiliar de conexão.
        ***********************************************************************/
        public bool Alterar(Tarefa pobj_Tarefa)
        {
            string s_varSql = "";
            bool b_valida = false;

            //Conexão
            SqlConnection obj_Conn = new SqlConnection(Connection.PathConnection());

            s_varSql = " UPDATE TB_TAREFA SET " +
                       " I_COD_USUARIO  = @I_COD_USUARIO  , " +
                       " I_COD_CATEGORIA  = @I_COD_CATEGORIA  , " +
                       " S_TIT_TAREFA   = @S_TIT_TAREFA   , " +
                       " S_DESC_TAREFA  = @S_DESC_TAREFA  , " +
                       " DT_TERM_TAREFA = @DT_TERM_TAREFA , " +
                       " I_STAT_TAREFA = @I_STAT_TAREFA , " +
                       " I_PRIOR_TAREFA = @I_PRIOR_TAREFA   " +
                       " WHERE I_COD_TAREFA = @I_COD_TAREFA ";

            SqlCommand obj_Cmd = new SqlCommand(s_varSql, obj_Conn);

            obj_Cmd.Parameters.AddWithValue("@I_COD_TAREFA", pobj_Tarefa.Cod_Tarefa);
            obj_Cmd.Parameters.AddWithValue("@I_COD_USUARIO", pobj_Tarefa.Cod_Usuario);
            obj_Cmd.Parameters.AddWithValue("I_COD_CATEGORIA", pobj_Tarefa.Cod_Categoria);
            obj_Cmd.Parameters.AddWithValue("@S_TIT_TAREFA", pobj_Tarefa.Tit_Tarefa);
            obj_Cmd.Parameters.AddWithValue("@S_DESC_TAREFA", pobj_Tarefa.Desc_Tarefa);
            obj_Cmd.Parameters.AddWithValue("@DT_TERM_TAREFA", pobj_Tarefa.Term_Tarefa);
            obj_Cmd.Parameters.AddWithValue("@I_STAT_TAREFA", pobj_Tarefa.Stat_Tarefa);
            obj_Cmd.Parameters.AddWithValue("@I_PRIOR_TAREFA", pobj_Tarefa.Prior_Tarefa);

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
        *  Descrição: Responsável por Excluir a TUPLA do Objeto Tarefa na
        *             Tabela TB_TAREFA
        *  Parametro: Tarefa (Objeto da Classe)
        *  Retorna: Boleano (bool)
        *  Dt. Criação:
        *  DT. Alteração:
        *  Obs. Alteração: -------------------
        *  Criada por: mFacine
        *  Observação: Este método utiliza a classe auxiliar de conexão.
        ***********************************************************************/
        public bool Excluir(Tarefa pobj_Tarefa)
        {
            string s_varSql = "";
            bool b_valida = false;

            //Conexão
            SqlConnection obj_Conn = new SqlConnection(Connection.PathConnection());

            s_varSql = " DELETE FROM TB_TAREFA " +
                       " WHERE I_COD_TAREFA = @I_COD_TAREFA ";

            SqlCommand obj_Cmd = new SqlCommand(s_varSql, obj_Conn);
            obj_Cmd.Parameters.AddWithValue("@I_COD_TAREFA", pobj_Tarefa.Cod_Tarefa);

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
        *  Descrição: Responsável por Selecionar a TUPLA do Objeto Tarefa na
        *             Tabela TB_TAREFA
        *  Parametro: Tarefa (Objeto da Classe)
        *  Retorna: Tarefa (Objeto da Classe) 
        *  Dt. Criação: 09/02/2024
        *  DT. Alteração: --/--/----
        *  Obs. Alteração: -------------------
        *  Criada por: mFacine
        *  Observação: Este método utiliza a classe auxiliar de conexão.
        ***********************************************************************/
        public Tarefa FindByCod(Tarefa pobj_Tarefa)
        {
            string s_varSql = "";

            //Conexão
            SqlConnection obj_Conn = new SqlConnection(Connection.PathConnection());

            s_varSql = " SELECT * FROM TB_TAREFA " +
                       " WHERE I_COD_TAREFA = @I_COD_TAREFA ";

            SqlCommand obj_Cmd = new SqlCommand(s_varSql, obj_Conn);
            obj_Cmd.Parameters.AddWithValue("@I_COD_TAREFA", pobj_Tarefa.Cod_Tarefa);

            try
            {
                obj_Conn.Open();
                SqlDataReader obj_Dtr = obj_Cmd.ExecuteReader();

                if (obj_Dtr.HasRows)
                {
                    obj_Dtr.Read();
                    pobj_Tarefa.Cod_Tarefa = Convert.ToInt16(obj_Dtr["I_COD_TAREFA"].ToString());
                    pobj_Tarefa.Cod_Usuario = Convert.ToInt16(obj_Dtr["I_COD_USUARIO"].ToString());
                    pobj_Tarefa.Cod_Categoria = Convert.ToInt16(obj_Dtr["I_COD_CATEGORIA"].ToString());
                    pobj_Tarefa.Tit_Tarefa = obj_Dtr["S_TIT_TAREFA"].ToString();
                    pobj_Tarefa.Desc_Tarefa = obj_Dtr["S_DESC_TAREFA"].ToString();
                    pobj_Tarefa.Term_Tarefa = Convert.ToDateTime(obj_Dtr["DT_TERM_TAREFA"]);
                    pobj_Tarefa.Stat_Tarefa = Convert.ToInt16(obj_Dtr["I_STAT_TAREFA"].ToString());
                    pobj_Tarefa.Prior_Tarefa = Convert.ToInt16(obj_Dtr["I_PRIOR_TAREFA"].ToString());
                }
                else
                {
                    pobj_Tarefa = new Tarefa();
                }

                obj_Conn.Close();
                obj_Dtr.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return pobj_Tarefa;
        }

        /**********************************************************************
        *  Nome: FindAll
        *  Descrição: Responsável por Selecionar todas as TUPLAS dos Objetos Tarefa na
        *             Tabela TB_TAREFA
        *  Retorna: Uma Lista de objetos Tarefa (List) 
        *  Dt. Criação: 09/02/2024
        *  DT. Alteração: --/--/----
        *  Obs. Alteração: -------------------
        *  Criada por: mFacine
        *  Observação: Este método utiliza a classe auxiliar de conexão.
        ***********************************************************************/
        public List<Tarefa> FindAll()
        {
            string s_varSql = "";

            //Conexão
            SqlConnection obj_Conn = new SqlConnection(Connection.PathConnection());

            s_varSql = " SELECT * FROM TB_TAREFA ";

            SqlCommand obj_Cmd = new SqlCommand(s_varSql, obj_Conn);

            List<Tarefa> Lista = new List<Tarefa>();

            try
            {
                obj_Conn.Open();
                SqlDataReader obj_Dtr = obj_Cmd.ExecuteReader();

                if (obj_Dtr.HasRows)
                {

                    while (obj_Dtr.Read())
                    {
                        Tarefa obj_Tarefa = new Tarefa();
                        obj_Tarefa.Cod_Tarefa = Convert.ToInt16(obj_Dtr["I_COD_TAREFA"].ToString());
                        obj_Tarefa.Cod_Usuario = Convert.ToInt16(obj_Dtr["I_COD_USUARIO"].ToString());
                        obj_Tarefa.Cod_Categoria = Convert.ToInt16(obj_Dtr["I_COD_CATEGORIA"].ToString());
                        obj_Tarefa.Tit_Tarefa = obj_Dtr["S_TIT_TAREFA"].ToString();
                        obj_Tarefa.Desc_Tarefa = obj_Dtr["S_DESC_TAREFA"].ToString();
                        obj_Tarefa.Term_Tarefa = Convert.ToDateTime(obj_Dtr["DT_TERM_TAREFA"]);
                        obj_Tarefa.Stat_Tarefa = Convert.ToInt16(obj_Dtr["I_STAT_TAREFA"].ToString());
                        obj_Tarefa.Prior_Tarefa = Convert.ToInt16(obj_Dtr["I_PRIOR_TAREFA"].ToString());

                        Lista.Add(obj_Tarefa);
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
