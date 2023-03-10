using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class FormAdicionarUsuario : Form
    {
        public FormAdicionarUsuario()
        {
            InitializeComponent();
        }

        private void buttonAddUsuario_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario usuario = new Usuario();
            usuario.Nome = nomeTextBox.Text;
            usuario.NomeUsuario = nomeUsuarioTextBox.Text;
            usuario.CPF = cPFTextBox.Text;
            usuario.Email = emailTextBox.Text;
            usuario.Senha = senhaTextBox.Text;
            usuario.Ativo = ativoCheckBox.Checked;

            usuarioBLL.Inserir(usuario);
            Close();
        }
    }
}
