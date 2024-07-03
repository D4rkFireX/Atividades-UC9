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
    public partial class frm_Familia : Form
    {
        FuncGeral obj_FuncGeral = new FuncGeral();
        public Familia obj_Familia_Atual = new Familia();


        public frm_Familia()
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
            FamiliaBD obj_FamiliaBD = new FamiliaBD();

            //Instância da Lista de Objetos
            List<Familia> Lista = new List<Familia>();

            //Limpeza do ListBox
            ltbox_Familias.Items.Clear();

            //Lista recebe os usuários
            Lista = obj_FamiliaBD.FindAll();

            if (Lista != null)
            {
                for (int i = 0; i < Lista.Count; i++)
                {
                    ltbox_Familias.Items.Add(Lista[i].Cod_Familia.ToString() + "-" +
                                             Lista[i].Nm_Familia.ToString());
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
        private void PopulaTela(Familia pobj_Familia)
        {
            if (pobj_Familia.Cod_Familia != -1)
            {
                tbox_Cod_Familia.Text = pobj_Familia.Cod_Familia.ToString();
                tbox_Nm_Familia.Text = pobj_Familia.Nm_Familia.ToString();
                
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
        private Familia PopulaObjeto()
        {
            Familia obj_Familia = new Familia();

            if (tbox_Cod_Familia.Text != "")
            {
                obj_Familia.Cod_Familia = Convert.ToInt16(tbox_Cod_Familia.Text);
            }

            obj_Familia.Nm_Familia = tbox_Nm_Familia.Text;

            return obj_Familia;
        }



        private void btn_Novo_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, true);
            obj_FuncGeral.LimpaTela(this);
            obj_FuncGeral.StatusBtn(this, 3);
            tbox_Nm_Familia.Focus();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, false);

            if (obj_Familia_Atual.Cod_Familia != -1)
            {
                PopulaTela(obj_Familia_Atual);
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
            FamiliaBD obj_FamiliaBD = new FamiliaBD();
            DialogResult v_Resp = MessageBox.Show("Confirma a exclusão da Família " + obj_Familia_Atual.Nm_Familia + "?", "Excluir Família", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (v_Resp == DialogResult.Yes)
            {
                if (obj_FamiliaBD.Excluir(obj_Familia_Atual))
                {
                    MessageBox.Show("Exclusão da Família " + obj_Familia_Atual.Nm_Familia + " realizada com sucesso", "Excluir Família", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                obj_FuncGeral.LimpaTela(this);
                obj_FuncGeral.HabilitaTela(this, false);
                obj_FuncGeral.StatusBtn(this, 1);
                PopulaLista();

            }
        }

        private void ltbox_Familias_Click(object sender, EventArgs e)
        {
            if (ltbox_Familias.SelectedIndex != -1)
            {
                FamiliaBD obj_FamiliaBD = new FamiliaBD();
                string s_Linha = ltbox_Familias.Items[ltbox_Familias.SelectedIndex].ToString();

                int i_pos = 0;
                for (int i = 0; i < s_Linha.Length; i++)
                {
                    if (s_Linha.Substring(i, 1) == "-")
                    {
                        i_pos = i;
                        break;
                    }
                }

                obj_Familia_Atual.Cod_Familia = Convert.ToInt16(s_Linha.Substring(0, i_pos));

                obj_Familia_Atual = obj_FamiliaBD.FindByCod(obj_Familia_Atual);
                PopulaTela(obj_Familia_Atual);
                obj_FuncGeral.StatusBtn(this, 2);




            }
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, true);
            obj_FuncGeral.StatusBtn(this, 3);
            tbox_Nm_Familia.Focus();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            FamiliaBD obj_FamiliaBD = new FamiliaBD();

            obj_Familia_Atual = PopulaObjeto();

            if (obj_Familia_Atual.Cod_Familia != -1)
            {
                if (obj_FamiliaBD.Alterar(obj_Familia_Atual))
                {
                    MessageBox.Show("Família " + obj_Familia_Atual.Nm_Familia + " foi atualizado com sucesso.", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                obj_Familia_Atual.Cod_Familia = obj_FamiliaBD.Incluir(obj_Familia_Atual);
                PopulaTela(obj_Familia_Atual);
                MessageBox.Show("Família " + obj_Familia_Atual.Nm_Familia +
                    " foi incluido com sucesso.", "Inclusão",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            PopulaLista();
            obj_FuncGeral.HabilitaTela(this, false);
            obj_FuncGeral.StatusBtn(this, 2);
        }

    }
}
