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
    public partial class FormAlterarUsuario : Form
    {
        public FormAlterarUsuario()
        {
            InitializeComponent();
        }

        private void buttonSalvarUsuario_Click(object sender, EventArgs e)
        {
            if (ValidarForm())
                MessageBox.Show("Salvo com sucesso.");
        }
        private bool ValidarForm()
        {
            bool FormValido;
            if (alterarNomeTextBox.Text == "")
            {
                MessageBox.Show("Informe o Nome");
                alterarNomeTextBox.Focus();
                FormValido = false;
            }
            else if (alteranomeUsuarioTextBox.Text == "")
            {
                MessageBox.Show("Informe o Nome do Usuário");
                alteranomeUsuarioTextBox.Focus();
                FormValido = false;
            }
            else if (alteracPFTextBox.Text == "")
            {
                MessageBox.Show("Informe o CPF");
                alteracPFTextBox.Focus();
                FormValido = false;
            }
            else if (alteraemailTextBox.Text == "")
            {
                MessageBox.Show("Informe o E-mail");
                alteraemailTextBox.Focus();
                FormValido = false;
            }
            else if (alterasenhaTextBox.Text == "")
            {
                MessageBox.Show("Informe o Senha");
                alterasenhaTextBox.Focus();
                FormValido = false;
            }
l            else if (alteraativoCheckBox.Text == "")
            {
                MessageBox.Show("Marque a ChecBox");
                alteraativoCheckBox.Focus();
                FormValido = false;
            }
            else
                FormValido = true;
            return FormValido;
        }
    }
}
