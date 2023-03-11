using BLL;
using Models;
using System;
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

            LimparCampos();

            usuarioBLL.Inserir(usuario);
            MessageBox.Show("Cadastrado com sucesso!");
        }

        private void LimparCampos()
        {
            nomeTextBox.Text = "";
            nomeUsuarioTextBox.Text = "";
            cPFTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            senhaTextBox.Text = string.Empty;
            ativoCheckBox.Checked = true;
        }
    }
}
