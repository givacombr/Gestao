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
        private void FormAdicionarGrupo_Load(object sender, EventArgs e)
        {
            GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
            try
            {
                grupoUsuarioBindingSource.AddNew();
                //grupoUsuarioBLL.Inserir((GrupoUsuario)grupoUsuarioBindingSource.Current);
                MessageBox.Show("Cadastrado com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tenrtar inserir um grupo no banco de dados." + ex.Message);
            }
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
            try
            {
                grupoUsuarioBindingSource.DataSource = grupoUsuarioBLL.BuscarGrupoPorNome(textBoxBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            if (grupoUsuarioBindingSource.Count > 0)
            {
                Id = ((GrupoUsuario)grupoUsuarioBindingSource.Current).IdGrupoUsuario;
                Close();
            }
            else
                MessageBox.Show("Não existe um grupo de usuário para ser selecionado.");
        }
    }
}
