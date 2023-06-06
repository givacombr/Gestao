using Models;
using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class FormPrincipal : Form
    {
        public int Id;
        public FormPrincipal()
        {
            InitializeComponent();
            Constantes.IdUsuarioLogado = Id;
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
