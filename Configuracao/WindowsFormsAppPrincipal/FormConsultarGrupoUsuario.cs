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
    public partial class FormConsultarGrupoUsuario : Form
    {
        public int Id;

        private bool alterar;
        public FormConsultarGrupoUsuario(bool _alterar = false, int _idgrupoUsuario = 0)
        {
            InitializeComponent();
            alterar = _alterar;

            if (alterar)
            {
                grupoUsuarioBindingSource.DataSource = new GrupoUsuarioBLL().BuscarPorId(_idgrupoUsuario);
            }
        }

        private void buttonAddGrupo_Click(object sender, EventArgs e)
        {
            GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
            try
            {
                grupoUsuarioBindingSource.EndEdit();
                grupoUsuarioBLL.Inserir((GrupoUsuario)grupoUsuarioBindingSource.Current);
                MessageBox.Show("Cadastrado com sucesso!");
                LimparCampos();
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro ao tenrtar inserir um grupo no banco de dados." + ex.Message);
            }
            //GrupoUsuario _grupoUsuario = new GrupoUsuario();
            //_grupoUsuario.NomeGrupo = nomeGrupoTextBox.Text;

            LimparCampos();

            //grupoUsuarioBLL.Inserir(_grupoUsuario);
            //MessageBox.Show("Cadastrado com sucesso.");
            //Close();
        }

        private void LimparCampos()
        {
            //nomeGrupoTextBox.Text = string.Empty;
        }
        private void FormAdicionarGrupo_Load(object sender, EventArgs e)
        {
            grupoUsuarioBindingSource.AddNew();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();

            grupoUsuarioBindingSource.DataSource = grupoUsuarioBLL.BuscarGrupoPorNome(textBoxBuscar.Text);
        }
    }
}
