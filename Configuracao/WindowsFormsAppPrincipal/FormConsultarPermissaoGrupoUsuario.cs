using BLL;
using Models;
using System;
using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class FormConsultarPermissaoGrupoUsuario : Form
    {
        public int Id;
        private bool alterar;
        public FormConsultarPermissaoGrupoUsuario(bool _alterar = false, int _id = 0)
        {
            InitializeComponent();
            alterar = _alterar;
        }

        private void buttonBuscarPermissao_Click(object sender, EventArgs e)
        {
            PermissaoBLL permissaoBLL = new PermissaoBLL();
            try
            {
                permissaoBindingSource.DataSource = permissaoBLL.BuscarPermissaoPorNome(textBoxPermissao.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonSelecionarPermissao_Click(object sender, EventArgs e)
        {
            try
            {
                if (permissaoBindingSource.Count > 0)
                {
                    Id = ((Permissao)permissaoBindingSource.Current).IdDescricao;
                    Close();
                }
                else
                    MessageBox.Show("Não existe uma permissão de grupo para ser selecionada!");
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}
        private void buttonCancelarPermissao_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
