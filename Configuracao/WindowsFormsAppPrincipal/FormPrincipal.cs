using Models;
using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            Constantes.IdUsuarioLogado = 11;
        }

        private void usuarioToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            using (FormBuscarUsuario frm = new FormBuscarUsuario())
            {
                frm.ShowDialog();
            }
        }
        private void gruposDeUsuáriosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            using (FormBuscarGrupoUsuario frm = new FormBuscarGrupoUsuario()) 
            {
                frm.ShowDialog();
            }
        }

        private void permissõesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            using (FormConsultarPermissaoGrupoUsuario frm = new FormConsultarPermissaoGrupoUsuario())
            {
                frm.ShowDialog();
            }
        }
    }
}
