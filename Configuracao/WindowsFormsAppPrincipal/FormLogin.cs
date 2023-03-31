using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class FormLogin : Form
    {
        Thread th1;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            this.Close();
            th1 = new Thread(abrirJanela);
            th1.SetApartmentState(ApartmentState.STA);
            th1.Start();
        }

        private void abrirJanela(object obj)
        {
            Application.Run(new FormPrincipal());
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Close();
        }
    }
}
