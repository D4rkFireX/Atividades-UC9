/*****************************************************************************
*           Nome: CategoriaBD
*      Descrição: Representa a classe que negocia com a Base de dados da 
*                 Entidade Categoria. A classe BD possui os metodos: Incluir,
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
    class CategoriaBD
    {
        //Destruidor da Classe
        ~CategoriaBD() 
        { 
        }

        /**********************************************************************
        *  Nome: Incluir
        *  Descrição: Responsável por incluir a TUPLA do Objeto Categoria na
        *             Tabela TB_CATEGORIA
        *  Parametro: Categoria (Objeto da Classe)
        *  Retorna: Código da TUPLA incluída.
        *  Dt. Criação:
        *  DT. Alteração:
        *  Obs. Alteração: -------------------
        *  Criada por: mFacine
        *  Observação: Este método utiliza a classe auxiliar de conexão.
        ***********************************************************************/
        public int Incluir(Categoria pobj_Categoria)
        {
            string s_varSql = "";
            int i_Cod = pobj_Categoria.Cod_Categoria;

            //Conexão

            SqlConnection obj_Conn = new SqlConnection(Connection.PathConnection());

            s_varSql = " INSERT INTO TB_CATEGORIA " +
                       " ( " +
                       " S_NM_CATEGORIA " +
                       " ) " +
                       " VALUES " +
                       " ( " +
                       " @S_NM_CATEGORIA " +
                       " ); " +
                       " SELECT IDENT_CURRENT ('TB_CATEGORIA') AS 'COD' ";

            SqlCommand obj_Cmd = new SqlCommand(s_varSql, obj_Conn);
            obj_Cmd.Parameters.AddWithValue("@S_NM_CATEGORIA", pobj_Categoria.Nm_Categoria);

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
        *  Descrição: Responsável por Alterar a TUPLA do Objeto Categoria na
        *             Tabela TB_CATEGORIA
        *  Parametro: Categoria (Objeto da Classe)
        *  Retorna: Boleano (bool)
        *  Dt. Criação:
        *  DT. Alteração:
        *  Obs. Alteração: -------------------
        *  Criada por: mFacine
        *  Observação: Este método utiliza a classe auxiliar de conexão.
        ***********************************************************************/
        public bool Alterar(Categoria pobj_Categoria)
        {
            string s_varSql = "";
            bool b_valida = false;

            //Conexão
            SqlConnection obj_Conn = new SqlConnection(Connection.PathConnection());

            s_varSql = " UPDATE TB_CATEGORIA SET " +
                       " S_NM_CATEGORIA = @S_NM_CATEGORIA " +
                       " WHERE I_COD_CATEGORIA = @I_COD_CATEGORIA ";

            SqlCommand obj_Cmd = new SqlCommand(s_varSql, obj_Conn);
            obj_Cmd.Parameters.AddWithValue("@S_NM_CATEGORIA", pobj_Categoria.Nm_Categoria);
            obj_Cmd.Parameters.AddWithValue("@I_COD_CATEGORIA", pobj_Categoria.Cod_Categoria);

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
        *  Descrição: Responsável por Excluir a TUPLA do Objeto Categoria na
        *             Tabela TB_CATEGORIA
        *  Parametro: Categoria (Objeto da Classe)
        *  Retorna: Boleano (bool)
        *  Dt. Criação:
        *  DT. Alteração:
        *  Obs. Alteração: -------------------
        *  Criada por: mFacine
        *  Observação: Este método utiliza a classe auxiliar de conexão.
        ***********************************************************************/
        public bool Excluir(Categoria pobj_Categoria)
        {
            string s_varSql = "";
            bool b_valida = false;

            //Conexão
            SqlConnection obj_Conn = new SqlConnection(Connection.PathConnection());

            s_varSql = " DELETE FROM TB_CATEGORIA " +
                       " WHERE I_COD_CATEGORIA = @I_COD_CATEGORIA ";

            SqlCommand obj_Cmd = new SqlCommand(s_varSql, obj_Conn);
            obj_Cmd.Parameters.AddWithValue("@I_COD_CATEGORIA", pobj_Categoria.Cod_Categoria);

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
        *  Descrição: Responsável por Selecionar a TUPLA do Objeto Categoria na
        *             Tabela TB_CATEGORIA
        *  Parametro: Categoria (Objeto da Classe)
        *  Retorna: Categoria (Objeto da Classe) 
        *  Dt. Criação: 09/02/2024
        *  DT. Alteração: --/--/----
        *  Obs. Alteração: -------------------
        *  Criada por: mFacine
        *  Observação: Este método utiliza a classe auxiliar de conexão.
        ***********************************************************************/
        public Categoria FindByCod(Categoria pobj_Categoria)
        {
            string s_varSql = "";
            
            //Conexão
            SqlConnection obj_Conn = new SqlConnection(Connection.PathConnection());

            s_varSql = " SELECT * FROM TB_CATEGORIA " +
                       " WHERE I_COD_CATEGORIA = @I_COD_CATEGORIA ";

            SqlCommand obj_Cmd = new SqlCommand(s_varSql, obj_Conn);
            obj_Cmd.Parameters.AddWithValue("@I_COD_CATEGORIA", pobj_Categoria.Cod_Categoria);

            try
            {
                obj_Conn.Open();
                SqlDataReader obj_Dtr = obj_Cmd.ExecuteReader();

                if (obj_Dtr.HasRows)
                {
                    obj_Dtr.Read();
                    pobj_Categoria.Nm_Categoria = obj_Dtr["S_NM_CATEGORIA"].ToString();
                    
                }
                else
                {
                    pobj_Categoria = new Categoria();
                }

                obj_Conn.Close();
                obj_Dtr.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return pobj_Categoria;
        }

        /**********************************************************************
        *  Nome: FindAll
        *  Descrição: Responsável por Selecionar todas as TUPLAS dos Objetos Categoria na
        *             Tabela TB_CATEGORIA
        *  Retorna: Uma Lista de objetos Categoria (List) 
        *  Dt. Criação: 09/02/2024
        *  DT. Alteração: --/--/----
        *  Obs. Alteração: -------------------
        *  Criada por: mFacine
        *  Observação: Este método utiliza a classe auxiliar de conexão.
        ***********************************************************************/
        public List<Categoria> FindAll()
        {
            string s_varSql = "";

            //Conexão
            SqlConnection obj_Conn = new SqlConnection(Connection.PathConnection());

            s_varSql = " SELECT * FROM TB_CATEGORIA ";

            SqlCommand obj_Cmd = new SqlCommand(s_varSql, obj_Conn);

            List<Categoria> Lista = new List<Categoria>();
            
            try
            {
                obj_Conn.Open();
                SqlDataReader obj_Dtr = obj_Cmd.ExecuteReader();
                
                if (obj_Dtr.HasRows)
                {
                    
                    while (obj_Dtr.Read())
                    {
                        Categoria obj_Categoria = new Categoria();
                        obj_Categoria.Cod_Categoria = Convert.ToInt16(obj_Dtr["I_COD_CATEGORIA"].ToString());
                        obj_Categoria.Nm_Categoria = obj_Dtr["S_NM_CATEGORIA"].ToString();

                        Lista.Add(obj_Categoria);
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
