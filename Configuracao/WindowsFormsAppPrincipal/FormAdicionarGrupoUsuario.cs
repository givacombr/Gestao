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
    public partial class FormAdicionarGrupoUsuario : Form
    {
        public FormAdicionarGrupoUsuario()
        {
            InitializeComponent();
        }

        private void buttonAddGrupo_Click(object sender, EventArgs e)
        {
            GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
            GrupoUsuario _grupoUsuario = new GrupoUsuario();
            _grupoUsuario.NomeGrupo = nomeGrupoTextBox.Text;

            grupoUsuarioBLL.Inserir(_grupoUsuario);
            Close();
        }
    }
}
