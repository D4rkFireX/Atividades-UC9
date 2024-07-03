/*****************************************************************************
*           Nome: InsumoBD
*      Descrição: Representa a classe que negocia com a Base de dados da 
*                 Entidade Insumo. A classe BD possui os metodos: Incluir,
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
    class InsumoBD
    {
        //Destruidor da Classe
        ~InsumoBD()
        {
        }

        /**********************************************************************
        *  Nome: Incluir
        *  Descrição: Responsável por incluir a TUPLA do Objeto Insumo na
        *             Tabela TB_INSUMO
        *  Parametro: Insumo (Objeto da Classe)
        *  Retorna: Código da TUPLA incluída.
        *  Dt. Criação:
        *  DT. Alteração:
        *  Obs. Alteração: -------------------
        *  Criada por: mFacine
        *  Observação: Este método utiliza a classe auxiliar de conexão.
        ***********************************************************************/
        public int Incluir(Insumo pobj_Insumo)
        {
            string s_varSql = "";
            int i_Cod = pobj_Insumo.Cod_Insumo;

            //Conexão

            SqlConnection obj_Conn = new SqlConnection(Connection.PathConnection());

            s_varSql = " INSERT INTO TB_INSUMO " +
                       " ( " +
                       " I_COD_FAMILIA, " +
                       " S_NM_INSUMO, " +
                       " B_FRAC_INSUMO " +
                       " ) " +
                       " VALUES " +
                       " ( " +
                       " @I_COD_FAMILIA, " +
                       " @S_NM_INSUMO, " +
                       " @B_FRAC_INSUMO " +
                       " ); " +
                       " SELECT IDENT_CURRENT ('TB_INSUMO') AS 'COD' ";

            SqlCommand obj_Cmd = new SqlCommand(s_varSql, obj_Conn);
            obj_Cmd.Parameters.AddWithValue("@I_COD_FAMILIA", pobj_Insumo.Cod_Familia);
            obj_Cmd.Parameters.AddWithValue("@S_NM_INSUMO", pobj_Insumo.Nm_Insumo);
            obj_Cmd.Parameters.AddWithValue("@B_FRAC_INSUMO", pobj_Insumo.Frac_Insumo);

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
        *  Descrição: Responsável por Alterar a TUPLA do Objeto Insumo na
        *             Tabela TB_INSUMO
        *  Parametro: Insumo (Objeto da Classe)
        *  Retorna: Boleano (bool)
        *  Dt. Criação:
        *  DT. Alteração:
        *  Obs. Alteração: -------------------
        *  Criada por: mFacine
        *  Observação: Este método utiliza a classe auxiliar de conexão.
        ***********************************************************************/
        public bool Alterar(Insumo pobj_Insumo)
        {
            string s_varSql = "";
            bool b_valida = false;

            //Conexão
            SqlConnection obj_Conn = new SqlConnection(Connection.PathConnection());

            s_varSql = " UPDATE TB_INSUMO SET " +
                       " I_COD_FAMILIA = @I_COD_FAMILIA, " +
                       " S_NM_INSUMO = @S_NM_INSUMO, " +
                       " B_FRAC_INSUMO = @B_FRAC_INSUMO " +
                       " WHERE I_COD_INSUMO = @I_COD_INSUMO ";

            SqlCommand obj_Cmd = new SqlCommand(s_varSql, obj_Conn);

            obj_Cmd.Parameters.AddWithValue("@I_COD_INSUMO", pobj_Insumo.Cod_Insumo);
            obj_Cmd.Parameters.AddWithValue("@I_COD_FAMILIA", pobj_Insumo.Cod_Familia);
            obj_Cmd.Parameters.AddWithValue("@S_NM_INSUMO", pobj_Insumo.Nm_Insumo);
            obj_Cmd.Parameters.AddWithValue("@B_FRAC_INSUMO", pobj_Insumo.Frac_Insumo);

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
        *  Descrição: Responsável por Excluir a TUPLA do Objeto Insumo na
        *             Tabela TB_INSUMO
        *  Parametro: Insumo (Objeto da Classe)
        *  Retorna: Boleano (bool)
        *  Dt. Criação:
        *  DT. Alteração:
        *  Obs. Alteração: -------------------
        *  Criada por: mFacine
        *  Observação: Este método utiliza a classe auxiliar de conexão.
        ***********************************************************************/
        public bool Excluir(Insumo pobj_Insumo)
        {
            string s_varSql = "";
            bool b_valida = false;

            //Conexão
            SqlConnection obj_Conn = new SqlConnection(Connection.PathConnection());

            s_varSql = " DELETE FROM TB_INSUMO " +
                       " WHERE I_COD_INSUMO = @I_COD_INSUMO ";

            SqlCommand obj_Cmd = new SqlCommand(s_varSql, obj_Conn);
            obj_Cmd.Parameters.AddWithValue("@I_COD_INSUMO", pobj_Insumo.Cod_Insumo);

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
        *  Descrição: Responsável por Selecionar a TUPLA do Objeto Insumo na
        *             Tabela TB_INSUMO
        *  Parametro: Insumo (Objeto da Classe)
        *  Retorna: Insumo (Objeto da Classe) 
        *  Dt. Criação: 09/02/2024
        *  DT. Alteração: --/--/----
        *  Obs. Alteração: -------------------
        *  Criada por: mFacine
        *  Observação: Este método utiliza a classe auxiliar de conexão.
        ***********************************************************************/
        public Insumo FindByCod(Insumo pobj_Insumo)
        {
            string s_varSql = "";

            //Conexão
            SqlConnection obj_Conn = new SqlConnection(Connection.PathConnection());

            s_varSql = " SELECT * FROM TB_INSUMO " +
                       " WHERE I_COD_INSUMO = @I_COD_INSUMO ";

            SqlCommand obj_Cmd = new SqlCommand(s_varSql, obj_Conn);
            obj_Cmd.Parameters.AddWithValue("@I_COD_INSUMO", pobj_Insumo.Cod_Insumo);

            try
            {
                obj_Conn.Open();
                SqlDataReader obj_Dtr = obj_Cmd.ExecuteReader();

                if (obj_Dtr.HasRows)
                {
                    obj_Dtr.Read();
                    pobj_Insumo.Cod_Familia = Convert.ToInt16(obj_Dtr["I_COD_FAMILIA"].ToString());
                    pobj_Insumo.Nm_Insumo = obj_Dtr["S_NM_INSUMO"].ToString();
                    pobj_Insumo.Frac_Insumo = obj_Dtr["B_FRAC_INSUMO"].ToString() == "1" ? true : false;
                }
                else
                {
                    pobj_Insumo = new Insumo();
                }

                obj_Conn.Close();
                obj_Dtr.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return pobj_Insumo;
        }

        /**********************************************************************
        *  Nome: FindAll
        *  Descrição: Responsável por Selecionar todas as TUPLAS dos Objetos Insumo na
        *             Tabela TB_INSUMO
        *  Retorna: Uma Lista de objetos Insumo (List) 
        *  Dt. Criação: 09/02/2024
        *  DT. Alteração: --/--/----
        *  Obs. Alteração: -------------------
        *  Criada por: mFacine
        *  Observação: Este método utiliza a classe auxiliar de conexão.
        ***********************************************************************/
        public List<Insumo> FindAll()
        {
            string s_varSql = "";

            //Conexão
            SqlConnection obj_Conn = new SqlConnection(Connection.PathConnection());

            s_varSql = " SELECT * FROM TB_INSUMO ";

            SqlCommand obj_Cmd = new SqlCommand(s_varSql, obj_Conn);

            List<Insumo> Lista = new List<Insumo>();

            try
            {
                obj_Conn.Open();
                SqlDataReader obj_Dtr = obj_Cmd.ExecuteReader();

                if (obj_Dtr.HasRows)
                {

                    while (obj_Dtr.Read())
                    {
                        Insumo obj_Insumo = new Insumo();
                        obj_Insumo.Cod_Insumo = Convert.ToInt16(obj_Dtr["I_COD_INSUMO"].ToString());
                        obj_Insumo.Cod_Familia = Convert.ToInt16(obj_Dtr["I_COD_FAMILIA"].ToString());
                        obj_Insumo.Nm_Insumo = obj_Dtr["S_NM_INSUMO"].ToString();
                        obj_Insumo.Frac_Insumo = obj_Dtr["B_FRAC_INSUMO"].ToString() == "1" ? true : false;

                        Lista.Add(obj_Insumo);
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
