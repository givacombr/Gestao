using BLL;
using Models;
using System;
using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class FormAdicionarUsuario : Form
    {
        private bool alterar;
        public FormAdicionarUsuario(bool _alterar = false, int _idUsuario = 0)
        {
            InitializeComponent();
            alterar = _alterar;

            if (alterar)
            {
                //UsuarioBLL usuarioBLL = new UsuarioBLL(); //é útil para usar em vários lugares.
                usuarioBindingSource.DataSource = new UsuarioBLL().BuscarPorId(_idUsuario);
            }
        }

        private void buttonAddUsuario_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            try
            {
                usuarioBindingSource.EndEdit();

                if (!alterar)
                    usuarioBLL.Inserir((Usuario)usuarioBindingSource.Current, confirmacaoTextBox.Text);
                else
                    usuarioBLL.Alterar((Usuario)usuarioBindingSource.Current, confirmacaoTextBox.Text);

                MessageBox.Show("Cadastrado com sucesso!");
                LimparCampos();
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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
            if (!alterar)
                usuarioBindingSource.AddNew();//estado de inserção de um registro
        }
    }
}
