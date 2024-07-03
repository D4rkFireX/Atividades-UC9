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
    public partial class frm_Insumo : Form
    {
        FuncGeral obj_FuncGeral = new FuncGeral();
        public Insumo obj_Insumo_Atual = new Insumo();


        public frm_Insumo()
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
            InsumoBD obj_InsumoBD = new InsumoBD();

            //Instância da Lista de Objetos
            List<Insumo> Lista = new List<Insumo>();

            //Limpeza do ListBox
            ltbox_Insumos.Items.Clear();

            //Lista recebe os usuários
            Lista = obj_InsumoBD.FindAll();

            if (Lista != null)
            {
                for (int i = 0; i < Lista.Count; i++)
                {
                    ltbox_Insumos.Items.Add(Lista[i].Cod_Insumo.ToString() + "-" +
                                             Lista[i].Nm_Insumo.ToString());
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
        private void PopulaTela(Insumo pobj_Insumo)
        {
            EventArgs e = new EventArgs();

            if (pobj_Insumo.Cod_Insumo != -1)
            {
                tbox_Cod_Insumo.Text = pobj_Insumo.Cod_Insumo.ToString();
                tbox_Nm_Insumo.Text = pobj_Insumo.Nm_Insumo.ToString();
                tbox_Cod_Familia.Text = pobj_Insumo.Cod_Familia.ToString();
                tbox_Cod_Familia_Leave(tbox_Cod_Familia, e);
                chBox_Frac_Insumo.Checked = pobj_Insumo.Frac_Insumo;
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
        private Insumo PopulaObjeto()
        {
            Insumo obj_Insumo = new Insumo();

            if (tbox_Cod_Insumo.Text != "")
            {
                obj_Insumo.Cod_Insumo = Convert.ToInt16(tbox_Cod_Insumo.Text);
            }

            obj_Insumo.Nm_Insumo = tbox_Nm_Insumo.Text;
            obj_Insumo.Cod_Familia = Convert.ToInt16(tbox_Cod_Familia.Text);
            obj_Insumo.Frac_Insumo = chBox_Frac_Insumo.Checked ? true : false;


            return obj_Insumo;
        }



        private void btn_Novo_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, true);
            obj_FuncGeral.LimpaTela(this);
            obj_FuncGeral.StatusBtn(this, 3);
            tbox_Nm_Insumo.Focus();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, false);

            if (obj_Insumo_Atual.Cod_Insumo != -1)
            {
                PopulaTela(obj_Insumo_Atual);
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
            InsumoBD obj_InsumoBD = new InsumoBD();
            DialogResult v_Resp = MessageBox.Show("Confirma a exclusão do Insumo " + obj_Insumo_Atual.Nm_Insumo + "?", "Excluir Insumo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (v_Resp == DialogResult.Yes)
            {
                if (obj_InsumoBD.Excluir(obj_Insumo_Atual))
                {
                    MessageBox.Show("Exclusão do Insumo " + obj_Insumo_Atual.Nm_Insumo + " realizada com sucesso.", "Excluir Insumo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                obj_FuncGeral.LimpaTela(this);
                obj_FuncGeral.HabilitaTela(this, false);
                obj_FuncGeral.StatusBtn(this, 1);
                PopulaLista();

            }
        }

        private void ltbox_Insumos_Click(object sender, EventArgs e)
        {
            if (ltbox_Insumos.SelectedIndex != -1)
            {
                InsumoBD obj_InsumoBD = new InsumoBD();
                string s_Linha = ltbox_Insumos.Items[ltbox_Insumos.SelectedIndex].ToString();

                int i_pos = 0;
                for (int i = 0; i < s_Linha.Length; i++)
                {
                    if (s_Linha.Substring(i, 1) == "-")
                    {
                        i_pos = i;
                        break;
                    }
                }

                obj_Insumo_Atual.Cod_Insumo = Convert.ToInt16(s_Linha.Substring(0, i_pos));

                obj_Insumo_Atual = obj_InsumoBD.FindByCod(obj_Insumo_Atual);
                PopulaTela(obj_Insumo_Atual);
                obj_FuncGeral.StatusBtn(this, 2);




            }
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, true);
            obj_FuncGeral.StatusBtn(this, 3);
            tbox_Nm_Insumo.Focus();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            InsumoBD obj_InsumoBD = new InsumoBD();

            obj_Insumo_Atual = PopulaObjeto();

            if (obj_Insumo_Atual.Cod_Insumo != -1)
            {
                if (obj_InsumoBD.Alterar(obj_Insumo_Atual))
                {
                    MessageBox.Show("Insumo " + obj_Insumo_Atual.Nm_Insumo + " foi atualizado com sucesso.", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                obj_Insumo_Atual.Cod_Insumo = obj_InsumoBD.Incluir(obj_Insumo_Atual);
                PopulaTela(obj_Insumo_Atual);
                MessageBox.Show("Insumo " + obj_Insumo_Atual.Nm_Insumo +
                    " foi incluido com sucesso.", "Inclusão",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            PopulaLista();
            obj_FuncGeral.HabilitaTela(this, false);
            obj_FuncGeral.StatusBtn(this, 2);
        }

        private void btn_Familia_Click(object sender, EventArgs e)
        {
            frm_Familia obj_frm_Familia = new frm_Familia();
            obj_frm_Familia.ShowDialog();

            int i_Cod_Familia = obj_frm_Familia.obj_Familia_Atual.Cod_Familia;

            if (i_Cod_Familia != -1)
            {
                tbox_Cod_Familia.Text = i_Cod_Familia.ToString();
                tbox_Cod_Familia_Leave(tbox_Cod_Familia, e);
            }
            
            
            
        }

        private void tbox_Cod_Familia_Leave(object sender, EventArgs e)
        {
            
            if (tbox_Cod_Familia.Text != "")
            {
                if (obj_FuncGeral.ValidaTipo(typeof(Int16), tbox_Cod_Familia.Text))
                {
                    Familia obj_Familia = new Familia();
                    FamiliaBD obj_FamiliaBD = new FamiliaBD();

                    obj_Familia.Cod_Familia = Convert.ToInt16(tbox_Cod_Familia.Text);
                    obj_Familia = obj_FamiliaBD.FindByCod(obj_Familia);

                    if (obj_Familia.Cod_Familia != -1)
                    {
                        lb_Nm_Familia.Text = obj_Familia.Nm_Familia;    
                    }
                }
                else
                {
                    obj_FuncGeral.ShowAlert(tbox_Cod_Familia);
                }
            }
        }
    }
}
