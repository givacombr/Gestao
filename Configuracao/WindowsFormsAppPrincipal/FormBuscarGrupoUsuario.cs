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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
            if(radioButton3ListarTodosGrupo.Checked )//Listar todos
            {
                grupoUsuarioBindingSource.DataSource = grupoUsuarioBLL.BuscarTodosGrupos();
            }
            else if(radioButton1NomeGrupo.Checked )
            {
                if(textBox2.Text != "")
                {
                    grupoUsuarioBindingSource.DataSource = grupoUsuarioBLL.BuscarGrupoPorNome(textBox2.Text);
                }
                else
                {
                    MessageBox.Show("Inserir um nome");
                }
            }
            else if(radioButton2IDGrupo.Checked )
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

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            using (FormAdicionarGrupo frm = new FormAdicionarGrupo())
            {
                frm.ShowDialog();
            }
        }

        private void buttonAlterarGrupo_Click(object sender, EventArgs e)
        {
            int id = ((GrupoUsuario)grupoUsuarioBindingSource.Current).IdGrupoUsuario;//pegar o id do registro atual
            //TODO corrigir esse formulario
            using (FormConsultarGrupoUsuario frm = new FormConsultarGrupoUsuario(true, id))
            {
                frm.ShowDialog();
            }
            buttonBuscarGrupoUsuario_Click(sender, e);
        }

    }
}