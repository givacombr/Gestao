namespace WindowsFormsAppPrincipal
{
    partial class FormAdicionarUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label nomeUsuarioLabel;
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label senhaLabel;
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.nomeUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.cPFTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.buttonAddUsuario = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmacaoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedcPFTextBox = new System.Windows.Forms.MaskedTextBox();
            nomeLabel = new System.Windows.Forms.Label();
            nomeUsuarioLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(8, 54);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(35, 13);
            nomeLabel.TabIndex = 1;
            nomeLabel.Text = "Nome";
            // 
            // nomeUsuarioLabel
            // 
            nomeUsuarioLabel.AutoSize = true;
            nomeUsuarioLabel.Location = new System.Drawing.Point(194, 54);
            nomeUsuarioLabel.Name = "nomeUsuarioLabel";
            nomeUsuarioLabel.Size = new System.Drawing.Size(72, 13);
            nomeUsuarioLabel.TabIndex = 3;
            nomeUsuarioLabel.Text = "Nome usuario";
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Location = new System.Drawing.Point(440, 54);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(27, 13);
            cPFLabel.TabIndex = 5;
            cPFLabel.Text = "CPF";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(8, 100);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(32, 13);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "Email";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new System.Drawing.Point(226, 97);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(38, 13);
            senhaLabel.TabIndex = 9;
            senhaLabel.Text = "Senha";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Models.Usuario);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(10, 71);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(181, 20);
            this.nomeTextBox.TabIndex = 2;
            // 
            // nomeUsuarioTextBox
            // 
            this.nomeUsuarioTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nomeUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "NomeUsuario", true));
            this.nomeUsuarioTextBox.Location = new System.Drawing.Point(196, 71);
            this.nomeUsuarioTextBox.Name = "nomeUsuarioTextBox";
            this.nomeUsuarioTextBox.Size = new System.Drawing.Size(242, 20);
            this.nomeUsuarioTextBox.TabIndex = 4;
            // 
            // cPFTextBox
            // 
            this.cPFTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cPFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "CPF", true));
            this.cPFTextBox.Location = new System.Drawing.Point(70, 162);
            this.cPFTextBox.Name = "cPFTextBox";
            this.cPFTextBox.Size = new System.Drawing.Size(144, 20);
            this.cPFTextBox.TabIndex = 6;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(10, 116);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(212, 20);
            this.emailTextBox.TabIndex = 8;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Senha", true));
            this.senhaTextBox.Location = new System.Drawing.Point(228, 113);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.PasswordChar = '*';
            this.senhaTextBox.Size = new System.Drawing.Size(123, 20);
            this.senhaTextBox.TabIndex = 10;
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ativoCheckBox.AutoSize = true;
            this.ativoCheckBox.Checked = true;
            this.ativoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ativoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usuarioBindingSource, "Ativo", true));
            this.ativoCheckBox.Location = new System.Drawing.Point(486, 116);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(50, 17);
            this.ativoCheckBox.TabIndex = 13;
            this.ativoCheckBox.Text = "Ativo";
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // buttonAddUsuario
            // 
            this.buttonAddUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddUsuario.Location = new System.Drawing.Point(380, 159);
            this.buttonAddUsuario.Name = "buttonAddUsuario";
            this.buttonAddUsuario.Size = new System.Drawing.Size(75, 23);
            this.buttonAddUsuario.TabIndex = 14;
            this.buttonAddUsuario.Text = "Salvar";
            this.buttonAddUsuario.UseVisualStyleBackColor = true;
            this.buttonAddUsuario.Click += new System.EventHandler(this.buttonAddUsuario_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelar.Location = new System.Drawing.Point(461, 159);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 15;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Usuário";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmacaoTextBox
            // 
            this.confirmacaoTextBox.Location = new System.Drawing.Point(356, 113);
            this.confirmacaoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.confirmacaoTextBox.Name = "confirmacaoTextBox";
            this.confirmacaoTextBox.PasswordChar = '*';
            this.confirmacaoTextBox.Size = new System.Drawing.Size(123, 20);
            this.confirmacaoTextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Confirmação de senha";
            // 
            // maskedcPFTextBox
            // 
            this.maskedcPFTextBox.Location = new System.Drawing.Point(443, 71);
            this.maskedcPFTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maskedcPFTextBox.Mask = "999.999.999.-99";
            this.maskedcPFTextBox.Name = "maskedcPFTextBox";
            this.maskedcPFTextBox.Size = new System.Drawing.Size(93, 20);
            this.maskedcPFTextBox.TabIndex = 6;
            // 
            // FormAdicionarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 208);
            this.Controls.Add(this.maskedcPFTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.confirmacaoTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAddUsuario);
            this.Controls.Add(this.ativoCheckBox);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(this.cPFTextBox);
            this.Controls.Add(nomeUsuarioLabel);
            this.Controls.Add(this.nomeUsuarioTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(590, 247);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(590, 247);
            this.Name = "FormAdicionarUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de usuário";
            this.Load += new System.EventHandler(this.FormAdicionarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox nomeUsuarioTextBox;
        private System.Windows.Forms.TextBox cPFTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.CheckBox ativoCheckBox;
        private System.Windows.Forms.Button buttonAddUsuario;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox confirmacaoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedcPFTextBox;
    }
}