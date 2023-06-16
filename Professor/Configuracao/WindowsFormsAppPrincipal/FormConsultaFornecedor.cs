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
    public partial class FormConsultaFornecedor : Form
    {
        public FormConsultaFornecedor()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        if (String.IsNullOrEmpty(textBoxBuscar.Text))
                            throw new Exception("Informe um Id para fazer a busca.") { Data = { { "Id", 41 } } };
                        fornecedorBindingSource.DataSource = new FornecedorBLL().BuscarPorId(Convert.ToInt32(textBoxBuscar.Text));
                        break;
                    case 1:
                        fornecedorBindingSource.DataSource = new FornecedorBLL().BuscarPorNome(textBoxBuscar.Text);
                        break;
                    case 2:
                        fornecedorBindingSource.DataSource = new FornecedorBLL().BuscarSite(textBoxBuscar.Text);
                        break;
                    case 3:
                        fornecedorBindingSource.DataSource = new FornecedorBLL().BuscarTodos();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (fornecedorBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído");
                    return;
                }
                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                new FornecedorBLL().Excluir(((Fornecedor)fornecedorBindingSource.Current).Id);
                fornecedorBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormCadastroFornecedor frm = new FormCadastroFornecedor())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (fornecedorBindingSource.Count == 0)
                {
                    MessageBox.Show("Não existe fornecedor para ser alterado.");
                    return;
                }
                int id = ((Fornecedor)fornecedorBindingSource.Current).Id;
                using (FormCadastroFornecedor frm = new FormCadastroFornecedor(id))
                {
                    frm.ShowDialog();
                }
                buttonBuscar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void FormConsultaFornecedor_Load(object sender, EventArgs e)
        {
            comboBoxBuscarPor.SelectedIndex = 3;
        }
    }
}
