using BLL;
using Models;
using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class FormBuscarUsuario : Form
    {
        public FormBuscarUsuario()
        {
            InitializeComponent();
        }

        private void buttonbuscar_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            if (radioButton3Todos.Checked)
            {
                usuarioBindingSource.DataSource = usuarioBLL.BuscarTodos();
            }
            else if (radioButton1PorNome.Checked)
            {
                if (textBox1.Text != "")
                {
                    usuarioBindingSource.DataSource = usuarioBLL.BuscarUsuarioPorNome(textBox1.Text);
                }
                else
                {
                    MessageBox.Show("Favor inserir um nome");
                }
            }
            else if (radioButton2PorID.Checked)
            {
                if (textBox1.Text != "")
                {
                    usuarioBindingSource.DataSource = usuarioBLL.BuscarPorId(Convert.ToInt32(textBox1.Text));
                    //usuarioBindingSource.DataSource = usuarioBLL.BuscarPorId(textBox1.Text);
                }
                else
                {
                    MessageBox.Show("Favor inserir um ID");
                }
            }
            /* if (textBox1.Text == "")
             {
                 usuarioBindingSource.DataSource = usuarioBLL.BuscarTodos(); 
             }
             //else if (textBox1.Text == "")
             //{
             //    usuarioBindingSource.DataSource = usuarioBLL.BuscarPorId(textBox1.Text);
             //}
             else
             {
                 usuarioBindingSource.DataSource = usuarioBLL.BuscarUsuarioPorNome(textBox1.Text);
             }*/
        }

        private void buttonAdicionarUsuario_Click(object sender, EventArgs e)
        {
            using (FormAdicionarUsuario frm = new FormAdicionarUsuario())
            {
                frm.ShowDialog();
            }

        }

        private void buttonAdicionarGrupo_Click(object sender, EventArgs e)
        {
            using (FormConsultarGrupoUsuario frm = new FormConsultarGrupoUsuario())
            {
                frm.ShowDialog();
                UsuarioBLL usuarioBLL = new UsuarioBLL();
                int idUsuario = ((Usuario)usuarioBindingSource.Current).IDUsuario;
                usuarioBLL.AdicionarGrupo(idUsuario, frm.Id);
            }
        }

        private void buttonAlterarUsuario_Click(object sender, EventArgs e)
        {
            int id = ((Usuario)usuarioBindingSource.Current).IDUsuario;//pegar o id do registro atual

            using (FormAdicionarUsuario frm = new FormAdicionarUsuario(true, id))
            {
                frm.ShowDialog();
            }
            buttonbuscar_Click(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                UsuarioBLL usuarioBLL = new UsuarioBLL();
                usuarioBindingSource.DataSource = usuarioBLL.BuscarUsuarioPorNome(textBox1.Text);

            }
            catch (Exception ex)
            {
                if (ex.Message != "Informe o nome do usuário.")
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void buttonExcluirUsuario_Click(object sender, EventArgs e)
        {
            if(usuarioBindingSource.Count <= 0)
            {
                MessageBox.Show("Não existe registro para ser excluído.");
                return;
            }
            if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = ((Usuario)usuarioBindingSource.Current).IDUsuario;
            new UsuarioBLL().Excluir(id);

            MessageBox.Show("Registro excluído com sucesso!");
            buttonbuscar_Click(null, null);
        }
    }
}
