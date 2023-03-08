using BLL;
using System;
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
                usuarioBindingSource.DataSource = usuarioBLL.BuscarTodos();
            else
                usuarioBindingSource.DataSource = usuarioBLL.BuscarUsuarioPorNome(textBox1.Text);
        }
    }
}
