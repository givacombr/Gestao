namespace WindowsFormsAppPrincipal
{
    partial class FormAlterarUsuario
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
            System.Windows.Forms.Label ativoLabel;
            System.Windows.Forms.Label senhaLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label nomeUsuarioLabel;
            System.Windows.Forms.Label nomeLabel;
            this.buttonSalvarUsuario = new System.Windows.Forms.Button();
            this.buttonAlteraUsuario = new System.Windows.Forms.Button();
            this.alteraativoCheckBox = new System.Windows.Forms.CheckBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alterasenhaTextBox = new System.Windows.Forms.TextBox();
            this.alteraemailTextBox = new System.Windows.Forms.TextBox();
            this.alteracPFTextBox = new System.Windows.Forms.TextBox();
            this.alteranomeUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.alterarNomeTextBox = new System.Windows.Forms.TextBox();
            ativoLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            nomeUsuarioLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ativoLabel
            // 
            ativoLabel.AutoSize = true;
            ativoLabel.Location = new System.Drawing.Point(404, 124);
            ativoLabel.Name = "ativoLabel";
            ativoLabel.Size = new System.Drawing.Size(34, 13);
            ativoLabel.TabIndex = 24;
            ativoLabel.Text = "Ativo:";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new System.Drawing.Point(55, 119);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(41, 13);
            senhaLabel.TabIndex = 22;
            senhaLabel.Text = "Senha:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(61, 93);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 20;
            emailLabel.Text = "Email:";
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Location = new System.Drawing.Point(66, 70);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(30, 13);
            cPFLabel.TabIndex = 18;
            cPFLabel.Text = "CPF:";
            // 
            // nomeUsuarioLabel
            // 
            nomeUsuarioLabel.AutoSize = true;
            nomeUsuarioLabel.Location = new System.Drawing.Point(19, 41);
            nomeUsuarioLabel.Name = "nomeUsuarioLabel";
            nomeUsuarioLabel.Size = new System.Drawing.Size(77, 13);
            nomeUsuarioLabel.TabIndex = 16;
            nomeUsuarioLabel.Text = "Nome Usuario:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(11, 16);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(85, 13);
            nomeLabel.TabIndex = 14;
            nomeLabel.Text = "Nome Completo:";
            // 
            // buttonSalvarUsuario
            // 
            this.buttonSalvarUsuario.Location = new System.Drawing.Point(103, 153);
            this.buttonSalvarUsuario.Name = "buttonSalvarUsuario";
            this.buttonSalvarUsuario.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvarUsuario.TabIndex = 27;
            this.buttonSalvarUsuario.Text = "Salvar";
            this.buttonSalvarUsuario.UseVisualStyleBackColor = true;
            this.buttonSalvarUsuario.Click += new System.EventHandler(this.buttonSalvarUsuario_Click);
            // 
            // buttonAlteraUsuario
            // 
            this.buttonAlteraUsuario.Location = new System.Drawing.Point(22, 153);
            this.buttonAlteraUsuario.Name = "buttonAlteraUsuario";
            this.buttonAlteraUsuario.Size = new System.Drawing.Size(75, 23);
            this.buttonAlteraUsuario.TabIndex = 26;
            this.buttonAlteraUsuario.Text = "Alterar";
            this.buttonAlteraUsuario.UseVisualStyleBackColor = true;
            // 
            // alteraativoCheckBox
            // 
            this.alteraativoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usuarioBindingSource, "Ativo", true));
            this.alteraativoCheckBox.Location = new System.Drawing.Point(441, 119);
            this.alteraativoCheckBox.Name = "alteraativoCheckBox";
            this.alteraativoCheckBox.Size = new System.Drawing.Size(13, 24);
            this.alteraativoCheckBox.TabIndex = 25;
            this.alteraativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Models.Usuario);
            // 
            // alterasenhaTextBox
            // 
            this.alterasenhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Senha", true));
            this.alterasenhaTextBox.Location = new System.Drawing.Point(102, 116);
            this.alterasenhaTextBox.Name = "alterasenhaTextBox";
            this.alterasenhaTextBox.PasswordChar = '*';
            this.alterasenhaTextBox.Size = new System.Drawing.Size(161, 20);
            this.alterasenhaTextBox.TabIndex = 23;
            // 
            // alteraemailTextBox
            // 
            this.alteraemailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Email", true));
            this.alteraemailTextBox.Location = new System.Drawing.Point(102, 90);
            this.alteraemailTextBox.Name = "alteraemailTextBox";
            this.alteraemailTextBox.Size = new System.Drawing.Size(352, 20);
            this.alteraemailTextBox.TabIndex = 21;
            // 
            // alteracPFTextBox
            // 
            this.alteracPFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "CPF", true));
            this.alteracPFTextBox.Location = new System.Drawing.Point(102, 64);
            this.alteracPFTextBox.Name = "alteracPFTextBox";
            this.alteracPFTextBox.Size = new System.Drawing.Size(352, 20);
            this.alteracPFTextBox.TabIndex = 19;
            // 
            // alteranomeUsuarioTextBox
            // 
            this.alteranomeUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "NomeUsuario", true));
            this.alteranomeUsuarioTextBox.Location = new System.Drawing.Point(102, 38);
            this.alteranomeUsuarioTextBox.Name = "alteranomeUsuarioTextBox";
            this.alteranomeUsuarioTextBox.Size = new System.Drawing.Size(352, 20);
            this.alteranomeUsuarioTextBox.TabIndex = 17;
            // 
            // alterarNomeTextBox
            // 
            this.alterarNomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Nome", true));
            this.alterarNomeTextBox.Location = new System.Drawing.Point(102, 12);
            this.alterarNomeTextBox.Name = "alterarNomeTextBox";
            this.alterarNomeTextBox.Size = new System.Drawing.Size(352, 20);
            this.alterarNomeTextBox.TabIndex = 15;
            // 
            // FormAlterarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 188);
            this.Controls.Add(ativoLabel);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(emailLabel);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(nomeUsuarioLabel);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.buttonSalvarUsuario);
            this.Controls.Add(this.buttonAlteraUsuario);
            this.Controls.Add(this.alteraativoCheckBox);
            this.Controls.Add(this.alterasenhaTextBox);
            this.Controls.Add(this.alteraemailTextBox);
            this.Controls.Add(this.alteracPFTextBox);
            this.Controls.Add(this.alteranomeUsuarioTextBox);
            this.Controls.Add(this.alterarNomeTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(481, 227);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(481, 227);
            this.Name = "FormAlterarUsuario";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar usuário";
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.Button buttonSalvarUsuario;
        private System.Windows.Forms.Button buttonAlteraUsuario;
        private System.Windows.Forms.CheckBox alteraativoCheckBox;
        private System.Windows.Forms.TextBox alterasenhaTextBox;
        private System.Windows.Forms.TextBox alteraemailTextBox;
        private System.Windows.Forms.TextBox alteracPFTextBox;
        private System.Windows.Forms.TextBox alteranomeUsuarioTextBox;
        private System.Windows.Forms.TextBox alterarNomeTextBox;
    }
}