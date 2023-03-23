using BLL;
using Models;
using System;
using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class FormBuscarGrupoUsuario : Form
    {
        public FormBuscarGrupoUsuario()
        {
            InitializeComponent();
        }
        private void buttonBuscarGrupoUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
                if (radioButton3ListarTodosGrupo.Checked)//Listar todos
                {
                    grupoUsuarioBindingSource.DataSource = grupoUsuarioBLL.BuscarTodosGrupos();
                }
                else if (radioButton1NomeGrupo.Checked)
                {
                    if (textBox2.Text != "")
                    {
                        grupoUsuarioBindingSource.DataSource = grupoUsuarioBLL.BuscarGrupoPorNome(textBox2.Text);
                    }
                    else
                    {
                        MessageBox.Show("Inserir um nome");
                    }
                }
                else if (radioButton2IDGrupo.Checked)
                {
                    if (textBox2.Text != "")
                    {
                        grupoUsuarioBindingSource.DataSource = grupoUsuarioBLL.BuscarPorId(Convert.ToInt32(textBox2.Text));
                    }
                    else
                    {
                        MessageBox.Show("Inserir o ID");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao vincular um grupo" + ex.Message);
            }
        }
        private void buttonAdicionarGrupo_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormAdicionarGrupo frm = new FormAdicionarGrupo())
                {
                    frm.ShowDialog();
                }
                buttonBuscarGrupoUsuario_Click(sender, e);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonAlterarGrupo_Click(object sender, EventArgs e)
        {
            try
            {
                if (grupoUsuarioBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser alterado.");
                    return;
                }
                int id = ((GrupoUsuario)grupoUsuarioBindingSource.Current).IdGrupoUsuario;//pegar o id do registro atual

                using (FormAdicionarGrupo frm = new FormAdicionarGrupo(true, id))
                {
                    frm.ShowDialog();
                }
                buttonBuscarGrupoUsuario_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
                grupoUsuarioBindingSource.DataSource = grupoUsuarioBLL.BuscarGrupoPorNome(textBox2.Text);
            }
            catch (Exception ex)
            {
                if (ex.Message != "Informe o nome do grupo.")
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (grupoUsuarioBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído.");
                    return;
                }
                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((GrupoUsuario)grupoUsuarioBindingSource.Current).IdGrupoUsuario;
                new GrupoUsuarioBLL().Excluir(id);
                grupoUsuarioBindingSource.RemoveCurrent();
            }
            catch (Exception)
            {
                MessageBox.Show("Registro excluído com sucesso!");
                buttonBuscarGrupoUsuario_Click(null, null);
            }
        }
        private void buttonAddDescricao_Click(object sender, EventArgs e)
        {
            using (FormConsultarPermissaoGrupoUsuario frm = new FormConsultarPermissaoGrupoUsuario())
            {
                try
                {
                    frm.ShowDialog();
                    if (frm.Id == 0)
                        return;
                    {
                        PermissaoBLL permissaoBLL = new PermissaoBLL();
                        int idGrupoUsuario = ((GrupoUsuario)grupoUsuarioBindingSource.Current).IdGrupoUsuario;
                        permissaoBLL.AdicionarPermissao(frm.Id, idGrupoUsuario);
                        MessageBox.Show("Permissão adicionado com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao vincular uma Permissão" + ex.Message);
                }
            }
            MessageBox.Show("Permissão adicionado com sucesso!");
            buttonBuscarGrupoUsuario_Click(null, null);
        }
        private void buttonExcluirDescricao_Click(object sender, EventArgs e)
        {
            try
            {
                if (grupoUsuarioBindingSource.Count == 0 || permissoesBindingSource.Count == 0)
                {
                    MessageBox.Show("Não existe descrição do grupo para ser excluído.");
                    return;
                }
                if (MessageBox.Show("Deseja realmente excluir esse registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int IDGrupoUsuario = ((GrupoUsuario)grupoUsuarioBindingSource.Current).IdGrupoUsuario;
                int IDDescricao = ((Permissao)permissoesBindingSource.Current).IdDescricao;
                new GrupoUsuarioBLL().RemoverDescricaoGrupo(IDGrupoUsuario, IDDescricao);
                permissoesBindingSource.RemoveCurrent();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao vincular uma Permissão" + ex.Message);
            }
            MessageBox.Show("Permissão adicionado com sucesso!");
            buttonBuscarGrupoUsuario_Click(null, null);
        }
    }
}