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
    public partial class frm_Principal : Form
    {
        public Usuario obj_Usuario_Logon = new Usuario();

        public frm_Principal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void tim_Principal_Tick(object sender, EventArgs e)
        {
            tsslb_Data.Text = DateTime.Now.ToString("dd/MM/yyyy");
            tsslb_Hora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Usuario obj_frm_Usuario = new frm_Usuario();
            obj_frm_Usuario.ShowDialog();
        }

        private void tarefaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Tarefa obj_frm_Tarefa = new frm_Tarefa();
            obj_frm_Tarefa.ShowDialog();
        }

        private void famíliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Familia obj_frm_Familia = new frm_Familia();
            obj_frm_Familia.ShowDialog();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Categoria obj_frm_Categoria = new frm_Categoria();
            obj_frm_Categoria.ShowDialog();
        }

        private void insumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Insumo obj_frm_Insumo = new frm_Insumo();
            obj_frm_Insumo.ShowDialog();
        }

        private void frm_Principal_Shown(object sender, EventArgs e)
        {
            tsslb_Usuario.Text = obj_Usuario_Logon.Nm_Usuario;
        }
    }
}
