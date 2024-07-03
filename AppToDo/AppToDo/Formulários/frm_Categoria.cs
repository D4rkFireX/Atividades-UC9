using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppToDo
{
    public partial class frm_Categoria : Form
    {
        FuncGeral obj_FuncGeral = new FuncGeral();
        public Categoria obj_Categoria_Atual = new Categoria();


        public frm_Categoria()
        {
            InitializeComponent();
            PopulaLista();
            obj_FuncGeral.StatusBtn(this, 1);
            obj_FuncGeral.HabilitaTela(this, false);
        }

        /**********************************************************************************
                  Nome : PopulaLista
            Dt. Criação: 29/02/2024
              Descrição: Preencher o ListBox com os dados que estão na Tabela (TB_USUARIO).
          Dt. Alteração: --/--/---- 
             Observação: --
             Criado Por: mFacine
        ***********************************************************************************/
        private void PopulaLista()
        {
            //Instância da classe BD
            CategoriaBD obj_CategoriaBD = new CategoriaBD();

            //Instância da Lista de Objetos
            List<Categoria> Lista = new List<Categoria>();

            //Limpeza do ListBox
            ltbox_Categorias.Items.Clear();

            //Lista recebe os usuários
            Lista = obj_CategoriaBD.FindAll();

            if (Lista != null)
            {
                for (int i = 0; i < Lista.Count; i++)
                {
                    ltbox_Categorias.Items.Add(Lista[i].Cod_Categoria.ToString() + "-" +
                                             Lista[i].Nm_Categoria.ToString());
                }
            }

        }

        /**********************************************************************************
                  Nome : PopulaTela
            Dt. Criação: 29/02/2024
              Descrição: Preencher a Tela com os dados do Objeto Atual.
          Dt. Alteração: --/--/---- 
             Observação: --
             Criado Por: mFacine
        ***********************************************************************************/
        private void PopulaTela(Categoria pobj_Categoria)
        {
            if (pobj_Categoria.Cod_Categoria != -1)
            {
                tbox_Cod_Categoria.Text = pobj_Categoria.Cod_Categoria.ToString();
                tbox_Nm_Categoria.Text = pobj_Categoria.Nm_Categoria.ToString();

            }
        }

        /**********************************************************************************
                  Nome : PopulaObjeto
            Dt. Criação: 29/02/2024
              Descrição: Preencher o Objeto Atual com os dados da Tela.
          Dt. Alteração: --/--/---- 
             Observação: --
             Criado Por: mFacine
        ***********************************************************************************/
        private Categoria PopulaObjeto()
        {
            Categoria obj_Categoria = new Categoria();

            if (tbox_Cod_Categoria.Text != "")
            {
                obj_Categoria.Cod_Categoria = Convert.ToInt16(tbox_Cod_Categoria.Text);
            }

            obj_Categoria.Nm_Categoria = tbox_Nm_Categoria.Text;

            return obj_Categoria;
        }



        private void btn_Novo_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, true);
            obj_FuncGeral.LimpaTela(this);
            obj_FuncGeral.StatusBtn(this, 3);
            tbox_Nm_Categoria.Focus();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, false);

            if (obj_Categoria_Atual.Cod_Categoria != -1)
            {
                PopulaTela(obj_Categoria_Atual);
                obj_FuncGeral.StatusBtn(this, 2);
            }
            else
            {
                obj_FuncGeral.StatusBtn(this, 1);
                obj_FuncGeral.LimpaTela(this);
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            CategoriaBD obj_CategoriaBD = new CategoriaBD();
            DialogResult v_Resp = MessageBox.Show("Confirma a exclusão da Família " + obj_Categoria_Atual.Nm_Categoria + "?", "Excluir Família", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (v_Resp == DialogResult.Yes)
            {
                if (obj_CategoriaBD.Excluir(obj_Categoria_Atual))
                {
                    MessageBox.Show("Exclusão da Família " + obj_Categoria_Atual.Nm_Categoria + " realizada com sucesso", "Excluir Família", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                obj_FuncGeral.LimpaTela(this);
                obj_FuncGeral.HabilitaTela(this, false);
                obj_FuncGeral.StatusBtn(this, 1);
                PopulaLista();

            }
        }

        private void ltbox_Categorias_Click(object sender, EventArgs e)
        {
            if (ltbox_Categorias.SelectedIndex != -1)
            {
                CategoriaBD obj_CategoriaBD = new CategoriaBD();
                string s_Linha = ltbox_Categorias.Items[ltbox_Categorias.SelectedIndex].ToString();

                int i_pos = 0;
                for (int i = 0; i < s_Linha.Length; i++)
                {
                    if (s_Linha.Substring(i, 1) == "-")
                    {
                        i_pos = i;
                        break;
                    }
                }

                obj_Categoria_Atual.Cod_Categoria = Convert.ToInt16(s_Linha.Substring(0, i_pos));

                obj_Categoria_Atual = obj_CategoriaBD.FindByCod(obj_Categoria_Atual);
                PopulaTela(obj_Categoria_Atual);
                obj_FuncGeral.StatusBtn(this, 2);




            }
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, true);
            obj_FuncGeral.StatusBtn(this, 3);
            tbox_Nm_Categoria.Focus();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            CategoriaBD obj_CategoriaBD = new CategoriaBD();

            obj_Categoria_Atual = PopulaObjeto();

            if (obj_Categoria_Atual.Cod_Categoria != -1)
            {
                if (obj_CategoriaBD.Alterar(obj_Categoria_Atual))
                {
                    MessageBox.Show("Família " + obj_Categoria_Atual.Nm_Categoria + " foi atualizado com sucesso.", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                obj_Categoria_Atual.Cod_Categoria = obj_CategoriaBD.Incluir(obj_Categoria_Atual);
                PopulaTela(obj_Categoria_Atual);
                MessageBox.Show("Família " + obj_Categoria_Atual.Nm_Categoria +
                    " foi incluido com sucesso.", "Inclusão",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            PopulaLista();
            obj_FuncGeral.HabilitaTela(this, false);
            obj_FuncGeral.StatusBtn(this, 2);
        }

    }
}
