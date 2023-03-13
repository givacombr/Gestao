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
            if (textBox1.Text == "")
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
            }
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
            using (FormAdicionarGrupoUsuario frm = new FormAdicionarGrupoUsuario())
            {
                frm.ShowDialog();
            }
        }

        private void buttonAlterarUsuario_Click(object sender, EventArgs e)
        {
            using(FormAlterarUsuario frm = new FormAlterarUsuario())
            {
                frm.ShowDialog();
            }
        }
    }
}
