/*****************************************************************************
*           Nome: ItemBD
*      Descrição: Representa a classe que negocia com a Base de dados da 
*                 Entidade Item. A classe BD possui os metodos: Incluir,
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
    class ItemBD
    {
        //Destruidor da Classe
        ~ItemBD()
        {
        }

        /**********************************************************************
        *  Nome: Incluir
        *  Descrição: Responsável por incluir a TUPLA do Objeto Item na
        *             Tabela TB_ITEM
        *  Parametro: Item (Objeto da Classe)
        *  Retorna: Código da TUPLA incluída.
        *  Dt. Criação:
        *  DT. Alteração:
        *  Obs. Alteração: -------------------
        *  Criada por: mFacine
        *  Observação: Este método utiliza a classe auxiliar de conexão.
        ***********************************************************************/
        public int Incluir(Item pobj_Item)
        {
            string s_varSql = "";
            int i_Cod = pobj_Item.Cod_Item;

            //Conexão

            SqlConnection obj_Conn = new SqlConnection(Connection.PathConnection());

            s_varSql = " INSERT INTO TB_ITEM " +
                       " ( " +
                       " I_COD_TAREFA, " +
                       " I_COD_INSUMO, " +
                       " I_QTDE_ITEM " +
                       " ) " +
                       " VALUES " +
                       " ( " +
                       " @I_COD_TAREFA, " +
                       " @I_COD_INSUMO, " +
                       " @I_QTDE_ITEM " +
                       " ); " +
                       " SELECT IDENT_CURRENT ('TB_ITEM') AS 'COD' ";

            SqlCommand obj_Cmd = new SqlCommand(s_varSql, obj_Conn);
            obj_Cmd.Parameters.AddWithValue("@I_COD_TAREFA", pobj_Item.Cod_Tarefa);
            obj_Cmd.Parameters.AddWithValue("@I_COD_INSUMO", pobj_Item.Cod_Insumo);
            obj_Cmd.Parameters.AddWithValue("@I_QTDE_ITEM", pobj_Item.Qtde_Item);

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
        *  Nome: ExcluirByCodTarefa
        *  Descrição: Responsável por Excluir a TUPLA do Objeto Item na
        *             Tabela TB_ITEM
        *  Parametro: Item (Objeto da Classe)
        *  Retorna: Boleano (bool)
        *  Dt. Criação:
        *  DT. Alteração:
        *  Obs. Alteração: -------------------
        *  Criada por: mFacine
        *  Observação: Este método utiliza a classe auxiliar de conexão.
        ***********************************************************************/
        public bool ExcluirByCodTarefa(Item pobj_Item)
        {
            string s_varSql = "";
            bool b_valida = false;

            //Conexão
            SqlConnection obj_Conn = new SqlConnection(Connection.PathConnection());

            s_varSql = " DELETE FROM TB_ITEM " +
                       " WHERE I_COD_TAREFA = @I_COD_TAREFA ";

            SqlCommand obj_Cmd = new SqlCommand(s_varSql, obj_Conn);
            obj_Cmd.Parameters.AddWithValue("@I_COD_TAREFA", pobj_Item.Cod_Tarefa);

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
        *  Nome: FindByCodTarefa
        *  Descrição: Responsável por Selecionar todas as TUPLAS dos Objetos IteNS na
        *             Tabela TB_ITEM que correspondem a tarefa.
        *  Parametro: Objeto Item com o código da tarefa.
        *  Retorna: Uma Lista de objetos Item (List) 
        *  Dt. Criação: 22/03/2024
        *  DT. Alteração: --/--/----
        *  Obs. Alteração: -------------------
        *  Criada por: mFacine
        *  Observação: Este método utiliza a classe auxiliar de conexão.
        ***********************************************************************/
        public List<Item> FindByCodTarefa(Item pobj_Item)
        {
            string s_varSql = "";

            //Conexão
            SqlConnection obj_Conn = new SqlConnection(Connection.PathConnection());

            s_varSql = " SELECT * FROM TB_ITEM "+
            " WHERE I_COD_TAREFA = @I_COD_TAREFA ";

            SqlCommand obj_Cmd = new SqlCommand(s_varSql, obj_Conn);
            obj_Cmd.Parameters.AddWithValue("@I_COD_TAREFA", pobj_Item.Cod_Tarefa);


            List<Item> Lista = new List<Item>();

            try
            {
                obj_Conn.Open();
                SqlDataReader obj_Dtr = obj_Cmd.ExecuteReader();

                if (obj_Dtr.HasRows)
                {

                    while (obj_Dtr.Read())
                    {
                        Item obj_Item = new Item();
                        obj_Item.Cod_Item = Convert.ToInt16(obj_Dtr["I_COD_ITEM"].ToString());
                        obj_Item.Cod_Tarefa = Convert.ToInt16(obj_Dtr["I_COD_TAREFA"].ToString());
                        obj_Item.Cod_Insumo = Convert.ToInt16(obj_Dtr["I_COD_INSUMO"].ToString());
                        obj_Item.Qtde_Item = Convert.ToInt16(obj_Dtr["I_QTDE_ITEM"].ToString());

                        Lista.Add(obj_Item);
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
