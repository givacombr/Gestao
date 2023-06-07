using BLL;
using Models;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class FormLogin : Form
    {
        public bool Logou;
        public int Id;

        public FormLogin()
        {
            InitializeComponent();
            Logou = false;
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            //con.ConnectionString = @"User ID=SA;Initial Catalog=Gestao;Data Source=.\SQLEXPRESS;Password=admin123";
            con.ConnectionString = @"User ID=SA;Initial Catalog=Gestao;Data Source=.\SQLEXPRESS2019;Password=Senailab02";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            string login = "select * from Usuario where NomeUsuario = '" + textBoxUsuario.Text + " ' and Senha = '" + textBoxSenha.Text + "'";
            cmd = new SqlCommand(login, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                new FormPrincipal().Show();
                this.Hide();
                var form2 = new FormPrincipal();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            else
            {
                MessageBox.Show("usuário ou senha inválido","Messagem",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                textBoxUsuario.Text = "";
                textBoxSenha.Text = "";
                textBoxUsuario.Focus();
            }
            // try
            //{
            //    UsuarioBLL usuarioBLL = new UsuarioBLL();
            //    Usuario usuario = new Usuario();
            //    BindingSource usuarioBindingSource = new BindingSource();
            //    usuario = usuarioBLL.BuscarUsuarioPorNome(textBoxUsuario.Text);
            //    string login;
            //    string senha;
            //    login = usuario.NomeUsuario;
            //    senha = usuario.Senha;
            //    if (login != "")
            //    {

            //        if (login == textBoxUsuario.Text &&  senha == textBoxSenha.Text)
            //        {
            //            Logou = true;
            //            Id = usuario.IDUsuario;

            //            Close();

            //        }
            //        else
            //        {
            //            MessageBox.Show("Login e/ou Senha incorreto", "Mensagem",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            //            textBoxSenha.Text = "";
            //            textBoxSenha.Focus();
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Login e/ou Senha incorreto", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        textBoxSenha.Text = "";
            //        textBoxSenha.Focus();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            ////new UsuarioBLL().AutenticarUsuario(textBoxUsuario.Text, textBoxSenha.Text);
            ////Logou = true;
            ////Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            textBoxUsuario.Text = "";
            textBoxSenha.Text = "";
            textBoxUsuario.Focus();
            //Application.Exit();
            //Close();
        }

        //private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        //{
        //    textBoxSenha.Focus();
        //}

        //private void textBoxSenha_TextChanged(object sender, EventArgs e)
        //{
        //    buttonEntrar_Click(null, null);
        //}

        private void checkBoxMostraSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMostraSenha.Checked)
            {
                textBoxSenha.PasswordChar = '\0';
            }
            else
            {
                textBoxSenha.PasswordChar = '*';
            }
        }
    }
}
