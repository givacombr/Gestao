using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsAppPrincipal
{
    public partial class FormBuscarGrupoUsuario : Form
    {
        public FormBuscarGrupoUsuario()
        {
            InitializeComponent();
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
            if (textBox1.Text == "")
                grupoUsuarioBindingSource.DataSource = grupoUsuarioBLL.BuscarTodosGrupos();
            else
                grupoUsuarioBindingSource.DataSource = grupoUsuarioBLL.BuscarPorId(Convert.ToInt32(textBox1.Text));
        }
    }
}