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
            try
            {
                usuarioBindingSource.EndEdit();
                usuarioBLL.Inserir((Usuario)usuarioBindingSource.Current, confirmacaoTextBox.Text);
                MessageBox.Show("Cadastrado com sucesso!");
                LimparCampos();
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            /*Usuario usuario = new Usuario();*/
            //usuario.Nome = nomeTextBox.Text;
            //usuario.NomeUsuario = nomeUsuarioTextBox.Text;
            //usuario.CPF = cPFTextBox.Text;
            //usuario.Email = emailTextBox.Text;
            //usuario.Senha = senhaTextBox.Text;
            //usuario.Ativo = ativoCheckBox.Checked;


            //usuarioBLL.Inserir(usuario);
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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormAdicionarUsuario_Load(object sender, EventArgs e)
        {
            usuarioBindingSource.AddNew();//estado de inserção de um registro
        }
    }
}
