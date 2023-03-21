﻿using BLL;
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
        public int Id;
        public FormBuscarGrupoUsuario()
        {
            InitializeComponent();
        }
        private void buttonBuscarGrupoUsuario_Click(object sender, EventArgs e)
        {
            GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
            if (radioButton3ListarTodosGrupo.Checked)//Listar todos
            {
                grupoUsuarioBindingSource.DataSource = grupoUsuarioBLL.BuscarTodosGrupos();
            }
            else if (radioButton1NomeGrupo.Checked)
            {
                if (textBox2.Text != "")
                {
                    grupoUsuarioBindingSource.DataSource = grupoUsuarioBLL.BuscarGrupoPorNome(textBox2.Text);
                }
                else
                {
                    MessageBox.Show("Inserir um nome");
                }
            }
            else if (radioButton2IDGrupo.Checked)
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

        private void buttonAdicionarGrupo_Click(object sender, EventArgs e)
        {
            using (FormAdicionarGrupo frm = new FormAdicionarGrupo())
            {
                try
                {
                    frm.ShowDialog();
                    //if (frm.Id > 0)
                    //{
                    //    GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
                    //    int IdGrupoUsuario = ((GrupoUsuario)grupoUsuarioBindingSource.Current).IdGrupoUsuario;
                    //    grupoUsuarioBLL.(IdGrupoUsuario, frm.Id);
                    //    MessageBox.Show("Grupo adicionado com sucesso.");
                    //}
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao vincular um grupo" + ex.Message);
                }
            }
        }

        private void buttonAlterarGrupo_Click(object sender, EventArgs e)
        {
            int id = ((GrupoUsuario)grupoUsuarioBindingSource.Current).IdGrupoUsuario;//pegar o id do registro atual

            using (FormAdicionarGrupo frm = new FormAdicionarGrupo(true, id))
            {
                frm.ShowDialog();
            }
            buttonBuscarGrupoUsuario_Click(sender, e);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
                grupoUsuarioBindingSource.DataSource = grupoUsuarioBLL.BuscarGrupoPorNome(textBox2.Text);

            }
            catch (Exception ex)
            {
                if (ex.Message != "Informe o nome do grupo.")
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (grupoUsuarioBindingSource.Count <= 0)
            {
                MessageBox.Show("Não existe registro para ser excluído.");
                return;
            }
            if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = ((GrupoUsuario)grupoUsuarioBindingSource.Current).IdGrupoUsuario;
            new GrupoUsuarioBLL().Excluir(id);

            MessageBox.Show("Registro excluído com sucesso!");
            buttonBuscarGrupoUsuario_Click(null, null);
        }

        private void buttonAddDescricao_Click(object sender, EventArgs e)
        {
            using(FormConsultarPermissaoGrupoUsuario frm = new FormConsultarPermissaoGrupoUsuario())
            {
                frm.ShowDialog();
            }
        }

        private void buttonExcluirDescricao_Click(object sender, EventArgs e)
        {

        }
    }
}