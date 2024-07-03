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
    public partial class frm_Tarefa : Form
    {
        FuncGeral obj_FuncGeral = new FuncGeral();
        Tarefa obj_Tarefa_Atual = new Tarefa();


        public frm_Tarefa()
        {
            InitializeComponent();
            PopulaLista();
            PopulaTitulo();
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
            TarefaBD obj_TarefaBD = new TarefaBD();

            //Instância da Lista de Objetos
            List<Tarefa> Lista = new List<Tarefa>();

            //Limpeza do ListBox
            ltbox_Tarefas.Items.Clear();

            //Lista recebe os usuários
            Lista = obj_TarefaBD.FindAll();

            if (Lista != null)
            {
                for (int i = 0; i < Lista.Count; i++)
                {
                    ltbox_Tarefas.Items.Add(Lista[i].Cod_Tarefa.ToString() + "-" +
                                             Lista[i].Tit_Tarefa.ToString());
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
        private void PopulaTela(Tarefa pobj_Tarefa)
        {
            EventArgs e = new EventArgs();

            Item obj_Item = new Item();
            ItemBD obj_ItemBD = new ItemBD();

            Insumo obj_Insumo = new Insumo();
            InsumoBD obj_InsumoBD = new InsumoBD();

            List<Item> ListaItens = new List<Item>();   


            obj_Item.Cod_Tarefa = obj_Tarefa_Atual.Cod_Tarefa;
            ListaItens = obj_ItemBD.FindByCodTarefa(obj_Item);

            if (ListaItens.Count != 0)
            {
                for (int i = 0; i < ListaItens.Count; i++)
                {
                    obj_Insumo.Cod_Insumo = ListaItens[i].Cod_Insumo;
                    obj_Insumo = obj_InsumoBD.FindByCod(obj_Insumo);

                    PopulaLinhaItem(lv_Itens, obj_Insumo.Cod_Insumo.ToString(),
                     obj_Insumo.Nm_Insumo, ListaItens[i].Qtde_Item.ToString());
                }
            }

            if (pobj_Tarefa.Cod_Tarefa != -1)
            {
                tbox_Cod_Tarefa.Text = pobj_Tarefa.Cod_Tarefa.ToString();
                tbox_Cod_Usuario.Text = pobj_Tarefa.Cod_Usuario.ToString();
                tbox_Cod_Usuario_Leave(tbox_Cod_Usuario, e);

                tbox_Cod_Categoria.Text = pobj_Tarefa.Cod_Categoria.ToString();
                tbox_Cod_Categoria_Leave(tbox_Cod_Categoria, e);

                tbox_Tit_Tarefa.Text = pobj_Tarefa.Tit_Tarefa.ToString();
                tbox_Desc_Tarefa.Text = pobj_Tarefa.Desc_Tarefa.ToString();
                tbox_Term_Tarefa.Text = pobj_Tarefa.Term_Tarefa.ToString("dd/MM/yyyy");
                
                cbox_Stat_Tarefa.SelectedIndex = pobj_Tarefa.Stat_Tarefa;
                cbox_Prior_Tarefa.SelectedIndex = pobj_Tarefa.Prior_Tarefa;

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
        private Tarefa PopulaObjeto()
        {
            Tarefa obj_Tarefa = new Tarefa();

            if (tbox_Cod_Tarefa.Text != "")
            {
                obj_Tarefa.Cod_Tarefa = Convert.ToInt16(tbox_Cod_Tarefa.Text);
            }

            obj_Tarefa.Cod_Usuario = Convert.ToInt16(tbox_Cod_Usuario.Text);
            obj_Tarefa.Cod_Categoria = Convert.ToInt16(tbox_Cod_Categoria.Text);
            obj_Tarefa.Tit_Tarefa = tbox_Tit_Tarefa.Text;
            obj_Tarefa.Desc_Tarefa = tbox_Desc_Tarefa.Text;
            obj_Tarefa.Term_Tarefa = Convert.ToDateTime(tbox_Term_Tarefa.Text);
            obj_Tarefa.Stat_Tarefa = cbox_Stat_Tarefa.SelectedIndex;
            obj_Tarefa.Prior_Tarefa = cbox_Prior_Tarefa.SelectedIndex;

            return obj_Tarefa;
        }

        /**********************************************************************************
                  Nome : PopulaLinhaItem
            Dt. Criação: 21/03/2024
              Descrição: Preencher os Itens na Tela.
          Dt. Alteração: --/--/---- 
             Observação: --
             Criado Por: mFacine
        ***********************************************************************************/
        private void PopulaLinhaItem(ListView plv_Lista, string p_CodInsumo, string p_NmInsumo, string p_QtdInsumo)
        {
            ListViewItem LinhaItem = new ListViewItem(new[]
                                            { p_CodInsumo, p_NmInsumo, p_QtdInsumo });
            plv_Lista.Items.Add(LinhaItem);
        }


        private bool AtualizaItens()
        {
            bool b_Valida = false;
            try
            {
                //Exclusão dos filhos
                Item obj_Item = new Item();
                ItemBD obj_ItemBD = new ItemBD();
                obj_Item.Cod_Tarefa = obj_Tarefa_Atual.Cod_Tarefa;
                obj_ItemBD.ExcluirByCodTarefa(obj_Item);
                //Criação dos filhos
                for (int i = 0; i < lv_Itens.Items.Count; i++)
                {
                    obj_Item.Cod_Tarefa = Convert.ToInt16(obj_Tarefa_Atual.Cod_Tarefa);
                    obj_Item.Cod_Insumo = Convert.ToInt16(lv_Itens.Items[i].SubItems[0].Text);
                    obj_Item.Qtde_Item = Convert.ToInt16(lv_Itens.Items[i].SubItems[2].Text);
                    int i_Cod = obj_ItemBD.Incluir(obj_Item);
                }
                b_Valida = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Atualizar os Itens: " + ex.Message, "Erro",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            return b_Valida;
        }

        /**********************************************************************************
                  Nome : PopulaTitulo
            Dt. Criação: 22/03/2024
              Descrição: Preencher os titulos do ListView na Tela.
          Dt. Alteração: --/--/---- 
             Observação: --
             Criado Por: mFacine
        ***********************************************************************************/
        private void PopulaTitulo()
        {
            lv_Itens.View = View.Details;
            lv_Itens.Columns.Add("Cod. Insumo", 85);
            lv_Itens.Columns.Add("Nome Insumo", 275);
            lv_Itens.Columns.Add("Qtde.", 70);
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, true);
            obj_FuncGeral.LimpaTela(this);
            obj_FuncGeral.StatusBtn(this, 3);
            tbox_Cod_Usuario.Focus();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, false);

            if (obj_Tarefa_Atual.Cod_Tarefa != -1)
            {
                PopulaTela(obj_Tarefa_Atual);
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
            TarefaBD obj_TarefaBD = new TarefaBD();

            DialogResult v_Resp = MessageBox.Show("Confirma a exclusão do Tarefa " + obj_Tarefa_Atual.Tit_Tarefa + "?", "Excluir Tarefa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (v_Resp == DialogResult.Yes)
            {


                //Exclusão do Pai
                if (obj_TarefaBD.Excluir(obj_Tarefa_Atual))
                {
                    //Exclusão dos filhos
                    Item obj_Item = new Item();
                    ItemBD obj_ItemBD = new ItemBD();
                    obj_Item.Cod_Tarefa = obj_Tarefa_Atual.Cod_Tarefa;
                    obj_ItemBD.ExcluirByCodTarefa(obj_Item);
                    MessageBox.Show("Exclusão do Tarefa " + obj_Tarefa_Atual.Tit_Tarefa + " realizada com sucesso.", "Excluir Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                obj_FuncGeral.LimpaTela(this);
                obj_FuncGeral.HabilitaTela(this, false);
                obj_FuncGeral.StatusBtn(this, 1);
                PopulaLista();

            }
        }

        private void ltbox_Tarefas_Click(object sender, EventArgs e)
        {
            if (ltbox_Tarefas.SelectedIndex != -1)
            {
                TarefaBD obj_TarefaBD = new TarefaBD();
                string s_Linha = ltbox_Tarefas.Items[ltbox_Tarefas.SelectedIndex].ToString();

                int i_pos = 0;
                for (int i = 0; i < s_Linha.Length; i++)
                {
                    if (s_Linha.Substring(i, 1) == "-")
                    {
                        i_pos = i;
                        break;
                    }
                }

                obj_Tarefa_Atual.Cod_Tarefa = Convert.ToInt16(s_Linha.Substring(0, i_pos));

                obj_Tarefa_Atual = obj_TarefaBD.FindByCod(obj_Tarefa_Atual);
                PopulaTela(obj_Tarefa_Atual);
                obj_FuncGeral.StatusBtn(this, 2);

            }
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, true);
            obj_FuncGeral.StatusBtn(this, 3);
            tbox_Cod_Usuario.Focus();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            TarefaBD obj_TarefaBD = new TarefaBD();

            obj_Tarefa_Atual = PopulaObjeto();

            if (obj_Tarefa_Atual.Cod_Tarefa != -1)
            {
                if (obj_TarefaBD.Alterar(obj_Tarefa_Atual))
                {
                    AtualizaItens();
                    MessageBox.Show("Tarefa " + obj_Tarefa_Atual.Tit_Tarefa + " foi atualizado com sucesso.", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                obj_Tarefa_Atual.Cod_Tarefa = obj_TarefaBD.Incluir(obj_Tarefa_Atual);
                AtualizaItens();
                PopulaTela(obj_Tarefa_Atual);
                MessageBox.Show("Tarefa " + obj_Tarefa_Atual.Tit_Tarefa +
                    " foi incluido com sucesso.", "Inclusão",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            PopulaLista();
            obj_FuncGeral.HabilitaTela(this, false);
            obj_FuncGeral.StatusBtn(this, 2);
        }

        private void btn_Usuario_Click(object sender, EventArgs e)
        {
            frm_Usuario obj_frm_Usuario = new frm_Usuario();
            obj_frm_Usuario.ShowDialog();

            int i_Cod_Usuario = obj_frm_Usuario.obj_Usuario_Atual.Cod_Usuario;

            if (i_Cod_Usuario != -1)
            {
                tbox_Cod_Usuario.Text = i_Cod_Usuario.ToString();
                tbox_Cod_Usuario_Leave(tbox_Cod_Usuario, e);
            }
        }

        private void tbox_Cod_Usuario_Leave(object sender, EventArgs e)
        {
            if (tbox_Cod_Usuario.Text != "")
            {
                if (obj_FuncGeral.ValidaTipo(typeof(Int16), tbox_Cod_Usuario.Text))
                {
                    Usuario obj_Usuario = new Usuario();
                    UsuarioBD obj_UsuarioBD = new UsuarioBD();

                    obj_Usuario.Cod_Usuario = Convert.ToInt16(tbox_Cod_Usuario.Text);
                    obj_Usuario = obj_UsuarioBD.FindByCod(obj_Usuario);

                    if (obj_Usuario.Cod_Usuario != -1)
                    {
                        lb_Nm_Usuario.Text = obj_Usuario.Nm_Usuario;
                    }
                }
                else
                {
                    obj_FuncGeral.ShowAlert(tbox_Cod_Usuario);
                }
            }
        }

        private void btn_Categoria_Click(object sender, EventArgs e)
        {
            frm_Categoria obj_frm_Categoria = new frm_Categoria();
            obj_frm_Categoria.ShowDialog();

            int i_Cod_Categoria = obj_frm_Categoria.obj_Categoria_Atual.Cod_Categoria;

            if (i_Cod_Categoria != -1)
            {
                tbox_Cod_Categoria.Text = i_Cod_Categoria.ToString();
                tbox_Cod_Categoria_Leave(tbox_Cod_Categoria, e);
            }
        }

        private void tbox_Cod_Categoria_Leave(object sender, EventArgs e)
        {

            if (tbox_Cod_Categoria.Text != "")
            {
                if (obj_FuncGeral.ValidaTipo(typeof(Int16), tbox_Cod_Categoria.Text))
                {
                    Categoria obj_Categoria = new Categoria();
                    CategoriaBD obj_CategoriaBD = new CategoriaBD();

                    obj_Categoria.Cod_Categoria = Convert.ToInt16(tbox_Cod_Categoria.Text);
                    obj_Categoria = obj_CategoriaBD.FindByCod(obj_Categoria);

                    if (obj_Categoria.Cod_Categoria != -1)
                    {
                        lb_Nm_Categoria.Text = obj_Categoria.Nm_Categoria;
                    }
                }
                else
                {
                    obj_FuncGeral.ShowAlert(tbox_Cod_Categoria);
                }
            }
        }

        private void btn_Insumo_Click(object sender, EventArgs e)
        {
            frm_Insumo obj_frm_Insumo = new frm_Insumo();
            obj_frm_Insumo.ShowDialog();

            int i_Cod_Insumo = obj_frm_Insumo.obj_Insumo_Atual.Cod_Insumo;

            if (i_Cod_Insumo != -1)
            {
                tbox_Cod_Insumo.Text = i_Cod_Insumo.ToString();
                tbox_Cod_Insumo_Leave(tbox_Cod_Insumo, e);
            }
        }

        private void tbox_Cod_Insumo_Leave(object sender, EventArgs e)
        {

            if (tbox_Cod_Insumo.Text != "")
            {
                if (obj_FuncGeral.ValidaTipo(typeof(Int16), tbox_Cod_Insumo.Text))
                {
                    Insumo obj_Insumo = new Insumo();
                    InsumoBD obj_InsumoBD = new InsumoBD();

                    obj_Insumo.Cod_Insumo = Convert.ToInt16(tbox_Cod_Insumo.Text);
                    obj_Insumo = obj_InsumoBD.FindByCod(obj_Insumo);

                    if (obj_Insumo.Cod_Insumo != -1)
                    {
                        lb_Nm_Insumo.Text = obj_Insumo.Nm_Insumo;
                    }
                }
                else
                {
                    obj_FuncGeral.ShowAlert(tbox_Cod_Insumo);
                }
            }
        }

        private void btn_Down_Click(object sender, EventArgs e)
        {
            if(tbox_Cod_Insumo.Text != "" && tbox_Qtde_Item.Text != "")
            {
                PopulaLinhaItem(lv_Itens, tbox_Cod_Insumo.Text, 
                                lb_Nm_Insumo.Text, tbox_Qtde_Item.Text);
                tbox_Cod_Insumo.Text = "";
                lb_Nm_Insumo.Text = "";
                tbox_Qtde_Item.Text = "";
                tbox_Cod_Insumo.Focus();
            }
        }

        private void btn_Up_Click(object sender, EventArgs e)
        {
            //Rever o True e o False
            if (lv_Itens.SelectedItems != null)
            {
                DialogResult v_Resp = MessageBox.Show("Confirma a retirada do insumo da Tarefa?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (v_Resp == DialogResult.Yes)
                {
                    for(int i = 0; i < lv_Itens.Items.Count; i++)
                    {
                        if (lv_Itens.Items[i].Selected)
                        {
                            tbox_Cod_Insumo.Text = lv_Itens.Items[i].SubItems[0].Text;
                            lb_Nm_Insumo.Text = lv_Itens.Items[i].SubItems[1].Text;
                            tbox_Qtde_Item.Text = lv_Itens.Items[i].SubItems[2].Text;
                            lv_Itens.Items[i].Remove();
                            i--;                            
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhum insumo foi selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
