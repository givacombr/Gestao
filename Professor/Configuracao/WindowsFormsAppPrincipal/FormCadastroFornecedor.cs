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
    public partial class FormCadastroFornecedor : Form
    {
        int id;
        public FormCadastroFornecedor(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                fornecedorBindingSource.EndEdit();

                if (id == 0)
                    new FornecedorBLL().Inserir((Fornecedor)fornecedorBindingSource.Current);
                else
                    new FornecedorBLL().Alterar((Fornecedor)fornecedorBindingSource.Current);
                MessageBox.Show("Registro salvo com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormCadastroFornecedor_Load(object sender, EventArgs e)
        {
            try
            {
                if (id == 0)
                    fornecedorBindingSource.AddNew();
                else
                    fornecedorBindingSource.DataSource = new FornecedorBLL().BuscarPorId(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
