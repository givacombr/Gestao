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
    public partial class FormAdicionarGrupo : Form
    {
        public int Id;

        private bool alterar;
        public FormAdicionarGrupo(bool _alterar = false, int _idGrupoUsuario = 0)
        {
            InitializeComponent();
            alterar = _alterar;

            if (alterar)
            {
                grupoUsuarioBindingSource.DataSource = new GrupoUsuarioBLL().BuscarPorId(_idGrupoUsuario);
            }
        }

        private void buttonSalvarGrupo_Click(object sender, EventArgs e)
        {
            GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
            try
            {
                grupoUsuarioBindingSource.EndEdit();

                if (!alterar)
                    grupoUsuarioBLL.Inserir((GrupoUsuario)grupoUsuarioBindingSource.Current);
                else
                    grupoUsuarioBLL.Alterar((GrupoUsuario)grupoUsuarioBindingSource.Current);

                MessageBox.Show("Cadastrado com sucesso!");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancelarGrupo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nomeGrupoTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
                //grupoUsuarioBindingSource = grupoUsuarioBLL.BuscarGrupoPorNome(nomeGrupoTextBox.Text);
            }
            catch (Exception ex)
            {
                if (ex.Message != "Informe o nome do Grupo.")
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
