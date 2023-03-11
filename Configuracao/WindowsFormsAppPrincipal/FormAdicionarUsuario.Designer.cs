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
            System.Windows.Forms.Label ativoLabel;
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.nomeUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.cPFTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.buttonAddUsuario = new System.Windows.Forms.Button();
            this.buttonExcluirUsuario = new System.Windows.Forms.Button();
            nomeLabel = new System.Windows.Forms.Label();
            nomeUsuarioLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            ativoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(5, 18);
            nomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(108, 16);
            nomeLabel.TabIndex = 0;
            nomeLabel.Text = "Nome Completo:";
            // 
            // nomeUsuarioLabel
            // 
            nomeUsuarioLabel.AutoSize = true;
            nomeUsuarioLabel.Location = new System.Drawing.Point(16, 49);
            nomeUsuarioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomeUsuarioLabel.Name = "nomeUsuarioLabel";
            nomeUsuarioLabel.Size = new System.Drawing.Size(97, 16);
            nomeUsuarioLabel.TabIndex = 2;
            nomeUsuarioLabel.Text = "Nome Usuario:";
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Location = new System.Drawing.Point(79, 85);
            cPFLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(36, 16);
            cPFLabel.TabIndex = 4;
            cPFLabel.Text = "CPF:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(72, 113);
            emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(44, 16);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "Email:";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new System.Drawing.Point(64, 145);
            senhaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(49, 16);
            senhaLabel.TabIndex = 8;
            senhaLabel.Text = "Senha:";
            // 
            // ativoLabel
            // 
            ativoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            ativoLabel.AutoSize = true;
            ativoLabel.Location = new System.Drawing.Point(529, 151);
            ativoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ativoLabel.Name = "ativoLabel";
            ativoLabel.Size = new System.Drawing.Size(40, 16);
            ativoLabel.TabIndex = 10;
            ativoLabel.Text = "Ativo:";
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
            this.nomeTextBox.Location = new System.Drawing.Point(127, 14);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(472, 22);
            this.nomeTextBox.TabIndex = 1;
            // 
            // nomeUsuarioTextBox
            // 
            this.nomeUsuarioTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nomeUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "NomeUsuario", true));
            this.nomeUsuarioTextBox.Location = new System.Drawing.Point(127, 46);
            this.nomeUsuarioTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nomeUsuarioTextBox.Name = "nomeUsuarioTextBox";
            this.nomeUsuarioTextBox.Size = new System.Drawing.Size(472, 22);
            this.nomeUsuarioTextBox.TabIndex = 3;
            // 
            // cPFTextBox
            // 
            this.cPFTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cPFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "CPF", true));
            this.cPFTextBox.Location = new System.Drawing.Point(127, 78);
            this.cPFTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cPFTextBox.Name = "cPFTextBox";
            this.cPFTextBox.Size = new System.Drawing.Size(472, 22);
            this.cPFTextBox.TabIndex = 5;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(127, 110);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(472, 22);
            this.emailTextBox.TabIndex = 7;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Senha", true));
            this.senhaTextBox.Location = new System.Drawing.Point(127, 142);
            this.senhaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.PasswordChar = '*';
            this.senhaTextBox.Size = new System.Drawing.Size(213, 22);
            this.senhaTextBox.TabIndex = 9;
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ativoCheckBox.Checked = true;
            this.ativoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ativoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usuarioBindingSource, "Ativo", true));
            this.ativoCheckBox.Location = new System.Drawing.Point(583, 145);
            this.ativoCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(27, 30);
            this.ativoCheckBox.TabIndex = 11;
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // buttonAddUsuario
            // 
            this.buttonAddUsuario.Location = new System.Drawing.Point(20, 187);
            this.buttonAddUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddUsuario.Name = "buttonAddUsuario";
            this.buttonAddUsuario.Size = new System.Drawing.Size(100, 28);
            this.buttonAddUsuario.TabIndex = 12;
            this.buttonAddUsuario.Text = "Adicionar";
            this.buttonAddUsuario.UseVisualStyleBackColor = true;
            this.buttonAddUsuario.Click += new System.EventHandler(this.buttonAddUsuario_Click);
            // 
            // buttonExcluirUsuario
            // 
            this.buttonExcluirUsuario.Location = new System.Drawing.Point(128, 187);
            this.buttonExcluirUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonExcluirUsuario.Name = "buttonExcluirUsuario";
            this.buttonExcluirUsuario.Size = new System.Drawing.Size(100, 28);
            this.buttonExcluirUsuario.TabIndex = 13;
            this.buttonExcluirUsuario.Text = "Excluir";
            this.buttonExcluirUsuario.UseVisualStyleBackColor = true;
            // 
            // FormAdicionarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 223);
            this.Controls.Add(this.buttonExcluirUsuario);
            this.Controls.Add(this.buttonAddUsuario);
            this.Controls.Add(ativoLabel);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(638, 270);
            this.MinimumSize = new System.Drawing.Size(638, 270);
            this.Name = "FormAdicionarUsuario";
            this.Text = "Adicionar usuário";
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
        private System.Windows.Forms.Button buttonExcluirUsuario;
    }
}