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
    public partial class frm_Login : Form
    {
        FuncGeral obj_FuncGeral = new FuncGeral();

        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (tbox_UNm_Usuario.Text != "" && tbox_PW_Usuario.Text != "")
            {
                Usuario obj_Usuario_Login = new Usuario();
                UsuarioBD obj_UsuarioBD = new UsuarioBD();

                obj_Usuario_Login.UNm_Usuario = tbox_UNm_Usuario.Text;

                obj_Usuario_Login = obj_UsuarioBD.FindByUNm(obj_Usuario_Login);

                if (obj_Usuario_Login.Cod_Usuario != -1)
                {
                    if (tbox_PW_Usuario.Text == obj_FuncGeral.Descriptografa(obj_Usuario_Login.PW_Usuario))
                    {
                        frm_Principal obj_frm_Principal = new frm_Principal();
                        obj_frm_Principal.obj_Usuario_Logon = obj_Usuario_Login;
                        obj_frm_Principal.ShowDialog();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta!", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbox_PW_Usuario.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado!","LOGIN",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    tbox_UNm_Usuario.Focus();
                }

            }
        }

        private void pbox_Olho_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void pbox_Olho_MouseHover(object sender, EventArgs e)
        {
            pbox_Olho.Image = Properties.Resources.img_OlhoOn;
            tbox_PW_Usuario.PasswordChar = '\u0000';
        }

        private void pbox_Olho_MouseLeave(object sender, EventArgs e)
        {
            pbox_Olho.Image = Properties.Resources.img_OlhoOff;
            tbox_PW_Usuario.PasswordChar = '*';
        }
    }
}
